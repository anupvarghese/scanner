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
    //  class SingleForm form
    //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    public partial class SingleForm : Form
    {
        // tag register count
        public int tagCount = 0;

        // Mask Dialog
        public static MaskForm MaskForm;

        // Listview
        ListView lst = new ListView();

        // Tx dB Text
        internal string[] dB = { "MAX", "-1dB", "-2dB", "-3dB", "-4dB", "-5dB", "-6dB", "-7dB", "-8dB", "-9dB" };


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  SingleForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public SingleForm()
        {
            InitializeComponent();

            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_SINGLE;

            // Check the link status..
            if (MainForm.RFIDAPI.UHFAPI_IsOpen())
            {
                pictureBox_link.Image = Properties.Resources.image2;
                MainForm.rfidhost_param.link_state = true;
                button_single.Enabled = true;
            }
            else
            {
                pictureBox_link.Image = Properties.Resources.Image1;
                MainForm.rfidhost_param.link_state = false;
                button_single.Enabled = false;
            }

            InitForm();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  InitForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void InitForm()
        {
            textBox_scantime.Text = MainForm.rfidhost_param.timeout.ToString();

            checkBox_continue.Checked = MainForm.rfidhost_param.continuous;
            checkBox_mask.Checked = MainForm.rfidhost_param.bldMask;

            trackBar_txpwr.Value = MainForm.rfidhost_param.txpower * 10;
            label_txpwr.Text = dB[MainForm.rfidhost_param.txpower];
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Button Control Function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        void ButtonCtrl()
        {
            // check if reader linked
            MainForm.rfidhost_param.host_state = (int)MainForm.HOST_MSG.RFID_OPERATION;

            while (MainForm.rfidhost_param.host_state == (int)MainForm.HOST_MSG.RFID_OPERATION && (MainForm.RFIDAPI.UHFAPI_IsOpen() == false))
            {
                Application.DoEvents();

                if (MainForm.RFIDAPI.UHFAPI_Open())
                {
                    pictureBox_link.Image = Properties.Resources.image2;
                    MainForm.rfidhost_param.link_state = true;
                }
            }

            if (button_single.Text.Equals("SINGLE"))
            {
                Application.DoEvents();

                MainForm.rfidhost_param.host_state = (int)MainForm.HOST_MSG.RFID_OPERATION;
                StartInventory();
            }
            else
            {
                Application.DoEvents();

                MainForm.rfidhost_param.host_state = (int)MainForm.HOST_MSG.RFID_STOP;
                StopInventory();
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  start inventory function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal void StartInventory()
        {
            button_single.Text = "STOP";

            // set duty
            MainForm.RFIDAPI.UHFAPI_SetAirDura(70, 100);

            // set session
            MainForm.RFIDAPI.UHFAPI_SET_Session(0x30);

            // set q value
            MainForm.RFIDAPI.UHFAPI_SET_QValue(0);

            // set inventory target
            MainForm.RFIDAPI.UHFAPI_SET_InventoryTarget(0x32);

            // set operation parameter.
            MainForm.SetupOperationParameter();

            // start inventory
            MainForm.RFIDAPI.UHFAPI_InventoryQ(MainForm.SetControlParam, false);
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  stop inventory function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal void StopInventory()
        {
            MainForm.RFIDAPI.UHFAPI_Stop(true);
            button_single.Text = "SINGLE";
            button_single.Enabled = true;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  get epc data process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void GetEPC(string epc)
        {
            int i;
            int count = listView1.Items.Count;

            for (i = 0; i < count; i++)
                if (epc == listView1.Items[i].SubItems[0].Text)
                    break;

            // increase count for repeated detection
            if (i < count)
                listView1.Items[i].SubItems[1].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[1].Text) + 1);

            // increase tag count
            else
            {
                ListViewItem item = new ListViewItem(epc);
                item.SubItems.Add("1");
                listView1.Items.Add(item);
                label_count.Text = Convert.ToString(Convert.ToInt32(label_count.Text) + 1);
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  command end process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void InventoryEnd()
        {
            button_single.Text = "SINGLE";
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  link lost process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void LinkLost()
        {
            if (button_single.Text != "SINGLE")
            {
                button_single.Text = "SINGLE";
                button_single.Enabled = true;

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
        //  inventory button process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_normal_Click(object sender, EventArgs e)
        {
            ButtonCtrl();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  set scan time function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void textBox_scantime_TextChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.timeout = (UInt32)int.Parse(textBox_scantime.Text);
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  set continue mode function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void checkBox_continue_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.continuous = checkBox_continue.Checked;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  set mask function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void checkBox_mask_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.rfidhost_param.bldMask = checkBox_mask.Checked;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  mask settings..
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_mask_Click(object sender, EventArgs e)
        {
            MaskForm = new MaskForm();
            MaskForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  list clear
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label_count.Text = "0";
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Form closing
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void SingleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.rfidhost_param.form_state = (int)MainForm.FORM_STATE.FORM_MENU;
            MainForm.RFIDAPI.UHFAPI_Stop(true);
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

    }
}