using CandyClient.Controllers;
using CandyClient.Models;
namespace CandyClient.Views.SupplyView;

public partial class SupplyControl : UserControl
{
    private MainForm mainForm;

    public SupplyController supplyController;
    public ProviderController providerController;
    public SupplyCompaundController supplyCompaundController;
    public ComponentController productController;
    public OrderCompaundController orderCompaundController;

    private SupplyAddController supplyAdd;

    public List<Supply> supply { get; set; }
    public Supply choisedSupply { get; set; }

    public SupplyControl(MainForm mainForm)
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
        choisedSupply = new Supply();

        supplyController = new SupplyController(mainForm.httpClient);
        supplyCompaundController = new SupplyCompaundController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        productController = new ComponentController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);

        supplyAdd = new SupplyAddController(this);
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }

    public async Task UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        supply = await supplyController.GetAllSupply();

        foreach (var item in supply)
        {
            flowLayoutPanel.Controls.Add(new SupplyRowControl(this, item));
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
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = false;
        supplyAdd.InitData();
        groupBoxAction.Controls.Add(supplyAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedSupply.Id == Guid.Empty) { return; }
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new SupplyEditController(this, choisedSupply));
    }
}
