using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MVC.Model
{
    public class Uzytkownik
    {        
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        
        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public Uzytkownik(string imie, string nazwisko, string haslo)
        {
            FirstName = imie;
            LastName= nazwisko;
            ID = haslo;
        }
    }
}
