using CandyClient.Models;

namespace CandyClient.Views.SupplyView.Rows;

public partial class ProductShortRow : UserControl
{
    public Component Component;

    public ProductShortRow(Component Component)
    {
        this.Component = Component;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        label3.Text = Component.Name.ToString();
        label4.Text = Component.Price.ToString("0.000");
    }

    public void SetQuantity(double quantity)
    {
        numericUpDown1.Value = int.Parse((quantity * 100).ToString());
    }

    public int GetQuantity()
    {
        return int.Parse(numericUpDown1.Value.ToString());
    }
}
