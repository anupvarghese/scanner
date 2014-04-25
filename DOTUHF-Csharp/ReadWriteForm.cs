using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTUHF_Csharp
{
    //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
    //  class ReadWriteForm form
    //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
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

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  ReadWriteForm form
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
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


        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  InitForm form
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
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

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Access End
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void AccessEnd()
        {
            button_access.Text = "ACCESS";
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Access epc data
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void AccessEPC(string epc)
        {
            textBox_epc.Text = epc;

            MainForm.PlaySound(MainForm.SOUND_STATE.SOUND_SUCCESS);
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Access read/write data
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void AccessDATA(string data)
        {
            textBox_write.Text = data;
            pictureBox_detect.Image = Properties.Resources.image2;
            pictureBox_status.Image = Properties.Resources.image2;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Access result
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void AccessRESULT(string res)
        {
            lasterrormessage = res;
            pictureBox_status.Image = Properties.Resources.Image1;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  link lost process function
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void LinkLost()
        {
            if (button_access.Text != "ACCESS")
            {
                button_access.Text = "ACCESS";
                button_access.Enabled = true;

                MessageBox.Show("LINK LOST");
            }
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  resume process function
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void PowerResume()
        {
            MessageBox.Show("Power Resume");
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  push access button
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
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

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  start access operation
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        internal void StartAccess()
        {
            byte MemBank = bankIDlist[comboBox_bank.SelectedIndex];
            UInt32 offset = Convert.ToUInt32(textBox_offset.Text);
            UInt32 length = Convert.ToUInt32(textBox_length.Text);
            UInt32 pwdACCESS;

            button_access.Text = "STOP";

            if (false == UtilClass.HEX32(out pwdACCESS, textBox_accesspassword.Text))
            {
                AccessEnd();
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
               /*
                if (textBox_write.Text.Length / 4 != 0 || textBox_write.Text == "0")
                {
                    AccessEnd();
                    MessageBox.Show("Wrong Write Data Length !!");
                    return;
                }
                */ 

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

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  stop access operation
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        internal void StopAccess()
        {
            MainForm.RFIDAPI.UHFAPI_Stop(true);
            AccessEnd();
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  check the continue mode
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void checkBox_continue_CheckStateChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.continuous = checkBox_continue.Checked;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  check the mask
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void checkBox_mask_CheckStateChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.bldMask = checkBox_mask.Checked;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  open mask form
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void button_mask_Click(object sender, EventArgs e)
        {
            MaskForm = new MaskForm();
            MaskForm.ShowDialog();
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  select tag memory bank
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void comboBox_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.mem_bank = comboBox_bank.SelectedIndex;
            textBox_offset.Text = defaultoffset[comboBox_bank.SelectedIndex];
            textBox_length.Text = defaultlength[comboBox_bank.SelectedIndex];
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  set tx power
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
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

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Form closing
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void ReadWriteForm_Closing(object sender, CancelEventArgs e)
        {
            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_MENU;
            MainForm.RFIDAPI.UHFAPI_Stop(true);
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Show error message
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        /*
        private void pictureBox_status_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            Application.DoEvents();

            MessageForm msgForm = new MessageForm();
            msgForm.Message = lasterrormessage;
            msgForm.Show();
            Application.DoEvents();
        }
         */ 
    }
}