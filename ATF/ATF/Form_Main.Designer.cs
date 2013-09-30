namespace ATF
{
    partial class Form_Main
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
            this.listView_TestCaseList = new System.Windows.Forms.ListView();
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TestCaseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_TestPlan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_RunAll = new System.Windows.Forms.Button();
            this.button_RunSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_TestCaseList
            // 
            this.listView_TestCaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ID,
            this.columnHeader_TestCaseName,
            this.columnHeader_Result});
            this.listView_TestCaseList.GridLines = true;
            this.listView_TestCaseList.Location = new System.Drawing.Point(12, 65);
            this.listView_TestCaseList.MultiSelect = false;
            this.listView_TestCaseList.Name = "listView_TestCaseList";
            this.listView_TestCaseList.Size = new System.Drawing.Size(268, 175);
            this.listView_TestCaseList.TabIndex = 0;
            this.listView_TestCaseList.UseCompatibleStateImageBehavior = false;
            this.listView_TestCaseList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.DisplayIndex = 1;
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 0;
            // 
            // columnHeader_TestCaseName
            // 
            this.columnHeader_TestCaseName.DisplayIndex = 0;
            this.columnHeader_TestCaseName.Text = "Test Case";
            this.columnHeader_TestCaseName.Width = 199;
            // 
            // columnHeader_Result
            // 
            this.columnHeader_Result.Text = "Pass / Fail";
            this.columnHeader_Result.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Plan";
            // 
            // comboBox_TestPlan
            // 
            this.comboBox_TestPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TestPlan.FormattingEnabled = true;
            this.comboBox_TestPlan.Location = new System.Drawing.Point(12, 25);
            this.comboBox_TestPlan.Name = "comboBox_TestPlan";
            this.comboBox_TestPlan.Size = new System.Drawing.Size(268, 21);
            this.comboBox_TestPlan.TabIndex = 2;
            this.comboBox_TestPlan.SelectedIndexChanged += new System.EventHandler(this.comboBox_TestPlan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Case List";
            // 
            // button_RunAll
            // 
            this.button_RunAll.Location = new System.Drawing.Point(205, 255);
            this.button_RunAll.Name = "button_RunAll";
            this.button_RunAll.Size = new System.Drawing.Size(75, 23);
            this.button_RunAll.TabIndex = 4;
            this.button_RunAll.Text = "Run All";
            this.button_RunAll.UseVisualStyleBackColor = true;
            // 
            // button_RunSelected
            // 
            this.button_RunSelected.Location = new System.Drawing.Point(117, 255);
            this.button_RunSelected.Name = "button_RunSelected";
            this.button_RunSelected.Size = new System.Drawing.Size(82, 23);
            this.button_RunSelected.TabIndex = 5;
            this.button_RunSelected.Text = "Run Selected";
            this.button_RunSelected.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 290);
            this.Controls.Add(this.button_RunSelected);
            this.Controls.Add(this.button_RunAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_TestPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_TestCaseList);
            this.Name = "Form_Main";
            this.Text = "ATF - Automated Test Framework";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_TestCaseList;
        private System.Windows.Forms.ColumnHeader columnHeader_TestCaseName;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_TestPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_RunAll;
        private System.Windows.Forms.Button button_RunSelected;
    }
}

