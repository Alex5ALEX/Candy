using CandyClient.Models;

namespace CandyClient.Views.CustomerView;

public partial class CustomerRowControl : UserControl
{
    private CustomerControl mainController;
    private Customer customer;

    public CustomerRowControl(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        this.customer = customer;

        InitializeComponent();
        InitializeData();

        groupBox1.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelSurname.Click += change_selected_Id;
        labelSurnameText.Click += change_selected_Id;
        labelPhone.Click += change_selected_Id;
        labelPhoneText.Click += change_selected_Id;
        labelEmail.Click += change_selected_Id;
        labelEmailText.Click += change_selected_Id;
        labelAddres.Click += change_selected_Id;
        labelAddresText.Click += change_selected_Id;
    }

    private void InitializeData()
    {
        labelNameText.Text = customer.Person.Name;
        labelSurnameText.Text = customer.Person.Surname;
        labelPhoneText.Text = customer.Person.Phone;
        labelEmailText.Text = customer.Person.Email;
        labelAddresText.Text = customer.Person.Address;
    }

    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(customer.Id.ToString());
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedCustomer = customer;
    }
}
