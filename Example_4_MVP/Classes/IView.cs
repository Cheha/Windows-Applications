using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_MVP.Classes
{
    interface IView
    {
        string GetUser();
        string GetPassword();
        void UpdateUsers(List<string> users);
        void ShowMessage(string message);

        event EventHandler<EventArgs> UpdateUserList;
        event EventHandler<EventArgs> TryLogin;
    }
}
