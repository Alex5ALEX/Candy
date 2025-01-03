using CandyClient.Controllers;
using CandyClient.Models;
namespace CandyClient.Views.CandyView;

public partial class CandyControl : UserControl
{
    private MainForm mainForm;

    public CandyController CandyController;
    public ComponentController productController;
    public CustomerController customerController;
    public CompositionController CandyCompaundController;

    private CandyAddController CandyAdd;

    public List<Candy> Candys { get; set; }
    public Candy choisedCandy { get; set; }

    public CandyControl(MainForm mainForm)
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
        choisedCandy = new Candy();

        CandyController = new CandyController(mainForm.httpClient);
        productController = new ComponentController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        CandyCompaundController = new CompositionController(mainForm.httpClient);

        CandyAdd = new CandyAddController(this);
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }

    public async Task UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        Candys = await CandyController.GetAllCandy() ?? [];

        foreach (var item in Candys)
        {
            flowLayoutPanel.Controls.Add(new CandyRowControl(this, item));
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
        CandyAdd.InitData();
        groupBoxAction.Controls.Add(CandyAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedCandy.Id == Guid.Empty) { return; }
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new CandyEditController(this, choisedCandy));
    }
}
