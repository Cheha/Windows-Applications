using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_MVP.Classes
{
    class Presenter
    {
        private IView view;
        private Model model;

        public Presenter(IView newView)
        {
            view = newView;
            model = new Model();
            view.UpdateUserList += new EventHandler<EventArgs>(UpdateUsers);
            view.TryLogin += new EventHandler<EventArgs>(Login);
        }

        private void UpdateUsers(object seder, EventArgs e)
        {
            view.UpdateUsers(model.Users);
        }

        private void Login(object sender, EventArgs e)
        {
            string loginResult = model.TryToLogin(view.GetUser(), view.GetPassword());
            view.ShowMessage(loginResult);
        }
    }
}
