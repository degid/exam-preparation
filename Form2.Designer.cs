namespace WindowsFormsApp1
{
    partial class FillMatrix
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.trackBar_Start = new System.Windows.Forms.TrackBar();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.trackBar_End = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_End)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "от";
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(46, 10);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(100, 20);
            this.textBox_start.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "до";
            // 
            // textBox_end
            // 
            this.textBox_end.Location = new System.Drawing.Point(207, 10);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_end.TabIndex = 3;
            // 
            // trackBar_Start
            // 
            this.trackBar_Start.Location = new System.Drawing.Point(46, 55);
            this.trackBar_Start.Maximum = 20;
            this.trackBar_Start.Minimum = -20;
            this.trackBar_Start.Name = "trackBar_Start";
            this.trackBar_Start.Size = new System.Drawing.Size(100, 45);
            this.trackBar_Start.TabIndex = 4;
            this.trackBar_Start.Scroll += new System.EventHandler(this.trackBar_Start_Scroll);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(246, 265);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(165, 265);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // trackBar_End
            // 
            this.trackBar_End.Location = new System.Drawing.Point(207, 54);
            this.trackBar_End.Maximum = 20;
            this.trackBar_End.Minimum = -20;
            this.trackBar_End.Name = "trackBar_End";
            this.trackBar_End.Size = new System.Drawing.Size(104, 45);
            this.trackBar_End.TabIndex = 7;
            this.trackBar_End.Scroll += new System.EventHandler(this.trackBar_End_Scroll);
            // 
            // FillMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 300);
            this.Controls.Add(this.trackBar_End);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.trackBar_Start);
            this.Controls.Add(this.textBox_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_start);
            this.Controls.Add(this.label1);
            this.Name = "FillMatrix";
            this.Text = "Параметры матрицы";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_End)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_start;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_end;
        private System.Windows.Forms.TrackBar trackBar_Start;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TrackBar trackBar_End;
    }
}