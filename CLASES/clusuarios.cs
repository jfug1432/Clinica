using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLASES
{
    class clusuarios
    {
        private int id;
        private string nombre;
        private string email;
        private int fecha;
        private int idrole;      
        private string password;
        private int idempresa;

        public clusuarios (string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string ingresar()
        {
            return ("select * from tblusarios where email='"+this.email+"' and password ='"+ this.password +"'");
        }
        
    }
}
