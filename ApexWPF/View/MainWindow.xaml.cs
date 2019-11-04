using ApexWPF.Controller;
using ApexWPF.View;
using ApexWPF.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApexWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerPlayer controller;
        ViewModelPlayer viewModel;
        public MainWindow()
        {
            controller = new ControllerPlayer();
            viewModel = new ViewModelPlayer();
            InitializeComponent();

            this.DataContext = viewModel;
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Platform))
                return;
            if (string.IsNullOrEmpty(viewModel.PlayerName))
                return;

            if(controller.GetPlayer(viewModel.Platform, viewModel.PlayerName))
            {
                //MessageBox.Show("OK");

                ProfileWindow profile = new ProfileWindow();
                profile.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Player not found");
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
