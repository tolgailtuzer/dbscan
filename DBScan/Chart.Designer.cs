namespace DBScan
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.visualize = new System.Windows.Forms.Button();
            this.axis2 = new System.Windows.Forms.ComboBox();
            this.axis1 = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            legend1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 96);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(804, 579);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // visualize
            // 
            this.visualize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.visualize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualize.FlatAppearance.BorderSize = 0;
            this.visualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualize.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.visualize.Location = new System.Drawing.Point(626, 45);
            this.visualize.Name = "visualize";
            this.visualize.Size = new System.Drawing.Size(167, 32);
            this.visualize.TabIndex = 14;
            this.visualize.Text = "Visualize";
            this.visualize.UseVisualStyleBackColor = false;
            this.visualize.Click += new System.EventHandler(this.visualize_Click);
            // 
            // axis2
            // 
            this.axis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axis2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axis2.ForeColor = System.Drawing.Color.White;
            this.axis2.FormattingEnabled = true;
            this.axis2.Location = new System.Drawing.Point(313, 50);
            this.axis2.Name = "axis2";
            this.axis2.Size = new System.Drawing.Size(278, 21);
            this.axis2.TabIndex = 13;
            // 
            // axis1
            // 
            this.axis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.axis1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axis1.ForeColor = System.Drawing.Color.White;
            this.axis1.FormattingEnabled = true;
            this.axis1.Location = new System.Drawing.Point(12, 50);
            this.axis1.Name = "axis1";
            this.axis1.Size = new System.Drawing.Size(278, 21);
            this.axis1.TabIndex = 12;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(782, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(43, 39);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 16;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(825, 701);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.visualize);
            this.Controls.Add(this.axis2);
            this.Controls.Add(this.axis1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 701);
            this.Name = "Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button visualize;
        private System.Windows.Forms.ComboBox axis2;
        private System.Windows.Forms.ComboBox axis1;
        private System.Windows.Forms.PictureBox exit;
    }
}