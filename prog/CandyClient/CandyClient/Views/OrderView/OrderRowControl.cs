using CandyClient.Models;
namespace CandyClient.Views.OrderView;

public partial class OrderRowControl : UserControl
{
    private OrderControl mainController;
    private Order order;

    public OrderRowControl(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Id;
        groupBox2.Click += change_selected_Id;
        labelDate.Click += change_selected_Id;
        labelDateText.Click += change_selected_Id;
        label1.Click += change_selected_Id;
        label2.Click += change_selected_Id;
        label3.Click += change_selected_Id;
    }

    private void InitData()
    {
        labelDateText.Text = order.Date.ToString("dd MM yyyy");

        InitCustomer();
    }

    private async void InitCustomer()
    {
        Customer customer = await mainController.customerController.GetCustomerById(order.CustomerId);

        label1.Text = customer.Person.Name;
        label2.Text = customer.Person.Surname;
        label3.Text = customer.Person.Phone;
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedOrder = order;
    }

}
