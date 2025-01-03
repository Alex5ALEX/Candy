using CandyClient.Models;

namespace CandyClient.Views.ComponentView;

public partial class ComponentEditController : UserControl
{
    private ComponentControl mainController;
    private Component Component;

    public ComponentEditController(ComponentControl mainController, Component Component)
    {
        this.mainController = mainController;
        this.Component = Component;

        InitializeComponent();
        InitializeData();

        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private void InitializeData()
    {
        textBoxName.Text = Component.Name;
        numericUpDown1.Value = (decimal)Component.Price;
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(numericUpDown1.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        Component.Name = textBoxName.Text;
        Component.Price = numericUpDown1.Value;

        var response = mainController.ComponentController.PutComponentById(Component);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }

    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.ComponentController.DelComponent(Component);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }

}
