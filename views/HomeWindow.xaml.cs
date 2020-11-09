using Livroteca.models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Livroteca
{
    /// <summary>
    /// Lógica interna para HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {

        User user_info = new User();
        
        public HomeWindow(User user)
        {
            
            InitializeComponent();
            user_info = user;

            lbl_bem_vindo.Text = "Olá, " + user_info.full_name ;

        }

        private void txtbox_pesquisar_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            lv_pesquisa_sujestao.Items.Clear();

            if (txtbox_pesquisar.Text != "")
            {
                lv_pesquisa_sujestao.Visibility = Visibility.Visible;

                foreach(string livro in simular_livros)
                {
                    if (livro.StartsWith(txtbox_pesquisar.Text))
                    {
                        lv_pesquisa_sujestao.Items.Add(livro);
                    } 
                }
            }
            else
            {
                lv_pesquisa_sujestao.Visibility = Visibility.Hidden;
            }
            */
                
        }

        private void lv_pesquisa_sujestao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            foreach (var item in lv_pesquisa_sujestao.SelectedItems)
            {
                selected_item = item.ToString();
            }

            txtbox_pesquisar.Text = selected_item;

            lv_pesquisa_sujestao.Visibility = Visibility.Hidden;
            */
            
        }
    }
}
