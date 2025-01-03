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
public partial class CandyRowRerport : UserControl
{
    public Candy Candy { get; set; }

    public CandyRowRerport(Candy candy)
    {
        Candy = candy;

        InitializeComponent();
        InitData();
    }


    private void InitData()
    {
        label2.Text = Candy.Name;
        label3.Text = Candy.Price.ToString("0.00");
    }






}
