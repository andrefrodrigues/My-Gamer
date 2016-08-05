using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace My_Gamer.AppLogic
{
    //this is the upper level class
    class MyGamer
    {
        public CurrentUser User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
            }
        }
        private CurrentUser _User;
        public MyGamer()
        {

        }
        public async void register(string email, string nome, char sexo, string password)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "email",email },
                    {"nome",nome },
                    { "sexo" , sexo.ToString() },
                    {"password",password }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("", content);

                var responseString = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
