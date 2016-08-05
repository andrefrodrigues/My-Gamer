using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Gamer.AppLogic
{
    class CurrentUser
    {
        private string _Email;
        private string _Nome;
        private char _Sexo;
        public string Email {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }
        public char Sexo
        {
            get
            {
                return _Sexo;
            }
            set
            {
                _Sexo = value;
            }
        }
        public CurrentUser(string email,string nome,char sexo)
        {
            _Email = email;
            _Nome = nome;
            _Sexo = sexo;
        }

    }
}
