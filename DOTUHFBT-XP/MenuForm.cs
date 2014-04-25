using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTUHFBT_XP
{
    public partial class MenuForm : Form
    {
        public static MainForm Main_Form;
        public static string Firmware_ver;
        public static string App_ver;

        // sound status
        public enum SOUND_STATE
        {
            SOUND_SUCCESS = 0x00000000,
            SOUND_FAILED = 0x00000001,
        }

        public MenuForm()
        {
            InitializeComponent();
              
            
            if (MainForm.rfidhost_param.link_state)
            {
                pictureBox_link.Image = Properties.Resources.image2;                
                MainForm.PlaySound(MainForm.SOUND_STATE.SOUND_SUCCESS);

                Firmware_ver = new string(new char[50]);                
                MainForm.RFIDAPI.UHFAPI_GetFirmwareVersion(Firmware_ver);
                
                label_fw_ver.Text = "Fw. Version : " + Firmware_ver;

                App_ver = System.Windows.Forms.Application.ProductVersion;
                label_app_ver.Text = "App. Version : " + App_ver;
            }
            else
            {
                pictureBox_link.Image = Properties.Resources.Image1;
            }


        }

        // Normal Mode
        private void button_normal_Click(object sender, EventArgs e)
        {
            MainForm main_form = new MainForm();
            main_form.DialogControl(MainForm.MODE_STATE.NORMAL_MODE);
        }

        // Multi Mode
        private void button_multi_Click(object sender, EventArgs e)
        {

        }

        // Single Mode
        private void button_single_Click(object sender, EventArgs e)
        {

        }

        // Custom Mode
        private void button_custom_Click(object sender, EventArgs e)
        {

        }

        // Read / Write Mode
        private void button_readwrite_Click(object sender, EventArgs e)
        {

        }

        // Lock / Kill Mode
        private void button_lockkill_Click(object sender, EventArgs e)
        {

        }

        // Config Mode
        private void button_config_Click(object sender, EventArgs e)
        {

        }

        // Link Mode
        private void button_link_Click(object sender, EventArgs e)
        {

        }
    }
}