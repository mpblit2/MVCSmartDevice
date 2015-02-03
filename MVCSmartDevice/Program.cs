using System;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;
using MVC.View;

namespace MVCSmartDevice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            //Application.Run(new Form1());
            UsersView view = new UsersView();
            view.Visible = false;

            IList users = new ArrayList();
            users.Add(new Uzytkownik("Janusz", "Tomaszewski", "1"));
            users.Add(new Uzytkownik("Kazimierz", "Sowa", "2"));
            users.Add(new Uzytkownik("Ewa", "Kowalska", "3"));

            UserController controller = new UserController(view, users);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}