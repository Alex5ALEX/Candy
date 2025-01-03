using CandyClient.Models;

namespace CandyClient.ViewClient.CatalogView;

public partial class ProductCatalogControl : UserControl
{
    private CatalogControl mainController;
    private Candy product;

    public ProductCatalogControl(CatalogControl mainController, Candy product)
    {
        this.mainController = mainController;
        this.product = product;

        InitializeComponent();
        InitData();
    }

    private async void InitData()
    {
        labelNameText.Text = product.Name;
        labelPriceText.Text = product.Price.ToString("0.00");
    }
}
