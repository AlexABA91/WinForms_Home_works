namespace My_File_Explorer {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IModel explorerData = new ExplorerData();
            ExplorerView explorerView = new ExplorerView();
            var Presenter = new Presenter(explorerData, explorerView);
            Application.Run(explorerView);
        }
    }
}