using CandyClient.Logic;
using CandyClient.Models;

namespace CandyClient.Views.ProviderView;

public partial class ProviderAddController : UserControl
{
    private ProviderControl mainController;
    private Validation validation;

    public ProviderAddController(ProviderControl mainController)
    {
        this.mainController = mainController;
        validation = new Validation();


        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private void AddItem(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxCompany.Text) ||
        string.IsNullOrWhiteSpace(textBoxContactPerson.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };

        Provider provider = new Provider()
        {
            Company = textBoxCompany.Text,
            ContactPerson = textBoxContactPerson.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text
        };

        var response = mainController.providerController.PostProvider(provider);

        textBoxContactPerson.Text = "";
        textBoxCompany.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }
}
