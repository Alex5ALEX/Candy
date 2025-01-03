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
using CandyClient.Controllers;
using System.Windows.Forms.DataVisualization.Charting;

namespace CandyClient.Views.ReportView;
public partial class FinanceReport : UserControl
{
    ReportControl mainController;

    public FinanceReport(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        InitLabel();
        InitChart();
    }

    private async void InitChart()
    {
        chart1.Series.Clear();

        Series seriesProfit = new Series()
        {
            Name = "ProfitFromProducts",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Column
        };

        Series seriesExpenses = new Series()
        {
            Name = "ProfitFromServices",
            Color = System.Drawing.Color.Red,
            ChartType = SeriesChartType.Column
        };


        List<Order> orders = await mainController.orderController.GetAllOrder();
        List<Supply> supplies = await mainController.supplyController.GetAllSupply();

        Dictionary<int, decimal> profitDict = new Dictionary<int, decimal>();
        Dictionary<int, decimal> expensesDict = new Dictionary<int, decimal>();

        foreach(var order in orders)
        {
            List<OrderCompaund> orderCompaunds = await mainController.orderCompaundController.GetOrderCompaundByOrderId(order.Id);
            decimal profit = 0;

            foreach (var compaund in orderCompaunds)
            {
                var product = await mainController.candyController.GetCandyById(compaund.CandyId);
                profit += (decimal)product.Price * compaund.Quantity;
            }


            if (profitDict.ContainsKey(order.Date.Year))
            {
                profitDict[order.Date.Year] += profit;
            }
            else
            {
                profitDict.Add(order.Date.Year, profit);
            }


        }


        foreach (var supply in supplies)
        {

            if (expensesDict.ContainsKey(supply.Date.Year))
            {
                expensesDict[supply.Date.Year] += supply.Price;
            }
            else
            {
                expensesDict.Add(supply.Date.Year, supply.Price);
            }
        }


        foreach (var item in profitDict)
        {
            seriesProfit.Points.AddXY(item.Key, item.Value);
        }

        foreach (var item in expensesDict)
        {
            seriesExpenses.Points.AddXY(item.Key, item.Value);
        }




        chart1.Series.Add(seriesProfit);
        chart1.Series.Add(seriesExpenses);

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Years";
        chart1.ChartAreas[0].AxisY.Title = "Profit";

        // Заголовок диаграммы
        chart1.Titles.Add("Profit in Year");

    }


    private async void InitLabel()
    {
        double profit = 0;
        double expences = 0;

        List<Order> orders = await mainController.orderController.GetAllOrder();
        foreach (var order in orders) 
        {
            var compaunds = await mainController.orderCompaundController.GetOrderCompaundByOrderId(order.Id);
        
            foreach(var compaund in compaunds)
            {
                var product = await mainController.candyController.GetCandyById(compaund.CandyId);
                profit += (double)product.Price * compaund.Quantity;
            }
        }


        List<Supply> supplys = await mainController.supplyController.GetAllSupply();
        foreach(var supply in supplys)
        {
            expences += (double)supply.Price;
        }

        label1.Text = profit.ToString("0.00");
        label3.Text = expences.ToString("0.00");

        label5.Text = orders.Count.ToString();
        label6.Text = supplys.Count.ToString();

    }


}
