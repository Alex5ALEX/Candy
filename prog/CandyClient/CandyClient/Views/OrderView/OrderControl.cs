using CandyClient.Controllers;
using CandyClient.Models;
namespace CandyClient.Views.OrderView;

public partial class OrderControl : UserControl
{
    private MainForm mainForm;

    public OrderController orderController;
    public CandyController productController;
    public CustomerController customerController;
    public OrderCompaundController orderCompaundController;

    private OrderAddController orderAdd;

    public List<Order> orders { get; set; }
    public Order choisedOrder { get; set; }

    public OrderControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += CallMenu;

        buttonAddNew.Click += AddNew;
        buttonEdit.Click += Edit;
    }

    private void InitializeData()
    {
        choisedOrder = new Order();

        orderController = new OrderController(mainForm.httpClient);
        productController = new CandyController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);

        orderAdd = new OrderAddController(this);
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }

    public async Task UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        orders = await orderController.GetAllOrder() ?? [];

        foreach (var item in orders)
        {
            flowLayoutPanel.Controls.Add(new OrderRowControl(this, item));
        }
    }

    //можно добавить функционал
    public void HideActionGroupBox()
    {
        pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        orderAdd.InitData();
        groupBoxAction.Controls.Add(orderAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedOrder.Id == Guid.Empty) { return; }
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new OrderEditController(this, choisedOrder));
    }
}
