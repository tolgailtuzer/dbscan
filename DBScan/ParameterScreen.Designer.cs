namespace DBScan
{
    partial class ParameterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParameterScreen));
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createLog = new System.Windows.Forms.CheckBox();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.minPts = new System.Windows.Forms.TextBox();
            this.startAlgorithm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(227, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 46);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Epsilon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "minPts";
            // 
            // createLog
            // 
            this.createLog.AutoSize = true;
            this.createLog.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.createLog.Location = new System.Drawing.Point(83, 178);
            this.createLog.Name = "createLog";
            this.createLog.Size = new System.Drawing.Size(128, 28);
            this.createLog.TabIndex = 3;
            this.createLog.Text = "Create Log";
            this.createLog.UseVisualStyleBackColor = true;
            // 
            // epsilon
            // 
            this.epsilon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.epsilon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epsilon.ForeColor = System.Drawing.Color.White;
            this.epsilon.Location = new System.Drawing.Point(152, 67);
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(100, 20);
            this.epsilon.TabIndex = 4;
            // 
            // minPts
            // 
            this.minPts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.minPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minPts.ForeColor = System.Drawing.Color.White;
            this.minPts.Location = new System.Drawing.Point(152, 125);
            this.minPts.Name = "minPts";
            this.minPts.Size = new System.Drawing.Size(100, 20);
            this.minPts.TabIndex = 5;
            // 
            // startAlgorithm
            // 
            this.startAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.startAlgorithm.FlatAppearance.BorderSize = 0;
            this.startAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startAlgorithm.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.startAlgorithm.Location = new System.Drawing.Point(38, 241);
            this.startAlgorithm.Name = "startAlgorithm";
            this.startAlgorithm.Size = new System.Drawing.Size(214, 42);
            this.startAlgorithm.TabIndex = 15;
            this.startAlgorithm.Text = "Start Algorithm";
            this.startAlgorithm.UseVisualStyleBackColor = false;
            this.startAlgorithm.Click += new System.EventHandler(this.startAlgorithm_Click);
            // 
            // ParameterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(286, 315);
            this.Controls.Add(this.startAlgorithm);
            this.Controls.Add(this.minPts);
            this.Controls.Add(this.epsilon);
            this.Controls.Add(this.createLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 315);
            this.Name = "ParameterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParameterScreen";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox createLog;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.TextBox minPts;
        private System.Windows.Forms.Button startAlgorithm;
    }
}