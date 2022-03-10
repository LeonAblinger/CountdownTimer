using System;
using System.Threading;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class FormMain : Form
    {
        Control control;
        DateTime[] dT_Goal = { new DateTime(2022, 4, 8), new DateTime(2022, 5, 5), new DateTime(2022, 6, 23) };
        int SelectedGoalInd = 0;

        public FormMain()
        {
            InitializeComponent();
            control = labCountdown;
        }

        private void MainApp()
        {
            try
            {
                while (true)
                {
                    UpdateCountdown(SelectedGoalInd);
                    Wait(50);
                }
            }
            catch (Exception) { }
        }

        private void UpdateCountdown(int _selectedCd)
        {
            DateTime dT_Now = DateTime.Now;
            TimeSpan tS_Diff = dT_Goal[_selectedCd] - dT_Now;
            String labText = "";

            labText += tS_Diff.Days > 0 ? tS_Diff.Days.ToString() + " Tage  " : "";
            labText += tS_Diff.Hours < 10 ? "0" + tS_Diff.Hours.ToString() + ":" : tS_Diff.Hours.ToString() + ":";
            labText += tS_Diff.Minutes < 10 ? "0" + tS_Diff.Minutes.ToString() + ":" : tS_Diff.Minutes.ToString() + ":";
            labText += tS_Diff.Seconds < 10 ? "0" + tS_Diff.Seconds.ToString() + ":" : tS_Diff.Seconds.ToString() + ".";
            labText += tS_Diff.Milliseconds < 10 ? "00" + tS_Diff.Milliseconds.ToString() : tS_Diff.Milliseconds < 100 ? "0" + tS_Diff.Milliseconds.ToString() : tS_Diff.Milliseconds.ToString();

            control.BeginInvoke((MethodInvoker)delegate ()
            {
                labCountdown.Text = labText;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread update = new Thread(MainApp);
            update.Start();
        }

        private void SetRadioButton(int _checkedRadioButton)
        {
            radioButton1.Checked = _checkedRadioButton == 1 ? true : false;
            radioButton2.Checked = _checkedRadioButton == 2 ? true : false;
            radioButton3.Checked = _checkedRadioButton == 3 ? true : false;

            SelectedGoalInd = _checkedRadioButton - 1;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            SetRadioButton(1);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            SetRadioButton(2);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            SetRadioButton(3);
        }
    }
}
