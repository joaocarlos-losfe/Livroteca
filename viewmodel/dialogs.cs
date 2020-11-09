using Livroteca.view;
using Livroteca.views.dialog_views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livroteca.views
{
    public static class show_dialogs
    {
        
        public static void showRegisterOk()
        {
            mensagebox_registerOK register_ok = new mensagebox_registerOK();
            register_ok.ShowDialog();
        }

        public static void showNoConection()
        {
            no_conection no_Conection = new no_conection();
            no_Conection.ShowDialog();
        }

        public static void showLoading()
        {
            loading_user loading_User = new loading_user();
            loading_User.ShowDialog();
        }
    }
}
