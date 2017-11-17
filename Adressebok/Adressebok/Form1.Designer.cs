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
            this.btCans = new System.Windows.Forms.Button();
            this.btSok = new System.Windows.Forms.Button();
            this.tbSok = new System.Windows.Forms.TextBox();
            this.sokList = new System.Windows.Forms.DataGridView();
            this.inx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pShow = new System.Windows.Forms.Panel();
            this.labPlass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numNr = new System.Windows.Forms.NumericUpDown();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.starCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbENavn = new System.Windows.Forms.TextBox();
            this.tbFNavn = new System.Windows.Forms.TextBox();
            this.pNew = new System.Windows.Forms.Panel();
            this.btAvbryt = new System.Windows.Forms.Button();
            this.numNyNr = new System.Windows.Forms.NumericUpDown();
            this.btSave = new System.Windows.Forms.Button();
            this.checkSave = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNyAddr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNyENavn = new System.Windows.Forms.TextBox();
            this.tbNyFNavn = new System.Windows.Forms.TextBox();
            this.m1 = new System.Windows.Forms.MenuStrip();
            this.søkTM = new System.Windows.Forms.ToolStripMenuItem();
            this.newOpp = new System.Windows.Forms.ToolStripMenuItem();
            this.chOpp = new System.Windows.Forms.ToolStripMenuItem();
            this.endreOppføringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slettOppføringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLogin.SuspendLayout();
            this.pSok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sokList)).BeginInit();
            this.pShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNr)).BeginInit();
            this.pNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNyNr)).BeginInit();
            this.m1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.btLogin);
            this.pLogin.Controls.Add(this.tbPass);
            this.pLogin.Location = new System.Drawing.Point(12, 27);
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
            this.pSok.Controls.Add(this.btCans);
            this.pSok.Controls.Add(this.btSok);
            this.pSok.Controls.Add(this.tbSok);
            this.pSok.Controls.Add(this.sokList);
            this.pSok.Location = new System.Drawing.Point(381, 36);
            this.pSok.Name = "pSok";
            this.pSok.Size = new System.Drawing.Size(410, 280);
            this.pSok.TabIndex = 2;
            // 
            // btCans
            // 
            this.btCans.Location = new System.Drawing.Point(271, 12);
            this.btCans.Name = "btCans";
            this.btCans.Size = new System.Drawing.Size(75, 23);
            this.btCans.TabIndex = 3;
            this.btCans.Text = "Avbryt";
            this.btCans.UseVisualStyleBackColor = true;
            this.btCans.Click += new System.EventHandler(this.Cancel);
            // 
            // btSok
            // 
            this.btSok.Location = new System.Drawing.Point(190, 12);
            this.btSok.Name = "btSok";
            this.btSok.Size = new System.Drawing.Size(75, 23);
            this.btSok.TabIndex = 2;
            this.btSok.Text = "Søk";
            this.btSok.UseVisualStyleBackColor = true;
            this.btSok.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSok
            // 
            this.tbSok.Location = new System.Drawing.Point(3, 14);
            this.tbSok.Name = "tbSok";
            this.tbSok.Size = new System.Drawing.Size(180, 20);
            this.tbSok.TabIndex = 1;
            this.tbSok.TextChanged += new System.EventHandler(this.btSearch_Click);
            // 
            // sokList
            // 
            this.sokList.AllowUserToAddRows = false;
            this.sokList.AllowUserToDeleteRows = false;
            this.sokList.AllowUserToResizeRows = false;
            this.sokList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sokList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inx,
            this.navn,
            this.nummer,
            this.adresse});
            this.sokList.Location = new System.Drawing.Point(3, 40);
            this.sokList.Name = "sokList";
            this.sokList.Size = new System.Drawing.Size(403, 237);
            this.sokList.TabIndex = 0;
            this.sokList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getSearch);
            // 
            // inx
            // 
            this.inx.HeaderText = "Plassering";
            this.inx.Name = "inx";
            this.inx.ReadOnly = true;
            this.inx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inx.Width = 60;
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
            // pShow
            // 
            this.pShow.Controls.Add(this.labPlass);
            this.pShow.Controls.Add(this.label9);
            this.pShow.Controls.Add(this.numNr);
            this.pShow.Controls.Add(this.btRight);
            this.pShow.Controls.Add(this.btLeft);
            this.pShow.Controls.Add(this.starCheck);
            this.pShow.Controls.Add(this.label4);
            this.pShow.Controls.Add(this.label3);
            this.pShow.Controls.Add(this.tbAddr);
            this.pShow.Controls.Add(this.label2);
            this.pShow.Controls.Add(this.label1);
            this.pShow.Controls.Add(this.tbENavn);
            this.pShow.Controls.Add(this.tbFNavn);
            this.pShow.Location = new System.Drawing.Point(12, 90);
            this.pShow.Name = "pShow";
            this.pShow.Size = new System.Drawing.Size(352, 213);
            this.pShow.TabIndex = 3;
            // 
            // labPlass
            // 
            this.labPlass.AutoSize = true;
            this.labPlass.Location = new System.Drawing.Point(99, 15);
            this.labPlass.Name = "labPlass";
            this.labPlass.Size = new System.Drawing.Size(55, 13);
            this.labPlass.TabIndex = 18;
            this.labPlass.Text = "Plassering";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Plassering";
            // 
            // numNr
            // 
            this.numNr.Location = new System.Drawing.Point(102, 90);
            this.numNr.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numNr.Name = "numNr";
            this.numNr.ReadOnly = true;
            this.numNr.Size = new System.Drawing.Size(152, 20);
            this.numNr.TabIndex = 16;
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(181, 173);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(75, 23);
            this.btRight.TabIndex = 11;
            this.btRight.Text = "-->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btNav);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(100, 173);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(75, 23);
            this.btLeft.TabIndex = 9;
            this.btLeft.Text = "<--";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btNav);
            // 
            // starCheck
            // 
            this.starCheck.AutoCheck = false;
            this.starCheck.AutoSize = true;
            this.starCheck.Location = new System.Drawing.Point(102, 143);
            this.starCheck.Name = "starCheck";
            this.starCheck.Size = new System.Drawing.Size(61, 17);
            this.starCheck.TabIndex = 8;
            this.starCheck.Text = "Favoritt";
            this.starCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nummer";
            // 
            // tbAddr
            // 
            this.tbAddr.Location = new System.Drawing.Point(102, 116);
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.ReadOnly = true;
            this.tbAddr.Size = new System.Drawing.Size(152, 20);
            this.tbAddr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etternavn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fornavn";
            // 
            // tbENavn
            // 
            this.tbENavn.Location = new System.Drawing.Point(102, 64);
            this.tbENavn.Name = "tbENavn";
            this.tbENavn.ReadOnly = true;
            this.tbENavn.Size = new System.Drawing.Size(152, 20);
            this.tbENavn.TabIndex = 1;
            // 
            // tbFNavn
            // 
            this.tbFNavn.Location = new System.Drawing.Point(102, 38);
            this.tbFNavn.Name = "tbFNavn";
            this.tbFNavn.ReadOnly = true;
            this.tbFNavn.Size = new System.Drawing.Size(152, 20);
            this.tbFNavn.TabIndex = 0;
            // 
            // pNew
            // 
            this.pNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pNew.Controls.Add(this.btAvbryt);
            this.pNew.Controls.Add(this.numNyNr);
            this.pNew.Controls.Add(this.btSave);
            this.pNew.Controls.Add(this.checkSave);
            this.pNew.Controls.Add(this.label5);
            this.pNew.Controls.Add(this.label6);
            this.pNew.Controls.Add(this.tbNyAddr);
            this.pNew.Controls.Add(this.label7);
            this.pNew.Controls.Add(this.label8);
            this.pNew.Controls.Add(this.tbNyENavn);
            this.pNew.Controls.Add(this.tbNyFNavn);
            this.pNew.Location = new System.Drawing.Point(12, 317);
            this.pNew.Name = "pNew";
            this.pNew.Size = new System.Drawing.Size(352, 196);
            this.pNew.TabIndex = 14;
            // 
            // btAvbryt
            // 
            this.btAvbryt.Location = new System.Drawing.Point(102, 153);
            this.btAvbryt.Name = "btAvbryt";
            this.btAvbryt.Size = new System.Drawing.Size(73, 23);
            this.btAvbryt.TabIndex = 18;
            this.btAvbryt.Text = "Avbryt";
            this.btAvbryt.UseVisualStyleBackColor = true;
            this.btAvbryt.Click += new System.EventHandler(this.Cancel);
            // 
            // numNyNr
            // 
            this.numNyNr.Location = new System.Drawing.Point(102, 77);
            this.numNyNr.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numNyNr.Name = "numNyNr";
            this.numNyNr.Size = new System.Drawing.Size(152, 20);
            this.numNyNr.TabIndex = 17;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(181, 153);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(73, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Lagre";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // checkSave
            // 
            this.checkSave.AutoSize = true;
            this.checkSave.Location = new System.Drawing.Point(102, 130);
            this.checkSave.Name = "checkSave";
            this.checkSave.Size = new System.Drawing.Size(61, 17);
            this.checkSave.TabIndex = 8;
            this.checkSave.Text = "Favoritt";
            this.checkSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nummer";
            // 
            // tbNyAddr
            // 
            this.tbNyAddr.Location = new System.Drawing.Point(102, 103);
            this.tbNyAddr.Name = "tbNyAddr";
            this.tbNyAddr.Size = new System.Drawing.Size(152, 20);
            this.tbNyAddr.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Etternavn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fornavn";
            // 
            // tbNyENavn
            // 
            this.tbNyENavn.Location = new System.Drawing.Point(102, 51);
            this.tbNyENavn.Name = "tbNyENavn";
            this.tbNyENavn.Size = new System.Drawing.Size(152, 20);
            this.tbNyENavn.TabIndex = 1;
            // 
            // tbNyFNavn
            // 
            this.tbNyFNavn.Location = new System.Drawing.Point(102, 25);
            this.tbNyFNavn.Name = "tbNyFNavn";
            this.tbNyFNavn.Size = new System.Drawing.Size(152, 20);
            this.tbNyFNavn.TabIndex = 0;
            // 
            // m1
            // 
            this.m1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.søkTM,
            this.newOpp,
            this.chOpp});
            this.m1.Location = new System.Drawing.Point(0, 0);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(995, 24);
            this.m1.TabIndex = 15;
            this.m1.Text = "menuStrip1";
            this.m1.Visible = false;
            // 
            // søkTM
            // 
            this.søkTM.Name = "søkTM";
            this.søkTM.Size = new System.Drawing.Size(38, 20);
            this.søkTM.Text = "Søk";
            this.søkTM.Click += new System.EventHandler(this.søkTM_Click);
            // 
            // newOpp
            // 
            this.newOpp.Name = "newOpp";
            this.newOpp.Size = new System.Drawing.Size(92, 20);
            this.newOpp.Text = "Ny Oppføring";
            this.newOpp.Click += new System.EventHandler(this.newOpp_Click);
            // 
            // chOpp
            // 
            this.chOpp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endreOppføringToolStripMenuItem,
            this.slettOppføringToolStripMenuItem});
            this.chOpp.Name = "chOpp";
            this.chOpp.Size = new System.Drawing.Size(59, 20);
            this.chOpp.Text = "Rediger";
            // 
            // endreOppføringToolStripMenuItem
            // 
            this.endreOppføringToolStripMenuItem.Name = "endreOppføringToolStripMenuItem";
            this.endreOppføringToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.endreOppføringToolStripMenuItem.Text = "Endre Oppføring";
            this.endreOppføringToolStripMenuItem.Click += new System.EventHandler(this.chOpp_Click);
            // 
            // slettOppføringToolStripMenuItem
            // 
            this.slettOppføringToolStripMenuItem.Name = "slettOppføringToolStripMenuItem";
            this.slettOppføringToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.slettOppføringToolStripMenuItem.Text = "Slett Oppføring";
            this.slettOppføringToolStripMenuItem.Click += new System.EventHandler(this.mSlett_Click);
            // 
            // adressebok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(995, 525);
            this.Controls.Add(this.pNew);
            this.Controls.Add(this.pShow);
            this.Controls.Add(this.pSok);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.m1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.m1;
            this.Name = "adressebok";
            this.Text = "mes";
            this.Load += new System.EventHandler(this.Adressebok_Load);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pSok.ResumeLayout(false);
            this.pSok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sokList)).EndInit();
            this.pShow.ResumeLayout(false);
            this.pShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNr)).EndInit();
            this.pNew.ResumeLayout(false);
            this.pNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNyNr)).EndInit();
            this.m1.ResumeLayout(false);
            this.m1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel pSok;
        private System.Windows.Forms.Panel pShow;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.CheckBox starCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbENavn;
        private System.Windows.Forms.TextBox tbFNavn;
        private System.Windows.Forms.DataGridView sokList;
        private System.Windows.Forms.Button btSok;
        private System.Windows.Forms.TextBox tbSok;
        private System.Windows.Forms.Panel pNew;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox checkSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNyAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNyENavn;
        private System.Windows.Forms.TextBox tbNyFNavn;
        private System.Windows.Forms.MenuStrip m1;
        private System.Windows.Forms.ToolStripMenuItem søkTM;
        private System.Windows.Forms.ToolStripMenuItem newOpp;
        private System.Windows.Forms.ToolStripMenuItem chOpp;
        private System.Windows.Forms.NumericUpDown numNr;
        private System.Windows.Forms.NumericUpDown numNyNr;
        private System.Windows.Forms.Button btAvbryt;
        private System.Windows.Forms.DataGridViewTextBoxColumn inx;
        private System.Windows.Forms.DataGridViewTextBoxColumn navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.Button btCans;
        private System.Windows.Forms.Label labPlass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem endreOppføringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slettOppføringToolStripMenuItem;
    }
}

