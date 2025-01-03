using CandyClient.Models;

namespace CandyClient.Views.OrderView.Rows;

public partial class CustomerShortRow : UserControl
{
    public Customer Customer { get; set; }
    public OrderAddController mainControllerAdd { get; set; }
    public OrderEditController mainControllerEdit { get; set; }

    public CustomerShortRow(OrderAddController mainController, Customer customer)
    {
        this.mainControllerAdd = mainController;
        this.Customer = customer;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Add_Customer;
        label1.Click += change_selected_Add_Customer;
        label2.Click += change_selected_Add_Customer;
        label3.Click += change_selected_Add_Customer;
        label4.Click += change_selected_Add_Customer;
    }

    public CustomerShortRow(OrderEditController mainController, Customer customer)
    {
        this.mainControllerEdit = mainController;
        this.Customer = customer;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Edit_Customer;
        label1.Click += change_selected_Edit_Customer;
        label2.Click += change_selected_Edit_Customer;
        label3.Click += change_selected_Edit_Customer;
        label4.Click += change_selected_Edit_Customer;
    }

    private void change_selected_Add_Customer(object sender, EventArgs e)
    {
        mainControllerAdd.choisedCustomer = Customer;
        mainControllerAdd.ShowCustomer();
    }

    private void change_selected_Edit_Customer(object sender, EventArgs e)
    {
        mainControllerEdit.choisedCustomer = Customer;
        mainControllerEdit.ShowCustomer();
    }

    public void InitData()
    {
        label3.Text = Customer.Person.Name;
        label4.Text = Customer.Person.Surname;
    }
}
