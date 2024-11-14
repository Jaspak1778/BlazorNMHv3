namespace MauiApp3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Määritellään tapahtumankäsittelijä käsittelemättömille poikkeuksille
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var exception = args.ExceptionObject as Exception;
                if (exception != null)
                {
                    // Kirjaa virhe konsoliin (tai halutessa raportoi palvelimelle)
                    Console.WriteLine($"Unhandled exception: {exception.Message}");
                    Console.WriteLine(exception.StackTrace);
                }
                else
                {
                    Console.WriteLine("Unhandled non-exception error occurred.");
                }
            };

            MainPage = new MainPage();
        }
    }
}
