using System;
using System.Linq;
using System.Collections;
using System.Text;
using MVC.Model;

namespace MVC.Controller
{
    public class UserController
    {
        IUsersView _view;
        IList _users;
        Uzytkownik _selectedUser;

        public UserController(IUsersView view, IList users)
        {
            _view = view;
            _users = users;

            view.SetController(this);
        }

        //Aktualizacja widoku danymi uzytkownika
        private void updateViewDetailValues(Uzytkownik user)
        {
            _view.FirstName = user.FirstName;
            _view.LastName = user.LastName;
            _view.ID = user.ID;
        }

        //Aktualizacja obiektu uzytkownika danymi z widoku
        private void updateUserWithViewValues(Uzytkownik user)
        {
            user.FirstName = _view.FirstName;
            user.LastName = _view.LastName ;
            user.ID = _view.ID;
        }

        public void LoadView()
        {
            _view.ClearGrid();
            foreach (Uzytkownik usr in _users)
                _view.AddUserToGrid(usr);

            //Ustawia zaznaczenie na pierwszej pozycji
            this._view.SetSelectedUserInGrid((Uzytkownik)_users[0]);
        }

        public void SelectedUserChanged(string selectedUserId)
        {
            
            foreach (Uzytkownik usr in this._users)
            {
                if (usr.ID == selectedUserId)
                {
                    _selectedUser = usr;
                    updateViewDetailValues(usr);
                    //_view.SetSelectedUserInGrid(usr);
                    //this._view.CanModifyID = false;
                    break;
                }
            }
        }

        public void AddNewUser()
        {
            _selectedUser = new Uzytkownik("",
                                            "",
                                            "");
            this.updateViewDetailValues(_selectedUser);
        }



        public void RemoveUser()
        {
            string id = this._view.GetIdOfSelectedUserInGrid();
            Uzytkownik userToRemove = null;

            if (id != "")
            {
                foreach (Uzytkownik usr in _users)
                {
                    if (usr.ID == id)
                    {
                        userToRemove = usr;
                        break;
                    }
                }

                if (userToRemove != null)
                {
                    int newSelecteIndex = this._users.IndexOf(userToRemove);
                    this._users.Remove(userToRemove);
                    this._view.RemoveUserFromGrid(userToRemove);

                    if(newSelecteIndex > -1 && newSelecteIndex < _users.Count)
                    {
                        this._view.SetSelectedUserInGrid((Uzytkownik)_users[newSelecteIndex]);
                    }
                }
            }
        }

        public void Save()
        {
            updateUserWithViewValues(_selectedUser);
            if (!this._users.Contains(_selectedUser))
            {
                this._users.Add(_selectedUser);
                this._view.AddUserToGrid(_selectedUser);
            }
            else
            {
                this._view.UpdateGridWithChangeUser(_selectedUser);
            }
            
        }
    }
}
