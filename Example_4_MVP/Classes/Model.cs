using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_MVP.Classes
{
    class Model
    {
        public Dictionary<string, string> Credentials { get; set; } // Users and passwords

        public List<string> Users
        {
            get { return Credentials.Keys.ToList<string>(); }
        }

        public Model()
        {
            Credentials = new Dictionary<string, string>();
            Credentials.Add("User1", "Password1");
        }

        public string TryToLogin(string user, string password)
        {
            if (Credentials.ContainsKey(user))
            {
                int index = Credentials.Keys.ToList<string>().IndexOf(user);
                if (Credentials.Values.ToList<string>()[index].Equals(password))
                {
                    return "Login successful";
                }
                return "Wrong password";
            }
            return "Wrong login";
        }
    }
}
