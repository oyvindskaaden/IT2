namespace LydTesting
{
    partial class Form1
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
            this.btStart1 = new System.Windows.Forms.Button();
            this.btStop1 = new System.Windows.Forms.Button();
            this.btStop2 = new System.Windows.Forms.Button();
            this.btStart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart1
            // 
            this.btStart1.Location = new System.Drawing.Point(52, 69);
            this.btStart1.Name = "btStart1";
            this.btStart1.Size = new System.Drawing.Size(75, 23);
            this.btStart1.TabIndex = 0;
            this.btStart1.Text = "Start";
            this.btStart1.UseVisualStyleBackColor = true;
            this.btStart1.Click += new System.EventHandler(this.btStart1_Click);
            // 
            // btStop1
            // 
            this.btStop1.Location = new System.Drawing.Point(52, 98);
            this.btStop1.Name = "btStop1";
            this.btStop1.Size = new System.Drawing.Size(75, 23);
            this.btStop1.TabIndex = 1;
            this.btStop1.Text = "Stop";
            this.btStop1.UseVisualStyleBackColor = true;
            this.btStop1.Click += new System.EventHandler(this.stop_Click);
            // 
            // btStop2
            // 
            this.btStop2.Location = new System.Drawing.Point(158, 98);
            this.btStop2.Name = "btStop2";
            this.btStop2.Size = new System.Drawing.Size(75, 23);
            this.btStop2.TabIndex = 3;
            this.btStop2.Text = "Stop";
            this.btStop2.UseVisualStyleBackColor = true;
            this.btStop2.Click += new System.EventHandler(this.stop_Click);
            // 
            // btStart2
            // 
            this.btStart2.Location = new System.Drawing.Point(158, 69);
            this.btStart2.Name = "btStart2";
            this.btStart2.Size = new System.Drawing.Size(75, 23);
            this.btStart2.TabIndex = 2;
            this.btStart2.Text = "Start";
            this.btStart2.UseVisualStyleBackColor = true;
            this.btStart2.Click += new System.EventHandler(this.btStart2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btStop2);
            this.Controls.Add(this.btStart2);
            this.Controls.Add(this.btStop1);
            this.Controls.Add(this.btStart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart1;
        private System.Windows.Forms.Button btStop1;
        private System.Windows.Forms.Button btStop2;
        private System.Windows.Forms.Button btStart2;
    }
}

