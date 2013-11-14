namespace ATF
{
    partial class Form_Add_TestCase
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
            this.label_TestPlan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TestCaseName = new System.Windows.Forms.TextBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Plan that case will be added to:";
            // 
            // label_TestPlan
            // 
            this.label_TestPlan.AutoSize = true;
            this.label_TestPlan.Location = new System.Drawing.Point(197, 9);
            this.label_TestPlan.Name = "label_TestPlan";
            this.label_TestPlan.Size = new System.Drawing.Size(64, 13);
            this.label_TestPlan.TabIndex = 1;
            this.label_TestPlan.Text = "<Test Plan>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name of new Test Case";
            // 
            // textBox_TestCaseName
            // 
            this.textBox_TestCaseName.Location = new System.Drawing.Point(15, 51);
            this.textBox_TestCaseName.Name = "textBox_TestCaseName";
            this.textBox_TestCaseName.Size = new System.Drawing.Size(265, 20);
            this.textBox_TestCaseName.TabIndex = 3;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(205, 77);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(124, 77);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_Add_TestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 115);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.textBox_TestCaseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_TestPlan);
            this.Controls.Add(this.label1);
            this.Name = "Form_Add_TestCase";
            this.Text = "Add Test Case";
            this.Load += new System.EventHandler(this.Form_Add_TestCase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TestPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TestCaseName;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Add;
    }
}