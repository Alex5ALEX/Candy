using CandyClient.Controllers;
using CandyClient.Views.ComponentView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandyClient.Controllers;
using System.Reflection.Metadata;


namespace CandyClient.Views.ReportView;
public partial class ReportControl : UserControl
{
    private MainForm mainForm;

    public CandyController candyController;
    public ComponentController componentController;
    public CompositionController compositionController;
    public CustomerController customerController;
    public OrderCompaundController orderCompaundController;
    public OrderController orderController;
    public PersonController personController;
    public ProviderController providerController;
    public SupplyCompaundController supplyCompaundController;
    public SupplyController supplyController;


    public List<Component> Components { get; set; }
    public Component choisedComponent { get; set; }

    public ReportControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitData();

        buttonMenu.Click += mainForm.ShowMenuControl;


        buttonClear.Click += HideActionGroupBox;
        buttonFinance.Click += FinanceReport;
        buttonStatistic.Click += StatisticReport;
    }

    private void InitData()
    {
        candyController = new CandyController(mainForm.httpClient);
        componentController = new ComponentController(mainForm.httpClient);
        compositionController = new CompositionController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);
        orderController = new OrderController(mainForm.httpClient);
        personController = new PersonController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        supplyCompaundController = new SupplyCompaundController(mainForm.httpClient);
        supplyController = new SupplyController(mainForm.httpClient);
    }



    //можно добавить функционал
    public void HideActionGroupBox(object sender, EventArgs e)
    {
        pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void FinanceReport(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new FinanceReport(this));
    }

    private void StatisticReport(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new StatisticReport(this));
    }


}
