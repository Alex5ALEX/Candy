using CandyClient.ViewClient;
using CandyClient.ViewReg;

namespace CandyClient;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        ApplicationConfiguration.Initialize();


        RegistrationForm reg = new RegistrationForm();
        Application.Run(reg);


        if (reg.result == "Customer")
        {
            Application.Run(new ClientForm(reg.person));
        }
        else if (reg.result == "Admin")
        {
            Application.Run(new MainForm());
        }
    }
}