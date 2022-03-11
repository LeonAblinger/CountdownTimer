/****************************************************************************************************************************
Project:    CountdownTimer
File:       FormMain.cs
Author:     Leon Ablinger / AblL
Version:    1.0.0.2
Created:    08/03/2022
Updated:    10/03/2022

Copyright (c) 2022 - Leon Ablinger / AblL
****************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class FormMain : Form
    {
        private readonly Control control;
        private readonly FormAddCountdown AddCountdownForm = new FormAddCountdown();
        private readonly ListCountdown CountdownList = new ListCountdown();
        private readonly FileHandler SettingsFile = new FileHandler();
        private DateTime dT_SelectedGoal = DateTime.Now;

        public FormMain()
        {
            InitializeComponent();
            control = UI_Label_Countdown;
        }

        private void FormMain_Init(object sender, EventArgs e)
        {
            this.UI_ComboBox_CountdownChooser.SelectedValueChanged += new EventHandler(this.UI_ComboBox_CountdownChooser_SelectedValueChanged);
            this.UI_Button_Add.Click += new EventHandler(this.UI_Button_Add_Click);
            AddCountdownForm.CountdownAdded += new EventHandler(this.CountdownAdded);

            Thread update = new Thread(FormMainApp);
            update.Start();
        }

        private void FormMainApp()
        {
            try
            {
                while (true)
                {
                    UpdateCountdown();
                    Wait(50);
                }
            }
            catch (Exception) { }
        }

        private void UpdateCountdown()
        {
            DateTime dT_Now = DateTime.Now;
            TimeSpan tS_Diff = dT_SelectedGoal - dT_Now;
            String labText = "";

            if (tS_Diff.TotalMilliseconds < 0)
            {
                labText = "CountdownTimer";
            }
            else
            {
                labText += tS_Diff.Days > 0 ? tS_Diff.Days.ToString() + " Tage  " : "";
                labText += tS_Diff.Hours < 10 ? "0" + tS_Diff.Hours.ToString() + ":" : tS_Diff.Hours.ToString() + ":";
                labText += tS_Diff.Minutes < 10 ? "0" + tS_Diff.Minutes.ToString() + ":" : tS_Diff.Minutes.ToString() + ":";
                labText += tS_Diff.Seconds < 10 ? "0" + tS_Diff.Seconds.ToString() + ":" : tS_Diff.Seconds.ToString() + ".";
                labText += tS_Diff.Milliseconds < 10 ? "00" + tS_Diff.Milliseconds.ToString() : tS_Diff.Milliseconds < 100 ? "0" + tS_Diff.Milliseconds.ToString() : tS_Diff.Milliseconds.ToString();
            }

            control.BeginInvoke((MethodInvoker)delegate ()
            {
                UI_Label_Countdown.Text = labText;
            });
        }

        public void Wait(int ms)
        {
            try
            {
                var tim_Timer = new System.Windows.Forms.Timer();
                if (ms == 0 || ms < 0) return;

                tim_Timer.Interval = ms;
                tim_Timer.Enabled = true;
                tim_Timer.Start();

                tim_Timer.Tick += (s, e) =>
                {
                    tim_Timer.Enabled = false;
                    tim_Timer.Stop();
                };

                while (tim_Timer.Enabled)
                {
                    Application.DoEvents();
                    Thread.Sleep(1);
                }
            }
            catch (Exception) { }
        }

        private void CountdownAdded(object sender, EventArgs e)
        {
            Countdown AddedCountdown = AddCountdownForm.Get();
            CountdownList.Add(AddedCountdown);
            SettingsFile.Add(AddedCountdown);
            UI_ComboBox_CountdownChooser.Items.Clear();
            UI_ComboBox_CountdownChooser.Items.AddRange(CountdownList.GetNames());
        }

        private void UI_ComboBox_CountdownChooser_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = 0;
            List<Countdown> list = CountdownList.Get();
            while (UI_ComboBox_CountdownChooser.Text != list[i].Name)
            {
                i++;
            }
            dT_SelectedGoal = list[i].DateTime;
        }

        private void UI_Button_Add_Click(object sender, EventArgs e)
        {
            AddCountdownForm.ShowDialog();
        }
    }
}
