using Livroteca.models;
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
using System.Windows.Shapes;
using MongoDB.Driver;
using Livroteca.services;

namespace Livroteca
{
    /// <summary>
    /// Lógica interna para Cadastrese.xaml
    /// </summary>
    public partial class Cadastrese : Window
    {
        RegisterUser crudOperatios = new RegisterUser();
        public Cadastrese()
        {
            InitializeComponent();    
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.ShowInTaskbar = false;
        }

        private void btn_cadastrese_Click(object sender, RoutedEventArgs e)
        {
            crudOperatios.InsertNewUser(txtbox_nome_completo.Text, txtbox_cpf.Text, txtbox_cpf.Text, txtbox_email.Text, txtbox_senha.Text);   
        }

        
    }
}
