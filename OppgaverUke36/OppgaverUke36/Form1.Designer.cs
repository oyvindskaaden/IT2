namespace OppgaverUke36
{
    partial class oppgaver_uke36
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btTog = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btNytt = new System.Windows.Forms.Button();
            this.gjettRes = new System.Windows.Forms.Label();
            this.antForsok = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btGjett = new System.Windows.Forms.Button();
            this.gjettInn = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.parOutbx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPar = new System.Windows.Forms.Button();
            this.parOdd = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.convOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btConv = new System.Windows.Forms.Button();
            this.convInn = new System.Windows.Forms.TextBox();
            this.nyttLabel = new System.Windows.Forms.Label();
            this.popoKommer = new System.Windows.Forms.Label();
            this.ulovlig = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ulovlig);
            this.tabPage1.Controls.Add(this.popoKommer);
            this.tabPage1.Controls.Add(this.btTog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Oppgave 1 - Toggle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btTog
            // 
            this.btTog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTog.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTog.Location = new System.Drawing.Point(3, 3);
            this.btTog.Name = "btTog";
            this.btTog.Size = new System.Drawing.Size(619, 429);
            this.btTog.TabIndex = 0;
            this.btTog.Text = "TRYKK MEG!!!!";
            this.btTog.UseVisualStyleBackColor = true;
            this.btTog.Click += new System.EventHandler(this.btTog_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nyttLabel);
            this.tabPage2.Controls.Add(this.btNytt);
            this.tabPage2.Controls.Add(this.gjettRes);
            this.tabPage2.Controls.Add(this.antForsok);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btGjett);
            this.tabPage2.Controls.Add(this.gjettInn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oppgave 2 - Gjett";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btNytt
            // 
            this.btNytt.Location = new System.Drawing.Point(407, 69);
            this.btNytt.Name = "btNytt";
            this.btNytt.Size = new System.Drawing.Size(75, 23);
            this.btNytt.TabIndex = 5;
            this.btNytt.Text = "Nytt spill";
            this.btNytt.UseVisualStyleBackColor = true;
            this.btNytt.Click += new System.EventHandler(this.btNytt_Click);
            // 
            // gjettRes
            // 
            this.gjettRes.AutoSize = true;
            this.gjettRes.Location = new System.Drawing.Point(12, 139);
            this.gjettRes.Name = "gjettRes";
            this.gjettRes.Size = new System.Drawing.Size(0, 13);
            this.gjettRes.TabIndex = 4;
            // 
            // antForsok
            // 
            this.antForsok.AutoSize = true;
            this.antForsok.Location = new System.Drawing.Point(12, 108);
            this.antForsok.Name = "antForsok";
            this.antForsok.Size = new System.Drawing.Size(96, 13);
            this.antForsok.TabIndex = 3;
            this.antForsok.Text = "Antall forsøk igjen: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Skriv inn ett tall for å gjette hva maskinen har valgt";
            // 
            // btGjett
            // 
            this.btGjett.Enabled = false;
            this.btGjett.Location = new System.Drawing.Point(326, 70);
            this.btGjett.Name = "btGjett";
            this.btGjett.Size = new System.Drawing.Size(75, 23);
            this.btGjett.TabIndex = 1;
            this.btGjett.Text = "Gjett";
            this.btGjett.UseVisualStyleBackColor = true;
            this.btGjett.Click += new System.EventHandler(this.btGjett_Click);
            // 
            // gjettInn
            // 
            this.gjettInn.Enabled = false;
            this.gjettInn.Location = new System.Drawing.Point(8, 72);
            this.gjettInn.Name = "gjettInn";
            this.gjettInn.Size = new System.Drawing.Size(312, 20);
            this.gjettInn.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.parOutbx);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btPar);
            this.tabPage3.Controls.Add(this.parOdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(625, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Oppgave 3 - Partall?";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // parOutbx
            // 
            this.parOutbx.AutoSize = true;
            this.parOutbx.Location = new System.Drawing.Point(11, 115);
            this.parOutbx.Name = "parOutbx";
            this.parOutbx.Size = new System.Drawing.Size(0, 13);
            this.parOutbx.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resultat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Skriv inn et tall for å sjekke om det er et partall eller oddetall";
            // 
            // btPar
            // 
            this.btPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPar.Location = new System.Drawing.Point(454, 41);
            this.btPar.Name = "btPar";
            this.btPar.Size = new System.Drawing.Size(75, 23);
            this.btPar.TabIndex = 1;
            this.btPar.Text = "Sjekk";
            this.btPar.UseVisualStyleBackColor = true;
            this.btPar.Click += new System.EventHandler(this.btPar_Click);
            // 
            // parOdd
            // 
            this.parOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parOdd.Location = new System.Drawing.Point(6, 43);
            this.parOdd.Name = "parOdd";
            this.parOdd.Size = new System.Drawing.Size(432, 20);
            this.parOdd.TabIndex = 0;
            this.parOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.parOdd.WordWrap = false;
            this.parOdd.TextChanged += new System.EventHandler(this.parOdd_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.convOut);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btConv);
            this.tabPage4.Controls.Add(this.convInn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(625, 435);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Oppgave 4 - Converter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // convOut
            // 
            this.convOut.Location = new System.Drawing.Point(8, 132);
            this.convOut.Name = "convOut";
            this.convOut.ReadOnly = true;
            this.convOut.Size = new System.Drawing.Size(232, 20);
            this.convOut.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skrevet om til timer:minutter:sekunder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skriv inn sekunder";
            // 
            // btConv
            // 
            this.btConv.Location = new System.Drawing.Point(246, 34);
            this.btConv.Name = "btConv";
            this.btConv.Size = new System.Drawing.Size(75, 23);
            this.btConv.TabIndex = 1;
            this.btConv.Text = "Konverter";
            this.btConv.UseVisualStyleBackColor = true;
            this.btConv.Click += new System.EventHandler(this.btConv_Click);
            // 
            // convInn
            // 
            this.convInn.Location = new System.Drawing.Point(8, 36);
            this.convInn.Name = "convInn";
            this.convInn.Size = new System.Drawing.Size(232, 20);
            this.convInn.TabIndex = 0;
            // 
            // nyttLabel
            // 
            this.nyttLabel.AutoSize = true;
            this.nyttLabel.Location = new System.Drawing.Point(326, 42);
            this.nyttLabel.Name = "nyttLabel";
            this.nyttLabel.Size = new System.Drawing.Size(129, 13);
            this.nyttLabel.TabIndex = 6;
            this.nyttLabel.Text = "Trykk Nytt spill for å starte";
            // 
            // popoKommer
            // 
            this.popoKommer.AutoSize = true;
            this.popoKommer.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popoKommer.Location = new System.Drawing.Point(364, 56);
            this.popoKommer.Name = "popoKommer";
            this.popoKommer.Size = new System.Drawing.Size(0, 40);
            this.popoKommer.TabIndex = 1;
            // 
            // ulovlig
            // 
            this.ulovlig.AutoSize = true;
            this.ulovlig.Location = new System.Drawing.Point(254, 366);
            this.ulovlig.Name = "ulovlig";
            this.ulovlig.Size = new System.Drawing.Size(0, 13);
            this.ulovlig.TabIndex = 2;
            this.ulovlig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelClick);
            // 
            // oppgaver_uke36
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "oppgaver_uke36";
            this.Text = "Oppgaver Uke 36";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btTog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox parOdd;
        private System.Windows.Forms.Button btPar;
        private System.Windows.Forms.TextBox convOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConv;
        private System.Windows.Forms.TextBox convInn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label parOutbx;
        private System.Windows.Forms.Label gjettRes;
        private System.Windows.Forms.Label antForsok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btGjett;
        private System.Windows.Forms.TextBox gjettInn;
        private System.Windows.Forms.Button btNytt;
        private System.Windows.Forms.Label nyttLabel;
        private System.Windows.Forms.Label popoKommer;
        private System.Windows.Forms.Label ulovlig;
    }
}

