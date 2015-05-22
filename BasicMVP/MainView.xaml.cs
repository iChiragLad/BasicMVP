using System;
using System.Windows;

namespace BasicMVP
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        //public Action FileSelected { get; set; }
        //public Action<string, string> SessionInfoChanged { get; set; }
    }
}
