using Livroteca.models;
using Livroteca.services;
using Livroteca.viewmodel;
using Livroteca.views;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading;
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

namespace Livroteca
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (network_status.checkConectionOk())
            {
                Cadastrese tela_cadastro = new Cadastrese();
                this.Hide();
                this.ShowInTaskbar = false;
                tela_cadastro.ShowDialog();
                this.ShowInTaskbar = true;
                this.Show();
            }
            else
                show_dialogs.showNoConection();
        }

        private void btn_entrar_Click(object sender, RoutedEventArgs e)
        {

            Thread T = new Thread(new ThreadStart(show_dialogs.showLoading));
            T.SetApartmentState(ApartmentState.STA);

            if (network_status.checkConectionOk())
            {
                T.Start();

                Login login = new Login();


                if (login.Userlogin(txtbox_cpf.Text, txtbox_senha.Text))
                {
                    T.Abort();
                    
                    MongodbAcess mongodbAcess = new MongodbAcess();

                    HomeWindow home = new HomeWindow( mongodbAcess.getAllInfoUser(txtbox_cpf.Text));
                    this.Hide();
                    this.ShowInTaskbar = false;
                    home.ShowDialog();

                    
                    this.ShowInTaskbar = true;
                    this.Show();

                    
                }
                else
                {
                    T.Abort();
                    MessageBox.Show("usuario ou senha invalida"); 
                }

            }
        }

        

        
    }
}
