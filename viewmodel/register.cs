using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Livroteca.services;
using Livroteca.view;
using Livroteca.views;
using MongoDB.Driver;

namespace Livroteca.models
{
    class RegisterUser
    {
        
        public void InsertNewUser(string full_name, string cpf_id, string cpf, string email, string password)
        {
            User user_info = new User();

            MongodbAcess mongodbAcess = new MongodbAcess();

            if ( validade_user(full_name, cpf, email, password))
            {
                Thread T = new Thread(new ThreadStart(show_dialogs.showLoading));
                T.SetApartmentState(ApartmentState.STA);

                user_info.full_name = full_name;
                user_info.CPF_ID = cpf_id;
                user_info.CPF = cpf;
                user_info.email = email;
                user_info.password = password;

                T.Start();

                if(!network_status.checkConectionOk())
                    MessageBox.Show("Parece que você não esta conectado a internet...");
                else
                {
                    if( mongodbAcess.getUser(cpf))
                    {
                        T.Abort();
                        MessageBox.Show("Usuario ja existente...");
                    }
                    else
                    {
                        
                        mongodbAcess.insertUser(user_info);
                        T.Abort();
                        show_dialogs.showRegisterOk();
                    }
                }
            }
            else
            {
                MessageBox.Show("Algumas dados são invalidos...");
            }
 
        }

        private bool validade_user(string nome_completo, string cpf, string email, string senha)
        {
            if (senha.Length < 6 || cpf.Length < 11 || !(email.Contains("@")))
            {
                return false;
            }

            return true;
        }

        
       
    }
}
