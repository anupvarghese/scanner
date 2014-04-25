using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;


/********************************************************************************************************************************************************
* revision history																																		*
*********************************************************************************************************************************************************
* 2011.2      ver1.0.0.0    kshan     1.First release.                                                                                                  *
//----------+------------+---------+---------------------------------------------------------------------------------------------------------------------
* 2011.11     ver1.1.1.1    kshan     1.change import prototypes.                                                                                       *
//----------+------------+---------+---------------------------------------------------------------------------------------------------------------------
* 2013.9.3    ver1.2.0.0    eric      1.Add to R900 control functions.(Buzzer/AutoPowerOff)                                                             *
*                                     2.Add to UHFAPI functions.                                                                                        *
*                                       - UHFAPI_InventoryQ()                                                                                           *
*                                       - UHFAPI_Scan()                                                                                                 *
*                                       - UHFAPI_SET_OnlyEPC()                                                                                          *
*                                       - UHFAPI_GET_OnlyEPC()                                                                                          *
*                                       - UHFAPI_SET_OuputFormat()                                                                                      *
*                                       - UHFAPI_GET_OuputFormat()                                                                                      *
*                                       - UHFAPI_SET_UhfConfigure()                                                                                     *
*                                       - UHFAPI_GET_UhfConfigure()                                                                                     *
*                                       - UHFAPI_SET_RegParms()                                                                                         *
*                                       - UHFAPI_GET_RegParms()                                                                                         *
*********************************************************************************************************************************************************/

//┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
//  UHFAPI_NET namespace
//┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
namespace UHFAPI_NET
{
    //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    //  UHFAPI_NET Class
    //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    public class UHFAPI_NET
    {
        //  DLL Import region
        #region Dll Import

        /*****************************************************************************************************
        ///////////////////////////////////// general functions  /////////////////////////////////////////////
        ******************************************************************************************************/
        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_Open", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_Open();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_HWND_EX", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_HWND_EX(IntPtr handle, UInt32 report_mode_set, UInt32 report_mode_reset);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_IsOpen", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_IsOpen();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_Close", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_Close();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetLibVersion", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetLibVersion(char* szValue);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_IsBusy", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_IsBusy();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_Stop", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_Stop(bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_FilterMode", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_FilterMode(bool mode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_FilterMode", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_FilterMode(out bool mode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_RESULT_MESSAGE", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_RESULT_MESSAGE(char* szResult, uint msg, UInt16 wParam, UInt32 lParam);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_EPC", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_EPC(char* szResult);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_DATA", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_DATA(char* szResult);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_LAST_ERROR", SetLastError = true)]
        unsafe internal static extern IntPtr _UHFAPI_GET_LAST_ERROR();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_LAST_ERROR_CODE", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_GET_LAST_CODE_CODE();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_LAST_ERROR_CODE", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_GET_LAST_ERROR_CODE();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetFirmwareVersion", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetFirmwareVersion(char* szValue);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetReaderClock", SetLastError = true)]
        unsafe internal static extern Int64 _UHFAPI_GetReaderClock(UInt32 ReaderTick);
        //======================================  end of general function   =====================================


        /*****************************************************************************************************
        ///////////////////////////////////// tag operation functions ////////////////////////////////////////
        ******************************************************************************************************/
        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_Inventory", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_Inventory(TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_ReadTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_ReadTag(byte MemBank, UInt32 offset, UInt32 length, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_WriteTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_WriteTag(byte MemBank, UInt32 offset, UInt32 length, UInt16* szWriteData, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_LockTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_LockTag(bool kill_pwd, bool access_pwd, bool epc, bool tid, bool user, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_UnlockTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_UnlockTag(bool kill_pwd, bool access_pwd, bool epc, bool tid, bool user, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_PermalockTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_PermalockTag(byte ActionField, bool Lock, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_LockSetTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_LockSetTag(typeLockMasks masks, typeLockMasks enables, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_KillTag", SetLastError = true)]
        unsafe internal static extern enumAccessResult _UHFAPI_KillTag(UInt32 Kill_PWD, UInt32 pwdACCESS, TAG_OP_PARAM* param, bool wait_done);
        //=====================================  end of tag operation  ============================================


        /****************************************************************************************************
        ////////////////////////////////////// RFID module setting function  ////////////////////////////////
        ****************************************************************************************************/
        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_PowerControl", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_PowerControl(UInt32 attDb10);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_PowerControl", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_PowerControl(out UInt32 attDb10);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_Session", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_Session(byte SessionCode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_Session", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_Session(out byte SessionCode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_QValue", SetLastError = true)]
        internal static extern bool _UHFAPI_SET_QValue(UInt32 QValue);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_QValue", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_QValue(out UInt32 QValue);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_InventoryTarget", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_InventoryTarget(byte TargetCode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_InventoryTarget", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_InventoryTarget(out byte TargetCode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_SelectActionMultiple", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_SelectActionMultiple(int count, ref typeSelectMaskEx mask);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_SelectAction", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_SelectAction(bool SelectFlag, byte ActionCode, ref typeSelectMask mask);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_SelectAction", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_SelectAction(out bool SelectFlag, out Byte ActionCode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_OpMode", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_OpMode(bool single_tag, bool UseMask, bool QuerySelected, UInt32 timeout);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_OpMode", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_OpMode(out bool single_tag, out bool UseMask, out bool QuerySelected, out UInt32 timeout);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_LBT_CHState", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_LBT_CHState(UInt32 State);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_LBT_CHState", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_LBT_CHState(out UInt32 State);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_CHState", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_CHState(UInt32 State);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_CHState", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_CHState(out UInt32 State);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_LBT_Time", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_LBT_Time(UInt32 LBT_Time);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_LBT_Time", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_LBT_Time(out UInt32 LBT_Time);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_Default", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_Default();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SetAirDura", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SetAirDura(UInt32 onms, UInt32 offms);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetAirDura", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetAirDura(out UInt32 onms, out UInt32 offms);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SetAirDuty", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SetAirDuty(UInt32 speed);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_Scan", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_Scan(out string epc, out UInt32 length);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetPowerState", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetPowerState(out int nPowerState);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetOemVersion", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetOemVersion(out string ver);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetSerialNumber", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetSerialNumber(out string code_f, out string code_s, out string serial);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetOemRegionInfo", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GetOemRegionInfo(out string band);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_InventoryQ", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_InventoryQ(TAG_OP_PARAM* param, bool wait_done);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_OnlyEPC", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_OnlyEPC(bool set);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_OnlyEPC", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_OnlyEPC(out bool set);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_OuputFormat", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_OuputFormat(enumFormatType type);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_OuputFormat", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_OuputFormat(out enumFormatType type);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_UhfConfigure", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_UhfConfigure(int max_msec, bool singletag, bool continuous, int duty, int txpower, bool buzzer, bool discardSameTag);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_UhfConfigure", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_UhfConfigure(out int max_msec, out bool singletag, out bool continuous, out int duty, out int txpower, out bool buzzer, out bool discardSameTag);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SET_RegParms", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_SET_RegParms(byte Session, byte Target, UInt32 QValue);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GET_RegParms", SetLastError = true)]
        unsafe internal static extern bool _UHFAPI_GET_RegParms(out byte Session, out byte Target, out UInt32 QValue);
        //===================================== end of setting function  =====================================


        /*****************************************************************************************************
        ///////////////////////////////////// enginnering functions  /////////////////////////////////////////
        ******************************************************************************************************/
        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SpecialAccessCtrl", SetLastError = true)]
        internal static extern bool _UHFAPI_SpecialAccessCtrl(UInt32 type, UInt32 code, out UInt32 value);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_Custom_Access", SetLastError = true)]
        internal static extern int _UHFAPI_Custom_Access(out byte cmd, UInt32 cmdbytes, UInt32 respbits, UInt32 pwdACCESS, ref TAG_OP_PARAM param);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_LibraryMode", SetLastError = true)]
        internal static extern bool _UHFAPI_LibraryMode(UInt32 mode);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_CheckBattery", SetLastError = true)]
        internal static extern int _UHFAPI_CheckBattery();

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_SetBand", SetLastError = true)]
        internal static extern bool _UHFAPI_SetBand(Int16 band_code);

        [DllImport("UHFAPI.dll", EntryPoint = "UHFAPI_GetBand", SetLastError = true)]
        internal static extern bool _UHFAPI_GetBand(out Int16 band_code);
        //===================================== end of engineering function  ==================================

        /*****************************************************************************************************
        ///////////////////////////////////// r900 control functions  ////////////////////////////////////////
        ******************************************************************************************************/
        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_HWND_EX", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_HWND_EX(IntPtr handle, UInt32 report_mode_set, UInt32 report_mode_reset);

        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_IsTriggerEvent", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_IsTriggerEvent(out Int32 trigger);

        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_RefreshStatus", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_RefreshStatus();

        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_SetPowerOffDelay", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_SetPowerOffDelay(UInt32 value, bool nv);

        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_GetPowerOffDelay", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_GetPowerOffDelay(out UInt32 value);

        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_SetBuzzerVolume", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_SetBuzzerVolume(UInt32 value, bool nv);

        [DllImport("R900Lib.dll", EntryPoint = "R900LIB_GetBuzzerVolume", SetLastError = true)]
        unsafe internal static extern bool _R900LIB_GetBuzzerVolume(out UInt32 value);
        //===================================== end of r900 control function  =================================


        /*****************************************************************************************************
        ///////////////////////////////////// r900 link functions  ///////////////////////////////////////////
        ******************************************************************************************************/
        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_GetMessageId", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_GetMessageId();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_GetDeviceLostEventId", SetLastError = true)]
        unsafe internal static extern IntPtr _UHFSUPAPI_GetDeviceLostEventId();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_GetR900MessageId", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_GetR900MessageId();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_GetDeviceLostMessageId", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_GetDeviceLostMessageId();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_GetPlatformPowerMessageId", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_GetPlatformPowerMessageId();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_UploadInventory", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_UploadInventory(UploadCallbackHandler1 UploadCallbackHandler1);

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_OpenUploadInventoryList", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_OpenUploadInventoryList();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_GetUploadInventoryData", SetLastError = true)]
        unsafe internal static extern char* _UHFSUPAPI_GetUploadInventoryData(UInt32 index);

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_CloseUploadInventoryList", SetLastError = true)]
        unsafe internal static extern void _UHFSUPAPI_CloseUploadInventoryList();

        [DllImport("uhfapi_sup_4_net.dll", EntryPoint = "UHFSUPAPI_ClearInventory", SetLastError = true)]
        unsafe internal static extern UInt32 _UHFSUPAPI_ClearInventory();
        //===================================== end of r900 link function  =================================

        #endregion
        //  end of DLL Import region        

        //  Message Handler region
        #region unsafe handle

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  RFID module message
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe static int GetMessageId()
        {
            return (int)_UHFSUPAPI_GetMessageId();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  R900 message
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe static int GetR900MessageId()
        {
            return (int)_UHFSUPAPI_GetR900MessageId();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  DeviceLost Message
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe static int GetDeviceLostMessageId()
        {
            return (int)_UHFSUPAPI_GetDeviceLostMessageId();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  DeviceLost Event Message
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe static IntPtr GetDeviceLostEventId()
        {
            return _UHFSUPAPI_GetDeviceLostEventId();
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Platform Power Message
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe static int GetPlatformPowerMessageId()
        {
            return (int)_UHFSUPAPI_GetPlatformPowerMessageId();
        }

        #endregion
        //  end of Message Handler region

        // delegate region
        #region delegate

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  delegate
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public delegate void UHFAPIEventHandler(int Msg, IntPtr WParam, IntPtr LParam);
        public delegate void R900EventHandler(int Msg, IntPtr WParam, IntPtr LParam);
        public delegate void R900TriggerHandler(bool trigger);
        public delegate void InventoryEPCDispacher(string epc);
        public delegate void AccessEPCDispacher(string epc);
        public delegate void AccessDataDispacher(string data);
        public delegate void AccessResultDispacher(string msg);
        public delegate void MsgEventDispacher(string msg);
        public delegate void BeginEventDispacher(string msg);
        public delegate void EndEventDispacher(string msg);
        public delegate void LinkLostEventHandler();
        public delegate void PlatformPowerResumeEventHandler();
        public delegate void UploadCallbackHandler(string msg);
        public unsafe delegate UInt32 UploadCallbackHandler1(char* msg);

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  event
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public event R900EventHandler R900APIMessage = null;
        public event R900TriggerHandler evtR900TriggerEvent = null;
        public event InventoryEPCDispacher evtInventoryEPC = null;
        public event InventoryEPCDispacher evtUploadEPC = null;
        public event AccessEPCDispacher evtAccessEPC = null;
        public event AccessDataDispacher evtAccessData = null;
        public event AccessResultDispacher evtAccessResult = null;
        public event MsgEventDispacher evtNotifyMsg = null;
        public event BeginEventDispacher evtCmdBegin = null;
        public event EndEventDispacher evtCmdEnd = null;
        public event LinkLostEventHandler evtLinkLost = null;
        public event PlatformPowerResumeEventHandler evtPlatformPowerResume = null;
        public event UploadCallbackHandler evtUploadCallback = null;

        #endregion
        // end of delegate region


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Message variable
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal static int UHFAPI_MESSAGE = GetMessageId();
        internal static int R900_MESSAGE = GetR900MessageId();
        internal static int DEVICE_LOST_MESSAGE = GetDeviceLostMessageId();
        internal static int PLATFORM_POWER_MESSAGE = GetPlatformPowerMessageId();


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  variable
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal int readercommand;
        internal int access_state;
        internal string LastCommandName;
        internal string LastTagEPC;
        internal string msgLastError;


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  window message handler
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal UHFMsgWnd uhfmsgwnd = null;


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  internal class UHFMsgWnd : System.Windows.Forms.Form
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal class UHFMsgWnd : System.Windows.Forms.Form
        {
            private UHFAPI_NET _uhf = null;
            public UHFMsgWnd(UHFAPI_NET uhf)
            {
                this._uhf = uhf;
            }
            protected override void WndProc(ref Message m)
            {
                if (m.Msg == UHFAPI_MESSAGE)
                {
                    _uhf.MessageHandler(m.Msg, m.WParam, m.LParam);
                }
                else if (m.Msg == R900_MESSAGE)
                {
                    _uhf.R900MessageHandler(m.Msg, m.WParam, m.LParam);
                }
                else if (m.Msg == DEVICE_LOST_MESSAGE)
                {
                    _uhf.DeviceLostMessageHandler(m.Msg, m.WParam, m.LParam);
                }
                else if (m.Msg == PLATFORM_POWER_MESSAGE)
                {
                    _uhf.PlatformPowerMessageHandler(m.Msg, m.WParam, m.LParam);
                }

                base.WndProc(ref m);
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Message Handler Routine
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        private void MessageHandler(int msg, IntPtr wParam, IntPtr lParam)
        {
            string szRawBuff = new string(new char[1024]);
            string szBuff;

            // get result message
            if (!UHFAPI_GET_RESULT_MESSAGE(szRawBuff, msg, wParam, lParam))
            {
                // fail to get message
                return;
            }
            szBuff = szRawBuff.Substring(0, szRawBuff.IndexOf('\0'));


            switch (wParam.ToInt32())
            {
                // Inventory epc message
                case (int)MSG_TYPE.MSG_TYPE_INV_EPC:
                    {
                        // dispach epc
                        if (evtInventoryEPC != null)
                            evtInventoryEPC(szBuff);
                    }
                    break;

                // Access epc message
                case (int)MSG_TYPE.MSG_TYPE_ACCESS_EPC:
                    {
                        // dispach epc
                        if (evtAccessEPC != null)
                            evtAccessEPC(szBuff);

                        LastTagEPC = szBuff;
                    }
                    break;

                // Access read data message
                case (int)MSG_TYPE.MSG_TYPE_READ_DATA:
                    {
                        // dispatch read data
                        if (evtAccessData != null)
                            evtAccessData(szBuff);
                    }
                    break;

                // Access result message(success/fail/etc)
                case (int)MSG_TYPE.MSG_TYPE_ACCESS_RESULT:
                    {
                        // dispatch result
                        if (evtAccessResult != null)
                            evtAccessResult(szBuff);
                    }
                    break;

                // Operation begin message
                case (int)MSG_TYPE.MSG_TYPE_CMD_BEGIN:
                    {
                        readercommand = lParam.ToInt32();

                        // dispatch command name
                        if (evtCmdBegin != null)
                            evtCmdBegin(szBuff);

                        LastCommandName = szBuff;
                        LastTagEPC = "";
                        msgLastError = "";
                    }
                    break;

                // Operation end message
                case (int)MSG_TYPE.MSG_TYPE_CMD_END:
                    {
                        // dispatch command name
                        if (evtCmdEnd != null)
                            evtCmdEnd(LastCommandName);
                    }
                    break;

                // Report error message
                case (int)MSG_TYPE.MSG_TYPE_REPORT_ERROR:
                    {
                        // dispatch error message
                        if (evtNotifyMsg != null)
                            evtNotifyMsg(szBuff);
                    }
                    break;

                default:
                    break;
            }
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  R900 Message Handler Routine
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe private void R900MessageHandler(int Msg, IntPtr WParam, IntPtr LParam)
        {
            Int32 trigger;

            if (R900APIMessage != null)
                R900APIMessage(Msg, WParam, LParam);

            if (evtR900TriggerEvent != null)
            {
                if (_R900LIB_IsTriggerEvent(out trigger))
                    evtR900TriggerEvent((bool)(trigger != 0));
            }
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Lost Device Message Handler Routine
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe private void DeviceLostMessageHandler(int Msg, IntPtr WParam, IntPtr LParam)
        {
            if (evtLinkLost != null)
                evtLinkLost();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Platform Power Message Handler Routine
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe private void PlatformPowerMessageHandler(int Msg, IntPtr WParam, IntPtr LParam)
        {
            if (evtPlatformPowerResume != null)
                evtPlatformPowerResume();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  LostEvent thread Routine
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal Thread EventMonitorThread = null;
        internal void threadProc()
        {
            AutoResetEvent LostEvent = new AutoResetEvent(false);

            LostEvent.Handle = GetDeviceLostEventId();

            while (LostEvent.WaitOne())
            {
                if (evtLinkLost != null)
                    evtLinkLost();
            }
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  UHFAPI_NET basic Functions
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public UHFAPI_NET()
        {
            uhfmsgwnd = new UHFMsgWnd(this);            
        }

        
        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Exit Thread Functions
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public void Cleanup()
        {
            EventMonitorThread.Abort();
        }


        //  User API Functions region
        #region API

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Open comport for UHF RFID device control
        //                : 모듈과의 통신을 Open 합니다.
        //  Parameter     : void
        //  Return        : true on success, false on fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_Open()
        {
            EventMonitorThread = new Thread(threadProc);
            EventMonitorThread.Start();

            return _UHFAPI_Open();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : register window handle to receive window message
        //                : 본 API에서 결과를 알려줄 parent window를 지정합니다.
        //  Parameter     : HWND handle of the application
        //  Return        : true
        //  remark        : refer to enumReportMode definition
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_HWND_EX(UInt32 report_mode_set, UInt32 report_mode_reset)
        {
            bool res = _R900LIB_HWND_EX(uhfmsgwnd.Handle, 0, 0);
            return res && _UHFAPI_HWND_EX(uhfmsgwnd.Handle, report_mode_set, report_mode_reset);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get comport open state
        //                : 모듈 open 여부를 확인합니다.
        //  Parameter     : void
        //  Return        : true if opened, false if no opened
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_IsOpen()
        {
            return _UHFAPI_IsOpen();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Release comport
        //                : 모듈과의 연결을 해제합니다.
        //  Parameter     : void
        //  Return        : true
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_Close()
        {
            EventMonitorThread.Abort();

            return _UHFAPI_Close();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get this library version
        //                : Library 버전을 가져옵니다.
        //  Parameter     : LPWSTR szValue to receive version string. should be long enough to receive version string
        //  Return        : true
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public unsafe string UHFAPI_GetLibVersion()
        {
            String lszValue = new string(new char[50]);
            fixed (char* p = lszValue)
                if (_UHFAPI_GetLibVersion(p))
                    return lszValue;
            return null;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get module status whether tag operation is underdoing or idle
        //                : 모듈의 command 실행 상태를 가져옵니다.
        //  Parameter     : void
        //  Return        : TRUE if busy
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_IsBusy()
        {
            return _UHFAPI_IsBusy();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Stops current tag operation
        //                : 현재 진행 중인 모듈 동작을 중지합니다.
        //  Parameter     : wait_done; TRUE for waiting stop operation finished
        //  Return        : true if stopped or stop operation is started with no problem
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_Stop(bool wait_done)
        {
            return _UHFAPI_Stop(wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Set inventory result report mode.
        //                : 중복된 tag ID를 report할 지를 지정합니다.
        //  Parameter     : mode ; TRUE to enable, FALSE to disable
        //  Return        : true 
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_FilterMode(bool mode)
        {
            return _UHFAPI_SET_FilterMode(mode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get current setting of inventory report filter mode.
        //                : filter mode 설정 값을 가져옵니다.
        //  Parameter     : mode ; TRUE to enable, FALSE to disable
        //  Return        : true 
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_FilterMode(out bool mode)
        {
            return _UHFAPI_GET_FilterMode(out mode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get the message data corresponding message which was sent by api.
        //                : api가 보낸 message에 해당하는 data를 가져옵니다.
        //  Parameter     : LPWSTR szResult
        //                  msg,wParam,lParam; paramters in the event message.
        //  Return        : true if success
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public unsafe bool UHFAPI_GET_RESULT_MESSAGE(string szResult, int msg, IntPtr wParam, IntPtr lParam)
        {
            fixed (char* p = szResult)
                if (_UHFAPI_GET_RESULT_MESSAGE(p, (uint)msg, (UInt16)wParam.ToInt32(), (UInt32)lParam.ToInt32()))
                    return true;
            return false;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get the EPC data of the latest tag operation.
        //                : 마지막 inventory 한 EPC 값을 가져옵니다.
        //  Parameter     : LPWSTR szResult                  
        //  Return        : true if success
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public unsafe bool UHFAPI_GET_EPC(string szResult)
        {
            fixed (char* p = szResult)
                if (_UHFAPI_GET_EPC(p))
                    return true;
            return false;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get the data which is read from a tag.
        //                : 태그에서 읽어온 데이터를 가져옵니다.
        //  Parameter     : LPWSTR szResult                  
        //  Return        : true if success
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public unsafe bool UHFAPI_GET_DATA(string szResult)
        {
            fixed (char* p = szResult)
                if (_UHFAPI_GET_DATA(p))
                    return true;
            return false;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get operation result of the latest tag operation.
        //                : API 함수 실행 완료 후 실행 결과를 가져옵니다.
        //  Return        : pointer to the character string of the operation result.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_LAST_ERROR(string err)
        {
            IntPtr ip = _UHFAPI_GET_LAST_ERROR();
            err = ip.ToString();
            return true;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get operation result of the latest tag operation.
        //                : Event Mode로 동작 시, 함수 완료 후 결과 code를 가져옵니다.
        //  Return        : operation result code of the latest operation.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enumAccessResult UHFAPI_GET_LAST_ERROR_CODE()
        {
            return _UHFAPI_GET_LAST_ERROR_CODE();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get firmware version of RFID module.
        //                : 모듈 펌웨어 버전을 가져옵니다.
        //  Parameter     : LPWSTR szValue , where to recieve the firmware version string 
        //  Return        : true if success
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public unsafe bool UHFAPI_GetFirmwareVersion(string strValue)
        {
            fixed (char* p = strValue)
                if (_UHFAPI_GetFirmwareVersion(p))
                    return true;
            return false;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : start inventory operation using given parameters.
        //                : 지정한 parameter에 따라 tag Inventory를 실행합니다.
        //  Parameter     : TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                                  And no message is posted to the host.
        //  Return        : operation result status refer to enumAccessResult. ACCESS_RESULT_OK is returned if operation is started.
        //  Remark        : use UHFAPI_GET_EPC() and/or UHFAPI_GET_RESULT_MESSAGE() on message reception to get the data or status.
        //                  The system could be locked if wait_done is selected but no stop condition is given.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_Inventory(TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_Inventory(&param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : detect a tag and read the data at memory designated.
        //                : 하나의 태그를 판독하여 지정된 메모리에서 데이터를 읽어옵니다.
        //  Parameter     : BYTE MemBank - bank address where to read
        //  				UINT offset (Min:0 ~ Max:422820625) - word offset of the bank
        //	      			UINT length(Min:1 ~ Max:255) - word count to read in
        //   				pwdACCESS : access password of the tag to read. 0 means no access password.
        //                  TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //                              After returning, use UHFAPI_GET_EPC() and UHFAPI_GET_DATA() to get result
        //  Return        : result status
        //  Remark        : use GET_LAST_ERROR() to get result status

        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_ReadTag(byte MemBank, UInt32 offset, UInt32 length, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_ReadTag(MemBank, offset, length, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : detect a tag and write the data into memory designated
        //                : 하나의 태그를 판독하여 지정된 메모리에 데이터를 삽입합니다.
        //  Parameter     : BYTE MemBank - bank address where to write
        //  				UINT offset (Min:0 ~ Max:422820625) - word offset of the bank
        //  				UINT length(Min:1 ~ Max:255) - word count to access
        //  				pwdACCESS : access password of the tag to access. 0 means no access password.
        //                  TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //                              After returning, use UHFAPI_GET_EPC() and UHFAPI_GET_DATA() to get result
        //  Return        : result status
        //  Remark        : use GET_LAST_ERROR() to get result status
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_WriteTag(byte MemBank, UInt32 offset, UInt32 length, ref UInt16[] szWriteData, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            fixed (UInt16* pszWriteData = &szWriteData[0]) return _UHFAPI_WriteTag(MemBank, offset, length, pszWriteData, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Decription    : detect a tag and change data block designated to lock state.
        //                : 하나의 태그를 판독하여 지정된 데이터 블럭을 잠금 상태로 변경합니다.
        //  Parameter     : bool kill_pwd, bool access_pwd, bool epc, bool tid, bool user - set to true if want to lock
        //  				pwdACCESS : access password of the tag to access. 0 means no access password.
        //                  TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //                              After returning, use UHFAPI_GET_EPC() and UHFAPI_GET_DATA() to get result
        //  Return        : result status
        //  Protocol Type : EPC Gen2
        //  Remark        : lock the selected memory bank or password memory.
        //  				passwords are only accessible using access password if locked.
        //  				epc, tid, user memory banks are writable using access password if locked. but can be read without access password
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_LockTag(bool kill_pwd, bool access_pwd, bool epc, bool tid, bool user, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_LockTag(kill_pwd, access_pwd, epc, tid, user, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Decription    : detect a tag and change data block designated to unlock state.
        //                : 하나의 태그를 판독하여 지정된 데이터 블럭을 잠금 상태를 해제합니다.
        //  Parameter     : bool kill_pwd, bool access_pwd, bool epc, bool tid, bool user - set to true if want to unlock
        //  	  			pwdACCESS : access password of the tag to access. 0 means no access password.
        //                  TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //                              After returning, use UHFAPI_GET_EPC() and UHFAPI_GET_DATA() to get result
        //  Return        : result status
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_UnlockTag(bool kill_pwd, bool access_pwd, bool epc, bool tid, bool user, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_UnlockTag(kill_pwd, access_pwd, epc, tid, user, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Decription    : detect a tag and change the status of lock bit which is designated permanently.
        //                : 하나의 태그를 판독하여 지정된 lock bit의 상태를 변경합니다.
        //  Parameter     : ActionField = memory or password to lock. see codes below.
        //  				lock = set to true to lock permanently
        //                  TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //                              After returning, use UHFAPI_GET_EPC() and UHFAPI_GET_DATA() to get result
        //  Return        : result status
        //  Protocol Type : EPC Gen2
        //  Remark		  : permanently locks the memory or password designated by the ActionField.
        //  				* Permanently locked memory or password cannot revert to unlocked sate.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_PermalockTag(byte ActionField, bool Lock, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_PermalockTag(ActionField, Lock, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Decription    : detect a tag and change the status of lock bits which are desinated.
        //                : 하나의 태그를 판독하여 lock bit의 상태를 변경합니다.
        //  Parameter     : TypeLockMasks masks : state to be changed
        //                  TypeLockMasks enables : sert true to change corresponding state
        //                  TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //                              After returning, use UHFAPI_GET_EPC() and UHFAPI_GET_DATA() to get result
        //  Return        : result status
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_LockSetTag(typeLockMasks masks, typeLockMasks enables, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_LockSetTag(masks, enables, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Decription    : detect a tag and then kill it
        //                : 하나의 태그를 판독하여 태그를 kill 합니다.
        //  Parameter     : UINT32 Kill_PWD - Kill Password of the tag (8Byte)
        //                  TAG_OP_PARAM *param : operation parameters
        //	                mskMemBank : the bank address of the select masks. one of BANK_RESERVED,BANK_EPC,BANK_TID and BANK_USER
        //		            mskOffset : bit offset address of the bank of the select mask.
        //		            mskBits : number of bits of the select mask
        //			        mskPattern : bit pattern of the select mask. MSB is the first bit.
        //					pwdACCESS : access password of the tag. 0 for null access password.
        //					timeout : maximum operation time in [ms]. 0 for endless until UHFAPI_Stop() is called.
        //  				wait_done : TRUE for returning when success or operation timeout.
        //			                    tag id(PC/EPC) can be read using UHFAPI_GET_EPC() after return.
        //  					        FALSE for using events to get operation result using UHFAPI_GET_RESULT_MESSAGE() after event.
        //  Return        : result state
        //  Remark        : kill tag. a killed tag neverr respond to a command.
        //                  To kill a tag, the tag must have non-0 kill password.
        //  				A killed tag can not work permanently
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public enumAccessResult UHFAPI_KillTag(UInt32 Kill_PWD, UInt32 pwdACCESS, TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_KillTag(Kill_PWD, pwdACCESS, &param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set tx power level
        //  				attDb10 Min:0(Full Power) ~ Max:300
        //  				Default = 0
        //  				attDb10 is attenuation value 
        //  				ex) attDb10 = 30, the tx power is reduced by 3dB.
        //
        //  				 +-----------------------------------------------------------+
        //  				 |attDb10   |     0     | 10  |  20 |  .......        | 100  |
        //  				 |-----------------------------------------------------------|
        //  				 |Power(dBm)|    Full   |-1db |-2db |  .......        |-10db |
        //  				 +-----------------------------------------------------------+
        //  Parameter     : UINT attDb10
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_PowerControl(UInt32 attDb10)
        {
            return _UHFAPI_SET_PowerControl(attDb10);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get tx power level
        //  				attDb10 Min:0(Full Power) ~ Max:300
        //  				Default = 0
        //  				attDb10 is attenuation value 
        //  				ex) attDb10 = 30, the tx power is reduced by 3dB.
        //
        //  				 +-----------------------------------------------------------+
        //  				 |attDb10   |     0     | 10  |  20 |  .......        | 100  |
        //  				 |-----------------------------------------------------------|
        //  				 |Power(dBm)|    Full   |-1db |-2db |  .......        |-10db |
        //  				 +-----------------------------------------------------------+
        //  Parameter     : UINT attDb10
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_PowerControl(out UInt32 attDb10)
        {
            return _UHFAPI_GET_PowerControl(out attDb10);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set session value for query command(inventory)
        //                : 태그 동작에 사용할 session을 설정합니다.
        //  Parameter     : BYTE SessionCode see below
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2                
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_Session(byte SessionCode)
        {
            return _UHFAPI_SET_Session(SessionCode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get session value for query command(inventory)
        //                : 태그 동작에 사용될 session을 불러옵니다.
        //  Parameter     : BYTE SessionCode see below
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2                
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_Session(out byte SessionCode)
        {
            return _UHFAPI_GET_Session(out SessionCode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set population Q for query command.
        //                : 태그 동작에 사용할 Q 값을 설정합니다.
        //  				QValue Min:0(Auto) ~ Max:15
        //  				Default = 0
        //  Parameter     : UINT QValue
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_QValue(UInt32 QValue)
        {
            return _UHFAPI_SET_QValue(QValue);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get population Q for query command.
        //                : 태그 동작에 사용할 Q 값을 불러옵니다.
        //  				QValue Min:0(Auto) ~ Max:15
        //  				Default = 0
        //  Parameter     : UINT *QValue
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_QValue(out UInt32 QValue)
        {
            return _UHFAPI_GET_QValue(out QValue);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set inventorized falsg state for query command.
        //                : 태그 동작에 Inventory round 시, 사용할 target을 설정합니다.
        //  Parameter     : BYTE TargetCode see below
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_InventoryTarget(byte TargetCode)
        {
            return _UHFAPI_SET_InventoryTarget(TargetCode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get inventorized falsg state for query command.
        //                : 태그 동작에 Inventory round 시, 사용할 target을 불러옵니다.
        //  Parameter     : BYTE TargetCode see below
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_InventoryTarget(out byte TargetCode)
        {
            return _UHFAPI_GET_InventoryTarget(out TargetCode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set multiple select mawsks for tag query.
        //                : 여러 개의 select action mask를 설정합니다.
        //  Parameter     : int count, number of list.
        //                  typeSelectMaskEx *mask, point of mask action list.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //  Remark        : This setting can be altered by other selection operations.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_SelectActionMultiple(int count, ref typeSelectMaskEx maskex)
        {
            return _UHFAPI_SET_SelectActionMultiple(count, ref maskex);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set or remove select mask.
        //                : select 명령을 받은 후. 태그의 action type을 설정합니다.
        //  Parameter     : BOOL SelectFlag, set tag of action type, after received select command.
        //                  BYTE ActionCode, set tag of select flag, after received select command.
        //                  typeSelectMaskEx *mask, point of mask action list.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //  Remark        : This setting can be altered by other selection operations.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_SelectAction(bool SelectFlag, byte ActionCode, ref typeSelectMask mask)
        {
            return _UHFAPI_SET_SelectAction(SelectFlag, ActionCode, ref mask);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get or remove select mask.
        //                : select 명령을 받은 후. 태그의 action type을 불러옵니다.
        //  Parameter     : BOOL *SelectFlag, get tag of action type, after received select command.
        //                  BYTE *ActionCode, get tag of select flag, after received select command.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //  Remark        : This setting can be altered by other selection operations.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_SelectAction(out bool SelectFlag, out Byte ActionCode)
        {
            return _UHFAPI_GET_SelectAction(out SelectFlag, out ActionCode);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set tag operation mode
        //                : 태그 동작 모드를 설정합니다.
        //  Parameter     : SingleTag : access on a single tag
        //                  UseMask : access using select mask for tag singulation
        //                  QuerySelcted : query only selected tags
        //  				timeout : interval to try access
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_OpMode(bool single_tag, bool UseMask, bool QuerySelected, UInt32 timeout)
        {
            return _UHFAPI_SET_OpMode(single_tag, UseMask, QuerySelected, timeout);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get tag operation mode
        //                : 태그 동작 모드를 불러옵니다.
        //  Parameter     : *SingleTag : access on a single tag
        //                  *UseMask : access using select mask for tag singulation
        //                  *QuerySelcted : query only selected tags
        //  				*timeout : interval to try access
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_OpMode(out bool single_tag, out bool UseMask, out bool QuerySelected, out UInt32 timeout)
        {
            return _UHFAPI_GET_OpMode(out single_tag, out UseMask, out QuerySelected, out timeout);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set channels to use in regions where LBT mode is used. 
        //                : LBT 모드를 사용하는 권역에서 사용할 채널을 설정합니다.
        //  				Min:1 ~ Max:255
        //  				Japan  Default : Japan  254 ( using ch2 to ch8 )
        //  Parameter     : UINT State
        //  				Ex) State = 254 = 1111 1110 
        //  				=> use channel ch2 to ch8 ( LSB = ch1 )
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_LBT_CHState(UInt32 State)
        {
            return _UHFAPI_SET_LBT_CHState(State);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get channels to use in regions where LBT mode is used.
        //                : LBT 모드를 사용하는 권역에서 사용되는 채널을 불러옵니다.
        //  				Min:1 ~ Max:255
        //  				Japan  Default : Japan  254 ( using ch2 to ch8 )
        //  Parameter     : UINT *State
        //  				Ex) State = 254 = 1111 1110 
        //  				=> use channel ch2 to ch8 ( LSB = ch1 )
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_LBT_CHState(out UInt32 State)
        {
            return _UHFAPI_GET_LBT_CHState(out State);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set channels to use in regions.
        //                : LBT 모드를 사용하지 않은 권역에서 사용되는 채널을 설정합니다.
        //  				Min:1 ~ Max:255  				
        //  Parameter     : UINT State
        //  				Ex) State = 254 = 1111 1110 
        //  				=> use channel ch2 to ch8 ( LSB = ch1 )
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_CHState(UInt32 State)
        {
            return _UHFAPI_SET_CHState(State);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get channels to use in regions.
        //                : LBT 모드를 사용하지 않은 권역에서 사용되는 채널을 불러옵니다.
        //  				Min:1 ~ Max:255  				
        //  Parameter     : UINT *State
        //  				Ex) State = 254 = 1111 1110 
        //  				=> use channel ch2 to ch8 ( LSB = ch1 )
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_CHState(out UInt32 State)
        {
            return _UHFAPI_GET_CHState(out State);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set maximum channel occupation time in a channel in regions where LBT mode is used.
        //                : LBT 모드를 사용하는 권역에서 LBT로 선택한 채널의 최대 사용 시간을 설정합니다.
        //  				Default = 4000
        //  Parameter     : UINT LBT_Time (Min:0 ~ Max:4000)
        //  Return        : true = Success, false = fail
        //  Remark        : the maxmum resident time is 4000msec. if set to 0, the resident time is the minimum time 
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_LBT_Time(UInt32 LBT_Time)
        {
            return _UHFAPI_SET_LBT_Time(LBT_Time);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get maximum channel occupation time in a channel in regions where LBT mode is used.
        //                : LBT 모드를 사용하는 권역에서 LBT로 선택한 채널의 최대 사용 시간을 불러옵니다.
        //  				Default = 4000
        //  Parameter     : UINT LBT_Time (Min:0 ~ Max:4000)
        //  Return        : true = Success, false = fail
        //  Remark        : the maxmum resident time is 4000msec. if set to 0, the resident time is the minimum time 
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_LBT_Time(out UInt32 LBT_Time)
        {
            return _UHFAPI_GET_LBT_Time(out LBT_Time);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : reset settings to default values
        //                : 모듈을 control 하기 위한 parameter를 default 상태로 설정합니다.
        //  Parameter     : void
        //  Return        : true = Success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_Default()
        {
            return _UHFAPI_SET_Default();
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Set rf tx cycle duration. The durations must meet the natonal regulation.
        //                : 한 채널 상에서의 reader의 RF 송출 duty를 설정합니다.
        //  Parameter     : onms ; on duration in msec unit
        //                  offms ; off duration in msec unit
        //  Return        : true = Success, false = fail
        //  Remark        : The tatal cycle time ( onms + offms ) must be less than or equal to 
        //                  the maximium allowed cycle time based on the national regulation.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SetAirDura(UInt32 onms, UInt32 offms)
        {
            return _UHFAPI_SetAirDura(onms, offms);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get rf tx cycle duration. The durations must meet the natonal regulation.
        //                : 한 채널 상에서의 reader의 RF 송출 duty를 불러옵니다.
        //  Parameter     : *onms ; on duration in msec unit
        //                  *offms ; off duration in msec unit
        //  Return        : true = Success, false = fail
        //  Remark        : The tatal cycle time ( onms + offms ) must be less than or equal to 
        //                  the maximium allowed cycle time based on the national regulation.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GetAirDura(out UInt32 onms, out UInt32 offms)
        {
            return _UHFAPI_GetAirDura(out onms, out offms);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Set rf tx cycle on-duty. The durations must meet the national regulation.
        //                : Tx duty를 설정합니다.
        //  Parameter     : speed ; must be a value of 10 to 100
        //                          the total cycle duration is maintained. 100 means maximum duration
        //  Return        : true = Success, false = fail
        //  Remark        : The on and off durations are caculated based on pre-defined national regulation.
        //                  ie, the calcalation is not accumulative.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SetAirDuty(UInt32 speed)
        {
            return _UHFAPI_SetAirDuty(speed);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get Tag EPC data.
        //                : 태그 Inventory 동작을 실행하여 EPC 데이터를 판독합니다.
        //  Parameter     : buffer 
        //                     Tag EPC data.
        //  				length
        //  				   Tag EPC data length
        //  Return        : true = Success, false = fail
        //  Remark        : This function is supported by data.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_Scan(out string buffer, out UInt32 length)
        {
            return _UHFAPI_Scan(out buffer, out length);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get the power state information.
        //                : 전원 상태를 불러옵니다. (Open이 안되는 경우 이 함수를 호출하여 전원 상태를 확인하시길 바랍니다.)
        //  Parameter     : state 
        //                      0 is OK
        //  				   -1 is Failed
        //  				   -2 is Invalid value
        //  				   -3 is Not Support
        //                     -4 is Low Battery
        //  				   -5 is Un-Known
        //  Return        : true = Success, false = fail
        //  Remark        : This function is supported by PDA battery state information.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GetPowerState(out int nPowerState)
        {
            return _UHFAPI_GetPowerState(out nPowerState);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get the oem version.
        //                : oem 버전을 불러옵니다.
        //  Parameter     : state 
        //                      ver is get oem version.
        //  Return        : true = Success, false = fail
        //  Remark        : This function is supported by oem version.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GetOemVersion(out string ver)
        {
            return _UHFAPI_GetOemVersion(out ver);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get the Module board serial version.
        //                : 모듈 시리얼 버전을 불러옵니다.
        //  Parameter     : state 
        //                      code_f - serial code 1
        //  					code_s - serial code 2
        //  					serial - serial number
        //  Return        : true = Success, false = fail
        //  Remark        : This function is supported to oem Seiral number.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GetSerialNumber(out string code_f, out string code_s, out string serial)
        {
            return _UHFAPI_GetSerialNumber(out code_f, out code_s, out serial);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get oem region info.
        //                : OEM 국가 정보를 불러옵니다.
        //  Parameter     : band is oem setting region.                    
        //  Return        : TCHAR *band, receive country name.
        //  Remark        : This function is supported to oem region info.
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GetOemRegionInfo(out string band)
        {
            return _UHFAPI_GetOemRegionInfo(out band);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : inventory tags for a given time
        //  Parameter     : TAG_OP_PARAM *param : operation parameters
        //                  wait_done : true means "DO NOT RETURN". return after all operations are done. 
        //                              And no message is posted to the host.
        //  Return        : operation result status refer to enumAccessResult. ACCESS_RESULT_OK is returned if operation is started.
        //  Remark        : use UHFAPI_GET_EPC() and/or UHFAPI_GET_RESULT_MESSAGE() on message reception to get the data or status.
        //                  The system could be locked if wait_done is selected but no stop condition is given.
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public bool UHFAPI_InventoryQ(TAG_OP_PARAM param, bool wait_done)
        {
            return _UHFAPI_InventoryQ(&param, wait_done);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Set EPC data packet mode.
        //  Parameter     : set : true is only epc data,
        //                        false is pc/epc data,
        //  Return        : true = Success, false = fail
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_OnlyEPC(bool set)
        {
            return _UHFAPI_SET_OnlyEPC(set);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Get EPC data packet mode.
        //  Parameter     : *get : true is only epc data,
        //                         false is pc/epc data,
        //  Return        : true = Success, false = fail
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_OnlyEPC(out bool set)
        {
            return _UHFAPI_GET_OnlyEPC(out set);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set output format type.
        //  Parameter     : enumFormatType type
        //                    FORMAT_HEX_STRING - epc data receive the hexa string.
        //                    FORMAT_ASCII_CODE - epc data receive the ASCII.(character)
        //  Return        : true = Success, false = fail
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_OuputFormat(enumFormatType type)
        {
            return _UHFAPI_SET_OuputFormat(type);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get output format type.
        //  Parameter     : enumFormatType type
        //                    FORMAT_HEX_STRING - epc data receive the hexa string.
        //                    FORMAT_ASCII_CODE - epc data receive the ASCII.(character)
        //  Return        : true = Success, false = fail
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_OuputFormat(out enumFormatType type)
        {
            return _UHFAPI_GET_OuputFormat(out type);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set registry of uhf configure value
        //                : UHF 모듈 설정 값을 레지스트리에 설정합니다.
        //  Parameter     : int max_msec, set tag operation time, from UHF registry.
        //                  BOOL singletag, set one tag detection, from UHF registry.
        //                  BOOL continuous, set mult tag detection, from UHF registry.
        //                  int duty, set tx duty, from UHF registry.
        //                  BOOL txpower, set tx power level, from UHF registry.
        //					BOOL buzzer, set buzzer, from UHF registry.
        //                  BOOL discardSameTag, set sametag, from UHF registry.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_UhfConfigure(int max_msec, bool singletag, bool continuous, int duty, int txpower, bool buzzer, bool discardSameTag)
        {
            return _UHFAPI_SET_UhfConfigure(max_msec, singletag, continuous, duty, txpower, buzzer, discardSameTag);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get registry of uhf configure value
        //                : UHF 레지스트리에 저장된 모듈 설정 값을 불러옵니다.
        //  Parameter     : int *max_msec, get tag operation time, from UHF registry.
        //                  BOOL *singletag, get one tag detection, from UHF registry.
        //                  BOOL *continuous, set mult tag detection, from UHF registry.
        //                  int *duty, get tx duty, from UHF registry.
        //                  BOOL *txpower, get tx power level, from UHF registry.
        //					BOOL *buzzer, get buzzer, from UHF registry.
        //                  BOOL *discardSameTag, get sametag, from UHF registry.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_UhfConfigure(out int max_msec, out bool singletag, out bool continuous, out int duty, out int txpower, out bool buzzer, out bool discardSameTag)
        {
            return _UHFAPI_GET_UhfConfigure(out max_msec, out singletag, out continuous, out duty, out txpower, out buzzer, out discardSameTag);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set registry of query value
        //                : query 값을 레지스트리에 설정합니다.
        //  Parameter     : BYTE Session, set the query session value, from uhf registry.
        //                  BYTE Target, set the query target value, from uhf registry.
        //                  UINT QValue, set the query Q value, from uhf registry.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_SET_RegParms(byte Session, byte Target, UInt32 QValue)
        {
            return _UHFAPI_SET_RegParms(Session, Target, QValue);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get registry of query value
        //                : query 설정 값을 레지스트리에 설정합니다.
        //  Parameter     : BYTE *Session, get the query session value, from uhf registry.
        //                  BYTE *Target, get the query target value, from uhf registry.
        //                  UINT *QValue, get the query Q value, from uhf registry.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool UHFAPI_GET_RegParms(out byte Session, out byte Target, out UInt32 QValue)
        {
            return _UHFAPI_GET_RegParms(out Session, out Target, out QValue);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : epc upload callback function
        //                : R900으로부터 전달된 epc 데이터를 콜백하는 함수입니다.
        //  Parameter     : string - inventoried epc data.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        internal unsafe UInt32 UploadCallback(string inv)
        {
            if (evtUploadEPC != null)
                evtUploadEPC(inv);
            return 0;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Upload inventoried data stored in R900 reader.
        //                : R900에 저장된 epc 데이터를 업로드 합니다.
        //  Parameter     : 
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public unsafe bool R900LIB_UploadInventory()
        {
            // upload all tag infomation
            if (evtUploadEPC == null)
                return false;

            UInt32 count = _UHFSUPAPI_OpenUploadInventoryList();
            if (count == 0)
                return false;

            for (UInt32 i = 0; i < count; i++)
            {
                char* p = _UHFSUPAPI_GetUploadInventoryData(i);
                if (p == null)
                {
                    _UHFSUPAPI_CloseUploadInventoryList();
                    return false;
                }
                UploadCallback(new string(p));
            }

            _UHFSUPAPI_CloseUploadInventoryList();

            return true;
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set auto off timeout value of the R900.
        //                : R900의 자동 전원 종료 시간을 설정합니다.
        //  Parameter     : value - auto off timeout in seconds to set.
        //                  nv - set to TRUE to keep the setting after power cycle.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool R900LIB_SetPowerOffDelay(UInt32 value, bool nv)
        {
            return _R900LIB_SetPowerOffDelay(value, nv);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get auto off timeout value of R900.
        //                : R900의 자동 전원 종료 시간을 가져옵니다.
        //  Parameter     : value - auto off timeout in seconds to set.
        //                  nv - set to TRUE to keep the setting after power cycle.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool R900LIB_GetPowerOffDelay(out UInt32 value)
        {
            return _R900LIB_GetPowerOffDelay(out value);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : set buzzer volume in the R900.
        //                : R900의 부저 볼퓸값을 설정합니다.
        //  Parameter     : value - buzzer volume to set.
        //                  nv - set to TRUE to keep the setting after power cycle.
        //                      0 is mute.
        //                      1 is low volume.
        //                      2 is high volume.                   
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool R900LIB_SetBuzzerVolume(UInt32 value, bool nv)
        {
            return _R900LIB_SetBuzzerVolume(value, nv);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : get buzzer volume in the R900.
        //                : R900의 부저 볼퓸값을 가져옵니다.
        //  Parameter     : value - auto off timeout in seconds to set.
        //                  nv - set to TRUE to keep the setting after power cycle.
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool R900LIB_GetBuzzerVolume(out UInt32 value)
        {
            return _R900LIB_GetBuzzerVolume(out value);
        }


        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Description   : Remove all tag data stored in the R900.
        //                : R900에 저장된 태그 정보를 지웁니다.
        //  Parameter     : 
        //  Return        : true = success, false = fail
        //  Protocol Type : EPC Gen2
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public bool R900LIB_ClearInventory()
        {
            return 0 == _UHFSUPAPI_ClearInventory();
        }

        #endregion
        //  end of User API Functions region

        // Struct region
        #region STRUCT

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   Mask bytes definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public struct typeSelectMask
        {
            public byte mskMemBank;	                // mem bank id for selection mask
            public UInt32 mskOffset;		        // mem bank bit offset for selection mask
            public UInt32 mskBits;		            // mem bank pattern bits for selection mask
            public fixed byte mskPattern[256 / 8];  // bit pattern for selection mask
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   select-mask definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        unsafe public struct typeSelectMaskEx
        {
            public byte SelectTarget;               // select target, 0=s0,1=s1,2=s2,3=s3,4=select flag
            public byte ActionCode;
            // select action
            //+-------+----------------------------+---------------------------+
            //|       | SelectTarget==SL           | SelectTarget==Inventoried |
            //|Action +----------------------------+-----------+---------------+
            //| Code  | matching    | non-matching | matching  | non-matching  |
            //+-------+-------------+--------------+-----------+---------------+
            //| 0     | Assert SL   | De-assert SL | ->A       | ->B           |
            //| 1     | Assert SL   | No Action    | ->A       | No Action     |
            //| 2     | No Action   | De-assert SL | No Action | ->B           |
            //| 3     | Negate SL   | No Action    | Negate    | No Action     |
            //| 4     | De-assert SL| Assert SL    | ->B       | ->A           |
            //| 5     | De-assert SL| No Action    | ->B       | No Action     |
            //| 6     | No Action   | Assert SL    | No Action | ->A           |
            //| 7     | No Action   | Negate SL    | No Action | Negate        |
            //+-------+-------------+--------------+-----------+---------------+
            public byte mskMemBank;                 // mem bank id for selection mask. it is one of the BANK_RESERVED,BANK_EPC,BANK_TID and BANK_USER.
            public UInt32 mskOffset;                // mem bank bit offset for selection mask
            public UInt32 mskBits;                  // mem bank pattern bits for selection mask
            public fixed byte mskPattern[1024 / 8];  // bit pattern for selection mask
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   tag operation parameter definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public struct TAG_OP_PARAM
        {
            public Int32 single_tag;		// access only 1 tag
            public Int32 QuerySelected;	// inventory only for selected tag
            public typeSelectMask mask; // select mask
            public UInt32 timeout;		// access timeout in [ms]
        }

        #endregion
        // end of Struct region

        // enum region
        #region ENUM

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  Reader Command
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum READER_COMMAND
        {
            READER_COMMAND_INVENTORY = 0x0000000F,
            READER_COMMAND_READ = 0x00000010,
            READER_COMMAND_WRITE = 0x00000011,
            READER_COMMAND_LOCK = 0x00000012,
            READER_COMMAND_KILL = 0x00000013,
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //  result message type
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum MSG_TYPE
        {
            MSG_TYPE_REPORT_ERROR,	// error report
            MSG_TYPE_ACCESS_EPC,	// EPC report from access operation
            MSG_TYPE_INV_EPC,		// EPC report from inventory operation
            MSG_TYPE_READ_DATA,		// read data from read access operation
            MSG_TYPE_ACCESS_RESULT, // han 2009.10.23
            MSG_TYPE_CMD_BEGIN,		// command begin report from module
            MSG_TYPE_CMD_END,		// command end report from module
            MSG_TYPE_CMD_INFO,		// informative data during command execution in the module
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   access result code
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum enumAccessResult
        {
            ACCESS_RESULT_OK = 0,
            ACCESS_RESULT_NOT_CONNECTED = -1,
            ACCESS_RESULT_NOT_DETECT = -2,
            ACCESS_RESULT_ACCESS_ERROR = -3,
            // command finished with error, see error message string for details
            ACCESS_RESULT_NOT_OPENED = -4,
            ACCESS_RESULT_INVALID_PARAMETER = -5,
            // command terminated by invalid parameter
            ACCESS_RESULT_COMMAND_ERROR = -6,
            // command terminated by device error
            ACCESS_RESULT_LOW_BATTERY = -7,
            ACCESS_RESULT_Unknown = -8,
            ACCESS_RESULT_NOT_SUPPORTED = -9,
            // the command is not supported by this device
            ACCESS_RESULT_STOPPED = -10,
            ACCESS_RESULT_POWER_OFF = -11,
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   report mode bit field definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum enumReportMode
        {
            REPORT_MODE_WAIT_DONE = 1,
            // default disabled; do not return API function until operation is finished. No message are generated
            REPORT_MODE_ACCESS_EPC = 2,
            // default enabled; do not generate message for the EPC report. EPC can be read when operation is finished successfully
            REPORT_MODE_EXTENDED_INFORMATION = 4,
            // default disabled; report epc with additional auxiliary information
            REPORT_MODE_BATTERY_FAULT = 8,
            // default enabled; check battery fault
            REPORT_MODE_THREAD_MESSAGE = 16,
            // default disabled; application handle is thread id. use thread message for message 
            REPORT_MODE_NO_EPC_CRC = 32,
            // default enabled; do not report crc word for epc
            REPORT_MODE_RFTX_INFO = 64,
            // default disabled; for administrator use only
            REPORT_MODE_RSSI_TRACE = 128,
            // default disabled; minimize delay for rssi trace
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   Output Format type definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum enumFormatType
        {
            FORMAT_HEX_STRING = 0,
            // default enabled; EPC data receive the hexa string.
            FORMAT_ASCII_CODE = 1,
            // default disabled; EPC data receive the ASCII.(character)
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   Lock Mask bits definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum typeLockMasks
        {
            LM_KILL_PWD_RW_LOCK = 1 << 9,
            LM_KILL_PWD_PERM_LOCK = 1 << 8,
            LM_ACCESS_PWD_RW_LOCK = 1 << 7,
            LM_ACCESS_PWD_PERM_LOCK = 1 << 6,
            LM_EPC_MEM_RW_LOCK = 1 << 5,
            LM_EPC_MEM_PERM_LOCK = 1 << 4,
            LM_TID_MEM_RW_LOCK = 1 << 3,
            LM_TID_MEM_PERM_LOCK = 1 << 2,
            LM_USER_MEM_RW_LOCK = 1 << 1,
            LM_USER_MEM_PERM_LOCK = 1 << 0,
        }

        //┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //   Tag Memory definition
        //┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        public enum MEMBANK_CODE
        {
            BANK_RESERVED = 0x0,
            BANK_EPC = 0x1,
            BANK_TID = 0x2,
            BANK_USER = 0x3
        }

        #endregion
        // end of enum region

        // sound region
        #region  PlaySound
        [DllImport("coredll.dll")]
        private static extern int PlaySound(string szSound, IntPtr hModule, int flags);
        private enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0,     // play synchronously (default)
            SND_ASYNC = 0x1,    // play asynchronously
            SND_NODEFAULT = 0x2,    // silence (!default) if sound not found
            SND_MEMORY = 0x4,       // pszSound points to a memory file
            SND_LOOP = 0x8,     // loop the sound until next sndPlaySound
            SND_NOSTOP = 0x10,      // don't stop any currently playing sound
            SND_NOWAIT = 0x2000,    // don't wait if the driver is busy
            SND_ALIAS = 0x10000,    // name is a registry alias
            SND_ALIAS_ID = 0x110000,// alias is a predefined ID
            SND_FILENAME = 0x20000, // name is file name
            SND_RESOURCE = 0x40004, // name is resource name or atom
        };
        public static void PlaySound(string fileName)
        {
            PlaySound(fileName, IntPtr.Zero, (int)(PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC | PlaySoundFlags.SND_NOSTOP));
        }
        public static void PlaySuccess()
        {
            PlaySound(@"\Windows\Success.wav", IntPtr.Zero, (int)(PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC | PlaySoundFlags.SND_NOSTOP));
        }
        public static void PlayFail()
        {
            PlaySound(@"\Windows\fail.wav", IntPtr.Zero, (int)(PlaySoundFlags.SND_FILENAME | PlaySoundFlags.SND_ASYNC | PlaySoundFlags.SND_NOSTOP));
        }
        #endregion
        // end of sound region

    }
}
