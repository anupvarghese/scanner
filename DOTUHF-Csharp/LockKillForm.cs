using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTUHF_Csharp
{

    public partial class LockKillForm : Form
    {
        // Mask Dialog
        public static MaskForm MaskForm;

        // tx power db
        internal string[] dB = { "MAX", "-1dB", "-2dB", "-3dB", "-4dB", "-5dB", "-6dB", "-7dB", "-8dB", "-9dB" };

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  class LockKillForm form
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public LockKillForm()
        {
            InitializeComponent();

            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_LOCKKILL;

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
            radioButton_lock.Checked = true;
            radioButton_kill.Checked = false;

            checkBox_continue.Checked = MainForm.rfidhost_param.continuous;
            checkBox_mask.Checked = MainForm.rfidhost_param.bldMask;

            textBox_killpassword.Text = "00000000";
            textBox_accesspassword.Text = "00000000";

            comboBox_bank.SelectedIndex = 0;
            comboBox_lockop.SelectedIndex = 0;

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
            //textBox_write.Text = data;
            pictureBox_detect.Image = Properties.Resources.image2;
            pictureBox_status.Image = Properties.Resources.image2;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  Access result
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public void AccessRESULT(string res)
        {
            //lasterrormessage = res;
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
        //  swaping function
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        public ushort SWAPLSB2(int value)
        {
            int res = (((((value) & 1) << 1) | (((value) >> 1) & 1)) & 3);
            return (ushort)res;
        }


        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  start access operation
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        internal void StartAccess()
        {
            button_access.Text = "STOP";

            MainForm.SetupOperationParameter();

            // lock operation
            if (radioButton_lock.Checked)
            {
                UInt32 pwdACCESS;
                ushort lock_enable = 0;
                ushort lock_mask = 0;

                int mark;
                int index = (int)comboBox_bank.SelectedIndex;

                if (false == UtilClass.HEX32(out pwdACCESS, textBox_accesspassword.Text))
                {
                    AccessEnd();
                    MessageBox.Show("Wrong Access Password!!");
                    return;
                }

                // set kill password field
                if (index == 0)
                {
                    mark = (int)comboBox_lockop.SelectedIndex;
                }
                else
                {
                    mark = 0;
                }

                lock_enable |= SWAPLSB2(mark > 0 ? mark - 1 : 0);
                lock_mask |= (ushort)(mark > 0 ? 3 : 0);

                lock_enable <<= 2;
                lock_mask <<= 2;

                // set access password field
                if (index == 1)
                {
                    mark = (int)comboBox_lockop.SelectedItem;
                }
                else
                {
                    mark = 0;
                }

                lock_enable |= SWAPLSB2(mark > 0 ? mark - 1 : 0);
                lock_mask |= (ushort)(mark > 0 ? 3 : 0);

                lock_enable <<= 2;
                lock_mask <<= 2;

                // set EPC memory field
                if (index == 2)
                {
                    mark = (int)comboBox_lockop.SelectedItem;
                }
                else
                {
                    mark = 0;
                }

                lock_enable |= SWAPLSB2(mark > 0 ? mark - 1 : 0);
                lock_mask |= (ushort)(mark > 0 ? 3 : 0);

                lock_enable <<= 2;
                lock_mask <<= 2;

                // TID memory field
                if (index == 3)
                {
                    mark = (int)comboBox_lockop.SelectedItem;
                }
                else
                {
                    mark = 0;
                }

                lock_enable |= SWAPLSB2(mark > 0 ? mark - 1 : 0);
                lock_mask |= (ushort)(mark > 0 ? 3 : 0);

                lock_enable <<= 2;
                lock_mask <<= 2;

                // USER memory field
                if (index == 4)
                {
                    mark = (int)comboBox_lockop.SelectedItem;
                }
                else
                {
                    mark = 0;
                }

                lock_enable |= SWAPLSB2(mark > 0 ? mark - 1 : 0);
                lock_mask |= (ushort)(mark > 0 ? 3 : 0);

                MainForm.RFIDAPI.UHFAPI_LockSetTag((UHFAPI_NET.UHFAPI_NET.typeLockMasks)lock_mask, (UHFAPI_NET.UHFAPI_NET.typeLockMasks)lock_enable, pwdACCESS, MainForm.SetControlParam, false);
            }

            else if (radioButton_kill.Checked)
            {
                UInt32 pwdACCESS;
                UInt32 pwdKILL;

                if (false == UtilClass.HEX32(out pwdACCESS, textBox_accesspassword.Text))
                {
                    AccessEnd();
                    MessageBox.Show("Wrong Access Password!!");
                    return;
                }

                if (false == UtilClass.HEX32(out pwdKILL, textBox_killpassword.Text))
                {
                    AccessEnd();
                    MessageBox.Show("Wrong Access Password!!");
                    return;
                }

                System.Windows.Forms.DialogResult rts = System.Windows.Forms.MessageBox.Show("If you click on this YES, the kill tag will run..", "Warring",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                switch (rts)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        {
                            MainForm.SetupOperationParameter();

                            MainForm.RFIDAPI.UHFAPI_KillTag(pwdKILL, pwdACCESS, MainForm.SetControlParam, false);
                        }
                        break;

                    case System.Windows.Forms.DialogResult.No:
                        {
                            AccessEnd();
                        }
                        break;
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
        //  Form closing
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void LockKillForm_Closing(object sender, CancelEventArgs e)
        {
            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_MENU;
            MainForm.RFIDAPI.UHFAPI_Stop(true);
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
        //  set continue mode function
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void checkBox_continue_CheckStateChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.continuous = checkBox_continue.Checked;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  set mask function
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void checkBox_mask_CheckStateChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.bldMask = checkBox_mask.Checked;
        }

        //旨收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        //  mask settings..
        //曲收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收收
        private void button_mask_Click(object sender, EventArgs e)
        {
            MaskForm = new MaskForm();
            MaskForm.ShowDialog();
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
    }
}