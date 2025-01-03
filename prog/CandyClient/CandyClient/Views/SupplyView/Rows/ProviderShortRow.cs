using CandyClient.Models;

namespace CandyClient.Views.SupplyView.Rows;

public partial class ProviderShortRow : UserControl
{
    public Provider Provider { get; set; }

    public SupplyAddController mainControllerAdd;

    public SupplyEditController mainControllerEdit;

    public ProviderShortRow(SupplyAddController mainController, Provider provider)
    {
        this.Provider = provider;
        this.mainControllerAdd = mainController;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Add_Provider;
        label1.Click += change_selected_Add_Provider;
        label2.Click += change_selected_Add_Provider;
        label3.Click += change_selected_Add_Provider;
        label4.Click += change_selected_Add_Provider;
        label5.Click += change_selected_Add_Provider;
        label6.Click += change_selected_Add_Provider;
    }

    public ProviderShortRow(SupplyEditController mainController, Provider provider)
    {
        this.Provider = provider;
        this.mainControllerEdit = mainController;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Edit_Provider;
        label1.Click += change_selected_Edit_Provider;
        label2.Click += change_selected_Edit_Provider;
        label3.Click += change_selected_Edit_Provider;
        label4.Click += change_selected_Edit_Provider;
        label5.Click += change_selected_Edit_Provider;
        label6.Click += change_selected_Edit_Provider;
    }

    private void change_selected_Add_Provider(object sender, EventArgs e)
    {
        mainControllerAdd.choisedProvider = Provider;
        mainControllerAdd.ShowProvider();
    }

    private void change_selected_Edit_Provider(object sender, EventArgs e)
    {
        mainControllerEdit.choisedProvider = Provider;
        mainControllerEdit.ShowProvider();
    }

    public void InitData()
    {
        label1.Text = Provider.Company;
        label2.Text = Provider.ContactPerson;
        label3.Text = Provider.Phone;
    }
}
