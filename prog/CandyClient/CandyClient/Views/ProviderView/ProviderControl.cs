using CandyClient.Controllers;
using CandyClient.Models;
namespace CandyClient.Views.ProviderView;

public partial class ProviderControl : UserControl
{
    private MainForm mainForm;
    public ProviderController providerController;
    private ProviderAddController providerAdd;

    public List<Provider> providers { get; set; }
    public Provider choisedProvider { get; set; }

    public ProviderControl(MainForm mainForm)
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
        choisedProvider = new Provider();
        providerController = new ProviderController(mainForm.httpClient);
        providerAdd = new ProviderAddController(this);
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }

    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        providers = await providerController.GetAllProvider() ?? [];

        foreach (var provider in providers)
        {
            flowLayoutPanel.Controls.Add(new ProviderRowControl(this, provider));
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
        groupBoxAction.Controls.Add(providerAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedProvider.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ProviderEditController(this, choisedProvider));
    }
}
