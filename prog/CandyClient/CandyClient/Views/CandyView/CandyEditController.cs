using CandyClient.Models;
namespace CandyClient.Views.CandyView;

public partial class CandyEditController : UserControl
{
    private CandyControl mainController;
    private Candy Candy;

    private List<Composition> CandyCompaundRow { get; set; } = [];
    private List<ComponentShortRow> productRow { get; set; } = [];

    public CandyEditController(CandyControl mainController, Candy Candy)
    {
        this.mainController = mainController;
        this.Candy = Candy;

        InitializeComponent();
        InitData();

        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    //data
    private async Task InitData()
    {
        textBoxName.Text = Candy.Name;
        numericUpDown1.Value = Candy.Price;

        InitProducts();
    }

    public async Task InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAllComponents() ?? [];

        foreach (var item in products)
        {
            var token = new ComponentShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProducts.Controls.Add(token);
        }

        CandyCompaundRow = await mainController.CandyCompaundController.GetCompositionByCandyId(Candy.Id) ?? [];

        foreach (var item in CandyCompaundRow)
        {
            foreach (var productline in productRow)
            {
                if (productline.Component.Id == item.ComponentId)
                {
                    productline.SetQuantity(decimal.Parse(item.Weight.ToString()));
                }

            }
        }
    }

    private async void Edit(object? sender, EventArgs e)
    {
        Candy.Name = textBoxName.Text;
        Candy.Price = numericUpDown1.Value;

        var response = await mainController.CandyController.PutCandyById(Candy);

        foreach (var prod in productRow)
        {
            bool temp = false;

            foreach (var CandyCompaund in CandyCompaundRow)
            {
                if (prod.Component.Id == CandyCompaund.ComponentId)
                {
                    temp = true;
                    if (double.Parse(prod.GetQuantity().ToString()) != CandyCompaund.Weight)
                    {
                        CandyCompaund.Weight = double.Parse(prod.GetQuantity().ToString());
                        await mainController.CandyCompaundController.PutCompositionById(CandyCompaund);
                    }
                    break;
                }
            }
            if (!temp && prod.GetQuantity() > 0)
            {
                Composition compaund = new Composition()
                {
                    CandyId = Candy.Id,
                    ComponentId = prod.Component.Id,
                    Weight = double.Parse(prod.GetQuantity().ToString())
                };

                var responseCompaund = await mainController.CandyCompaundController.PostComposition(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }
            }
        }

        await InitData();
        await mainController.UpdateData();
    }

    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.CandyController.DelCandy(Candy);

        foreach (var item in CandyCompaundRow)
        {
            mainController.CandyCompaundController.DelComposition(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }

}
