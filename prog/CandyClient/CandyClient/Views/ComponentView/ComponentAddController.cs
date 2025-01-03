using CandyClient.Models;

namespace CandyClient.Views.ComponentView;

public partial class ComponentAddController : UserControl
{
    private ComponentControl mainController;

    public ComponentAddController(ComponentControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private void AddItem(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(numericUpDownComponent.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        decimal price = 0;

        if (!decimal.TryParse(numericUpDownComponent.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }

        Component Component = new()
        {
            Name = textBoxName.Text,
            Price = price
        };


        var response = mainController.ComponentController.PostComponent(Component);

        numericUpDownComponent.Text = "";
        textBoxName.Text = "";

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }

}
