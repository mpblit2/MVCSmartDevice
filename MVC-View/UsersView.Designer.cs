namespace MVC.View
{
    partial class UsersView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttUsun = new System.Windows.Forms.Button();
            this.chBAdmin = new System.Windows.Forms.CheckBox();
            this.tBHaslo = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.tBNazwisko = new System.Windows.Forms.TextBox();
            this.chBAktywny = new System.Windows.Forms.CheckBox();
            this.lbImie = new System.Windows.Forms.Label();
            this.tBImie = new System.Windows.Forms.TextBox();
            this.bttZapisz = new System.Windows.Forms.Button();
            this.bttZaniechaj = new System.Windows.Forms.Button();
            this.bttNowy = new System.Windows.Forms.Button();
            this.bttEdycja = new System.Windows.Forms.Button();
            this.bttWybierz = new System.Windows.Forms.Button();
            this.bttWyjscie = new System.Windows.Forms.Button();
            this.dgGrid = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // bttUsun
            // 
            this.bttUsun.Location = new System.Drawing.Point(169, 311);
            this.bttUsun.Name = "bttUsun";
            this.bttUsun.Size = new System.Drawing.Size(75, 35);
            this.bttUsun.TabIndex = 47;
            this.bttUsun.Text = "Usuń";
            this.bttUsun.Click += new System.EventHandler(this.bttUsun_Click_1);
            // 
            // chBAdmin
            // 
            this.chBAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chBAdmin.Location = new System.Drawing.Point(88, 378);
            this.chBAdmin.Name = "chBAdmin";
            this.chBAdmin.Size = new System.Drawing.Size(109, 20);
            this.chBAdmin.TabIndex = 46;
            this.chBAdmin.Text = "Administrator";
            // 
            // tBHaslo
            // 
            this.tBHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBHaslo.Location = new System.Drawing.Point(88, 464);
            this.tBHaslo.Name = "tBHaslo";
            this.tBHaslo.Size = new System.Drawing.Size(150, 23);
            this.tBHaslo.TabIndex = 45;
            // 
            // lblHaslo
            // 
            this.lblHaslo.Location = new System.Drawing.Point(7, 464);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(58, 18);
            this.lblHaslo.Text = "Hasło:";
            this.lblHaslo.ParentChanged += new System.EventHandler(this.lblHaslo_ParentChanged);
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.Location = new System.Drawing.Point(7, 435);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(75, 18);
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // tBNazwisko
            // 
            this.tBNazwisko.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBNazwisko.Location = new System.Drawing.Point(88, 435);
            this.tBNazwisko.Name = "tBNazwisko";
            this.tBNazwisko.Size = new System.Drawing.Size(368, 23);
            this.tBNazwisko.TabIndex = 44;
            // 
            // chBAktywny
            // 
            this.chBAktywny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chBAktywny.Location = new System.Drawing.Point(88, 352);
            this.chBAktywny.Name = "chBAktywny";
            this.chBAktywny.Size = new System.Drawing.Size(100, 20);
            this.chBAktywny.TabIndex = 43;
            this.chBAktywny.Text = "Aktywny";
            // 
            // lbImie
            // 
            this.lbImie.Location = new System.Drawing.Point(7, 404);
            this.lbImie.Name = "lbImie";
            this.lbImie.Size = new System.Drawing.Size(75, 18);
            this.lbImie.Text = "Imię:";
            // 
            // tBImie
            // 
            this.tBImie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBImie.Location = new System.Drawing.Point(88, 404);
            this.tBImie.Name = "tBImie";
            this.tBImie.Size = new System.Drawing.Size(368, 23);
            this.tBImie.TabIndex = 42;
            // 
            // bttZapisz
            // 
            this.bttZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttZapisz.Location = new System.Drawing.Point(445, 464);
            this.bttZapisz.Name = "bttZapisz";
            this.bttZapisz.Size = new System.Drawing.Size(75, 35);
            this.bttZapisz.TabIndex = 41;
            this.bttZapisz.Text = "Zapisz";
            this.bttZapisz.Click += new System.EventHandler(this.bttZapisz_Click_1);
            // 
            // bttZaniechaj
            // 
            this.bttZaniechaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttZaniechaj.Location = new System.Drawing.Point(526, 464);
            this.bttZaniechaj.Name = "bttZaniechaj";
            this.bttZaniechaj.Size = new System.Drawing.Size(75, 35);
            this.bttZaniechaj.TabIndex = 40;
            this.bttZaniechaj.Text = "Zaniechaj";
            // 
            // bttNowy
            // 
            this.bttNowy.Location = new System.Drawing.Point(7, 311);
            this.bttNowy.Name = "bttNowy";
            this.bttNowy.Size = new System.Drawing.Size(75, 35);
            this.bttNowy.TabIndex = 39;
            this.bttNowy.Text = "Nowy";
            this.bttNowy.Click += new System.EventHandler(this.bttNowy_Click_1);
            // 
            // bttEdycja
            // 
            this.bttEdycja.Location = new System.Drawing.Point(88, 311);
            this.bttEdycja.Name = "bttEdycja";
            this.bttEdycja.Size = new System.Drawing.Size(75, 35);
            this.bttEdycja.TabIndex = 38;
            this.bttEdycja.Text = "Edycja";
            this.bttEdycja.Click += new System.EventHandler(this.bttEdycja_Click_1);
            // 
            // bttWybierz
            // 
            this.bttWybierz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttWybierz.Location = new System.Drawing.Point(445, 311);
            this.bttWybierz.Name = "bttWybierz";
            this.bttWybierz.Size = new System.Drawing.Size(75, 35);
            this.bttWybierz.TabIndex = 37;
            this.bttWybierz.Text = "Wybierz";
            this.bttWybierz.Click += new System.EventHandler(this.bttWybierz_Click);
            // 
            // bttWyjscie
            // 
            this.bttWyjscie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttWyjscie.Location = new System.Drawing.Point(526, 311);
            this.bttWyjscie.Name = "bttWyjscie";
            this.bttWyjscie.Size = new System.Drawing.Size(75, 35);
            this.bttWyjscie.TabIndex = 35;
            this.bttWyjscie.Text = "Wyjscie";
            this.bttWyjscie.Click += new System.EventHandler(this.bttWyjscie_Click);
            // 
            // dgGrid
            // 
            this.dgGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgGrid.Location = new System.Drawing.Point(7, 3);
            this.dgGrid.Name = "dgGrid";
            this.dgGrid.Size = new System.Drawing.Size(594, 300);
            this.dgGrid.TabIndex = 55;
            this.dgGrid.CurrentCellChanged += new System.EventHandler(this.dgGrid_CurrentCellChanged);
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(608, 505);
            this.Controls.Add(this.dgGrid);
            this.Controls.Add(this.bttUsun);
            this.Controls.Add(this.chBAdmin);
            this.Controls.Add(this.tBHaslo);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.tBNazwisko);
            this.Controls.Add(this.chBAktywny);
            this.Controls.Add(this.lbImie);
            this.Controls.Add(this.tBImie);
            this.Controls.Add(this.bttZapisz);
            this.Controls.Add(this.bttZaniechaj);
            this.Controls.Add(this.bttNowy);
            this.Controls.Add(this.bttEdycja);
            this.Controls.Add(this.bttWybierz);
            this.Controls.Add(this.bttWyjscie);
            this.Name = "UsersView";
            this.Text = "UsersView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttUsun;
        private System.Windows.Forms.CheckBox chBAdmin;
        private System.Windows.Forms.TextBox tBHaslo;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox tBNazwisko;
        private System.Windows.Forms.CheckBox chBAktywny;
        private System.Windows.Forms.Label lbImie;
        private System.Windows.Forms.TextBox tBImie;
        private System.Windows.Forms.Button bttZapisz;
        private System.Windows.Forms.Button bttZaniechaj;
        private System.Windows.Forms.Button bttNowy;
        private System.Windows.Forms.Button bttEdycja;
        private System.Windows.Forms.Button bttWybierz;
        private System.Windows.Forms.Button bttWyjscie;
        private System.Windows.Forms.DataGrid dgGrid;
    }
}