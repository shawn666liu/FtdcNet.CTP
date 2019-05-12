/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2019/5/12 13:31:52
/////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CTP
{
    [System.Security.SuppressUnmanagedCodeSecurity]
    static unsafe class Interop
    {
        static Interop()
        {
            string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dir = Path.Combine(assemblyDirectory, Environment.Is64BitProcess ? "x64" : "x86");
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                // Can't work, since LD_LIBRARY_PATH will not reload 
                Environment.SetEnvironmentVariable("LD_LIBRARY_PATH", dir + ":" + Environment.GetEnvironmentVariable("LD_LIBRARY_PATH"));
            else
                Environment.SetEnvironmentVariable("PATH", dir + ";" + Environment.GetEnvironmentVariable("PATH"));
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnErrRtnEvent(IntPtr pObject, EnumOnErrRtnType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnFrontEvent(IntPtr pObject, EnumOnFrontType type, int nReason);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnRspEvent(IntPtr pObject, EnumOnRspType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.I1)] bool bIsLast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnRtnEvent(IntPtr pObject, EnumOnRtnType type, IntPtr pParam);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterCallback(IntPtr pApi, CbOnFrontEvent c1, CbOnRspEvent c2, CbOnRtnEvent c3, IntPtr pObject);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterCallback(IntPtr pApi, CbOnErrRtnEvent c1, CbOnFrontEvent c2, CbOnRspEvent c3, CbOnRtnEvent c4, IntPtr pObject);


        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CTPGetSystemInfo([MarshalAs(UnmanagedType.LPArray)] byte[] pSystemInfo, ref int nLen);


        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdCreateApi(string pszFlowPath, bool bIsUsingUdp, bool bIsMulticast);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdGetApiVersion();

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdDestroyApi(IntPtr pApi);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdInit(IntPtr pApi);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdGetTradingDay(IntPtr pApi);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterFront(IntPtr pApi, string pszFrontAddress);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterNameServer(IntPtr pApi, string pszNsAddress);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterFensUserInfo(IntPtr pApi, ThostFtdcFensUserInfoField pFensUserInfo);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdSubscribeMarketData(IntPtr pApi, string[] ppInstrumentID, int nCount);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdUnSubscribeMarketData(IntPtr pApi, string[] ppInstrumentID, int nCount);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdSubscribeForQuoteRsp(IntPtr pApi, string[] ppInstrumentID, int nCount);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdUnSubscribeForQuoteRsp(IntPtr pApi, string[] ppInstrumentID, int nCount);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUserLogin(IntPtr pApi, ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUserLogout(IntPtr pApi, ThostFtdcUserLogoutField pUserLogout, int nRequestID);



        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdCreateApi(string pszFlowPath);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdGetApiVersion();

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdDestroyApi(IntPtr pApi);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdInit(IntPtr pApi);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdGetTradingDay(IntPtr pApi);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterFront(IntPtr pApi, string pszFrontAddress);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterNameServer(IntPtr pApi, string pszNsAddress);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterFensUserInfo(IntPtr pApi, ThostFtdcFensUserInfoField pFensUserInfo);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribePrivateTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribePublicTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqAuthenticate(IntPtr pApi, ThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdRegisterUserSystemInfo(IntPtr pApi, ThostFtdcUserSystemInfoField pUserSystemInfo);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdSubmitUserSystemInfo(IntPtr pApi, ThostFtdcUserSystemInfoField pUserSystemInfo);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLogin(IntPtr pApi, ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLogout(IntPtr pApi, ThostFtdcUserLogoutField pUserLogout, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserPasswordUpdate(IntPtr pApi, ThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqTradingAccountPasswordUpdate(IntPtr pApi, ThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserAuthMethod(IntPtr pApi, ThostFtdcReqUserAuthMethodField pReqUserAuthMethod, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqGenUserCaptcha(IntPtr pApi, ThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqGenUserText(IntPtr pApi, ThostFtdcReqGenUserTextField pReqGenUserText, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLoginWithCaptcha(IntPtr pApi, ThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLoginWithText(IntPtr pApi, ThostFtdcReqUserLoginWithTextField pReqUserLoginWithText, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLoginWithOTP(IntPtr pApi, ThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOrderInsert(IntPtr pApi, ThostFtdcInputOrderField pInputOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqParkedOrderInsert(IntPtr pApi, ThostFtdcParkedOrderField pParkedOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqParkedOrderAction(IntPtr pApi, ThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOrderAction(IntPtr pApi, ThostFtdcInputOrderActionField pInputOrderAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQueryMaxOrderVolume(IntPtr pApi, ThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqSettlementInfoConfirm(IntPtr pApi, ThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqRemoveParkedOrder(IntPtr pApi, ThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqRemoveParkedOrderAction(IntPtr pApi, ThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqExecOrderInsert(IntPtr pApi, ThostFtdcInputExecOrderField pInputExecOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqExecOrderAction(IntPtr pApi, ThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqForQuoteInsert(IntPtr pApi, ThostFtdcInputForQuoteField pInputForQuote, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQuoteInsert(IntPtr pApi, ThostFtdcInputQuoteField pInputQuote, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQuoteAction(IntPtr pApi, ThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqBatchOrderAction(IntPtr pApi, ThostFtdcInputBatchOrderActionField pInputBatchOrderAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOptionSelfCloseInsert(IntPtr pApi, ThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOptionSelfCloseAction(IntPtr pApi, ThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqCombActionInsert(IntPtr pApi, ThostFtdcInputCombActionField pInputCombAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOrder(IntPtr pApi, ThostFtdcQryOrderField pQryOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTrade(IntPtr pApi, ThostFtdcQryTradeField pQryTrade, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPosition(IntPtr pApi, ThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTradingAccount(IntPtr pApi, ThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestor(IntPtr pApi, ThostFtdcQryInvestorField pQryInvestor, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTradingCode(IntPtr pApi, ThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInstrumentMarginRate(IntPtr pApi, ThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInstrumentCommissionRate(IntPtr pApi, ThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExchange(IntPtr pApi, ThostFtdcQryExchangeField pQryExchange, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryProduct(IntPtr pApi, ThostFtdcQryProductField pQryProduct, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInstrument(IntPtr pApi, ThostFtdcQryInstrumentField pQryInstrument, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryDepthMarketData(IntPtr pApi, ThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySettlementInfo(IntPtr pApi, ThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTransferBank(IntPtr pApi, ThostFtdcQryTransferBankField pQryTransferBank, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPositionDetail(IntPtr pApi, ThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryNotice(IntPtr pApi, ThostFtdcQryNoticeField pQryNotice, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySettlementInfoConfirm(IntPtr pApi, ThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPositionCombineDetail(IntPtr pApi, ThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCFMMCTradingAccountKey(IntPtr pApi, ThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryEWarrantOffset(IntPtr pApi, ThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorProductGroupMargin(IntPtr pApi, ThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExchangeMarginRate(IntPtr pApi, ThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExchangeMarginRateAdjust(IntPtr pApi, ThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExchangeRate(IntPtr pApi, ThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecAgentACIDMap(IntPtr pApi, ThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryProductExchRate(IntPtr pApi, ThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryProductGroup(IntPtr pApi, ThostFtdcQryProductGroupField pQryProductGroup, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryMMInstrumentCommissionRate(IntPtr pApi, ThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryMMOptionInstrCommRate(IntPtr pApi, ThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInstrumentOrderCommRate(IntPtr pApi, ThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecAgentTradingAccount(IntPtr pApi, ThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecAgentCheckMode(IntPtr pApi, ThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecAgentTradeInfo(IntPtr pApi, ThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOptionInstrTradeCost(IntPtr pApi, ThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOptionInstrCommRate(IntPtr pApi, ThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExecOrder(IntPtr pApi, ThostFtdcQryExecOrderField pQryExecOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryForQuote(IntPtr pApi, ThostFtdcQryForQuoteField pQryForQuote, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryQuote(IntPtr pApi, ThostFtdcQryQuoteField pQryQuote, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOptionSelfClose(IntPtr pApi, ThostFtdcQryOptionSelfCloseField pQryOptionSelfClose, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestUnit(IntPtr pApi, ThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCombInstrumentGuard(IntPtr pApi, ThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCombAction(IntPtr pApi, ThostFtdcQryCombActionField pQryCombAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTransferSerial(IntPtr pApi, ThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryAccountregister(IntPtr pApi, ThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryContractBank(IntPtr pApi, ThostFtdcQryContractBankField pQryContractBank, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryParkedOrder(IntPtr pApi, ThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryParkedOrderAction(IntPtr pApi, ThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTradingNotice(IntPtr pApi, ThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryBrokerTradingParams(IntPtr pApi, ThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryBrokerTradingAlgos(IntPtr pApi, ThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQueryCFMMCTradingAccountToken(IntPtr pApi, ThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqFromBankToFutureByFuture(IntPtr pApi, ThostFtdcReqTransferField pReqTransfer, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqFromFutureToBankByFuture(IntPtr pApi, ThostFtdcReqTransferField pReqTransfer, int nRequestID);

        [DllImport("ftdc2c_ctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQueryBankAccountMoneyByFuture(IntPtr pApi, ThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID);


    }
}

