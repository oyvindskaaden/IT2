namespace Adressebok
{
    partial class adressebok
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
            this.pLogin = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.pSok = new System.Windows.Forms.Panel();
            this.pShow = new System.Windows.Forms.Panel();
            this.tbFNavn = new System.Windows.Forms.TextBox();
            this.tbENavn = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.starCheck = new System.Windows.Forms.CheckBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.søkList = new System.Windows.Forms.DataGridView();
            this.navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fav = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbSok = new System.Windows.Forms.TextBox();
            this.btSok = new System.Windows.Forms.Button();
            this.pLogin.SuspendLayout();
            this.pSok.SuspendLayout();
            this.pShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.søkList)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.btLogin);
            this.pLogin.Controls.Add(this.tbPass);
            this.pLogin.Location = new System.Drawing.Point(12, 12);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(167, 57);
            this.pLogin.TabIndex = 1;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(44, 29);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(3, 3);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '?';
            this.tbPass.Size = new System.Drawing.Size(161, 20);
            this.tbPass.TabIndex = 0;
            // 
            // pSok
            // 
            this.pSok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pSok.Controls.Add(this.btSok);
            this.pSok.Controls.Add(this.tbSok);
            this.pSok.Controls.Add(this.søkList);
            this.pSok.Location = new System.Drawing.Point(506, 173);
            this.pSok.Name = "pSok";
            this.pSok.Size = new System.Drawing.Size(398, 275);
            this.pSok.TabIndex = 2;
            // 
            // pShow
            // 
            this.pShow.Controls.Add(this.btSave);
            this.pShow.Controls.Add(this.btRight);
            this.pShow.Controls.Add(this.btSearch);
            this.pShow.Controls.Add(this.btLeft);
            this.pShow.Controls.Add(this.starCheck);
            this.pShow.Controls.Add(this.label4);
            this.pShow.Controls.Add(this.label3);
            this.pShow.Controls.Add(this.tbAddr);
            this.pShow.Controls.Add(this.label2);
            this.pShow.Controls.Add(this.label1);
            this.pShow.Controls.Add(this.tbNr);
            this.pShow.Controls.Add(this.tbENavn);
            this.pShow.Controls.Add(this.tbFNavn);
            this.pShow.Location = new System.Drawing.Point(15, 107);
            this.pShow.Name = "pShow";
            this.pShow.Size = new System.Drawing.Size(352, 196);
            this.pShow.TabIndex = 3;
            // 
            // tbFNavn
            // 
            this.tbFNavn.Location = new System.Drawing.Point(102, 25);
            this.tbFNavn.Name = "tbFNavn";
            this.tbFNavn.Size = new System.Drawing.Size(152, 20);
            this.tbFNavn.TabIndex = 0;
            // 
            // tbENavn
            // 
            this.tbENavn.Location = new System.Drawing.Point(102, 51);
            this.tbENavn.Name = "tbENavn";
            this.tbENavn.Size = new System.Drawing.Size(152, 20);
            this.tbENavn.TabIndex = 1;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(102, 77);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(152, 20);
            this.tbNr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etternavn";
            // 
            // tbAddr
            // 
            this.tbAddr.Location = new System.Drawing.Point(102, 103);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(152, 20);
            this.tbAddr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // starCheck
            // 
            this.starCheck.AutoSize = true;
            this.starCheck.Location = new System.Drawing.Point(102, 130);
            this.starCheck.Name = "starCheck";
            this.starCheck.Size = new System.Drawing.Size(61, 17);
            this.starCheck.TabIndex = 8;
            this.starCheck.Text = "Favoritt";
            this.starCheck.UseVisualStyleBackColor = true;
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(17, 158);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(75, 23);
            this.btLeft.TabIndex = 9;
            this.btLeft.Text = "<--";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btNav);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(98, 158);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "Søk";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(260, 158);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(75, 23);
            this.btRight.TabIndex = 11;
            this.btRight.Text = "-->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btNav);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(179, 158);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Lagre";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // søkList
            // 
            this.søkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.søkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.navn,
            this.nummer,
            this.adresse,
            this.fav});
            this.søkList.Location = new System.Drawing.Point(3, 92);
            this.søkList.Name = "søkList";
            this.søkList.Size = new System.Drawing.Size(393, 150);
            this.søkList.TabIndex = 0;
            // 
            // navn
            // 
            this.navn.HeaderText = "Navn";
            this.navn.Name = "navn";
            this.navn.ReadOnly = true;
            // 
            // nummer
            // 
            this.nummer.HeaderText = "Nummer";
            this.nummer.Name = "nummer";
            this.nummer.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // fav
            // 
            this.fav.HeaderText = "Favoritt";
            this.fav.Name = "fav";
            this.fav.ReadOnly = true;
            this.fav.Width = 50;
            // 
            // tbSok
            // 
            this.tbSok.Location = new System.Drawing.Point(3, 66);
            this.tbSok.Name = "tbSok";
            this.tbSok.Size = new System.Drawing.Size(180, 20);
            this.tbSok.TabIndex = 1;
            this.tbSok.TextChanged += new System.EventHandler(this.DoSearch);
            // 
            // btSok
            // 
            this.btSok.Location = new System.Drawing.Point(190, 64);
            this.btSok.Name = "btSok";
            this.btSok.Size = new System.Drawing.Size(75, 23);
            this.btSok.TabIndex = 2;
            this.btSok.Text = "Søk";
            this.btSok.UseVisualStyleBackColor = true;
            this.btSok.Click += new System.EventHandler(this.DoSearch);
            // 
            // adressebok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(995, 525);
            this.Controls.Add(this.pShow);
            this.Controls.Add(this.pSok);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adressebok";
            this.Text = "Adressebok";
            this.Load += new System.EventHandler(this.Adressebok_Load);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pSok.ResumeLayout(false);
            this.pSok.PerformLayout();
            this.pShow.ResumeLayout(false);
            this.pShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.søkList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel pSok;
        private System.Windows.Forms.Panel pShow;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.CheckBox starCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNr;
        private System.Windows.Forms.TextBox tbENavn;
        private System.Windows.Forms.TextBox tbFNavn;
        private System.Windows.Forms.DataGridView søkList;
        private System.Windows.Forms.DataGridViewTextBoxColumn navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fav;
        private System.Windows.Forms.Button btSok;
        private System.Windows.Forms.TextBox tbSok;
    }
}

