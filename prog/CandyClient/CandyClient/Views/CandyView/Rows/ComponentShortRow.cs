using CandyClient.Models;

namespace CandyClient.Views.CandyView;

public partial class ComponentShortRow : UserControl
{
    public Component Component;

    public ComponentShortRow(Component product)
    {
        this.Component = product;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        label3.Text = Component.Name.ToString();
        label4.Text = Component.Price.ToString("0.00");
    }

    public void SetQuantity(decimal quantity)
    {
        numericUpDown1.Value = quantity;
    }

    public decimal GetQuantity()
    {
        return decimal.Parse(numericUpDown1.Value.ToString());
    }
}
