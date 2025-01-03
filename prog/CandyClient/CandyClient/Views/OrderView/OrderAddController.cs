using CandyClient.Models;
using CandyClient.Views.OrderView.Rows;

namespace CandyClient.Views.OrderView;

public partial class OrderAddController : UserControl
{

    private OrderControl mainController;
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<CustomerShortRow> customerRow { get; set; } = [];

    public Customer choisedCustomer { get; set; } = new Customer() { Id = Guid.Empty, Person = new() };

    public OrderAddController(OrderControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    //memu
    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    //data
    public async Task InitData()
    {
        await InitProducts();
        await InitCustomers();
    }

    public async Task InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAllCandy() ?? [];

        foreach (var item in products)
        {
            var token = new ProductShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProducts.Controls.Add(token);
        }
    }

    public async Task InitCustomers()
    {
        flowLayoutPanelCustomers.Controls.Clear();
        customerRow.Clear();

        var customers = await mainController.customerController.GetAllCustomer();

        foreach (var item in customers)
        {
            var token = new CustomerShortRow(this, item);
            customerRow.Add(token);
            flowLayoutPanelCustomers.Controls.Add(token);
        }
    }

    //action
    public void ShowCustomer()
    {
        if (choisedCustomer.Person != null)
        {
            label1.Text = choisedCustomer.Person.Name;
            label2.Text = choisedCustomer.Person.Surname;
            label3.Text = choisedCustomer.Person.Phone;
            label4.Text = choisedCustomer.Person.Email;
        }
    }

    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (choisedCustomer.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите покупателя.");
            return;
        }

        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker.Value,
            CustomerId = choisedCustomer.Id,
        };

        var response = await mainController.orderController.PostOrder(order);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var item in productRow)
        {
            if (item.GetQuantity() > 0)
            {
                OrderCompaund compaund = new OrderCompaund()
                {
                    OrderId = order.Id,
                    CandyId = item.product.Id,
                    Quantity = item.GetQuantity()
                };

                var responseCompaund = await mainController.orderCompaundController.PostOrderCompaund(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }
            }
        }

        dateTimePicker.Value = DateTime.Now;
        choisedCustomer = new Customer();
        ShowCustomer();
        await InitData();
        mainController.UpdateData();
    }
}