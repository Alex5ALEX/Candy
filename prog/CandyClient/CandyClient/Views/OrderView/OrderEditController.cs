using CandyClient.Models;
using CandyClient.Views.OrderView.Rows;
namespace CandyClient.Views.OrderView;

public partial class OrderEditController : UserControl
{
    private OrderControl mainController;
    private Order order;

    private List<OrderCompaund> orderCompaundRow { get; set; } = [];
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<CustomerShortRow> customerRow { get; set; } = [];

    public Customer choisedCustomer { get; set; }

    public OrderEditController(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;

        InitializeComponent();
        InitData();

        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    //data
    private async Task InitData()
    {
        dateTimePicker.Value = order.Date;

        choisedCustomer = await mainController.customerController.GetCustomerById(order.CustomerId) ?? new();

        ShowCustomer();

        InitProducts();
        InitCustomer();
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

        orderCompaundRow = await mainController.orderCompaundController.GetOrderCompaundByOrderId(order.Id) ?? [];

        foreach (var item in orderCompaundRow)
        {
            foreach (var productline in productRow)
            {
                if (productline.product.Id == item.CandyId)
                {
                    productline.SetQuantity(item.Quantity);
                }

            }
        }
    }

    public async Task InitCustomer()
    {
        flowLayoutPanelCustomers.Controls.Clear();
        customerRow.Clear();

        var customers = await mainController.customerController.GetAllCustomer() ?? [];

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
        label1.Text = choisedCustomer.Person.Name;
        label2.Text = choisedCustomer.Person.Surname;
        label3.Text = choisedCustomer.Person.Phone;
        label4.Text = choisedCustomer.Person.Email;
    }

    private async void Edit(object? sender, EventArgs e)
    {
        order.Date = dateTimePicker.Value;
        order.CustomerId = choisedCustomer.Id;

        var response = await mainController.orderController.PutOrderById(order);

        foreach (var prod in productRow)
        {
            bool temp = false;

            foreach (var orderCompaund in orderCompaundRow)
            {
                if (prod.product.Id == orderCompaund.CandyId)
                {
                    temp = true;
                    if (prod.GetQuantity() != orderCompaund.Quantity)
                    {
                        orderCompaund.Quantity = prod.GetQuantity();
                        await mainController.orderCompaundController.PutOrderCompaundById(orderCompaund);
                    }
                    break;
                }
            }
            if (!temp && prod.GetQuantity() > 0)
            {
                OrderCompaund compaund = new OrderCompaund()
                {
                    OrderId = order.Id,
                    CandyId = prod.product.Id,
                    Quantity = prod.GetQuantity()
                };

                var responseCompaund = await mainController.orderCompaundController.PostOrderCompaund(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }
            }
        }

        await InitData();
        await mainController.UpdateData();
    }

    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.orderController.DelOrder(order);

        foreach (var item in orderCompaundRow)
        {
            mainController.orderCompaundController.DelOrderCompaund(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }

}
