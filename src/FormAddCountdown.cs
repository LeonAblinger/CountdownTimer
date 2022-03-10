/****************************************************************************************************************************
Project:    CountdownTimer
File:       FormAddCountdown.cs
Author:     Leon Ablinger / AblL
Version:    1.0.0.2
Created:    08/03/2022
Updated:    10/03/2022

Copyright (c) 2022 - Leon Ablinger / AblL
****************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class FormAddCountdown : Form
    {
        public event EventHandler CountdownAdded;

        public FormAddCountdown()
        {
            InitializeComponent();
            dateTimePicker.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
        }

        private void UI_Button_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();

            if (UI_TextBox_Name.Text == "") return;

            CountdownAdded?.Invoke(this, EventArgs.Empty);
        }

        public Countdown Get()
        {
            String name = UI_TextBox_Name.Text;
            if (UI_TextBox_Name.Text == "") return null;
            DateTime dt = dateTimePicker.Value;
            return new Countdown(name, dt);
        }
    }
}
