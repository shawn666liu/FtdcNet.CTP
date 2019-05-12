/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2019/5/12 13:31:52
/////////////////////////////////////////////////////////////////////////

using System;

namespace CTP
{

    public class OnErrRtnEventArgs : EventArgs
    {
        public EnumOnErrRtnType EventType { get; protected set; }
        /// <summary>
        ///  不要用 Param != null 判断非空，需要 Param != IntPtr.Zero
        /// </summary>
        public IntPtr Param { get; protected set; }
        public ThostFtdcRspInfoField RspInfo { get; protected set; }
        public OnErrRtnEventArgs(EnumOnErrRtnType EventType, IntPtr pParam, ThostFtdcRspInfoField pRspInfo)
        {
            this.EventType = EventType;
            this.Param = pParam;
            this.RspInfo = pRspInfo;
        }
    }

    public class OnFrontEventArgs : EventArgs
    {
        public EnumOnFrontType EventType { get; protected set; }
        public int Reason { get; protected set; }
        public OnFrontEventArgs(EnumOnFrontType EventType, int nReason)
        {
            this.EventType = EventType;
            this.Reason = nReason;
        }
    }

    public class OnRspEventArgs : EventArgs
    {
        public EnumOnRspType EventType { get; protected set; }
        /// <summary>
        ///  不要用 Param != null 判断非空，需要 Param != IntPtr.Zero
        /// </summary>
        public IntPtr Param { get; protected set; }
        public ThostFtdcRspInfoField RspInfo { get; protected set; }
        public int RequestID { get; protected set; }
        public bool IsLast { get; protected set; }
        public OnRspEventArgs(EnumOnRspType EventType, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.EventType = EventType;
            this.Param = pParam;
            this.RspInfo = pRspInfo;
            this.RequestID = nRequestID;
            this.IsLast = bIsLast;
        }
    }

    public class OnRtnEventArgs : EventArgs
    {
        public EnumOnRtnType EventType { get; protected set; }
        /// <summary>
        ///  不要用 Param != null 判断非空，需要 Param != IntPtr.Zero
        /// </summary>
        public IntPtr Param { get; protected set; }
        public OnRtnEventArgs(EnumOnRtnType EventType, IntPtr pParam)
        {
            this.EventType = EventType;
            this.Param = pParam;
        }
    }

    public delegate void OnErrRtnEventHandler(object sender, OnErrRtnEventArgs e);
    public delegate void OnFrontEventHandler(object sender, OnFrontEventArgs e);
    public delegate void OnRspEventHandler(object sender, OnRspEventArgs e);
    public delegate void OnRtnEventHandler(object sender, OnRtnEventArgs e);

}; // end of namespace
