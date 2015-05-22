namespace BasicMVP
{
    public class MainController
    {
        private IMainView _view;
        private IMainModel _model;

        public MainController(IMainView view, IMainModel model)
        {
            _view = view;
            _model = model;

            InitializeViewEvents();
        }

        public void Run()
        {
            _view.Show();
        }

        private void InitializeViewEvents()
        {
            //Bind to View Actions here
        }

    }
}
