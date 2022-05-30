using System.Reflection;

namespace Contacts {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm meinform = new MainForm();
            IModel model = new Model();
            var presenter = new Presenter(model, meinform);
            Application.Run(meinform);
        }
    }
}