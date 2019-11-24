namespace DBScan
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.chooseFile = new System.Windows.Forms.Button();
            this.algorithm = new System.Windows.Forms.Button();
            this.visualization = new System.Windows.Forms.Button();
            this.selectionPanelpic = new System.Windows.Forms.PictureBox();
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.selectionPanelpic)).BeginInit();
            this.selectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.chooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.chooseFile.FlatAppearance.BorderSize = 0;
            this.chooseFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.chooseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.chooseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.chooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFile.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chooseFile.Location = new System.Drawing.Point(607, 82);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(281, 91);
            this.chooseFile.TabIndex = 2;
            this.chooseFile.Text = "Choose File";
            this.chooseFile.UseVisualStyleBackColor = false;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // algorithm
            // 
            this.algorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.algorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.algorithm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.algorithm.FlatAppearance.BorderSize = 0;
            this.algorithm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.algorithm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.algorithm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.algorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algorithm.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.algorithm.Location = new System.Drawing.Point(645, 220);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(281, 91);
            this.algorithm.TabIndex = 3;
            this.algorithm.Text = "Algorithm";
            this.algorithm.UseVisualStyleBackColor = false;
            this.algorithm.Click += new System.EventHandler(this.algorithm_Click);
            // 
            // visualization
            // 
            this.visualization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.visualization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualization.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.visualization.FlatAppearance.BorderSize = 0;
            this.visualization.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.visualization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.visualization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.visualization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualization.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.visualization.Location = new System.Drawing.Point(607, 376);
            this.visualization.Name = "visualization";
            this.visualization.Size = new System.Drawing.Size(281, 91);
            this.visualization.TabIndex = 4;
            this.visualization.Text = "Visualize";
            this.visualization.UseVisualStyleBackColor = false;
            this.visualization.Click += new System.EventHandler(this.visualization_Click);
            // 
            // selectionPanelpic
            // 
            this.selectionPanelpic.Image = ((System.Drawing.Image)(resources.GetObject("selectionPanelpic.Image")));
            this.selectionPanelpic.Location = new System.Drawing.Point(0, 23);
            this.selectionPanelpic.Name = "selectionPanelpic";
            this.selectionPanelpic.Size = new System.Drawing.Size(47, 48);
            this.selectionPanelpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectionPanelpic.TabIndex = 0;
            this.selectionPanelpic.TabStop = false;
            // 
            // selectionPanel
            // 
            this.selectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.selectionPanel.Controls.Add(this.selectionPanelpic);
            this.selectionPanel.Location = new System.Drawing.Point(554, 82);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(47, 91);
            this.selectionPanel.TabIndex = 5;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(875, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(51, 39);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 554);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.selectionPanel);
            this.Controls.Add(this.visualization);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.chooseFile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(938, 554);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.selectionPanelpic)).EndInit();
            this.selectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Button algorithm;
        private System.Windows.Forms.Button visualization;
        private System.Windows.Forms.PictureBox selectionPanelpic;
        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}