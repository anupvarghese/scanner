using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


//┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
//  DOTUHFBT_XP namespace
//┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
namespace DOTUHFBT_XP
{

    //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    //  class ReadWriteForm form
    //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    public partial class ReadWriteForm : Form
    {

        // pc_epc,acs_pwd,kill_pwd,tid,reserved,uii,tid,user
        internal byte[] bankIDlist =      { 0, 1, 2, 3 };
        internal string[] defaultoffset = { "00", "02", "00", "00" };
        internal string[] defaultlength = { "2", "6", "2", "2" };
        internal string[] dB = { "MAX", "-1dB", "-2dB", "-3dB", "-4dB", "-5dB", "-6dB", "-7dB", "-8dB", "-9dB" };

        internal string lasterrormessage;

        // Mask Dialog
        public static MaskForm MaskForm;

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  ReadWriteForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public ReadWriteForm()
        {
            InitializeComponent();

            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_READWRITE;

            pictureBox_detect.Image = Properties.Resources.image4;
            pictureBox_status.Image = Properties.Resources.image4;

            // Check the link status..
            if (MainForm.RFIDAPI.UHFAPI_IsOpen())
            {
                pictureBox_link.Image = Properties.Resources.image2;
                MainForm.rfidhost_param.link_state = true;
            }
            else
            {
                pictureBox_link.Image = Properties.Resources.Image1;
                MainForm.rfidhost_param.link_state = false;
            }

            InitForm();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  InitForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void InitForm()
        {
            radioButton_read.Checked = true;
            radioButton_write.Checked = false;

            checkBox_continue.Checked = MainForm.rfidhost_param.continuous;
            checkBox_mask.Checked = MainForm.rfidhost_param.bldMask;

            comboBox_bank.SelectedIndex = MainForm.rfidhost_param.mem_bank;

            textBox_epc.Text = "0";
            textBox_offset.Text = defaultoffset[comboBox_bank.SelectedIndex];
            textBox_length.Text = defaultlength[comboBox_bank.SelectedIndex];
            textBox_accesspassword.Text = "00000000";
            textBox_write.Text = "0";
            textBox_writecnt.Text = "0";

            trackBar_txpwr.Value = MainForm.rfidhost_param.txpower * 10;
            label_txpwr.Text = dB[MainForm.rfidhost_param.txpower];
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Access End
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void AccessEnd()
        {
            button_access.Text = "ACCESS";
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Access epc data
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void AccessEPC(string epc)
        {
            textBox_epc.Text = epc;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Access read/write data
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void AccessDATA(string data)
        {
            textBox_write.Text = data;
            pictureBox_detect.Image = Properties.Resources.image2;
            pictureBox_status.Image = Properties.Resources.image2;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Access result
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void AccessRESULT(string res)
        {
            lasterrormessage = res;                      
            pictureBox_status.Image = Properties.Resources.Image1;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  link lost process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void LinkLost()
        {
            if (button_access.Text != "NORMAL")
            {
                button_access.Text = "NORMAL";
                button_access.Enabled = true;

                MessageBox.Show("LINK LOST");
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  resume process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void PowerResume()
        {
            MessageBox.Show("Power Resume");
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  push access button
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_access_Click(object sender, EventArgs e)
        {
            if (button_access.Text.Equals("ACCESS"))
            {
                Application.DoEvents();
                MainForm.rfidhost_param.host_state = (int)MainForm.HOST_MSG.RFID_OPERATION;
                StartAccess();
            }
            else
            {
                Application.DoEvents();
                MainForm.rfidhost_param.host_state = (int)MainForm.HOST_MSG.RFID_STOP;
                StopAccess();
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  start access operation
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal void StartAccess()
        {
            byte MemBank = bankIDlist[comboBox_bank.SelectedIndex];
            UInt32 offset = Convert.ToUInt32(textBox_offset.Text);
            UInt32 length = Convert.ToUInt32(textBox_length.Text);
            UInt32 pwdACCESS;

            button_access.Text = "STOP";

            if(false == UtilClass.HEX32(out pwdACCESS, textBox_accesspassword.Text))
            {
                AccessEnd();
                MessageBox.Show("Wrong Access Password!!");
                return;
            }

            MainForm.SetupOperationParameter();

            // read access
            if (radioButton_read.Checked)
            {
                MainForm.RFIDAPI.UHFAPI_ReadTag(MemBank, offset, length, pwdACCESS, MainForm.SetControlParam, false);
            }

            // write access
            else if (radioButton_write.Checked)
            {
                ushort[] szWriteData;
                if (true == UtilClass.HEXSTR(out szWriteData, textBox_write.Text))
                {
                    MainForm.RFIDAPI.UHFAPI_WriteTag(MemBank, offset, length, ref szWriteData, pwdACCESS, MainForm.SetControlParam, false);
                }
                else
                {
                    AccessEnd();
                }
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  stop access operation
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal void StopAccess()
        {
            MainForm.RFIDAPI.UHFAPI_Stop(true);
            AccessEnd();
        }       

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  check the continue mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void checkBox_continue_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.continuous = checkBox_continue.Checked;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  check the mask
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void checkBox_mask_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.bldMask = checkBox_mask.Checked;
        }
        
        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  open mask form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_mask_Click(object sender, EventArgs e)
        {
            MaskForm = new MaskForm();
            MaskForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  select tag memory bank
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void comboBox_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.mem_bank = comboBox_bank.SelectedIndex;
            textBox_offset.Text = defaultoffset[comboBox_bank.SelectedIndex];
            textBox_length.Text = defaultlength[comboBox_bank.SelectedIndex];
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
        //  Form closing
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void ReadWriteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_MENU;
            MainForm.RFIDAPI.UHFAPI_Stop(true);
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Show error message
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void pictureBox_status_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            Application.DoEvents();

            MessageForm msgForm = new MessageForm();
            msgForm.Message = lasterrormessage;
            msgForm.Show();
            Application.DoEvents();
        }        
    }
}