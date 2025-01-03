using CandyClient.Models;
using CandyClient.Views.OrderView;

namespace CandyClient.ViewClient.OrderClientView;

public partial class OrderAddClient : UserControl
{
    private OrderClientControl mainController;

    private List<ProductShortRow> productRow = [];

    public Customer customer;

    public OrderAddClient(OrderClientControl mainController, Customer customer)
    {
        this.mainController = mainController;
        this.customer = customer;


        InitializeComponent();
        InitData();
        ShowCustomer();


        buttonBack.Click += Back;
        buttonAdd.Click += Add;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    public void InitData()
    {
        InitProducts();
    }

    private async void InitProducts()
    {
        flowLayoutPanelProduct.Controls.Clear();

        List<Candy> products = await mainController.productController.GetAllCandy();

        foreach (Candy product in products)
        {
            ProductShortRow productShortRow = new ProductShortRow(product);
            productRow.Add(productShortRow);
            flowLayoutPanelProduct.Controls.Add(productShortRow);
        }
    }

    public void ShowCustomer()
    {
        label2.Text = customer.Person.Name;
        label4.Text = customer.Person.Surname;
        label6.Text = customer.Person.Phone;
        label8.Text = customer.Person.Email;
        label10.Text = customer.Person.Address;
    }

    private async void Add(object? sender, EventArgs e)
    {
        if (customer.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите покупателя.");
            return;
        }

        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker1.Value,
            CustomerId = customer.Id
        };

        var response = await mainController.orderController.PostOrder(order);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var product in productRow)
        {
            if (product.GetQuantity() > 0)
            {
                OrderCompaund purchasedProduct = new OrderCompaund()
                {
                    OrderId = order.Id,
                    CandyId = product.product.Id,
                    Quantity = product.GetQuantity()
                };

                mainController.purchasedProductController.PostOrderCompaund(purchasedProduct);
            }
        }


        dateTimePicker1.Value = DateTime.Now;
        ShowCustomer();
        mainController.UpdateData();
    }
}
