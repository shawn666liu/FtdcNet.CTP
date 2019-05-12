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
    /// 行情接口
    /// </summary>
    public class FtdcMdAdapter : IDisposable
    {
        /// <summary>
        /// Native Object Pointer
        /// </summary>
        public IntPtr Handle { get; private set; }

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
        ///创建MdApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        ///modify for udp marketdata
        /// </summary>
        public FtdcMdAdapter(string pszFlowPath, bool bIsUsingUdp, bool bIsMulticast)
        {
            Handle = Interop.MdCreateApi(pszFlowPath, bIsUsingUdp, bIsMulticast);
            if (Handle == IntPtr.Zero)
                throw new Exception("MdCreateApi Failed!");
            this.CbOnFrontDelegate = this.CbOnFrontFunc;
            this.CbOnRspDelegate = this.CbOnRspFunc;
            this.CbOnRtnDelegate = this.CbOnRtnFunc;
            Interop.MdRegisterCallback(Handle, this.CbOnFrontDelegate, this.CbOnRspDelegate, this.CbOnRtnDelegate, IntPtr.Zero);
        }


        /// <summary>
        ///获取API的版本信息
        ///@retrun 获取到的版本号
        /// </summary>
        public static string GetApiVersion()
        {
            return Marshal.PtrToStringAnsi(Interop.MdGetApiVersion());
        }

        /// <summary>
        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        /// </summary>
        public void Release()
        {
            if (Handle != IntPtr.Zero)
            {
                Interop.MdDestroyApi(Handle);
                Handle = IntPtr.Zero;
            }
        }

        /// <summary>
        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        /// </summary>
        public void Init()
        {
            Interop.MdInit(Handle);
        }

        /// <summary>
        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        /// </summary>
        public string GetTradingDay()
        {
            return Marshal.PtrToStringAnsi(Interop.MdGetTradingDay(Handle));
        }

        /// <summary>
        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        /// </summary>
        public void RegisterFront(string pszFrontAddress)
        {
            Interop.MdRegisterFront(Handle, pszFrontAddress);
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
            Interop.MdRegisterNameServer(Handle, pszNsAddress);
        }

        /// <summary>
        ///注册名字服务器用户信息
        ///@param pFensUserInfo：用户信息。
        /// </summary>
        public void RegisterFensUserInfo(ThostFtdcFensUserInfoField pFensUserInfo)
        {
            Interop.MdRegisterFensUserInfo(Handle, pFensUserInfo);
        }

        /// <summary>
        ///订阅行情。
        ///@param ppInstrumentID 合约ID
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark
        /// </summary>
        public int SubscribeMarketData(string[] ppInstrumentID)
        {
            return Interop.MdSubscribeMarketData(Handle, ppInstrumentID, ppInstrumentID.Length);
        }

        /// <summary>
        ///退订行情。
        ///@param ppInstrumentID 合约ID
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark
        /// </summary>
        public int UnSubscribeMarketData(string[] ppInstrumentID)
        {
            return Interop.MdUnSubscribeMarketData(Handle, ppInstrumentID, ppInstrumentID.Length);
        }

        /// <summary>
        ///订阅询价。
        ///@param ppInstrumentID 合约ID
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark
        /// </summary>
        public int SubscribeForQuoteRsp(string[] ppInstrumentID)
        {
            return Interop.MdSubscribeForQuoteRsp(Handle, ppInstrumentID, ppInstrumentID.Length);
        }

        /// <summary>
        ///退订询价。
        ///@param ppInstrumentID 合约ID
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark
        /// </summary>
        public int UnSubscribeForQuoteRsp(string[] ppInstrumentID)
        {
            return Interop.MdUnSubscribeForQuoteRsp(Handle, ppInstrumentID, ppInstrumentID.Length);
        }

        /// <summary>
        ///用户登录请求
        /// </summary>
        public int ReqUserLogin(ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            return Interop.MdReqUserLogin(Handle, pReqUserLoginField, nRequestID);
        }

        /// <summary>
        ///登出请求
        /// </summary>
        public int ReqUserLogout(ThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            return Interop.MdReqUserLogout(Handle, pUserLogout, nRequestID);
        }

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

