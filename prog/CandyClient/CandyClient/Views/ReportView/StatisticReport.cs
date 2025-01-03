using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandyClient.Models;


namespace CandyClient.Views.ReportView;
public partial class StatisticReport : UserControl
{
    private ReportControl mainController;






    public StatisticReport(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    
    }



    private void InitData()
    {
        InitLabels();
        InitBox();

    }

    private async void InitBox()
    {
        List<Models.Component> components = await mainController.componentController.GetAllComponents();

        foreach(var comp in components)
        {
            flowLayoutPanelComponent.Controls.Add(new ComponentRowReport(comp));
        }

        List<Candy> candies = await mainController.candyController.GetAllCandy();


        foreach(var cand in candies)
        {
            flowLayoutPanelCandy.Controls.Add(new CandyRowRerport(cand));
        }

    }




    private async void InitLabels()
    {
        List<Customer> customers = await mainController.customerController.GetAllCustomer();
        List<Provider> providers = await mainController.providerController.GetAllProvider();
        List<Candy> candies = await mainController.candyController.GetAllCandy();
        List<Models.Component> components = await mainController.componentController.GetAllComponents();


        label2.Text = customers.Count.ToString();
        label5.Text = providers.Count.ToString();
        label7.Text = candies.Count.ToString();
        label9.Text = components.Count.ToString();
    }




}
