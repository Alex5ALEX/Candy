using CandyClient.Controllers;
using CandyClient.Models;


namespace CandyClient.ViewClient.CatalogView;

public partial class CatalogControl : UserControl
{
    private ClientForm mainForm;

    public CandyController productController;
    public ProviderController providerController;

    public CatalogControl(ClientForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuButton;
    }

    public void InitData()
    {
        productController = new CandyController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
    }

    public void UpdateData()
    {
        UpdateProductRow();
    }
    public async void UpdateProductRow()
    {
        flowLayoutPanelProduct.Controls.Clear();

        List<Candy> products = await productController.GetAllCandy();

        foreach (var product in products)
        {
            flowLayoutPanelProduct.Controls.Add(new ProductCatalogControl(this, product));
        }
    }
}
