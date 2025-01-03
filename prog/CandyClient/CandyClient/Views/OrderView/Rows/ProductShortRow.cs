using CandyClient.Models;

namespace CandyClient.Views.OrderView;

public partial class ProductShortRow : UserControl
{
    public Candy product;

    public ProductShortRow(Candy product)
    {
        this.product = product;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        label3.Text = product.Name.ToString();
        label4.Text = product.Price.ToString("0.00");
    }

    public void SetQuantity(int quantity)
    {
        numericUpDown1.Value = quantity;
    }

    public int GetQuantity()
    {
        return int.Parse(numericUpDown1.Value.ToString());
    }
}
