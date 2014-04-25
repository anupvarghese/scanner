using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTUHFBT_XP
{
    public partial class MaskForm : Form
    {
        public MaskForm()
        {
            InitializeComponent();

            InitForm();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  InitForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void InitForm()
        {
            // set to mask bank
            comboBox_bank.SelectedIndex = (int)MainForm.rfidhost_param.mask_bank;

            // set to mask offset
            textBox_offset.Text = MainForm.rfidhost_param.mask_offset.ToString();

            // set to mask length
            textBox_length.Text = MainForm.rfidhost_param.mask_bits.ToString();

            if (MainForm.rfidhost_param.mask_bits > 0)
            {
                unsafe
                {
                    byte[] buf = new byte[256];

                    fixed (byte* p = MainForm.rfidhost_param.mskID, b = buf)
                    {
                        for (int i = 0; i < MainForm.rfidhost_param.mskID_len; i++)
                            *(b + i) = *(p + i);
                    }

                    textBox_epcdata.Text = System.Text.Encoding.ASCII.GetString(buf);
                    textBox_maskdata.Text = System.Text.Encoding.ASCII.GetString(buf);
                }
            }


            switch (MainForm.rfidhost_param.mask_mode)
            {
                case (int)MainForm.MASK_MODE.EPC_MASK_MODE:
                    {
                        radioButton_epcmask.Checked = true;
                        radioButton_multimode.Checked = false;
                        textBox_epcdata.Enabled = true;
                        comboBox_bank.Enabled = false;
                        textBox_offset.Enabled = false;
                        textBox_length.Enabled = false;
                        textBox_maskdata.Enabled = false;
                    }
                    break;

                case (int)MainForm.MASK_MODE.MULTI_MASK_MODE:
                    {
                        radioButton_epcmask.Checked = false;
                        radioButton_multimode.Checked = true;
                        textBox_epcdata.Enabled = false;
                        comboBox_bank.Enabled = true;
                        textBox_offset.Enabled = true;
                        textBox_length.Enabled = true;
                        textBox_maskdata.Enabled = true;
                      
                    }
                    break;
            }           
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Save the option parameters
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void MaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // checked mask mode.
            if (radioButton_epcmask.Checked)
            {
                MainForm.rfidhost_param.mask_mode = (int)MainForm.MASK_MODE.EPC_MASK_MODE;

                if (textBox_epcdata.Text.Length != 0)
                {
                    MainForm.rfidhost_param.mskID_len = (uint)textBox_epcdata.Text.Length;

                    if (true == UtilClass.BitCount(out MainForm.rfidhost_param.mask_bits, textBox_epcdata.Text))
                    {
                        MainForm.rfidhost_param.mask_offset = 2 * 16;
                        MainForm.rfidhost_param.mask_bank = (byte)MainForm.TAG_MEMORY_BANK.EPC;

                        unsafe
                        {
                            byte[] tagid = new byte[256];

                            UtilClass.HexStrToByteArray(out tagid, textBox_epcdata.Text);

                            fixed (byte* s = tagid, t = MainForm.rfidhost_param.mskpattern)
                            {
                                for (int i = 0; i < tagid.Length; i++)
                                    *(t + i) = *(s + i);
                            }
                        }

                        // restore tag id
                        unsafe
                        {
                            byte[] ID = new byte[256];

                            ID = UtilClass.StrToByteArray(textBox_epcdata.Text);

                            fixed (byte* s = ID, t = MainForm.rfidhost_param.mskID)
                            {
                                for (int i = 0; i < MainForm.rfidhost_param.mskID_len; i++)
                                    *(t + i) = *(s + i);
                            }
                        }
                    }
                    else
                    {
                        MainForm.rfidhost_param.mask_bits = 0;
                        MainForm.rfidhost_param.mask_offset = 0;
                        MessageBox.Show("Wrong Tag EPC data");
                    }
                }
                else
                {
                    MainForm.rfidhost_param.mask_bits = 0;
                    MainForm.rfidhost_param.mask_offset = 0;
                    MessageBox.Show("Nothing is Tag ID Value");
                }                
            }
            else if (radioButton_multimode.Checked)
            {
                MainForm.rfidhost_param.mask_mode = (int)MainForm.MASK_MODE.MULTI_MASK_MODE;

                // bank
                switch( comboBox_bank.SelectedIndex)
                {
                    case (int)MainForm.TAG_MEMORY_BANK.EPC:
                        MainForm.rfidhost_param.mask_bank = (byte)MainForm.TAG_MEMORY_BANK.EPC;
                        break;

                    case (int)MainForm.TAG_MEMORY_BANK.RESERVED:
                        MainForm.rfidhost_param.mask_bank = (byte)MainForm.TAG_MEMORY_BANK.RESERVED;
                        break;

                    case (int)MainForm.TAG_MEMORY_BANK.TID:
                        MainForm.rfidhost_param.mask_bank = (byte)MainForm.TAG_MEMORY_BANK.TID;
                        break;

                    case (int)MainForm.TAG_MEMORY_BANK.USER:
                        MainForm.rfidhost_param.mask_bank = (byte)MainForm.TAG_MEMORY_BANK.USER;
                        break;
                }
                

                // offset
                if (textBox_offset.Text.Length != 0)
                {
                    uint offset;

                    if(true == UtilClass.HEX32(out offset, textBox_offset.Text))
                    {
                        MainForm.rfidhost_param.mask_offset = offset;
                    }
                }

                // bit count
                if( textBox_length.Text.Length != 0)
                {
                    uint len;

                    if(true == UtilClass.HEX32(out len, textBox_length.Text))
                    {
                        MainForm.rfidhost_param.mask_bits = len;
                    }
                }

                // tag mask data
                if ( textBox_maskdata.Text.Length != 0)
                {
                    uint len;
                    
                    if (true == UtilClass.BitCount(out len, textBox_maskdata.Text))
                    {
                        unsafe
                        {
                            byte[] tagid = new byte[256];

                            UtilClass.HexStrToByteArray(out tagid, textBox_maskdata.Text);

                            fixed (byte* s = tagid, t = MainForm.rfidhost_param.mskpattern)
                            {
                                for (int i = 0; i < tagid.Length; i++)
                                    *(t + i) = *(s + i);
                            }
                        }

                        // restore tag id
                        unsafe
                        {
                            byte[] ID = new byte[256];

                            ID = UtilClass.StrToByteArray(textBox_epcdata.Text);

                            fixed (byte* s = ID, t = MainForm.rfidhost_param.mskID)
                            {
                                for (int i = 0; i < MainForm.rfidhost_param.mskID_len; i++)
                                    *(t + i) = *(s + i);
                            }
                        }
                    }
                    else
                    {
                        MainForm.rfidhost_param.mask_bits = 0;
                        MainForm.rfidhost_param.mask_offset = 0;                        
                        MessageBox.Show("Wrong Tag EPC data");
                    }
                }
                else
                {
                    MainForm.rfidhost_param.mask_bits = 0;
                    MainForm.rfidhost_param.mask_offset = 0;
                    MessageBox.Show("Nothing is Tag ID Value");
                }                
            }            
        }
    }
}