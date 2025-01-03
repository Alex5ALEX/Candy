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
public partial class ComponentRowReport : UserControl
{


    public Models.Component component { get; set; }



    public ComponentRowReport(Models.Component component)
    {
        InitializeComponent();
        this.component = component;

        InitData();
    }



    public void InitData()
    {
        label2.Text = component.Name;
        label3.Text = component.Price.ToString("0.00");
    }
}
