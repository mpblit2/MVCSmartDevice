using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;

namespace MVC.View
{
    public partial class UsersView : Form, IUsersView
    {
        UserController _controller;

        DataTable table = new DataTable("Users");

        public UsersView()
        {
            InitializeComponent();
        }

        private void bttUsun_Click(object sender, EventArgs e)
        {
            _controller.RemoveUser();
        }

        private void tBHaslo_GotFocus(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBNazwisko_GotFocus(object sender, EventArgs e)
        {

        }

        private void tBImie_GotFocus(object sender, EventArgs e)
        {

        }

        private void bttZapisz_Click(object sender, EventArgs e)
        {
        }

        private void bttZaniechaj_Click(object sender, EventArgs e)
        {

        }

        private void bttNowy_Click(object sender, EventArgs e)
        {

        }

        private void bttEdycja_Click(object sender, EventArgs e)
        {
        }

        private void dgUzytkownicy_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void bttWyjscie_Click_1(object sender, EventArgs e)
        {

        }

        private void bttWyjscie_Click(object sender, EventArgs e)
        {

        }

        #region Implementacja Interfejsu

        public void SetController(UserController controller)
        {
            _controller = controller;
        }

        public void ClearGrid()
        {
            DataColumn dc;
            dc = new DataColumn("ID", System.Type.GetType("System.String"));
            dc.DefaultValue = string.Empty;
            dc.Caption = "Id";
            table.Columns.Add(dc);

            dc = new DataColumn("Imie", System.Type.GetType("System.String"));
            dc.DefaultValue = string.Empty;
            dc.Caption = "Imie";
            table.Columns.Add(dc);

            dc = new DataColumn("Nazwisko", System.Type.GetType("System.String"));
            dc.DefaultValue = string.Empty;
            dc.Caption = "Nazwisko";
            table.Columns.Add(dc);

            dgGrid.DataSource = null;
        }

        public void AddUserToGrid(Uzytkownik usr)
        {
            DataRow dr;
            dr = table.NewRow();
            dr["ID"] = usr.ID;
            dr["Imie"] = usr.FirstName;
            dr["Nazwisko"] = usr.LastName;

            table.Rows.Add(dr);
            dgGrid.DataSource = table;
        }

        public void UpdateGridWithChangeUser(Uzytkownik usr)
        {
            DataRow rowToUpdate = null;

            foreach (DataRow row in table.Rows)
            {
                if (row["ID"].ToString() == usr.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate["ID"] = usr.ID;
                rowToUpdate["Imie"] = usr.FirstName;
                rowToUpdate["Nazwisko"] = usr.LastName;
            }
        }

        public void RemoveUserFromGrid(Uzytkownik usr)
        {
            DataRow rowToRemove = null;

            foreach (DataRow row in this.table.Rows)
            {
                if (row["ID"].ToString() == usr.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.table.Rows.Remove(rowToRemove);
                this.dgGrid.Focus();
            }


        }
            /*
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdUsers.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = usr.ID;
                rowToUpdate.SubItems[1].Text = usr.FirstName;
                rowToUpdate.SubItems[2].Text = usr.LastName;
            }
             */


        public string GetIdOfSelectedUserInGrid()
        {
            if (this.dgGrid.VisibleRowCount > 0)
            {
                return this.dgGrid[this.dgGrid.CurrentRowIndex, 0].ToString();
            }

            return "";
            /*
            if (this.grdUsers.SelectedIndices.Count > 0)
            {
                return this.grdUsers.SelectedIndices[0].ToString();
            }
            else
             */
            
             
        }

        public void SetSelectedUserInGrid(Uzytkownik usr)
        {
            /*
            foreach (ListViewItem row in this.grdUsers.Items)
            {
                if (row.Text == usr.ID)
                {
                    row.Selected = true;
                }
            }
             */
        }

        public string FirstName
        {
            get { return this.tBImie.Text; }
            set { this.tBImie.Text = value; }
        }

        public string LastName
        {
            get { return this.tBNazwisko.Text; }
            set { this.tBNazwisko.Text = value; }
        }

        public string ID
        {
            get { return this.tBHaslo.Text; }
            set { this.tBHaslo.Text = value; }
        }

        #endregion

        private void lblHaslo_ParentChanged(object sender, EventArgs e)
        {
        
        }

        private void CreateTable()
        {
            DataColumn dc;

            dc = new DataColumn("Haslo", System.Type.GetType("System.String"));
            dc.DefaultValue = string.Empty;
            dc.Caption = "Haslo";
            table.Columns.Add(dc);
            
            dc = new DataColumn("Imie", System.Type.GetType("System.String"));
            dc.DefaultValue = string.Empty;
            dc.Caption = "Imie";
            table.Columns.Add(dc);

            dc = new DataColumn("Nazwisko", System.Type.GetType("System.String"));
            dc.DefaultValue = string.Empty;
            dc.Caption = "Nazwisko";
            table.Columns.Add(dc);
        }

        private void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public bool CanModifyID
        {
            set { this.tBHaslo.Enabled = value; }
        }

        private void grdUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            /*
            //MessageBox.Show(this.grdUsers.SelectedIndices.Count.ToString());
            if (this.grdUsers.SelectedIndices.Count > 0)
            {
                //MessageBox.Show(this.grdUsers.SelectedIndices[0].ToString());
                this._controller.SelectedUserChanged(this.grdUsers.SelectedIndices[0].ToString());
            }*/
        }

        private void bttWybierz_Click(object sender, EventArgs e)
        {

        }

        private void dgGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dgGrid.VisibleRowCount.ToString());
            if (this.dgGrid.VisibleRowCount > 0)
            {
                //MessageBox.Show(this.dgGrid[this.dgGrid.CurrentRowIndex, 0].ToString());
                this._controller.SelectedUserChanged(this.dgGrid[this.dgGrid.CurrentRowIndex, 0].ToString());
            }
        }

        private void bttEdycja_Click_1(object sender, EventArgs e)
        {
        }

        private void bttNowy_Click_1(object sender, EventArgs e)
        {
            _controller.AddNewUser();
        }

        private void bttZapisz_Click_1(object sender, EventArgs e)
        {
            _controller.Save();
        }

        private void bttUsun_Click_1(object sender, EventArgs e)
        {
            _controller.RemoveUser();
        }
    }
}