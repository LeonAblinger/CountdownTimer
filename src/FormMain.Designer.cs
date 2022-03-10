namespace CountdownTimer
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_Label_Countdown = new System.Windows.Forms.Label();
            this.UI_ComboBox_CountdownChooser = new System.Windows.Forms.ComboBox();
            this.UI_Button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Label_Countdown
            // 
            this.UI_Label_Countdown.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Label_Countdown.Location = new System.Drawing.Point(11, 8);
            this.UI_Label_Countdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Label_Countdown.Name = "UI_Label_Countdown";
            this.UI_Label_Countdown.Size = new System.Drawing.Size(338, 41);
            this.UI_Label_Countdown.TabIndex = 0;
            this.UI_Label_Countdown.Text = "CountdownTimer";
            this.UI_Label_Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_ComboBox_CountdownChooser
            // 
            this.UI_ComboBox_CountdownChooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UI_ComboBox_CountdownChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ComboBox_CountdownChooser.Location = new System.Drawing.Point(197, 63);
            this.UI_ComboBox_CountdownChooser.MaxDropDownItems = 20;
            this.UI_ComboBox_CountdownChooser.Name = "UI_ComboBox_CountdownChooser";
            this.UI_ComboBox_CountdownChooser.Size = new System.Drawing.Size(121, 24);
            this.UI_ComboBox_CountdownChooser.TabIndex = 1;
            // 
            // UI_Button_Add
            // 
            this.UI_Button_Add.Location = new System.Drawing.Point(324, 63);
            this.UI_Button_Add.Name = "UI_Button_Add";
            this.UI_Button_Add.Size = new System.Drawing.Size(25, 25);
            this.UI_Button_Add.TabIndex = 2;
            this.UI_Button_Add.Text = "+";
            this.UI_Button_Add.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 96);
            this.Controls.Add(this.UI_Button_Add);
            this.Controls.Add(this.UI_ComboBox_CountdownChooser);
            this.Controls.Add(this.UI_Label_Countdown);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(380, 135);
            this.MinimumSize = new System.Drawing.Size(380, 135);
            this.Name = "FormMain";
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.FormMain_Init);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_Label_Countdown;
        private System.Windows.Forms.ComboBox UI_ComboBox_CountdownChooser;
        private System.Windows.Forms.Button UI_Button_Add;
    }
}

