using CandyClient.Controllers;
using CandyClient.Logic;
using CandyClient.Models;

namespace CandyClient.ViewClient.PersonalAccountView;

public partial class PersonalAccountControl : UserControl
{
    public Customer Customer;

    private ClientForm mainForm;


    public CustomerController customerController;

    public Validation validation;

    public PersonalAccountControl(ClientForm mainForm, Customer Customer)
    {
        this.Customer = Customer;
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();

        buttonMenu.Click += mainForm.ShowMenuButton;
        buttonEdit.Click += Edit;
    }

    public void InitData()
    {
        validation = new Validation();

        customerController = new CustomerController(mainForm.httpClient);

        if (Customer.Person == null) { return; }

        textBoxName.Text = Customer.Person.Name;
        textBoxSurname.Text = Customer.Person.Surname;
        textBoxPhone.Text = Customer.Person.Phone;
        textBoxEmail.Text = Customer.Person.Email;
        textBoxAddres.Text = Customer.Person.Address;
        textBoxLogin.Text = Customer.Person.Login;
        textBoxPassword.Text = Customer.Person.Password;
    }

    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text) ||
        string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
        string.IsNullOrWhiteSpace(textBoxPassword.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        Customer.Person.Name = textBoxName.Text;
        Customer.Person.Surname = textBoxSurname.Text;
        Customer.Person.Phone = textBoxPhone.Text;
        Customer.Person.Email = textBoxEmail.Text;
        Customer.Person.Address = textBoxAddres.Text;
        Customer.Person.Login = textBoxLogin.Text;
        Customer.Person.Password = textBoxPassword.Text;



        if ((await customerController.PutCustomerById(Customer)) != null)
        {
            mainForm.Customer = Customer;
            //mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

    }

}
