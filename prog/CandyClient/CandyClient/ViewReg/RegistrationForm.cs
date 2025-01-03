using CandyClient.Controllers;
using CandyClient.Models;

namespace CandyClient.ViewReg;

public partial class RegistrationForm : Form
{
    PersonController personController;
    public string result = "";
    public Person person;

    public RegistrationForm()
    {
        InitializeComponent();
        InitData();

        buttonEnter.Click += enter;
    }

    private void InitData()
    {
        personController = new PersonController(new HttpClient());
        person = new Person();
    }

    private async void enter(object sender, EventArgs e)
    {
        string a = await personController.LoginAsync(textBoxLogin.Text, textBoxPass.Text);

        person.Login = textBoxLogin.Text;
        person.Password = textBoxPass.Text;

        if (a == "Customer")
        {
            result = a;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else if (a == "Admin")
        {
            result = a;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else
        {
            MessageBox.Show("Что-то введено не верно");
            return;
        }
    }
}
