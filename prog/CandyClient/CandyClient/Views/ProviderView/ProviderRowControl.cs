using CandyClient.Models;
namespace CandyClient.Views.ProviderView;

public partial class ProviderRowControl : UserControl
{
    private ProviderControl mainController;
    private Provider provider;

    public ProviderRowControl(ProviderControl mainController, Provider provider)
    {
        this.mainController = mainController;
        this.provider = provider;

        InitializeComponent();
        InitializeData();

        groupBox1.Click += change_selected_Id;
        labelCompany.Click += change_selected_Id;
        labelCompanyText.Click += change_selected_Id;
        labelContactPerson.Click += change_selected_Id;
        labelContactPersonText.Click += change_selected_Id;
        labelPhone.Click += change_selected_Id;
        labelPhoneText.Click += change_selected_Id;
        labelEmail.Click += change_selected_Id;
        labelEmailText.Click += change_selected_Id;
        labelAddres.Click += change_selected_Id;
        labelAddresText.Click += change_selected_Id;
    }

    private void InitializeData()
    {
        labelCompanyText.Text = provider.Company;
        labelContactPersonText.Text = provider.ContactPerson;
        labelPhoneText.Text = provider.Phone;
        labelEmailText.Text = provider.Email;
        labelAddresText.Text = provider.Address;
    }

    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(provider.Id.ToString());
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedProvider = provider;
    }
}
