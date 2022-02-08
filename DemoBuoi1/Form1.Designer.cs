namespace DemoBuoi1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblSo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Exercise1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Chuong Trinh T1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Doi Chu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(16, 92);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 2;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyUp);
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.BackColor = System.Drawing.SystemColors.Control;
            this.lblSo.Location = new System.Drawing.Point(123, 98);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(13, 13);
            this.lblSo.TabIndex = 3;
            this.lblSo.Text = "0";
            this.lblSo.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Box A",
            "Box B",
            "Box C",
            "Box D"});
            this.comboBox1.Location = new System.Drawing.Point(97, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Calculator Demo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exercise1
            // 
            this.Exercise1.Location = new System.Drawing.Point(169, 132);
            this.Exercise1.Name = "Exercise1";
            this.Exercise1.Size = new System.Drawing.Size(75, 23);
            this.Exercise1.TabIndex = 6;
            this.Exercise1.Text = "Exercise 1";
            this.Exercise1.UseVisualStyleBackColor = true;
            this.Exercise1.Click += new System.EventHandler(this.Exercise1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exercise1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSo);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exercise1;
    }
}

