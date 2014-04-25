using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTUHFBT_XP
{
    //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    //  class config form
    //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    public partial class ConfigForm : Form
    {

        // Tx dB Text
        internal string[] dB = { "MAX", "-1dB", "-2dB", "-3dB", "-4dB", "-5dB", "-6dB", "-7dB", "-8dB", "-9dB" };

        // Tx duty text
        internal string[] duty = { "90%", "80%", "60%", "41%", "20%" };


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Config form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public ConfigForm()
        {
            InitializeComponent();

            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_CONFIG;

            InitForm();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  InitForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void InitForm()
        {
            textBox_scantime.Text = MainForm.rfidhost_param.timeout.ToString();

            checkBox_continue.Checked = MainForm.rfidhost_param.continuous;

            comboBox_session.SelectedIndex = MainForm.rfidhost_param.session;

            comboBox_target.SelectedIndex = MainForm.rfidhost_param.target;

            comboBox_q.SelectedIndex = MainForm.rfidhost_param.q;

            trackBar_txpwr.Value = MainForm.rfidhost_param.txpower * 10;
            label_txpwr.Text = dB[MainForm.rfidhost_param.txpower];

            trackBar_duty.Value = MainForm.rfidhost_param.tx_duty * 10;
            label_duty.Text = duty[MainForm.rfidhost_param.tx_duty];

            if (MainForm.rfidhost_param.link_state)
            {
                string Firmware_ver = new string(new char[50]);
                MainForm.RFIDAPI.UHFAPI_GetFirmwareVersion(Firmware_ver);
                textBox_firmwarever.Text = Firmware_ver;
            }
            else
                textBox_firmwarever.Text = "UNKNOWN";

            string App_ver = System.Windows.Forms.Application.ProductVersion;
            textBox_appversion.Text = App_ver ;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  set tx power
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void trackBar_txpwr_ValueChanged(object sender, EventArgs e)
        {
            int level = trackBar_txpwr.Value;
            MainForm.rfidhost_param.txpower = level / 10;

            if (MainForm.RFIDAPI.UHFAPI_SET_PowerControl((uint)(level * 4)))
            {
                label_txpwr.Text = dB[MainForm.rfidhost_param.txpower];
            }
            else
            {
                label_txpwr.Text = "ERROR";
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  set tx duty power
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void trackBar_duty_ValueChanged(object sender, EventArgs e)
        {
            int level = trackBar_duty.Value;
            MainForm.rfidhost_param.tx_duty = level / 10;
            label_duty.Text = duty[MainForm.rfidhost_param.tx_duty];            
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Form closing
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_MENU;

            MainForm.rfidhost_param.continuous = checkBox_continue.Checked;

            MainForm.rfidhost_param.skip_same = checkBox_skipsame.Checked;

            MainForm.rfidhost_param.timeout = (UInt32)int.Parse(textBox_scantime.Text);

            MainForm.rfidhost_param.session = comboBox_session.SelectedIndex;

            MainForm.rfidhost_param.target = comboBox_target.SelectedIndex;

            MainForm.rfidhost_param.q = comboBox_q.SelectedIndex;

            int tx_level = trackBar_txpwr.Value;
            MainForm.rfidhost_param.txpower = tx_level / 10;

            int tx_duty_level = trackBar_duty.Value;
            MainForm.rfidhost_param.tx_duty = tx_duty_level / 10;

            switch (MainForm.rfidhost_param.tx_duty)
            {
                case 0: // 90%
                    {
                        MainForm.rfidhost_param.tx_on = 190;
                        MainForm.rfidhost_param.tx_off = 10;
                    }
                    break;

                case 1: // 80%
                    {
                        MainForm.rfidhost_param.tx_on = 180;
                        MainForm.rfidhost_param.tx_off = 20;
                    }
                    break;

                case 2: // 60%
                    {
                        MainForm.rfidhost_param.tx_on = 120;
                        MainForm.rfidhost_param.tx_off = 80;
                    }
                    break;

                case 3: // 41%
                    {
                        MainForm.rfidhost_param.tx_on = 70;
                        MainForm.rfidhost_param.tx_off = 100;
                    }
                    break;

                case 4: // 20%
                    {
                        MainForm.rfidhost_param.tx_on = 40;
                        MainForm.rfidhost_param.tx_off = 160;
                    }
                    break;
            }            
        }
    }
}