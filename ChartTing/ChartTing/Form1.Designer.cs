namespace ChartTing
{
    partial class karakterviser
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartKarakterer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkData = new System.Windows.Forms.CheckedListBox();
            this.checkCheks = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartKarakterer)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKarakterer
            // 
            chartArea1.Name = "ChartArea1";
            this.chartKarakterer.ChartAreas.Add(chartArea1);
            this.chartKarakterer.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartKarakterer.Legends.Add(legend1);
            this.chartKarakterer.Location = new System.Drawing.Point(0, 0);
            this.chartKarakterer.Name = "chartKarakterer";
            this.chartKarakterer.Size = new System.Drawing.Size(782, 459);
            this.chartKarakterer.TabIndex = 0;
            this.chartKarakterer.Text = "Karakterviser";
            // 
            // checkData
            // 
            this.checkData.CheckOnClick = true;
            this.checkData.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkData.FormattingEnabled = true;
            this.checkData.Location = new System.Drawing.Point(565, 0);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(217, 459);
            this.checkData.TabIndex = 1;
            this.checkData.Click += new System.EventHandler(this.ChangeData);
            this.checkData.SelectedIndexChanged += new System.EventHandler(this.ChangeData);
            this.checkData.SelectedValueChanged += new System.EventHandler(this.ChangeData);
            this.checkData.EnabledChanged += new System.EventHandler(this.ChangeData);
            this.checkData.Validated += new System.EventHandler(this.ChangeData);
            // 
            // checkCheks
            // 
            this.checkCheks.AutoSize = true;
            this.checkCheks.Checked = true;
            this.checkCheks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCheks.Location = new System.Drawing.Point(12, 0);
            this.checkCheks.Name = "checkCheks";
            this.checkCheks.Size = new System.Drawing.Size(78, 17);
            this.checkCheks.TabIndex = 2;
            this.checkCheks.Text = "Datavelger";
            this.checkCheks.UseVisualStyleBackColor = true;
            this.checkCheks.CheckedChanged += new System.EventHandler(this.ShowList);
            // 
            // karakterviser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 459);
            this.Controls.Add(this.checkCheks);
            this.Controls.Add(this.checkData);
            this.Controls.Add(this.chartKarakterer);
            this.Name = "karakterviser";
            this.Text = "Karakterviser";
            this.Load += new System.EventHandler(this.karakterviser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKarakterer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKarakterer;
        private System.Windows.Forms.CheckedListBox checkData;
        private System.Windows.Forms.CheckBox checkCheks;
    }
}

