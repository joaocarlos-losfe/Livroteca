using Livroteca.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Livroteca.services
{
    public static class network_status
    {
        public static bool checkConectionOk()
        {
            bool conection_ok = false;
            System.Uri Url = new System.Uri("http://www.microsoft.com"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                conection_ok = true;
            }
            catch
            {
                WebReq = null;
                conection_ok = false;
            }

            Console.WriteLine(conection_ok);

            return conection_ok;
        }
    }
}
