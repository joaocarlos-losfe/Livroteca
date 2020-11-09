using Livroteca.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livroteca.viewmodel
{
    class Login
    {
        MongodbAcess MongodbAcess = new MongodbAcess();
        public bool Userlogin(string CPF, string passowrd)
        {
            if( MongodbAcess.getUser(CPF, passowrd))
            {
                return true;
            }
            return false;
        }

        ///adiconar informacçoes de tratamento
    }
}
