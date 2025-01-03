using CandyClient.Models;

namespace CandyClient.Views.CandyView;

public partial class CandyAddController : UserControl
{

    private CandyControl mainController;
    private List<ComponentShortRow> productRow { get; set; } = [];

    public CandyAddController(CandyControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    //memu
    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    //data
    public async Task InitData()
    {
        await InitProducts();
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
    }

    private async void AddItem(object? sender, EventArgs e)
    {

        Candy Candy = new Candy()
        {
            Id = Guid.NewGuid(),
            Name = textBoxName.Text,
            Price = numericUpDown1.Value,
        };

        var response = await mainController.CandyController.PostCandy(Candy);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var item in productRow)
        {
            if (item.GetQuantity() > 0)
            {
                Composition compaund = new Composition()
                {
                    CandyId = Candy.Id,
                    ComponentId = item.Component.Id,
                    Weight = double.Parse(item.GetQuantity().ToString())
                };

                var responseCompaund = await mainController.CandyCompaundController.PostComposition(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }
            }
        }

        textBoxName.Text = "";
        numericUpDown1.Value = 0;
        await InitData();
        mainController.UpdateData();
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {

    }
}