using CandyClient.Models;
namespace CandyClient.Views.SupplyView;

public partial class SupplyRowControl : UserControl
{
    private SupplyControl mainController;
    private Supply supply;

    public SupplyRowControl(SupplyControl mainController, Supply supply)
    {
        this.mainController = mainController;
        this.supply = supply;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Id;
        groupBox2.Click += change_selected_Id;
        labelDate.Click += change_selected_Id;
        labelDateText.Click += change_selected_Id;
        labelPrice.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
        label1.Click += change_selected_Id;
        label2.Click += change_selected_Id;
        label3.Click += change_selected_Id;
    }

    private void InitData()
    {
        labelDateText.Text = supply.Date.ToString("dd MM yyyy");

        labelPriceText.Text = supply.Price.ToString("0.00");

        InitProvider();
    }

    private async Task InitProvider()
    {
        Provider provider = await mainController.providerController.GetProviderById(supply.ProviderId) ?? new();

        label1.Text = provider.Company;
        label2.Text = provider.ContactPerson;
        label3.Text = provider.Phone;
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedSupply = supply;
    }

}
