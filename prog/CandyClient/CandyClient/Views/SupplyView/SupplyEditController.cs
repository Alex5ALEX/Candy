using System.Diagnostics;
using System.Windows.Forms;
using CandyClient.Models;
using CandyClient.Views.SupplyView.Rows;

namespace CandyClient.Views.SupplyView;

public partial class SupplyEditController : UserControl
{
    private SupplyControl mainController;
    private Supply supply;

    private List<SupplyCompaund> supplyCompaundRow { get; set; } = [];
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<ProviderShortRow> providerRow { get; set; } = [];


    public Provider choisedProvider { get; set; }


    public SupplyEditController(SupplyControl mainController, Supply supply)
    {
        this.mainController = mainController;
        this.supply = supply;

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

    private async Task InitData()
    {
        dateTimePicker.Value = supply.Date;
        numericUpDown1.Value = supply.Price;

        choisedProvider = await mainController.providerController.GetProviderById(supply.ProviderId);
        ShowProvider();

        InitProducts();
        InitProviders();
    }

    public async void InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAllComponents();

        foreach (var item in products)
        {
            var token = new ProductShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProducts.Controls.Add(token);
        }

        supplyCompaundRow = await mainController.supplyCompaundController.GetSupplyCompaundByIdSupply(supply.Id) ?? [];

        foreach (var item in supplyCompaundRow)
        {
            foreach (var productline in productRow)
            {
                if (productline.Component.Id == item.ComponentId)
                {
                    productline.SetQuantity(item.Weight);
                }
            }
        }
    }

    public async Task InitProviders()
    {
        flowLayoutPanelProviders.Controls.Clear();
        productRow.Clear();

        var providers = await mainController.providerController.GetAllProvider() ?? [];

        foreach (var provider in providers)
        {
            var token = new ProviderShortRow(this, provider);
            providerRow.Add(token);
            flowLayoutPanelProviders.Controls.Add(token);
        }
    }

    //action
    public void ShowProvider()
    {
        label1.Text = choisedProvider.Company;
        label2.Text = choisedProvider.ContactPerson;
        label3.Text = choisedProvider.Phone;
        label4.Text = choisedProvider.Email;
    }

    private async void Edit(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (string.IsNullOrWhiteSpace(numericUpDown1.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        supply.Date = dateTimePicker.Value;
        supply.ProviderId = choisedProvider.Id;
        supply.Price = numericUpDown1.Value;
        


        foreach (var item in productRow)//List<ProductAddRowControl>
        {
            bool temp1 = false;

            foreach (var temp in supplyCompaundRow)//List<SupplyCompaund>
            {
                if (item.Component.Id == temp.ComponentId && item.GetQuantity() != int.Parse((temp.Weight * 100).ToString()))
                {
                    temp.Weight = item.GetQuantity();
                    await mainController.supplyCompaundController.PutSupplyCompaundById(temp);
                }
            }
            if (!temp1 && item.GetQuantity() > 0)
            {
                SupplyCompaund compaund = new SupplyCompaund()
                {
                    SupplyId = supply.Id,
                    ComponentId = item.Component.Id,
                    Weight = item.GetQuantity()
                };
                var responseCompaund = await mainController.supplyCompaundController.PostSupplyCompaund(compaund);

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

        var response = mainController.supplyController.DelSupply(supply);

        foreach (var item in supplyCompaundRow)
        {
            mainController.supplyCompaundController.DelSupplyCompaund(item);
        }

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
