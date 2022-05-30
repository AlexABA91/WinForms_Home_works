using TagsOnMVP;

namespace TagsOnMVP {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var tag = new TagData();
            var formView = new FormView();
            var presenter = new Presenter( tag, formView);
            Application.Run(formView);
        }
    }
}