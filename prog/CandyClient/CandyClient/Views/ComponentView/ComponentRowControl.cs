using CandyClient.Models;

namespace CandyClient.Views.ComponentView;

public partial class ComponentRowControl : UserControl
{
    private ComponentControl mainController;
    private Component Component;

    public ComponentRowControl(ComponentControl mainController, Component Component)
    {
        this.mainController = mainController;
        this.Component = Component;

        InitializeComponent();
        InitializeData();

        groupBox1.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelPrice.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
    }

    private void InitializeData()
    {
        labelNameText.Text = Component.Name;
        labelPriceText.Text = Component.Price.ToString("0.00");
    }

    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(Component.Id.ToString());
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedComponent = Component;
    }
}
