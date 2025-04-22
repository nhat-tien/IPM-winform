using DocumentFormat.OpenXml.Bibliography;
using IPM_winform.IPM.Views;
using IPM_winform.Services;

namespace IPM_winform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Dashboard("Tien"));

            if(Services.Author.isDevelopment)
            {
                Application.Run(new Dashboard());
            } else
            {
                LoginForm loginForm = new LoginForm();
                Application.Run(loginForm);
                if (loginForm.AuthenticatedSuccess)
                {
                    Application.Run(new Dashboard());
                }
            }
        }
    }
}