/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2019/5/12 13:31:52
/////////////////////////////////////////////////////////////////////////



using System;
using System.Runtime.InteropServices;


namespace CTP
{
    /// <summary>
    /// 交易接口
    /// </summary>
    public class FtdcTdAdapter : IDisposable
    {
        /// <summary>
        /// Native Object Pointer
        /// </summary>
        public IntPtr Handle { get; private set; }

        /// <summary>
        /// 处理所有的OnErrRtn****回调事件
        /// </summary>
        public event OnErrRtnEventHandler OnErrRtnEvent;

        /// <summary>
        /// 处理所有的OnFront****回调事件
        /// </summary>
        public event OnFrontEventHandler OnFrontEvent;

        /// <summary>
        /// 处理所有的OnRsp****回调事件
        /// </summary>
        public event OnRspEventHandler OnRspEvent;

        /// <summary>
        /// 处理所有的OnRtn****回调事件
        /// </summary>
        public event OnRtnEventHandler OnRtnEvent;


        /// <summary>
        /// pSystemInfo至少分配273字节,建议512
        /// </summary>
        /// <param name="pSystemInfo" ></param>
        /// <param name="nLen" > 获取到的采集信息的长度</param>
        /// <returns>0 为正确，非0为错误</returns>
        public static int CTP_GetSystemInfo(byte[] pSystemInfo, ref int nLen)
        {
            return Interop.CTPGetSystemInfo(pSystemInfo, ref nLen);
        }
        /// <summary>
        ///创建TraderApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        /// </summary>
        public FtdcTdAdapter(string pszFlowPath)
        {
            Handle = Interop.TdCreateApi(pszFlowPath);
            if (Handle == IntPtr.Zero)
                throw new Exception("TdCreateApi Failed!");
            this.CbOnErrRtnDelegate = this.CbOnErrRtnFunc;
            this.CbOnFrontDelegate = this.CbOnFrontFunc;
            this.CbOnRspDelegate = this.CbOnRspFunc;
            this.CbOnRtnDelegate = this.CbOnRtnFunc;
            Interop.TdRegisterCallback(Handle, this.CbOnErrRtnDelegate, this.CbOnFrontDelegate, this.CbOnRspDelegate, this.CbOnRtnDelegate, IntPtr.Zero);
        }


        /// <summary>
        ///获取API的版本信息
        ///@retrun 获取到的版本号
        /// </summary>
        public static string GetApiVersion()
        {
            return Marshal.PtrToStringAnsi(Interop.TdGetApiVersion());
        }

        /// <summary>
        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        /// </summary>
        public void Release()
        {
            if (Handle != IntPtr.Zero)
            {
                Interop.TdDestroyApi(Handle);
                Handle = IntPtr.Zero;
            }
        }

        /// <summary>
        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        /// </summary>
        public void Init()
        {
            Interop.TdInit(Handle);
        }

        /// <summary>
        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        /// </summary>
        public string GetTradingDay()
        {
            return Marshal.PtrToStringAnsi(Interop.TdGetTradingDay(Handle));
        }

        /// <summary>
        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        /// </summary>
        public void RegisterFront(string pszFrontAddress)
        {
            Interop.TdRegisterFront(Handle, pszFrontAddress);
        }

        /// <summary>
        ///注册名字服务器网络地址
        ///@param pszNsAddress：名字服务器网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
        ///@remark RegisterNameServer优先于RegisterFront
        /// </summary>
        public void RegisterNameServer(string pszNsAddress)
        {
            Interop.TdRegisterNameServer(Handle, pszNsAddress);
        }

        /// <summary>
        ///注册名字服务器用户信息
        ///@param pFensUserInfo：用户信息。
        /// </summary>
        public void RegisterFensUserInfo(ThostFtdcFensUserInfoField pFensUserInfo)
        {
            Interop.TdRegisterFensUserInfo(Handle, pFensUserInfo);
        }

        /// <summary>
        ///订阅私有流。
        ///@param nResumeType 私有流重传方式
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后私有流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
        /// </summary>
        public void SubscribePrivateTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribePrivateTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///订阅公共流。
        ///@param nResumeType 公共流重传方式
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后公共流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
        /// </summary>
        public void SubscribePublicTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribePublicTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///客户端认证请求
        /// </summary>
        public int ReqAuthenticate(ThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID)
        {
            return Interop.TdReqAuthenticate(Handle, pReqAuthenticateField, nRequestID);
        }

        /// <summary>
        ///注册用户终端信息，用于中继服务器多连接模式
        ///需要在终端认证成功后，用户登录前调用该接口
        /// </summary>
        public int RegisterUserSystemInfo(ThostFtdcUserSystemInfoField pUserSystemInfo)
        {
            return Interop.TdRegisterUserSystemInfo(Handle, pUserSystemInfo);
        }

        /// <summary>
        ///上报用户终端信息，用于中继服务器操作员登录模式
        ///操作员登录后，可以多次调用该接口上报客户信息
        /// </summary>
        public int SubmitUserSystemInfo(ThostFtdcUserSystemInfoField pUserSystemInfo)
        {
            return Interop.TdSubmitUserSystemInfo(Handle, pUserSystemInfo);
        }

        /// <summary>
        ///用户登录请求
        /// </summary>
        public int ReqUserLogin(ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            return Interop.TdReqUserLogin(Handle, pReqUserLoginField, nRequestID);
        }

        /// <summary>
        ///登出请求
        /// </summary>
        public int ReqUserLogout(ThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            return Interop.TdReqUserLogout(Handle, pUserLogout, nRequestID);
        }

        /// <summary>
        ///用户口令更新请求
        /// </summary>
        public int ReqUserPasswordUpdate(ThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
        {
            return Interop.TdReqUserPasswordUpdate(Handle, pUserPasswordUpdate, nRequestID);
        }

        /// <summary>
        ///资金账户口令更新请求
        /// </summary>
        public int ReqTradingAccountPasswordUpdate(ThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID)
        {
            return Interop.TdReqTradingAccountPasswordUpdate(Handle, pTradingAccountPasswordUpdate, nRequestID);
        }

        /// <summary>
        ///查询用户当前支持的认证模式
        /// </summary>
        public int ReqUserAuthMethod(ThostFtdcReqUserAuthMethodField pReqUserAuthMethod, int nRequestID)
        {
            return Interop.TdReqUserAuthMethod(Handle, pReqUserAuthMethod, nRequestID);
        }

        /// <summary>
        ///用户发出获取图形验证码请求
        /// </summary>
        public int ReqGenUserCaptcha(ThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha, int nRequestID)
        {
            return Interop.TdReqGenUserCaptcha(Handle, pReqGenUserCaptcha, nRequestID);
        }

        /// <summary>
        ///用户发出获取短信验证码请求
        /// </summary>
        public int ReqGenUserText(ThostFtdcReqGenUserTextField pReqGenUserText, int nRequestID)
        {
            return Interop.TdReqGenUserText(Handle, pReqGenUserText, nRequestID);
        }

        /// <summary>
        ///用户发出带有图片验证码的登陆请求
        /// </summary>
        public int ReqUserLoginWithCaptcha(ThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha, int nRequestID)
        {
            return Interop.TdReqUserLoginWithCaptcha(Handle, pReqUserLoginWithCaptcha, nRequestID);
        }

        /// <summary>
        ///用户发出带有短信验证码的登陆请求
        /// </summary>
        public int ReqUserLoginWithText(ThostFtdcReqUserLoginWithTextField pReqUserLoginWithText, int nRequestID)
        {
            return Interop.TdReqUserLoginWithText(Handle, pReqUserLoginWithText, nRequestID);
        }

        /// <summary>
        ///用户发出带有动态口令的登陆请求
        /// </summary>
        public int ReqUserLoginWithOTP(ThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP, int nRequestID)
        {
            return Interop.TdReqUserLoginWithOTP(Handle, pReqUserLoginWithOTP, nRequestID);
        }

        /// <summary>
        ///报单录入请求
        /// </summary>
        public int ReqOrderInsert(ThostFtdcInputOrderField pInputOrder, int nRequestID)
        {
            return Interop.TdReqOrderInsert(Handle, pInputOrder, nRequestID);
        }

        /// <summary>
        ///预埋单录入请求
        /// </summary>
        public int ReqParkedOrderInsert(ThostFtdcParkedOrderField pParkedOrder, int nRequestID)
        {
            return Interop.TdReqParkedOrderInsert(Handle, pParkedOrder, nRequestID);
        }

        /// <summary>
        ///预埋撤单录入请求
        /// </summary>
        public int ReqParkedOrderAction(ThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID)
        {
            return Interop.TdReqParkedOrderAction(Handle, pParkedOrderAction, nRequestID);
        }

        /// <summary>
        ///报单操作请求
        /// </summary>
        public int ReqOrderAction(ThostFtdcInputOrderActionField pInputOrderAction, int nRequestID)
        {
            return Interop.TdReqOrderAction(Handle, pInputOrderAction, nRequestID);
        }

        /// <summary>
        ///查询最大报单数量请求
        /// </summary>
        public int ReqQueryMaxOrderVolume(ThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID)
        {
            return Interop.TdReqQueryMaxOrderVolume(Handle, pQueryMaxOrderVolume, nRequestID);
        }

        /// <summary>
        ///投资者结算结果确认
        /// </summary>
        public int ReqSettlementInfoConfirm(ThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID)
        {
            return Interop.TdReqSettlementInfoConfirm(Handle, pSettlementInfoConfirm, nRequestID);
        }

        /// <summary>
        ///请求删除预埋单
        /// </summary>
        public int ReqRemoveParkedOrder(ThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID)
        {
            return Interop.TdReqRemoveParkedOrder(Handle, pRemoveParkedOrder, nRequestID);
        }

        /// <summary>
        ///请求删除预埋撤单
        /// </summary>
        public int ReqRemoveParkedOrderAction(ThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID)
        {
            return Interop.TdReqRemoveParkedOrderAction(Handle, pRemoveParkedOrderAction, nRequestID);
        }

        /// <summary>
        ///执行宣告录入请求
        /// </summary>
        public int ReqExecOrderInsert(ThostFtdcInputExecOrderField pInputExecOrder, int nRequestID)
        {
            return Interop.TdReqExecOrderInsert(Handle, pInputExecOrder, nRequestID);
        }

        /// <summary>
        ///执行宣告操作请求
        /// </summary>
        public int ReqExecOrderAction(ThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID)
        {
            return Interop.TdReqExecOrderAction(Handle, pInputExecOrderAction, nRequestID);
        }

        /// <summary>
        ///询价录入请求
        /// </summary>
        public int ReqForQuoteInsert(ThostFtdcInputForQuoteField pInputForQuote, int nRequestID)
        {
            return Interop.TdReqForQuoteInsert(Handle, pInputForQuote, nRequestID);
        }

        /// <summary>
        ///报价录入请求
        /// </summary>
        public int ReqQuoteInsert(ThostFtdcInputQuoteField pInputQuote, int nRequestID)
        {
            return Interop.TdReqQuoteInsert(Handle, pInputQuote, nRequestID);
        }

        /// <summary>
        ///报价操作请求
        /// </summary>
        public int ReqQuoteAction(ThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID)
        {
            return Interop.TdReqQuoteAction(Handle, pInputQuoteAction, nRequestID);
        }

        /// <summary>
        ///批量报单操作请求
        /// </summary>
        public int ReqBatchOrderAction(ThostFtdcInputBatchOrderActionField pInputBatchOrderAction, int nRequestID)
        {
            return Interop.TdReqBatchOrderAction(Handle, pInputBatchOrderAction, nRequestID);
        }

        /// <summary>
        ///期权自对冲录入请求
        /// </summary>
        public int ReqOptionSelfCloseInsert(ThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, int nRequestID)
        {
            return Interop.TdReqOptionSelfCloseInsert(Handle, pInputOptionSelfClose, nRequestID);
        }

        /// <summary>
        ///期权自对冲操作请求
        /// </summary>
        public int ReqOptionSelfCloseAction(ThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction, int nRequestID)
        {
            return Interop.TdReqOptionSelfCloseAction(Handle, pInputOptionSelfCloseAction, nRequestID);
        }

        /// <summary>
        ///申请组合录入请求
        /// </summary>
        public int ReqCombActionInsert(ThostFtdcInputCombActionField pInputCombAction, int nRequestID)
        {
            return Interop.TdReqCombActionInsert(Handle, pInputCombAction, nRequestID);
        }

        /// <summary>
        ///请求查询报单
        /// </summary>
        public int ReqQryOrder(ThostFtdcQryOrderField pQryOrder, int nRequestID)
        {
            return Interop.TdReqQryOrder(Handle, pQryOrder, nRequestID);
        }

        /// <summary>
        ///请求查询成交
        /// </summary>
        public int ReqQryTrade(ThostFtdcQryTradeField pQryTrade, int nRequestID)
        {
            return Interop.TdReqQryTrade(Handle, pQryTrade, nRequestID);
        }

        /// <summary>
        ///请求查询投资者持仓
        /// </summary>
        public int ReqQryInvestorPosition(ThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorPosition(Handle, pQryInvestorPosition, nRequestID);
        }

        /// <summary>
        ///请求查询资金账户
        /// </summary>
        public int ReqQryTradingAccount(ThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
            return Interop.TdReqQryTradingAccount(Handle, pQryTradingAccount, nRequestID);
        }

        /// <summary>
        ///请求查询投资者
        /// </summary>
        public int ReqQryInvestor(ThostFtdcQryInvestorField pQryInvestor, int nRequestID)
        {
            return Interop.TdReqQryInvestor(Handle, pQryInvestor, nRequestID);
        }

        /// <summary>
        ///请求查询交易编码
        /// </summary>
        public int ReqQryTradingCode(ThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
        {
            return Interop.TdReqQryTradingCode(Handle, pQryTradingCode, nRequestID);
        }

        /// <summary>
        ///请求查询合约保证金率
        /// </summary>
        public int ReqQryInstrumentMarginRate(ThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID)
        {
            return Interop.TdReqQryInstrumentMarginRate(Handle, pQryInstrumentMarginRate, nRequestID);
        }

        /// <summary>
        ///请求查询合约手续费率
        /// </summary>
        public int ReqQryInstrumentCommissionRate(ThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID)
        {
            return Interop.TdReqQryInstrumentCommissionRate(Handle, pQryInstrumentCommissionRate, nRequestID);
        }

        /// <summary>
        ///请求查询交易所
        /// </summary>
        public int ReqQryExchange(ThostFtdcQryExchangeField pQryExchange, int nRequestID)
        {
            return Interop.TdReqQryExchange(Handle, pQryExchange, nRequestID);
        }

        /// <summary>
        ///请求查询产品
        /// </summary>
        public int ReqQryProduct(ThostFtdcQryProductField pQryProduct, int nRequestID)
        {
            return Interop.TdReqQryProduct(Handle, pQryProduct, nRequestID);
        }

        /// <summary>
        ///请求查询合约
        /// </summary>
        public int ReqQryInstrument(ThostFtdcQryInstrumentField pQryInstrument, int nRequestID)
        {
            return Interop.TdReqQryInstrument(Handle, pQryInstrument, nRequestID);
        }

        /// <summary>
        ///请求查询行情
        /// </summary>
        public int ReqQryDepthMarketData(ThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID)
        {
            return Interop.TdReqQryDepthMarketData(Handle, pQryDepthMarketData, nRequestID);
        }

        /// <summary>
        ///请求查询投资者结算结果
        /// </summary>
        public int ReqQrySettlementInfo(ThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID)
        {
            return Interop.TdReqQrySettlementInfo(Handle, pQrySettlementInfo, nRequestID);
        }

        /// <summary>
        ///请求查询转帐银行
        /// </summary>
        public int ReqQryTransferBank(ThostFtdcQryTransferBankField pQryTransferBank, int nRequestID)
        {
            return Interop.TdReqQryTransferBank(Handle, pQryTransferBank, nRequestID);
        }

        /// <summary>
        ///请求查询投资者持仓明细
        /// </summary>
        public int ReqQryInvestorPositionDetail(ThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID)
        {
            return Interop.TdReqQryInvestorPositionDetail(Handle, pQryInvestorPositionDetail, nRequestID);
        }

        /// <summary>
        ///请求查询客户通知
        /// </summary>
        public int ReqQryNotice(ThostFtdcQryNoticeField pQryNotice, int nRequestID)
        {
            return Interop.TdReqQryNotice(Handle, pQryNotice, nRequestID);
        }

        /// <summary>
        ///请求查询结算信息确认
        /// </summary>
        public int ReqQrySettlementInfoConfirm(ThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID)
        {
            return Interop.TdReqQrySettlementInfoConfirm(Handle, pQrySettlementInfoConfirm, nRequestID);
        }

        /// <summary>
        ///请求查询投资者持仓明细
        /// </summary>
        public int ReqQryInvestorPositionCombineDetail(ThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID)
        {
            return Interop.TdReqQryInvestorPositionCombineDetail(Handle, pQryInvestorPositionCombineDetail, nRequestID);
        }

        /// <summary>
        ///请求查询保证金监管系统经纪公司资金账户密钥
        /// </summary>
        public int ReqQryCFMMCTradingAccountKey(ThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID)
        {
            return Interop.TdReqQryCFMMCTradingAccountKey(Handle, pQryCFMMCTradingAccountKey, nRequestID);
        }

        /// <summary>
        ///请求查询仓单折抵信息
        /// </summary>
        public int ReqQryEWarrantOffset(ThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID)
        {
            return Interop.TdReqQryEWarrantOffset(Handle, pQryEWarrantOffset, nRequestID);
        }

        /// <summary>
        ///请求查询投资者品种/跨品种保证金
        /// </summary>
        public int ReqQryInvestorProductGroupMargin(ThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID)
        {
            return Interop.TdReqQryInvestorProductGroupMargin(Handle, pQryInvestorProductGroupMargin, nRequestID);
        }

        /// <summary>
        ///请求查询交易所保证金率
        /// </summary>
        public int ReqQryExchangeMarginRate(ThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID)
        {
            return Interop.TdReqQryExchangeMarginRate(Handle, pQryExchangeMarginRate, nRequestID);
        }

        /// <summary>
        ///请求查询交易所调整保证金率
        /// </summary>
        public int ReqQryExchangeMarginRateAdjust(ThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust, int nRequestID)
        {
            return Interop.TdReqQryExchangeMarginRateAdjust(Handle, pQryExchangeMarginRateAdjust, nRequestID);
        }

        /// <summary>
        ///请求查询汇率
        /// </summary>
        public int ReqQryExchangeRate(ThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID)
        {
            return Interop.TdReqQryExchangeRate(Handle, pQryExchangeRate, nRequestID);
        }

        /// <summary>
        ///请求查询二级代理操作员银期权限
        /// </summary>
        public int ReqQrySecAgentACIDMap(ThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID)
        {
            return Interop.TdReqQrySecAgentACIDMap(Handle, pQrySecAgentACIDMap, nRequestID);
        }

        /// <summary>
        ///请求查询产品报价汇率
        /// </summary>
        public int ReqQryProductExchRate(ThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID)
        {
            return Interop.TdReqQryProductExchRate(Handle, pQryProductExchRate, nRequestID);
        }

        /// <summary>
        ///请求查询产品组
        /// </summary>
        public int ReqQryProductGroup(ThostFtdcQryProductGroupField pQryProductGroup, int nRequestID)
        {
            return Interop.TdReqQryProductGroup(Handle, pQryProductGroup, nRequestID);
        }

        /// <summary>
        ///请求查询做市商合约手续费率
        /// </summary>
        public int ReqQryMMInstrumentCommissionRate(ThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate, int nRequestID)
        {
            return Interop.TdReqQryMMInstrumentCommissionRate(Handle, pQryMMInstrumentCommissionRate, nRequestID);
        }

        /// <summary>
        ///请求查询做市商期权合约手续费
        /// </summary>
        public int ReqQryMMOptionInstrCommRate(ThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate, int nRequestID)
        {
            return Interop.TdReqQryMMOptionInstrCommRate(Handle, pQryMMOptionInstrCommRate, nRequestID);
        }

        /// <summary>
        ///请求查询报单手续费
        /// </summary>
        public int ReqQryInstrumentOrderCommRate(ThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate, int nRequestID)
        {
            return Interop.TdReqQryInstrumentOrderCommRate(Handle, pQryInstrumentOrderCommRate, nRequestID);
        }

        /// <summary>
        ///请求查询资金账户
        /// </summary>
        public int ReqQrySecAgentTradingAccount(ThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
            return Interop.TdReqQrySecAgentTradingAccount(Handle, pQryTradingAccount, nRequestID);
        }

        /// <summary>
        ///请求查询二级代理商资金校验模式
        /// </summary>
        public int ReqQrySecAgentCheckMode(ThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode, int nRequestID)
        {
            return Interop.TdReqQrySecAgentCheckMode(Handle, pQrySecAgentCheckMode, nRequestID);
        }

        /// <summary>
        ///请求查询二级代理商信息
        /// </summary>
        public int ReqQrySecAgentTradeInfo(ThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo, int nRequestID)
        {
            return Interop.TdReqQrySecAgentTradeInfo(Handle, pQrySecAgentTradeInfo, nRequestID);
        }

        /// <summary>
        ///请求查询期权交易成本
        /// </summary>
        public int ReqQryOptionInstrTradeCost(ThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost, int nRequestID)
        {
            return Interop.TdReqQryOptionInstrTradeCost(Handle, pQryOptionInstrTradeCost, nRequestID);
        }

        /// <summary>
        ///请求查询期权合约手续费
        /// </summary>
        public int ReqQryOptionInstrCommRate(ThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate, int nRequestID)
        {
            return Interop.TdReqQryOptionInstrCommRate(Handle, pQryOptionInstrCommRate, nRequestID);
        }

        /// <summary>
        ///请求查询执行宣告
        /// </summary>
        public int ReqQryExecOrder(ThostFtdcQryExecOrderField pQryExecOrder, int nRequestID)
        {
            return Interop.TdReqQryExecOrder(Handle, pQryExecOrder, nRequestID);
        }

        /// <summary>
        ///请求查询询价
        /// </summary>
        public int ReqQryForQuote(ThostFtdcQryForQuoteField pQryForQuote, int nRequestID)
        {
            return Interop.TdReqQryForQuote(Handle, pQryForQuote, nRequestID);
        }

        /// <summary>
        ///请求查询报价
        /// </summary>
        public int ReqQryQuote(ThostFtdcQryQuoteField pQryQuote, int nRequestID)
        {
            return Interop.TdReqQryQuote(Handle, pQryQuote, nRequestID);
        }

        /// <summary>
        ///请求查询期权自对冲
        /// </summary>
        public int ReqQryOptionSelfClose(ThostFtdcQryOptionSelfCloseField pQryOptionSelfClose, int nRequestID)
        {
            return Interop.TdReqQryOptionSelfClose(Handle, pQryOptionSelfClose, nRequestID);
        }

        /// <summary>
        ///请求查询投资单元
        /// </summary>
        public int ReqQryInvestUnit(ThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID)
        {
            return Interop.TdReqQryInvestUnit(Handle, pQryInvestUnit, nRequestID);
        }

        /// <summary>
        ///请求查询组合合约安全系数
        /// </summary>
        public int ReqQryCombInstrumentGuard(ThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard, int nRequestID)
        {
            return Interop.TdReqQryCombInstrumentGuard(Handle, pQryCombInstrumentGuard, nRequestID);
        }

        /// <summary>
        ///请求查询申请组合
        /// </summary>
        public int ReqQryCombAction(ThostFtdcQryCombActionField pQryCombAction, int nRequestID)
        {
            return Interop.TdReqQryCombAction(Handle, pQryCombAction, nRequestID);
        }

        /// <summary>
        ///请求查询转帐流水
        /// </summary>
        public int ReqQryTransferSerial(ThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID)
        {
            return Interop.TdReqQryTransferSerial(Handle, pQryTransferSerial, nRequestID);
        }

        /// <summary>
        ///请求查询银期签约关系
        /// </summary>
        public int ReqQryAccountregister(ThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID)
        {
            return Interop.TdReqQryAccountregister(Handle, pQryAccountregister, nRequestID);
        }

        /// <summary>
        ///请求查询签约银行
        /// </summary>
        public int ReqQryContractBank(ThostFtdcQryContractBankField pQryContractBank, int nRequestID)
        {
            return Interop.TdReqQryContractBank(Handle, pQryContractBank, nRequestID);
        }

        /// <summary>
        ///请求查询预埋单
        /// </summary>
        public int ReqQryParkedOrder(ThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID)
        {
            return Interop.TdReqQryParkedOrder(Handle, pQryParkedOrder, nRequestID);
        }

        /// <summary>
        ///请求查询预埋撤单
        /// </summary>
        public int ReqQryParkedOrderAction(ThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID)
        {
            return Interop.TdReqQryParkedOrderAction(Handle, pQryParkedOrderAction, nRequestID);
        }

        /// <summary>
        ///请求查询交易通知
        /// </summary>
        public int ReqQryTradingNotice(ThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID)
        {
            return Interop.TdReqQryTradingNotice(Handle, pQryTradingNotice, nRequestID);
        }

        /// <summary>
        ///请求查询经纪公司交易参数
        /// </summary>
        public int ReqQryBrokerTradingParams(ThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID)
        {
            return Interop.TdReqQryBrokerTradingParams(Handle, pQryBrokerTradingParams, nRequestID);
        }

        /// <summary>
        ///请求查询经纪公司交易算法
        /// </summary>
        public int ReqQryBrokerTradingAlgos(ThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID)
        {
            return Interop.TdReqQryBrokerTradingAlgos(Handle, pQryBrokerTradingAlgos, nRequestID);
        }

        /// <summary>
        ///请求查询监控中心用户令牌
        /// </summary>
        public int ReqQueryCFMMCTradingAccountToken(ThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID)
        {
            return Interop.TdReqQueryCFMMCTradingAccountToken(Handle, pQueryCFMMCTradingAccountToken, nRequestID);
        }

        /// <summary>
        ///期货发起银行资金转期货请求
        /// </summary>
        public int ReqFromBankToFutureByFuture(ThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
            return Interop.TdReqFromBankToFutureByFuture(Handle, pReqTransfer, nRequestID);
        }

        /// <summary>
        ///期货发起期货资金转银行请求
        /// </summary>
        public int ReqFromFutureToBankByFuture(ThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
            return Interop.TdReqFromFutureToBankByFuture(Handle, pReqTransfer, nRequestID);
        }

        /// <summary>
        ///期货发起查询银行余额请求
        /// </summary>
        public int ReqQueryBankAccountMoneyByFuture(ThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID)
        {
            return Interop.TdReqQueryBankAccountMoneyByFuture(Handle, pReqQueryAccount, nRequestID);
        }

        /// <summary>
        /// 处理所有的OnErrRtn****回调事件
        /// </summary>
        protected void CbOnErrRtnFunc(IntPtr pObject, EnumOnErrRtnType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo)
        {
            if (OnErrRtnEvent != null)
                OnErrRtnEvent(this, new OnErrRtnEventArgs(type, pParam, pRspInfo));
        }
        private Interop.CbOnErrRtnEvent CbOnErrRtnDelegate;


        /// <summary>
        /// 处理所有的OnFront****回调事件
        /// </summary>
        protected void CbOnFrontFunc(IntPtr pObject, EnumOnFrontType type, int nReason)
        {
            if (OnFrontEvent != null)
                OnFrontEvent(this, new OnFrontEventArgs(type, nReason));
        }
        private Interop.CbOnFrontEvent CbOnFrontDelegate;


        /// <summary>
        /// 处理所有的OnRsp****回调事件
        /// </summary>
        protected void CbOnRspFunc(IntPtr pObject, EnumOnRspType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.I1)] bool bIsLast)
        {
            if (OnRspEvent != null)
                OnRspEvent(this, new OnRspEventArgs(type, pParam, pRspInfo, nRequestID, bIsLast));
        }
        private Interop.CbOnRspEvent CbOnRspDelegate;


        /// <summary>
        /// 处理所有的OnRtn****回调事件
        /// </summary>
        protected void CbOnRtnFunc(IntPtr pObject, EnumOnRtnType type, IntPtr pParam)
        {
            if (OnRtnEvent != null)
                OnRtnEvent(this, new OnRtnEventArgs(type, pParam));
        }
        private Interop.CbOnRtnEvent CbOnRtnDelegate;



        public void Dispose()
        {
            this.Release();
        }

    }; // end of class

}; // end of namespace

