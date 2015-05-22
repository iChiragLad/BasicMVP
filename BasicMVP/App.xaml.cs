using System.Windows;

namespace BasicMVP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private MainController ctl;
        private MainView view;
        private IMainModel model;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            view = new MainView();
            model = new MainModel();

            ctl = new MainController(view, model);

            ctl.Run();
        }
    }
}
