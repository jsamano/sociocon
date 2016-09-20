using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sociocon.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        string username;
        string password;

        public LoginViewModel() { }

        public string Username
        {
            get { return username; }
            set
            {
                if ( value == username )
                    return;

                username = value;
                OnPropertyChanged("username");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if ( value == password )
                    return;

                password = value;
                OnPropertyChanged("password");
            }
        }
    }
}
