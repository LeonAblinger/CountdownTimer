namespace CountdownTimer
{
    partial class FormAddCountdown
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
            this.UI_TextBox_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UI_Label_Text_Name = new System.Windows.Forms.Label();
            this.UI_Label_Text_Date = new System.Windows.Forms.Label();
            this.UI_Button_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_TextBox_Name
            // 
            this.UI_TextBox_Name.Location = new System.Drawing.Point(62, 12);
            this.UI_TextBox_Name.Name = "UI_TextBox_Name";
            this.UI_TextBox_Name.Size = new System.Drawing.Size(200, 20);
            this.UI_TextBox_Name.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(62, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // UI_Label_Text_Name
            // 
            this.UI_Label_Text_Name.AutoSize = true;
            this.UI_Label_Text_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Label_Text_Name.Location = new System.Drawing.Point(12, 13);
            this.UI_Label_Text_Name.Name = "UI_Label_Text_Name";
            this.UI_Label_Text_Name.Size = new System.Drawing.Size(44, 15);
            this.UI_Label_Text_Name.TabIndex = 2;
            this.UI_Label_Text_Name.Text = "Name:";
            // 
            // UI_Label_Text_Date
            // 
            this.UI_Label_Text_Date.AutoSize = true;
            this.UI_Label_Text_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Label_Text_Date.Location = new System.Drawing.Point(20, 38);
            this.UI_Label_Text_Date.Name = "UI_Label_Text_Date";
            this.UI_Label_Text_Date.Size = new System.Drawing.Size(36, 15);
            this.UI_Label_Text_Date.TabIndex = 3;
            this.UI_Label_Text_Date.Text = "Date:";
            // 
            // UI_Button_Confirm
            // 
            this.UI_Button_Confirm.Location = new System.Drawing.Point(187, 64);
            this.UI_Button_Confirm.Name = "UI_Button_Confirm";
            this.UI_Button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Confirm.TabIndex = 4;
            this.UI_Button_Confirm.Text = "Confirm";
            this.UI_Button_Confirm.UseVisualStyleBackColor = true;
            this.UI_Button_Confirm.Click += new System.EventHandler(this.UI_Button_Confirm_Click);
            // 
            // FormAddCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 95);
            this.Controls.Add(this.UI_Button_Confirm);
            this.Controls.Add(this.UI_Label_Text_Date);
            this.Controls.Add(this.UI_Label_Text_Name);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.UI_TextBox_Name);
            this.Name = "FormAddCountdown";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_TextBox_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label UI_Label_Text_Name;
        private System.Windows.Forms.Label UI_Label_Text_Date;
        private System.Windows.Forms.Button UI_Button_Confirm;
    }
}