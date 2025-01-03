using CandyClient.Controllers;
using CandyClient.Models;

namespace CandyClient.Views.CustomerView;

public partial class CustomerControl : UserControl
{
    private MainForm mainForm;
    public CustomerController customerController;
    private CustomerAddController customerAdd;

    public List<Customer> customers { get; set; }
    public Customer choisedCustomer { get; set; }

    public CustomerControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuControl;

        buttonAddNew.Click += AddNew;
        buttonEdit.Click += Edit;
    }

    private void InitializeData()
    {
        choisedCustomer = new Customer();
        customerController = new CustomerController(mainForm.httpClient);
        customerAdd = new CustomerAddController(this);
    }

    public async Task UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        customers = await customerController.GetAllCustomer() ?? [];

        foreach (var customer in customers)
        {
            flowLayoutPanel.Controls.Add(new CustomerRowControl(this, customer));
        }
    }

    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(customerAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedCustomer.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new CustomerEditController(this, choisedCustomer));
    }

}
