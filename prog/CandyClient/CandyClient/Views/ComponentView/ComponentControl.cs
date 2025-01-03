using CandyClient.Controllers;
using CandyClient.Models;

namespace CandyClient.Views.ComponentView;

public partial class ComponentControl : UserControl
{
    private MainForm mainForm;
    public ComponentController ComponentController;
    private ComponentAddController ComponentAdd;

    public List<Component> Components { get; set; }
    public Component choisedComponent { get; set; }

    public ComponentControl(MainForm mainForm)
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
        choisedComponent = new Component();
        ComponentController = new ComponentController(mainForm.httpClient);
        ComponentAdd = new ComponentAddController(this);
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }

    public async Task UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        Components = await ComponentController.GetAllComponents();

        foreach (var Component in Components)
        {
            flowLayoutPanel.Controls.Add(new ComponentRowControl(this, Component));
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
        groupBoxAction.Controls.Add(ComponentAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedComponent.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ComponentEditController(this, choisedComponent));
    }
}
