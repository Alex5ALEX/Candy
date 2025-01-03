using CandyClient.Logic;
using CandyClient.Models;

namespace CandyClient.Views.CustomerView;

public partial class CustomerEditController : UserControl
{
    private CustomerControl mainController;
    private Customer customer;
    private Validation validation;

    public CustomerEditController(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        this.customer = customer;

        validation = new Validation();

        InitializeComponent();
        InitializeData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private void InitializeData()
    {
        textBoxName.Text = customer!.Person!.Name;
        textBoxSurname.Text = customer.Person.Surname;
        textBoxPhone.Text = customer.Person.Phone;
        textBoxEmail.Text = customer.Person.Email;
        textBoxAddres.Text = customer.Person.Address;
        textBoxLogin.Text = customer.Person.Login;
        textBoxPassword.Text = customer.Person.Password;
    }

    private void Edit(object? sender, EventArgs e)
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

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; }
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; }

        customer!.Person!.Name = textBoxName.Text;
        customer.Person.Surname = textBoxSurname.Text;
        customer.Person.Phone = textBoxPhone.Text;
        customer.Person.Email = textBoxEmail.Text;
        customer.Person.Address = textBoxAddres.Text;
        customer.Person.Login = textBoxLogin.Text;
        customer.Person.Password = textBoxPassword.Text;

        var response = mainController.customerController.PutCustomerById(customer);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }

    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }

        var response = mainController.customerController.DelCustomer(customer);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
