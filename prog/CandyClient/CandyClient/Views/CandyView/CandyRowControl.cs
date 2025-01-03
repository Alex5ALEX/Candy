using CandyClient.Models;
namespace CandyClient.Views.CandyView;

public partial class CandyRowControl : UserControl
{
    private CandyControl mainController;
    private Candy Candy;

    public CandyRowControl(CandyControl mainController, Candy Candy)
    {
        this.mainController = mainController;
        this.Candy = Candy;

        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
        label2.Click += change_selected_Id;
    }

    private void InitData()
    {
        labelNameText.Text = Candy.Name;
        labelPriceText.Text = Candy.Price.ToString("0.00");
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedCandy = Candy;
    }

}
