using CandyClient.Controllers;
using CandyClient.Models;
using CandyClient.ViewClient.CatalogView;
using CandyClient.ViewClient.OrderClientView;
using CandyClient.ViewClient.PersonalAccountView;


namespace CandyClient.ViewClient;

public partial class ClientForm : Form
{

    public Customer Customer;
    public Person Person { get; set; }

    public HttpClient httpClient;

    public PersonController personController;

    public CustomerController customerController;

    public PersonalAccountControl personalAccountControl;
    public CatalogControl catalogControl;
    public OrderClientControl orderControl;


    public ClientForm(Person Person)
    {
        this.Person = Person;

        InitializeComponent();
        InitData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        buttonMenu.Click += ShowMenuButton;
        groupBoxMenu.Click += HideMenuButton;
        labelMenu.Click += HideMenuButton;

        personOption.Click += InitPersonalControl;
        orderOption.Click += InitOrderControl;
        catalogOption.Click += InitCatalogControl;
    }


    public async void InitData()
    {
        httpClient = new HttpClient();

        //Customer = new CustomerDTO();

        personController = new PersonController(httpClient);
        customerController = new CustomerController(httpClient);

        InitCustomer();
    }

    public async Task InitCustomer()
    {
        var person = await personController.GetByLogin(Person.Login, Person.Password);
        Customer = await customerController.GetByIdPerson(person.Id);

        InitControls();
    }

    public async void InitControls()
    {
        personalAccountControl = new PersonalAccountControl(this, Customer);
        catalogControl = new CatalogControl(this);
        orderControl = new OrderClientControl(this);

        Controls.Add(personalAccountControl);
        Controls.Add(catalogControl);
        Controls.Add(orderControl);

        HideMainControls();
        HideMenuControl();
    }

    //menu options
    private void InitPersonalControl(object sender, EventArgs e)
    {
        HideAllControls();
        personalAccountControl.Visible = true;
    }
    private void InitOrderControl(object sender, EventArgs e)
    {
        HideAllControls();
        orderControl.Visible = true;
    }

    private void InitCatalogControl(object sender, EventArgs e)
    {
        HideAllControls();
        catalogControl.Visible = true;
    }


    //controls



    private void HideAllControls()
    {
        HideMenuControl();
        buttonMenu.Visible = false;
        pictureBox1.Visible = false;

        HideMainControls();
    }


    private void HideMainControls()
    {
        personalAccountControl.Visible = false;
        catalogControl.Visible = false;
        orderControl.Visible = false;
    }



    //menu
    public void ShowMenuButton(object sender, EventArgs e)
    {
        ShowMenuControl();
    }

    public void HideMenuButton(object sender, EventArgs e)
    {
        HideMenuControl();
    }

    public void ShowMenuControl()
    {
        //groupBoxMenu.BringToFront();
        groupBoxMenu.Visible = true;
    }

    public void HideMenuControl()
    {
        groupBoxMenu.Visible = false;
    }

    //exit
    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

}
