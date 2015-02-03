using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVC.Model;

namespace MVC.Controller
{
    public interface IUsersView
    {
        void SetController(UserController controller);
        void ClearGrid();
        void AddUserToGrid(Uzytkownik user);
        string GetIdOfSelectedUserInGrid();
        void SetSelectedUserInGrid(Uzytkownik usr);
        void UpdateGridWithChangeUser(Uzytkownik usr);
        void RemoveUserFromGrid(Uzytkownik usr);

        bool CanModifyID { set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string ID { get; set; }
    }
}
