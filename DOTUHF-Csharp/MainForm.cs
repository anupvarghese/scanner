using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using UHFAPI_NET;

namespace DOTUHF_Csharp
{
    //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    //  rfid configuration parameters struct..
    //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    unsafe public struct RFID_PARMS
    {
        public Int32 single_tag;                        // single tag
        public bool auto_link;                          // auto link
        public bool continuous;                         // tag operation continuous
        public bool skip_same;                          // discard skip
        public Int32 session;                           // session (S00, S01, S10, S11)
        public Int32 target;                            // target AB
        public Int32 q;                                 // q value
        public UInt32 timeout;                          // set operation time when detected tag
        public Int32 txpower;                           // tx power level control
        public Int32 mask_mode;                         // mask mode
        public byte mask_bank;                          // bank mask
        public UInt32 mask_offset;                      // mask offset
        public UInt32 mask_bits;                        // mask bit
        public fixed byte mskpattern[256];              // set mask pattern
        public fixed byte mskID[256];                   // store mask id.
        public UInt32 mskID_len;                        // store mask id length;
        public bool bldMask;                            // select mask state
        public Int32 mem_bank;                         // tag memory bank
        public Int32 host_state;                        // host state
        public bool link_state;                         // link state
        public Int32 tx_on;                             // tx on time
        public Int32 tx_off;                            // tx off time     
        public Int32 tx_duty;                           // tx duty level
        public Int32 form_state;                        // form state
    }


    //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    //  class MainForm form
    //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    public partial class MainForm : Form
    {
        public static UHFAPI_NET.UHFAPI_NET RFIDAPI;
        public static UHFAPI_NET.UHFAPI_NET.TAG_OP_PARAM SetControlParam;
        
        // sound status
        public enum SOUND_STATE
        {
            SOUND_SUCCESS = 0x00000000,
            SOUND_FAILED = 0x00000001,
        }

        // operate status
        public enum HOST_MSG
        {
            RFID_STOP = 0x00000001,
            RFID_OPERATION = 0x0000000F,
        }

        // Tag Memory Bank
        public enum TAG_MEMORY_BANK
        {
            RESERVED = 0x00000000,
            EPC = 0x00000001,
            TID = 0x00000002,
            USER = 0x00000003,
        }

        // mask mode status
        public enum MASK_MODE
        {
            EPC_MASK_MODE = 0x00000000,
            MULTI_MASK_MODE = 0x00000001,
        }

        // lock mask field
        public enum LOCK_MASK_FIELD
        {
            KILL_PASSWORD = 0x00000000,
            ACCESS_PASSWORD = 0x00000001,
            EPC = 0x00000002,
            TID = 0x00000003,
            USER = 0x00000004,
        }

        // dialog status
        public enum FORM_STATE
        {
            FORM_MENU = 0x00000000,
            FORM_NORMAL = 0x00000001,
            FORM_MULTI = 0x00000002,
            FORM_SINGLE = 0x00000003,
            FORM_CUSTOM = 0x00000004,
            FORM_READWRITE = 0x00000005,
            FORM_LOCKKILL = 0x00000006,
            FORM_CONFIG = 0x00000007,
            FORM_LINK = 0x00000008,
        }

        // def. form
        public static NormalForm NormalForm;
        public static MultiForm MultiForm;
        public static SingleForm SingleForm;
        public static CustomForm CustomForm;
        public static ReadWriteForm ReadWriteForm;
        public static LockKillForm LockKillForm;
        public static ConfigForm ConfigForm;


        // def. system struct
        public static RFID_PARMS rfidhost_param;

        // def. string
        public static string Firmware_ver;
        public static string App_ver;



        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  MainForm form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public MainForm()
        {
            InitializeComponent();

            // Call by API
            RFIDAPI = new UHFAPI_NET.UHFAPI_NET();

            // init. parameters.
            init_param();

            // Link for control
            LinkReader();

            // UI link state.
            if (rfidhost_param.link_state)
            {
                pictureBox_link.Image = Properties.Resources.image2;
                PlaySound(SOUND_STATE.SOUND_SUCCESS);


                Firmware_ver = new string(new char[50]);
                RFIDAPI.UHFAPI_GetFirmwareVersion(Firmware_ver);
                label_fw_ver.Text = "Fw. Version : " + Firmware_ver;

                App_ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                label_app_ver.Text = "App. Version : " + App_ver;
            }
            else
            {
                pictureBox_link.Image = Properties.Resources.Image1;
            }

        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  rfid configuration parmeters initializate
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        void init_param()
        {
            rfidhost_param.auto_link = true;
            rfidhost_param.continuous = true;
            rfidhost_param.skip_same = false;
            rfidhost_param.q = 5;
            rfidhost_param.session = 0;
            rfidhost_param.single_tag = 0;
            rfidhost_param.target = 0;
            rfidhost_param.timeout = 0;
            rfidhost_param.txpower = 0;
            rfidhost_param.link_state = false;
            rfidhost_param.tx_on = 70;
            rfidhost_param.tx_off = 100;
            rfidhost_param.tx_duty = 3;
            rfidhost_param.mem_bank = 1;
            rfidhost_param.host_state = (int)HOST_MSG.RFID_STOP;
            rfidhost_param.form_state = (int)FORM_STATE.FORM_MENU;
            rfidhost_param.mask_mode = (int)MASK_MODE.EPC_MASK_MODE;
            rfidhost_param.mask_bank = (byte)TAG_MEMORY_BANK.EPC;
            rfidhost_param.mask_bits = 0;
            rfidhost_param.mask_offset = 0;
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  sound contorl function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public static void PlaySound(SOUND_STATE sel)
        {
            if (sel == SOUND_STATE.SOUND_SUCCESS)
            {
                Helpers.PlaySound(@"\Success.wav", IntPtr.Zero, Helpers.PlaySoundFlags.SND_FILENAME | Helpers.PlaySoundFlags.SND_ASYNC | Helpers.PlaySoundFlags.SND_NOSTOP);
            }
            else if (sel == SOUND_STATE.SOUND_FAILED) 
            {
                Helpers.PlaySound(@"\Success1.wav", IntPtr.Zero, Helpers.PlaySoundFlags.SND_FILENAME | Helpers.PlaySoundFlags.SND_ASYNC | Helpers.PlaySoundFlags.SND_NOSTOP);
            }
        }

        // Helpers class...
        internal class Helpers
        {
            [Flags]
            public enum PlaySoundFlags : int
            {
                SSND_SYNC = 0x0000,
                SND_ASYNC = 0x0001,
                SND_NODEFAULT = 0x0002,
                SND_MEMORY = 0x0004,
                SND_LOOP = 0x0008,
                SND_NOSTOP = 0x0010,
                SND_NOWAIT = 0x00002000,
                SND_ALIAS = 0x00010000,
                SND_ALIAS_ID = 0x00110000,
                SND_FILENAME = 0x00020000,
                SND_RESOURCE = 0x00040004
            }

            // dll importing...
            [DllImport("coredll")]
            public static extern bool PlaySound(string szSound, IntPtr hMod, PlaySoundFlags flags);
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Setup RFID Operation parameter        
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public static void SetupOperationParameter()
        {
            if (rfidhost_param.mask_bits > 255)
                rfidhost_param.mask_bits = 255;

            SetControlParam.single_tag = rfidhost_param.continuous == true ? 0 : 1;
            SetControlParam.timeout = rfidhost_param.timeout * 1000;
            SetControlParam.QuerySelected = rfidhost_param.mask_bits > 0 ? 1 : 0;
            SetControlParam.mask.mskBits = 0;

            if (rfidhost_param.bldMask)
            {
                SetControlParam.mask.mskBits = rfidhost_param.mask_bits;
                SetControlParam.mask.mskOffset = rfidhost_param.mask_offset;
                SetControlParam.mask.mskMemBank = rfidhost_param.mask_bank;

                unsafe
                {
                    fixed (byte* t = SetControlParam.mask.mskPattern, s = MainForm.rfidhost_param.mskpattern)
                    {
                        for (int i = 0; i < SetControlParam.mask.mskBits + 7; i++)
                            *(t + i) = *(s + i);
                    }
                }

                RFIDAPI.UHFAPI_SET_SelectAction(true, 0x30, ref SetControlParam.mask);
            }

            RFIDAPI.UHFAPI_SET_OpMode(SetControlParam.single_tag > 0 ? true : false, rfidhost_param.bldMask, rfidhost_param.bldMask/*SetControlParam.QuerySelected > 0 ? true : false*/, SetControlParam.timeout);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  link control function
        //  set the event / send the window handle / open the API
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void LinkReader()
        {
            // message handler
            RFIDAPI.evtCmdBegin += new UHFAPI_NET.UHFAPI_NET.BeginEventDispacher(CommandBegin);
            RFIDAPI.evtCmdEnd += new UHFAPI_NET.UHFAPI_NET.EndEventDispacher(CommandEnd);
            RFIDAPI.evtLinkLost += new UHFAPI_NET.UHFAPI_NET.LinkLostEventHandler(evtLinkLost);
            RFIDAPI.evtPlatformPowerResume += new UHFAPI_NET.UHFAPI_NET.PlatformPowerResumeEventHandler(evtPlatformPowerResume);
            RFIDAPI.evtInventoryEPC += new UHFAPI_NET.UHFAPI_NET.InventoryEPCDispacher(GetInventoryEPC);
            RFIDAPI.evtAccessEPC += new UHFAPI_NET.UHFAPI_NET.AccessEPCDispacher(GetAccessEPC);
            RFIDAPI.evtAccessData += new UHFAPI_NET.UHFAPI_NET.AccessDataDispacher(GetAccessData);
            RFIDAPI.evtAccessResult += new UHFAPI_NET.UHFAPI_NET.AccessResultDispacher(GetAccessResult);

            // transmit Window handle
            RFIDAPI.UHFAPI_HWND_EX(0, 0);

            // UHFAPI open
            if (RFIDAPI.UHFAPI_Open())
            {
                rfidhost_param.link_state = true;
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  power resume proccess function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void evtPlatformPowerResume()
        {
            switch (rfidhost_param.form_state)
            {
                case (int)FORM_STATE.FORM_NORMAL:
                    {
                        NormalForm.PowerResume();
                    }
                    break;
                case (int)FORM_STATE.FORM_MULTI:
                    {
                        MultiForm.PowerResume();
                    }
                    break;

                case (int)FORM_STATE.FORM_SINGLE:
                    {
                        SingleForm.PowerResume();
                    }
                    break;

                case (int)FORM_STATE.FORM_CUSTOM:
                    {
                        CustomForm.PowerResume();
                    }
                    break;
            }             
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  link lost proccess function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void evtLinkLost()
        {
            rfidhost_param.link_state = false;

            pictureBox_link.Image = Properties.Resources.Image1;

            RFIDAPI.UHFAPI_Close();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  command begin process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void CommandBegin(string cmd)
        {
            System.Diagnostics.Debug.WriteLine("[Command Begin] : " + cmd);
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  command end process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void CommandEnd(string cmd)
        {
            System.Diagnostics.Debug.WriteLine("[Command End] : " + cmd);

            switch (rfidhost_param.form_state)
            {
                case (int)FORM_STATE.FORM_NORMAL:
                    {
                        NormalForm.InventoryEnd();
                    }
                    break;

                case (int)FORM_STATE.FORM_MULTI:
                    {
                        MultiForm.InventoryEnd();
                    }
                    break;

                case (int)FORM_STATE.FORM_SINGLE:
                    {
                        SingleForm.InventoryEnd();
                    }
                    break;

                case (int)FORM_STATE.FORM_CUSTOM:
                    {
                        CustomForm.InventoryEnd();
                    }
                    break;

                case (int)FORM_STATE.FORM_READWRITE:
                    {
                        ReadWriteForm.AccessEnd();
                    }
                    break;

                case (int)FORM_STATE.FORM_LOCKKILL:
                    {
                        LockKillForm.AccessEnd();
                    }
                    break;
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  inventory epc process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void GetInventoryEPC(string epc)
        {
            System.Diagnostics.Debug.WriteLine("[GET EPC] : " + epc);

            switch (rfidhost_param.form_state)
            {
                case (int)FORM_STATE.FORM_NORMAL:
                    {
                        NormalForm.GetEPC(epc);
                    }
                    break;

                case (int)FORM_STATE.FORM_MULTI:
                    {
                        MultiForm.GetEPC(epc);
                    }
                    break;

                case (int)FORM_STATE.FORM_SINGLE:
                    {
                        SingleForm.GetEPC(epc);
                    }
                    break;

                case (int)FORM_STATE.FORM_CUSTOM:
                    {
                        CustomForm.GetEPC(epc);
                    }
                    break;
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  access epc process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void GetAccessEPC(string epc)
        {
            System.Diagnostics.Debug.WriteLine("[AccessEPC] : " + epc);

            switch (rfidhost_param.form_state)
            {
                case (int)FORM_STATE.FORM_READWRITE:
                    {
                        ReadWriteForm.AccessEPC(epc);
                    }
                    break;

                case (int)FORM_STATE.FORM_LOCKKILL:
                    {
                        LockKillForm.AccessEPC(epc);
                    }
                    break;
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  access data process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void GetAccessData(string data)
        {
            System.Diagnostics.Debug.WriteLine("[AccessDATA] : " + data);

            switch (rfidhost_param.form_state)
            {
                case (int)FORM_STATE.FORM_READWRITE:
                    {
                        ReadWriteForm.AccessDATA(data);
                    }
                    break;
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  access resuilt process function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void GetAccessResult(string res)
        {
            System.Diagnostics.Debug.WriteLine("[AccessRESULT] : " + res);

            switch (rfidhost_param.form_state)
            {
                case (int)FORM_STATE.FORM_READWRITE:
                    {
                        ReadWriteForm.AccessRESULT(res);
                    }
                    break;

                case (int)FORM_STATE.FORM_LOCKKILL:
                    {
                        LockKillForm.AccessRESULT(res);
                    }
                    break;
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Normal Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_normal_Click(object sender, EventArgs e)
        {
            NormalForm = new NormalForm();
            NormalForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Multi Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_multi_Click(object sender, EventArgs e)
        {
            MultiForm = new MultiForm();
            MultiForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Single Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_single_Click(object sender, EventArgs e)
        {
            SingleForm = new SingleForm();
            SingleForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Custom Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_custom_Click(object sender, EventArgs e)
        {
            CustomForm = new CustomForm();
            CustomForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Read & Write Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_readwrite_Click(object sender, EventArgs e)
        {
            ReadWriteForm = new ReadWriteForm();
            ReadWriteForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Lock & Kill Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_lockkill_Click(object sender, EventArgs e)
        {
            LockKillForm = new LockKillForm();
            LockKillForm.ShowDialog();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Config Mode
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void button_config_Click(object sender, EventArgs e)
        {
            ConfigForm = new ConfigForm();
            ConfigForm.ShowDialog();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Exit program proccess function
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            RFIDAPI.UHFAPI_Close();
            RFIDAPI.Cleanup();
            Application.Exit();
        }
    }
}