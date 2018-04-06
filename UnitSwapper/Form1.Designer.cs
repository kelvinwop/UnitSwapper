namespace UnitSwapper
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
            this.txt_InputValue = new System.Windows.Forms.TextBox();
            this.txt_InputUnits = new System.Windows.Forms.TextBox();
            this.txt_OutputValue = new System.Windows.Forms.TextBox();
            this.txt_OutputUnits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_InputValue
            // 
            this.txt_InputValue.Location = new System.Drawing.Point(60, 121);
            this.txt_InputValue.Name = "txt_InputValue";
            this.txt_InputValue.Size = new System.Drawing.Size(121, 20);
            this.txt_InputValue.TabIndex = 0;
            // 
            // txt_InputUnits
            // 
            this.txt_InputUnits.Location = new System.Drawing.Point(230, 121);
            this.txt_InputUnits.Name = "txt_InputUnits";
            this.txt_InputUnits.Size = new System.Drawing.Size(121, 20);
            this.txt_InputUnits.TabIndex = 1;
            // 
            // txt_OutputValue
            // 
            this.txt_OutputValue.Location = new System.Drawing.Point(505, 121);
            this.txt_OutputValue.Name = "txt_OutputValue";
            this.txt_OutputValue.Size = new System.Drawing.Size(210, 20);
            this.txt_OutputValue.TabIndex = 2;
            // 
            // txt_OutputUnits
            // 
            this.txt_OutputUnits.Location = new System.Drawing.Point(755, 121);
            this.txt_OutputUnits.Name = "txt_OutputUnits";
            this.txt_OutputUnits.Size = new System.Drawing.Size(121, 20);
            this.txt_OutputUnits.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Value*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Units*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output Units*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 52);
            this.label5.TabIndex = 8;
            this.label5.Text = "Make sure units are space delimited\r\n\r\nEg:\r\nkg m s^-3";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(367, 186);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 9;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(471, 186);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 270);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_OutputUnits);
            this.Controls.Add(this.txt_OutputValue);
            this.Controls.Add(this.txt_InputUnits);
            this.Controls.Add(this.txt_InputValue);
            this.Name = "Form1";
            this.Text = "Kelvin\'s Awesome Unit Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_InputValue;
        private System.Windows.Forms.TextBox txt_InputUnits;
        private System.Windows.Forms.TextBox txt_OutputValue;
        private System.Windows.Forms.TextBox txt_OutputUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
    }
}

