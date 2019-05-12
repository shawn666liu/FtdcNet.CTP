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
    /// Convert Native Ftdc struct ptr to Managed object
    /// </summary>
    public static class Conv
    {
        /// <summary>
        /// Marshal IntPtr to Struct/Class 
        /// </summary>
        public static T P2S<T>(IntPtr ptr) where T : class
        {
            return Marshal.PtrToStructure(ptr, typeof(T)) as T;
        }
    }

    /// <summary>
    /// 信息分发
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDisseminationField
    {
        /// <summary>
        /// 序列系列号
        /// </summary>
        public short SequenceSeries;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

    };

    /// <summary>
    /// 用户登录请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;

        /// <summary>
        /// 终端IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;

        /// <summary>
        /// 登录备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;

        /// <summary>
        /// 终端IP端口
        /// </summary>
        public int ClientIPPort;

    };

    /// <summary>
    /// 用户登录应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 登录成功时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 最大报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;

        /// <summary>
        /// 上期所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;

        /// <summary>
        /// 大商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;

        /// <summary>
        /// 郑商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;

        /// <summary>
        /// 中金所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;

        /// <summary>
        /// 能源中心时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string INETime;

    };

    /// <summary>
    /// 用户登出请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserLogoutField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 强制交易员退出
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcForceUserLogoutField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 客户端认证请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqAuthenticateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 认证码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;

        /// <summary>
        /// App代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;

    };

    /// <summary>
    /// 客户端认证响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspAuthenticateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// App代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;

        /// <summary>
        /// App类型
        /// </summary>
        public EnumAppTypeType AppType;

    };

    /// <summary>
    /// 客户端认证信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcAuthenticationInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 认证信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string AuthInfo;

        /// <summary>
        /// 是否为认证结果
        /// </summary>
        public int IsResult;

        /// <summary>
        /// App代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;

        /// <summary>
        /// App类型
        /// </summary>
        public EnumAppTypeType AppType;

    };

    /// <summary>
    /// 用户登录应答2
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserLogin2Field
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 登录成功时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 最大报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;

        /// <summary>
        /// 上期所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;

        /// <summary>
        /// 大商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;

        /// <summary>
        /// 郑商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;

        /// <summary>
        /// 中金所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;

        /// <summary>
        /// 能源中心时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string INETime;

        /// <summary>
        /// 随机串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string RandomString;

    };

    /// <summary>
    /// 银期转帐报文头
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferHeaderField
    {
        /// <summary>
        /// 版本号，常量，1.0
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Version;

        /// <summary>
        /// 交易代码，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 交易日期，必填，格式：yyyymmdd
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间，必填，格式：hhmmss
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 发起方流水号，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeSerial;

        /// <summary>
        /// 期货公司代码，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;

        /// <summary>
        /// 银行代码，根据查询银行得到，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分中心代码，根据查询银行得到，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;

        /// <summary>
        /// 操作员，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 交易设备类型，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 记录数，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string RecordNum;

        /// <summary>
        /// 会话编号，N/A
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 请求编号，N/A
        /// </summary>
        public int RequestID;

    };

    /// <summary>
    /// 银行资金转期货请求，TradeCode=202001
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferBankToFutureReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

        /// <summary>
        /// 密码标志
        /// </summary>
        public EnumFuturePwdFlagType FuturePwdFlag;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;

        /// <summary>
        /// 转账金额
        /// </summary>
        public double TradeAmt;

        /// <summary>
        /// 客户手续费
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 币种：RMB-人民币 USD-美圆 HKD-港元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

    };

    /// <summary>
    /// 银行资金转期货请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferBankToFutureRspField
    {
        /// <summary>
        /// 响应代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;

        /// <summary>
        /// 响应信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmt;

        /// <summary>
        /// 应收客户手续费
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

    };

    /// <summary>
    /// 期货资金转银行请求，TradeCode=202002
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferFutureToBankReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

        /// <summary>
        /// 密码标志
        /// </summary>
        public EnumFuturePwdFlagType FuturePwdFlag;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;

        /// <summary>
        /// 转账金额
        /// </summary>
        public double TradeAmt;

        /// <summary>
        /// 客户手续费
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 币种：RMB-人民币 USD-美圆 HKD-港元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

    };

    /// <summary>
    /// 期货资金转银行请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferFutureToBankRspField
    {
        /// <summary>
        /// 响应代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;

        /// <summary>
        /// 响应信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmt;

        /// <summary>
        /// 应收客户手续费
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

    };

    /// <summary>
    /// 查询银行资金请求，TradeCode=204002
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferQryBankReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

        /// <summary>
        /// 密码标志
        /// </summary>
        public EnumFuturePwdFlagType FuturePwdFlag;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;

        /// <summary>
        /// 币种：RMB-人民币 USD-美圆 HKD-港元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

    };

    /// <summary>
    /// 查询银行资金请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferQryBankRspField
    {
        /// <summary>
        /// 响应代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;

        /// <summary>
        /// 响应信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

        /// <summary>
        /// 银行余额
        /// </summary>
        public double TradeAmt;

        /// <summary>
        /// 银行可用余额
        /// </summary>
        public double UseAmt;

        /// <summary>
        /// 银行可取余额
        /// </summary>
        public double FetchAmt;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

    };

    /// <summary>
    /// 查询银行交易明细请求，TradeCode=204999
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferQryDetailReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;

    };

    /// <summary>
    /// 查询银行交易明细请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferQryDetailRspField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 期货流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 期货公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;

        /// <summary>
        /// 资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
        public string FutureAccount;

        /// <summary>
        /// 银行流水号
        /// </summary>
        public int BankSerial;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;

        /// <summary>
        /// 银行账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CertCode;

        /// <summary>
        /// 货币代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;

        /// <summary>
        /// 发生金额
        /// </summary>
        public double TxAmount;

        /// <summary>
        /// 有效标志
        /// </summary>
        public EnumTransferValidFlagType Flag;

    };

    /// <summary>
    /// 响应信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInfoField
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 交易所
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string ExchangeName;

        /// <summary>
        /// 交易所属性
        /// </summary>
        public EnumExchangePropertyType ExchangeProperty;

    };

    /// <summary>
    /// 产品
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcProductField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 产品名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ProductName;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品类型
        /// </summary>
        public EnumProductClassType ProductClass;

        /// <summary>
        /// 合约数量乘数
        /// </summary>
        public int VolumeMultiple;

        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double PriceTick;

        /// <summary>
        /// 市价单最大下单量
        /// </summary>
        public int MaxMarketOrderVolume;

        /// <summary>
        /// 市价单最小下单量
        /// </summary>
        public int MinMarketOrderVolume;

        /// <summary>
        /// 限价单最大下单量
        /// </summary>
        public int MaxLimitOrderVolume;

        /// <summary>
        /// 限价单最小下单量
        /// </summary>
        public int MinLimitOrderVolume;

        /// <summary>
        /// 持仓类型
        /// </summary>
        public EnumPositionTypeType PositionType;

        /// <summary>
        /// 持仓日期类型
        /// </summary>
        public EnumPositionDateTypeType PositionDateType;

        /// <summary>
        /// 平仓处理类型
        /// </summary>
        public EnumCloseDealTypeType CloseDealType;

        /// <summary>
        /// 交易币种类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string TradeCurrencyID;

        /// <summary>
        /// 质押资金可用范围
        /// </summary>
        public EnumMortgageFundUseRangeType MortgageFundUseRange;

        /// <summary>
        /// 交易所产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeProductID;

        /// <summary>
        /// 合约基础商品乘数
        /// </summary>
        public double UnderlyingMultiple;

    };

    /// <summary>
    /// 合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 产品类型
        /// </summary>
        public EnumProductClassType ProductClass;

        /// <summary>
        /// 交割年份
        /// </summary>
        public int DeliveryYear;

        /// <summary>
        /// 交割月
        /// </summary>
        public int DeliveryMonth;

        /// <summary>
        /// 市价单最大下单量
        /// </summary>
        public int MaxMarketOrderVolume;

        /// <summary>
        /// 市价单最小下单量
        /// </summary>
        public int MinMarketOrderVolume;

        /// <summary>
        /// 限价单最大下单量
        /// </summary>
        public int MaxLimitOrderVolume;

        /// <summary>
        /// 限价单最小下单量
        /// </summary>
        public int MinLimitOrderVolume;

        /// <summary>
        /// 合约数量乘数
        /// </summary>
        public int VolumeMultiple;

        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double PriceTick;

        /// <summary>
        /// 创建日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;

        /// <summary>
        /// 上市日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 到期日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;

        /// <summary>
        /// 开始交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;

        /// <summary>
        /// 结束交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;

        /// <summary>
        /// 合约生命周期状态
        /// </summary>
        public EnumInstLifePhaseType InstLifePhase;

        /// <summary>
        /// 当前是否交易
        /// </summary>
        public int IsTrading;

        /// <summary>
        /// 持仓类型
        /// </summary>
        public EnumPositionTypeType PositionType;

        /// <summary>
        /// 持仓日期类型
        /// </summary>
        public EnumPositionDateTypeType PositionDateType;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatio;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatio;

        /// <summary>
        /// 是否使用大额单边保证金算法
        /// </summary>
        public EnumMaxMarginSideAlgorithmType MaxMarginSideAlgorithm;

        /// <summary>
        /// 基础商品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UnderlyingInstrID;

        /// <summary>
        /// 执行价
        /// </summary>
        public double StrikePrice;

        /// <summary>
        /// 期权类型
        /// </summary>
        public EnumOptionsTypeType OptionsType;

        /// <summary>
        /// 合约基础商品乘数
        /// </summary>
        public double UnderlyingMultiple;

        /// <summary>
        /// 组合类型
        /// </summary>
        public EnumCombinationTypeType CombinationType;

    };

    /// <summary>
    /// 经纪公司
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司简称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BrokerAbbr;

        /// <summary>
        /// 经纪公司名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string BrokerName;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

    };

    /// <summary>
    /// 交易所交易员
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTraderField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装数量
        /// </summary>
        public int InstallCount;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;

        /// <summary>
        /// 投资者名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdentifiedCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;

        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;

        /// <summary>
        /// 保证金率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;

    };

    /// <summary>
    /// 交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingCodeField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 交易编码类型
        /// </summary>
        public EnumClientIDTypeType ClientIDType;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 业务类型
        /// </summary>
        public EnumBizTypeType BizType;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 会员编码和经纪公司编码对照表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcPartBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

    };

    /// <summary>
    /// 管理用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSuperUserField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

    };

    /// <summary>
    /// 管理用户功能权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSuperUserFunctionField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 功能代码
        /// </summary>
        public EnumFunctionCodeType FunctionCode;

    };

    /// <summary>
    /// 投资者组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorGroupField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;

        /// <summary>
        /// 投资者分组名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;

    };

    /// <summary>
    /// 资金账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 上次质押金额
        /// </summary>
        public double PreMortgage;

        /// <summary>
        /// 上次信用额度
        /// </summary>
        public double PreCredit;

        /// <summary>
        /// 上次存款额
        /// </summary>
        public double PreDeposit;

        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;

        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;

        /// <summary>
        /// 利息基数
        /// </summary>
        public double InterestBase;

        /// <summary>
        /// 利息收入
        /// </summary>
        public double Interest;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;

        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 期货结算准备金
        /// </summary>
        public double Balance;

        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 可取资金
        /// </summary>
        public double WithdrawQuota;

        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 信用额度
        /// </summary>
        public double Credit;

        /// <summary>
        /// 质押金额
        /// </summary>
        public double Mortgage;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;

        /// <summary>
        /// 投资者交割保证金
        /// </summary>
        public double DeliveryMargin;

        /// <summary>
        /// 交易所交割保证金
        /// </summary>
        public double ExchangeDeliveryMargin;

        /// <summary>
        /// 保底期货结算准备金
        /// </summary>
        public double ReserveBalance;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 上次货币质入金额
        /// </summary>
        public double PreFundMortgageIn;

        /// <summary>
        /// 上次货币质出金额
        /// </summary>
        public double PreFundMortgageOut;

        /// <summary>
        /// 货币质入金额
        /// </summary>
        public double FundMortgageIn;

        /// <summary>
        /// 货币质出金额
        /// </summary>
        public double FundMortgageOut;

        /// <summary>
        /// 货币质押余额
        /// </summary>
        public double FundMortgageAvailable;

        /// <summary>
        /// 可质押货币金额
        /// </summary>
        public double MortgageableFund;

        /// <summary>
        /// 特殊产品占用保证金
        /// </summary>
        public double SpecProductMargin;

        /// <summary>
        /// 特殊产品冻结保证金
        /// </summary>
        public double SpecProductFrozenMargin;

        /// <summary>
        /// 特殊产品手续费
        /// </summary>
        public double SpecProductCommission;

        /// <summary>
        /// 特殊产品冻结手续费
        /// </summary>
        public double SpecProductFrozenCommission;

        /// <summary>
        /// 特殊产品持仓盈亏
        /// </summary>
        public double SpecProductPositionProfit;

        /// <summary>
        /// 特殊产品平仓盈亏
        /// </summary>
        public double SpecProductCloseProfit;

        /// <summary>
        /// 根据持仓盈亏算法计算的特殊产品持仓盈亏
        /// </summary>
        public double SpecProductPositionProfitByAlg;

        /// <summary>
        /// 特殊产品交易所保证金
        /// </summary>
        public double SpecProductExchangeMargin;

        /// <summary>
        /// 业务类型
        /// </summary>
        public EnumBizTypeType BizType;

        /// <summary>
        /// 延时换汇冻结金额
        /// </summary>
        public double FrozenSwap;

        /// <summary>
        /// 剩余换汇额度
        /// </summary>
        public double RemainSwap;

    };

    /// <summary>
    /// 投资者持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPositionField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 持仓多空方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 持仓日期
        /// </summary>
        public EnumPositionDateType PositionDate;

        /// <summary>
        /// 上日持仓
        /// </summary>
        public int YdPosition;

        /// <summary>
        /// 今日持仓
        /// </summary>
        public int Position;

        /// <summary>
        /// 多头冻结
        /// </summary>
        public int LongFrozen;

        /// <summary>
        /// 空头冻结
        /// </summary>
        public int ShortFrozen;

        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double LongFrozenAmount;

        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double ShortFrozenAmount;

        /// <summary>
        /// 开仓量
        /// </summary>
        public int OpenVolume;

        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;

        /// <summary>
        /// 开仓金额
        /// </summary>
        public double OpenAmount;

        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;

        /// <summary>
        /// 持仓成本
        /// </summary>
        public double PositionCost;

        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;

        /// <summary>
        /// 占用的保证金
        /// </summary>
        public double UseMargin;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 开仓成本
        /// </summary>
        public double OpenCost;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;

        /// <summary>
        /// 组合成交形成的持仓
        /// </summary>
        public int CombPosition;

        /// <summary>
        /// 组合多头冻结
        /// </summary>
        public int CombLongFrozen;

        /// <summary>
        /// 组合空头冻结
        /// </summary>
        public int CombShortFrozen;

        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;

        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;

        /// <summary>
        /// 今日持仓
        /// </summary>
        public int TodayPosition;

        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;

        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;

        /// <summary>
        /// 执行冻结
        /// </summary>
        public int StrikeFrozen;

        /// <summary>
        /// 执行冻结金额
        /// </summary>
        public double StrikeFrozenAmount;

        /// <summary>
        /// 放弃执行冻结
        /// </summary>
        public int AbandonFrozen;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行冻结的昨仓
        /// </summary>
        public int YdStrikeFrozen;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 大商所持仓成本差值，只有大商所使用
        /// </summary>
        public double PositionCostOffset;

    };

    /// <summary>
    /// 合约保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentMarginRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

        /// <summary>
        /// 是否相对交易所收取
        /// </summary>
        public int IsRelative;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 合约手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentCommissionRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;

        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;

        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;

        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;

        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;

        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 业务类型
        /// </summary>
        public EnumBizTypeType BizType;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 深度行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDepthMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;

        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;

        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;

        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;

        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;

        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;

        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;

        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;

        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;

        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;

        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;

        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;

        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;

        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;

        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;

        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;

        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;

        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;

        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;

        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;

        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;

        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;

        /// <summary>
        /// 当日均价
        /// </summary>
        public double AveragePrice;

        /// <summary>
        /// 业务日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;

    };

    /// <summary>
    /// 投资者合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentTradingRightField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易权限
        /// </summary>
        public EnumTradingRightType TradingRight;

    };

    /// <summary>
    /// 经纪公司用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 用户类型
        /// </summary>
        public EnumUserTypeType UserType;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 是否使用令牌
        /// </summary>
        public int IsUsingOTP;

        /// <summary>
        /// 是否强制终端认证
        /// </summary>
        public int IsAuthForce;

    };

    /// <summary>
    /// 经纪公司用户口令
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 上次修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string LastUpdateTime;

        /// <summary>
        /// 上次登陆时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string LastLoginTime;

        /// <summary>
        /// 密码过期时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;

        /// <summary>
        /// 弱密码过期时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string WeakExpireDate;

    };

    /// <summary>
    /// 经纪公司用户功能权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserFunctionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 经纪公司功能代码
        /// </summary>
        public EnumBrokerFunctionCodeType BrokerFunctionCode;

    };

    /// <summary>
    /// 交易所交易员报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所交易员连接状态
        /// </summary>
        public EnumTraderConnectStatusType TraderConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 上次报告日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;

        /// <summary>
        /// 上次报告时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

        /// <summary>
        /// 启动日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;

        /// <summary>
        /// 启动时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 本席位最大成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;

        /// <summary>
        /// 本席位最大报单备拷
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;

    };

    /// <summary>
    /// 投资者结算结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSettlementInfoField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 合约保证金率调整
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentMarginRateAdjustField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

        /// <summary>
        /// 是否相对交易所收取
        /// </summary>
        public int IsRelative;

    };

    /// <summary>
    /// 交易所保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易所保证金率调整
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeMarginRateAdjustField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 跟随交易所投资者多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 跟随交易所投资者多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 跟随交易所投资者空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 跟随交易所投资者空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

        /// <summary>
        /// 交易所多头保证金率
        /// </summary>
        public double ExchLongMarginRatioByMoney;

        /// <summary>
        /// 交易所多头保证金费
        /// </summary>
        public double ExchLongMarginRatioByVolume;

        /// <summary>
        /// 交易所空头保证金率
        /// </summary>
        public double ExchShortMarginRatioByMoney;

        /// <summary>
        /// 交易所空头保证金费
        /// </summary>
        public double ExchShortMarginRatioByVolume;

        /// <summary>
        /// 不跟随交易所投资者多头保证金率
        /// </summary>
        public double NoLongMarginRatioByMoney;

        /// <summary>
        /// 不跟随交易所投资者多头保证金费
        /// </summary>
        public double NoLongMarginRatioByVolume;

        /// <summary>
        /// 不跟随交易所投资者空头保证金率
        /// </summary>
        public double NoShortMarginRatioByMoney;

        /// <summary>
        /// 不跟随交易所投资者空头保证金费
        /// </summary>
        public double NoShortMarginRatioByVolume;

    };

    /// <summary>
    /// 汇率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 源币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;

        /// <summary>
        /// 源币种单位数量
        /// </summary>
        public double FromCurrencyUnit;

        /// <summary>
        /// 目标币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;

        /// <summary>
        /// 汇率
        /// </summary>
        public double ExchangeRate;

    };

    /// <summary>
    /// 结算引用
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSettlementRefField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

    };

    /// <summary>
    /// 当前时间
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCurrentTimeField
    {
        /// <summary>
        /// 当前日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrDate;

        /// <summary>
        /// 当前时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrTime;

        /// <summary>
        /// 当前时间（毫秒）
        /// </summary>
        public int CurrMillisec;

        /// <summary>
        /// 业务日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;

    };

    /// <summary>
    /// 通讯阶段
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCommPhaseField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 通讯时段编号
        /// </summary>
        public short CommPhaseNo;

        /// <summary>
        /// 系统编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string SystemID;

    };

    /// <summary>
    /// 登录信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLoginInfoField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 登录日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;

        /// <summary>
        /// 登录时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// 系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;

        /// <summary>
        /// 密码,已弃用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string PasswordDeprecated;

        /// <summary>
        /// 最大报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;

        /// <summary>
        /// 上期所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;

        /// <summary>
        /// 大商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;

        /// <summary>
        /// 郑商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;

        /// <summary>
        /// 中金所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;

        /// <summary>
        /// 能源中心时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string INETime;

        /// <summary>
        /// 查询时是否需要流控
        /// </summary>
        public int IsQryControl;

        /// <summary>
        /// 登录备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

    };

    /// <summary>
    /// 登录信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLogoutAllField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;

    };

    /// <summary>
    /// 前置状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcFrontStatusField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 上次报告日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;

        /// <summary>
        /// 上次报告时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

    };

    /// <summary>
    /// 用户口令变更
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserPasswordUpdateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 原来的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;

        /// <summary>
        /// 新的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;

    };

    /// <summary>
    /// 输入报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 报单来源
        /// </summary>
        public EnumOrderSourceType OrderSource;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 报单类型
        /// </summary>
        public EnumOrderTypeType OrderType;

        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;

        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;

        /// <summary>
        /// 相关报单
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;

        /// <summary>
        /// 郑商所成交数量
        /// </summary>
        public int ZCETotalTradedVolume;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeOrderField
    {
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 报单来源
        /// </summary>
        public EnumOrderSourceType OrderSource;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 报单类型
        /// </summary>
        public EnumOrderTypeType OrderType;

        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;

        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所报单插入失败
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeOrderInsertErrorField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 输入报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeOrderActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所报单操作失败
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeOrderActionErrorField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 交易所成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeTradeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易角色
        /// </summary>
        public EnumTradingRoleType TradingRole;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double Price;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交时期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 成交类型
        /// </summary>
        public EnumTradeTypeType TradeType;

        /// <summary>
        /// 成交价来源
        /// </summary>
        public EnumPriceSourceType PriceSource;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 成交来源
        /// </summary>
        public EnumTradeSourceType TradeSource;

    };

    /// <summary>
    /// 成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易角色
        /// </summary>
        public EnumTradingRoleType TradingRole;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double Price;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交时期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 成交类型
        /// </summary>
        public EnumTradeTypeType TradeType;

        /// <summary>
        /// 成交价来源
        /// </summary>
        public EnumPriceSourceType PriceSource;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;

        /// <summary>
        /// 成交来源
        /// </summary>
        public EnumTradeSourceType TradeSource;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 用户会话
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserSessionField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 登录日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;

        /// <summary>
        /// 登录时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 登录备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;

    };

    /// <summary>
    /// 查询最大报单数量
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQueryMaxOrderVolumeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 最大允许报单数量
        /// </summary>
        public int MaxVolume;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者结算结果确认信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSettlementInfoConfirmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 确认日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmDate;

        /// <summary>
        /// 确认时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmTime;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 出入金同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncDepositField
    {
        /// <summary>
        /// 出入金流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 是否强制进行
        /// </summary>
        public int IsForce;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 货币质押同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncFundMortgageField
    {
        /// <summary>
        /// 货币质押流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string MortgageSeqNo;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 源币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;

        /// <summary>
        /// 质押金额
        /// </summary>
        public double MortgageAmount;

        /// <summary>
        /// 目标币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;

    };

    /// <summary>
    /// 经纪公司同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerSyncField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 正在同步中的投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingInvestorField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;

        /// <summary>
        /// 投资者名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdentifiedCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;

        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;

        /// <summary>
        /// 保证金率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;

    };

    /// <summary>
    /// 正在同步中的交易代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingTradingCodeField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 交易编码类型
        /// </summary>
        public EnumClientIDTypeType ClientIDType;

    };

    /// <summary>
    /// 正在同步中的投资者分组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingInvestorGroupField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;

        /// <summary>
        /// 投资者分组名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;

    };

    /// <summary>
    /// 正在同步中的交易账号
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 上次质押金额
        /// </summary>
        public double PreMortgage;

        /// <summary>
        /// 上次信用额度
        /// </summary>
        public double PreCredit;

        /// <summary>
        /// 上次存款额
        /// </summary>
        public double PreDeposit;

        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;

        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;

        /// <summary>
        /// 利息基数
        /// </summary>
        public double InterestBase;

        /// <summary>
        /// 利息收入
        /// </summary>
        public double Interest;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;

        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 期货结算准备金
        /// </summary>
        public double Balance;

        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 可取资金
        /// </summary>
        public double WithdrawQuota;

        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 信用额度
        /// </summary>
        public double Credit;

        /// <summary>
        /// 质押金额
        /// </summary>
        public double Mortgage;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;

        /// <summary>
        /// 投资者交割保证金
        /// </summary>
        public double DeliveryMargin;

        /// <summary>
        /// 交易所交割保证金
        /// </summary>
        public double ExchangeDeliveryMargin;

        /// <summary>
        /// 保底期货结算准备金
        /// </summary>
        public double ReserveBalance;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 上次货币质入金额
        /// </summary>
        public double PreFundMortgageIn;

        /// <summary>
        /// 上次货币质出金额
        /// </summary>
        public double PreFundMortgageOut;

        /// <summary>
        /// 货币质入金额
        /// </summary>
        public double FundMortgageIn;

        /// <summary>
        /// 货币质出金额
        /// </summary>
        public double FundMortgageOut;

        /// <summary>
        /// 货币质押余额
        /// </summary>
        public double FundMortgageAvailable;

        /// <summary>
        /// 可质押货币金额
        /// </summary>
        public double MortgageableFund;

        /// <summary>
        /// 特殊产品占用保证金
        /// </summary>
        public double SpecProductMargin;

        /// <summary>
        /// 特殊产品冻结保证金
        /// </summary>
        public double SpecProductFrozenMargin;

        /// <summary>
        /// 特殊产品手续费
        /// </summary>
        public double SpecProductCommission;

        /// <summary>
        /// 特殊产品冻结手续费
        /// </summary>
        public double SpecProductFrozenCommission;

        /// <summary>
        /// 特殊产品持仓盈亏
        /// </summary>
        public double SpecProductPositionProfit;

        /// <summary>
        /// 特殊产品平仓盈亏
        /// </summary>
        public double SpecProductCloseProfit;

        /// <summary>
        /// 根据持仓盈亏算法计算的特殊产品持仓盈亏
        /// </summary>
        public double SpecProductPositionProfitByAlg;

        /// <summary>
        /// 特殊产品交易所保证金
        /// </summary>
        public double SpecProductExchangeMargin;

        /// <summary>
        /// 延时换汇冻结金额
        /// </summary>
        public double FrozenSwap;

        /// <summary>
        /// 剩余换汇额度
        /// </summary>
        public double RemainSwap;

    };

    /// <summary>
    /// 正在同步中的投资者持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingInvestorPositionField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 持仓多空方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 持仓日期
        /// </summary>
        public EnumPositionDateType PositionDate;

        /// <summary>
        /// 上日持仓
        /// </summary>
        public int YdPosition;

        /// <summary>
        /// 今日持仓
        /// </summary>
        public int Position;

        /// <summary>
        /// 多头冻结
        /// </summary>
        public int LongFrozen;

        /// <summary>
        /// 空头冻结
        /// </summary>
        public int ShortFrozen;

        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double LongFrozenAmount;

        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double ShortFrozenAmount;

        /// <summary>
        /// 开仓量
        /// </summary>
        public int OpenVolume;

        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;

        /// <summary>
        /// 开仓金额
        /// </summary>
        public double OpenAmount;

        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;

        /// <summary>
        /// 持仓成本
        /// </summary>
        public double PositionCost;

        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;

        /// <summary>
        /// 占用的保证金
        /// </summary>
        public double UseMargin;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 开仓成本
        /// </summary>
        public double OpenCost;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;

        /// <summary>
        /// 组合成交形成的持仓
        /// </summary>
        public int CombPosition;

        /// <summary>
        /// 组合多头冻结
        /// </summary>
        public int CombLongFrozen;

        /// <summary>
        /// 组合空头冻结
        /// </summary>
        public int CombShortFrozen;

        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;

        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;

        /// <summary>
        /// 今日持仓
        /// </summary>
        public int TodayPosition;

        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;

        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;

        /// <summary>
        /// 执行冻结
        /// </summary>
        public int StrikeFrozen;

        /// <summary>
        /// 执行冻结金额
        /// </summary>
        public double StrikeFrozenAmount;

        /// <summary>
        /// 放弃执行冻结
        /// </summary>
        public int AbandonFrozen;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行冻结的昨仓
        /// </summary>
        public int YdStrikeFrozen;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 大商所持仓成本差值，只有大商所使用
        /// </summary>
        public double PositionCostOffset;

    };

    /// <summary>
    /// 正在同步中的合约保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingInstrumentMarginRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

        /// <summary>
        /// 是否相对交易所收取
        /// </summary>
        public int IsRelative;

    };

    /// <summary>
    /// 正在同步中的合约手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingInstrumentCommissionRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;

        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;

        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;

        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;

        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;

        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;

    };

    /// <summary>
    /// 正在同步中的合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncingInstrumentTradingRightField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易权限
        /// </summary>
        public EnumTradingRightType TradingRight;

    };

    /// <summary>
    /// 查询报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询投资者持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询资金账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 业务类型
        /// </summary>
        public EnumBizTypeType BizType;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 查询投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 查询交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradingCodeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易编码类型
        /// </summary>
        public EnumClientIDTypeType ClientIDType;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询投资者组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorGroupField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 查询合约保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentCommissionRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentTradingRightField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 查询经纪公司
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 查询交易员
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTraderField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 查询管理用户功能权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySuperUserFunctionField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 查询用户会话
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserSessionField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 查询经纪公司会员代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryPartBrokerField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

    };

    /// <summary>
    /// 查询前置状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryFrontStatusField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

    };

    /// <summary>
    /// 查询交易所报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeOrderField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 查询报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询交易所报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeOrderActionField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 查询管理用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySuperUserField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 查询交易所
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询产品
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryProductField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 产品类型
        /// </summary>
        public EnumProductClassType ProductClass;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

    };

    /// <summary>
    /// 查询行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryDepthMarketDataField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询经纪公司用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 查询经纪公司用户权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerUserFunctionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 查询交易员报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 查询出入金流水
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySyncDepositField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 出入金流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;

    };

    /// <summary>
    /// 查询投资者结算结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySettlementInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询交易所保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询交易所调整保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeMarginRateAdjustField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

    };

    /// <summary>
    /// 查询汇率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 源币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;

        /// <summary>
        /// 目标币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;

    };

    /// <summary>
    /// 查询货币质押流水
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySyncFundMortgageField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 货币质押流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string MortgageSeqNo;

    };

    /// <summary>
    /// 查询报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryHisOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

    };

    /// <summary>
    /// 当前期权合约最小保证金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionInstrMiniMarginField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 单位（手）期权合约最小保证金
        /// </summary>
        public double MinMargin;

        /// <summary>
        /// 取值方式
        /// </summary>
        public EnumValueMethodType ValueMethod;

        /// <summary>
        /// 是否跟随交易所收取
        /// </summary>
        public int IsRelative;

    };

    /// <summary>
    /// 当前期权合约保证金调整系数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionInstrMarginAdjustField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机空头保证金调整系数
        /// </summary>
        public double SShortMarginRatioByMoney;

        /// <summary>
        /// 投机空头保证金调整系数
        /// </summary>
        public double SShortMarginRatioByVolume;

        /// <summary>
        /// 保值空头保证金调整系数
        /// </summary>
        public double HShortMarginRatioByMoney;

        /// <summary>
        /// 保值空头保证金调整系数
        /// </summary>
        public double HShortMarginRatioByVolume;

        /// <summary>
        /// 套利空头保证金调整系数
        /// </summary>
        public double AShortMarginRatioByMoney;

        /// <summary>
        /// 套利空头保证金调整系数
        /// </summary>
        public double AShortMarginRatioByVolume;

        /// <summary>
        /// 是否跟随交易所收取
        /// </summary>
        public int IsRelative;

        /// <summary>
        /// 做市商空头保证金调整系数
        /// </summary>
        public double MShortMarginRatioByMoney;

        /// <summary>
        /// 做市商空头保证金调整系数
        /// </summary>
        public double MShortMarginRatioByVolume;

    };

    /// <summary>
    /// 当前期权合约手续费的详细内容
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionInstrCommRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;

        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;

        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;

        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;

        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;

        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;

        /// <summary>
        /// 执行手续费率
        /// </summary>
        public double StrikeRatioByMoney;

        /// <summary>
        /// 执行手续费
        /// </summary>
        public double StrikeRatioByVolume;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 期权交易成本
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionInstrTradeCostField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 期权合约保证金不变部分
        /// </summary>
        public double FixedMargin;

        /// <summary>
        /// 期权合约最小保证金
        /// </summary>
        public double MiniMargin;

        /// <summary>
        /// 期权合约权利金
        /// </summary>
        public double Royalty;

        /// <summary>
        /// 交易所期权合约保证金不变部分
        /// </summary>
        public double ExchFixedMargin;

        /// <summary>
        /// 交易所期权合约最小保证金
        /// </summary>
        public double ExchMiniMargin;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 期权交易成本查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOptionInstrTradeCostField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 期权合约报价
        /// </summary>
        public double InputPrice;

        /// <summary>
        /// 标的价格,填0则用昨结算价
        /// </summary>
        public double UnderlyingPrice;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 期权手续费率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOptionInstrCommRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 股指现货指数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcIndexPriceField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 指数现货收盘价
        /// </summary>
        public double ClosePrice;

    };

    /// <summary>
    /// 输入的执行宣告
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 执行宣告引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumActionTypeType ActionType;

        /// <summary>
        /// 保留头寸申请的持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 期权行权后是否保留期货头寸的标记,该字段已废弃
        /// </summary>
        public EnumExecOrderPositionFlagType ReservePositionFlag;

        /// <summary>
        /// 期权行权后生成的头寸是否自动平仓
        /// </summary>
        public EnumExecOrderCloseFlagType CloseFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 输入执行宣告操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 执行宣告操作引用
        /// </summary>
        public int ExecOrderActionRef;

        /// <summary>
        /// 执行宣告引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行宣告操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 执行宣告
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 执行宣告引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumActionTypeType ActionType;

        /// <summary>
        /// 保留头寸申请的持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 期权行权后是否保留期货头寸的标记,该字段已废弃
        /// </summary>
        public EnumExecOrderPositionFlagType ReservePositionFlag;

        /// <summary>
        /// 期权行权后生成的头寸是否自动平仓
        /// </summary>
        public EnumExecOrderCloseFlagType CloseFlag;

        /// <summary>
        /// 本地执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 执行宣告提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 执行结果
        /// </summary>
        public EnumExecResultType ExecResult;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerExecOrderSeq;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 执行宣告操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 执行宣告操作引用
        /// </summary>
        public int ExecOrderActionRef;

        /// <summary>
        /// 执行宣告引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行宣告操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumActionTypeType ActionType;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 执行宣告查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

    };

    /// <summary>
    /// 交易所执行宣告信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeExecOrderField
    {
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumActionTypeType ActionType;

        /// <summary>
        /// 保留头寸申请的持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 期权行权后是否保留期货头寸的标记,该字段已废弃
        /// </summary>
        public EnumExecOrderPositionFlagType ReservePositionFlag;

        /// <summary>
        /// 期权行权后生成的头寸是否自动平仓
        /// </summary>
        public EnumExecOrderCloseFlagType CloseFlag;

        /// <summary>
        /// 本地执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 执行宣告提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 执行结果
        /// </summary>
        public EnumExecResultType ExecResult;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所执行宣告查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeExecOrderField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 执行宣告操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易所执行宣告操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeExecOrderActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行宣告操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumActionTypeType ActionType;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

    };

    /// <summary>
    /// 交易所执行宣告操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeExecOrderActionField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 错误执行宣告
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcErrExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 执行宣告引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumActionTypeType ActionType;

        /// <summary>
        /// 保留头寸申请的持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 期权行权后是否保留期货头寸的标记,该字段已废弃
        /// </summary>
        public EnumExecOrderPositionFlagType ReservePositionFlag;

        /// <summary>
        /// 期权行权后生成的头寸是否自动平仓
        /// </summary>
        public EnumExecOrderCloseFlagType CloseFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 查询错误执行宣告
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryErrExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 错误执行宣告操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcErrExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 执行宣告操作引用
        /// </summary>
        public int ExecOrderActionRef;

        /// <summary>
        /// 执行宣告引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行宣告操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 查询错误执行宣告操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryErrExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 投资者期权合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionInstrTradingRightField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 交易权限
        /// </summary>
        public EnumTradingRightType TradingRight;

    };

    /// <summary>
    /// 查询期权合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOptionInstrTradingRightField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

    };

    /// <summary>
    /// 输入的询价
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputForQuoteField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 询价引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 询价
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcForQuoteField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 询价引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 本地询价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 询价状态
        /// </summary>
        public EnumForQuoteStatusType ForQuoteStatus;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司询价编号
        /// </summary>
        public int BrokerForQutoSeq;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 询价查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryForQuoteField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 交易所询价信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeForQuoteField
    {
        /// <summary>
        /// 本地询价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 询价状态
        /// </summary>
        public EnumForQuoteStatusType ForQuoteStatus;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所询价查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeForQuoteField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 输入的报价
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputQuoteField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报价引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 卖价格
        /// </summary>
        public double AskPrice;

        /// <summary>
        /// 买价格
        /// </summary>
        public double BidPrice;

        /// <summary>
        /// 卖数量
        /// </summary>
        public int AskVolume;

        /// <summary>
        /// 买数量
        /// </summary>
        public int BidVolume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 卖开平标志
        /// </summary>
        public EnumOffsetFlagType AskOffsetFlag;

        /// <summary>
        /// 买开平标志
        /// </summary>
        public EnumOffsetFlagType BidOffsetFlag;

        /// <summary>
        /// 卖投机套保标志
        /// </summary>
        public EnumHedgeFlagType AskHedgeFlag;

        /// <summary>
        /// 买投机套保标志
        /// </summary>
        public EnumHedgeFlagType BidHedgeFlag;

        /// <summary>
        /// 衍生卖报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AskOrderRef;

        /// <summary>
        /// 衍生买报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BidOrderRef;

        /// <summary>
        /// 应价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 输入报价操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputQuoteActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报价操作引用
        /// </summary>
        public int QuoteActionRef;

        /// <summary>
        /// 报价引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报价操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 报价
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQuoteField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报价引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 卖价格
        /// </summary>
        public double AskPrice;

        /// <summary>
        /// 买价格
        /// </summary>
        public double BidPrice;

        /// <summary>
        /// 卖数量
        /// </summary>
        public int AskVolume;

        /// <summary>
        /// 买数量
        /// </summary>
        public int BidVolume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 卖开平标志
        /// </summary>
        public EnumOffsetFlagType AskOffsetFlag;

        /// <summary>
        /// 买开平标志
        /// </summary>
        public EnumOffsetFlagType BidOffsetFlag;

        /// <summary>
        /// 卖投机套保标志
        /// </summary>
        public EnumHedgeFlagType AskHedgeFlag;

        /// <summary>
        /// 买投机套保标志
        /// </summary>
        public EnumHedgeFlagType BidHedgeFlag;

        /// <summary>
        /// 本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报价提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 报价提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 报价状态
        /// </summary>
        public EnumOrderStatusType QuoteStatus;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 卖方报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AskOrderSysID;

        /// <summary>
        /// 买方报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BidOrderSysID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报价编号
        /// </summary>
        public int BrokerQuoteSeq;

        /// <summary>
        /// 衍生卖报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AskOrderRef;

        /// <summary>
        /// 衍生买报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BidOrderRef;

        /// <summary>
        /// 应价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 报价操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQuoteActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报价操作引用
        /// </summary>
        public int QuoteActionRef;

        /// <summary>
        /// 报价引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报价操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 报价查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryQuoteField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 交易所报价信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeQuoteField
    {
        /// <summary>
        /// 卖价格
        /// </summary>
        public double AskPrice;

        /// <summary>
        /// 买价格
        /// </summary>
        public double BidPrice;

        /// <summary>
        /// 卖数量
        /// </summary>
        public int AskVolume;

        /// <summary>
        /// 买数量
        /// </summary>
        public int BidVolume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 卖开平标志
        /// </summary>
        public EnumOffsetFlagType AskOffsetFlag;

        /// <summary>
        /// 买开平标志
        /// </summary>
        public EnumOffsetFlagType BidOffsetFlag;

        /// <summary>
        /// 卖投机套保标志
        /// </summary>
        public EnumHedgeFlagType AskHedgeFlag;

        /// <summary>
        /// 买投机套保标志
        /// </summary>
        public EnumHedgeFlagType BidHedgeFlag;

        /// <summary>
        /// 本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报价提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 报价提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 报价状态
        /// </summary>
        public EnumOrderStatusType QuoteStatus;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 卖方报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AskOrderSysID;

        /// <summary>
        /// 买方报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BidOrderSysID;

        /// <summary>
        /// 应价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所报价查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeQuoteField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 报价操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryQuoteActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易所报价操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeQuoteActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报价操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所报价操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeQuoteActionField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 期权合约delta值
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionInstrDeltaField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// Delta值
        /// </summary>
        public double Delta;

    };

    /// <summary>
    /// 发给做市商的询价请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcForQuoteRspField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 询价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;

        /// <summary>
        /// 询价时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ForQuoteTime;

        /// <summary>
        /// 业务日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 当前期权合约执行偏移值的详细内容
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcStrikeOffsetField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 执行偏移值
        /// </summary>
        public double Offset;

        /// <summary>
        /// 执行偏移类型
        /// </summary>
        public EnumStrikeOffsetTypeType OffsetType;

    };

    /// <summary>
    /// 期权执行偏移值查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryStrikeOffsetField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 输入批量报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputBatchOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 批量报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBatchOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所批量报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeBatchOrderActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 查询批量报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBatchOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 组合合约安全系数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombInstrumentGuardField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 
        /// </summary>
        public double GuarantRatio;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 组合合约安全系数查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombInstrumentGuardField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 输入的申请组合
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputCombActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 组合引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombActionRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 组合指令方向
        /// </summary>
        public EnumCombDirectionType CombDirection;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 申请组合
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 组合引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombActionRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 组合指令方向
        /// </summary>
        public EnumCombDirectionType CombDirection;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 本地申请组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 组合状态
        /// </summary>
        public EnumOrderActionStatusType ActionStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 申请组合查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 交易所申请组合信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeCombActionField
    {
        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 组合指令方向
        /// </summary>
        public EnumCombDirectionType CombDirection;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 本地申请组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 组合状态
        /// </summary>
        public EnumOrderActionStatusType ActionStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

    };

    /// <summary>
    /// 交易所申请组合查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeCombActionField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 产品报价汇率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcProductExchRateField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 报价币种类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string QuoteCurrencyID;

        /// <summary>
        /// 汇率
        /// </summary>
        public double ExchangeRate;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 产品报价汇率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryProductExchRateField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询询价价差参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryForQuoteParamField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 询价价差参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcForQuoteParamField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 价差
        /// </summary>
        public double PriceInterval;

    };

    /// <summary>
    /// 当前做市商期权合约手续费的详细内容
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMMOptionInstrCommRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;

        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;

        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;

        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;

        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;

        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;

        /// <summary>
        /// 执行手续费率
        /// </summary>
        public double StrikeRatioByMoney;

        /// <summary>
        /// 执行手续费
        /// </summary>
        public double StrikeRatioByVolume;

    };

    /// <summary>
    /// 做市商期权手续费率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMMOptionInstrCommRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 做市商合约手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMMInstrumentCommissionRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;

        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;

        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;

        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;

        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;

        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;

    };

    /// <summary>
    /// 查询做市商合约手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMMInstrumentCommissionRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 当前报单手续费的详细内容
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentOrderCommRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 报单手续费
        /// </summary>
        public double OrderCommByVolume;

        /// <summary>
        /// 撤单手续费
        /// </summary>
        public double OrderActionCommByVolume;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 报单手续费率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentOrderCommRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 交易参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradeParamField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 参数代码
        /// </summary>
        public EnumTradeParamIDType TradeParamID;

        /// <summary>
        /// 参数代码值
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string TradeParamValue;

        /// <summary>
        /// 备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string Memo;

    };

    /// <summary>
    /// 合约保证金率调整
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentMarginRateULField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

    };

    /// <summary>
    /// 期货持仓限制参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcFutureLimitPosiParamField
    {
        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 当日投机开仓数量限制
        /// </summary>
        public int SpecOpenVolume;

        /// <summary>
        /// 当日套利开仓数量限制
        /// </summary>
        public int ArbiOpenVolume;

        /// <summary>
        /// 当日投机+套利开仓数量限制
        /// </summary>
        public int OpenVolume;

    };

    /// <summary>
    /// 禁止登录IP
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLoginForbiddenIPField
    {
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

    };

    /// <summary>
    /// IP列表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcIPListField
    {
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// 是否白名单
        /// </summary>
        public int IsWhite;

    };

    /// <summary>
    /// 输入的期权自对冲
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOptionSelfCloseField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 期权自对冲引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 期权行权的头寸是否自对冲
        /// </summary>
        public EnumOptSelfCloseFlagType OptSelfCloseFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 输入期权自对冲操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOptionSelfCloseActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 期权自对冲操作引用
        /// </summary>
        public int OptionSelfCloseActionRef;

        /// <summary>
        /// 期权自对冲引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 期权自对冲操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 期权自对冲
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionSelfCloseField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 期权自对冲引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 期权行权的头寸是否自对冲
        /// </summary>
        public EnumOptSelfCloseFlagType OptSelfCloseFlag;

        /// <summary>
        /// 本地期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 期权自对冲提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 自对冲结果
        /// </summary>
        public EnumExecResultType ExecResult;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOptionSelfCloseSeq;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 期权自对冲操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOptionSelfCloseActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 期权自对冲操作引用
        /// </summary>
        public int OptionSelfCloseActionRef;

        /// <summary>
        /// 期权自对冲引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 期权自对冲操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 期权自对冲查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOptionSelfCloseField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

    };

    /// <summary>
    /// 交易所期权自对冲信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeOptionSelfCloseField
    {
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 期权行权的头寸是否自对冲
        /// </summary>
        public EnumOptSelfCloseFlagType OptSelfCloseFlag;

        /// <summary>
        /// 本地期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 期权自对冲提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 自对冲结果
        /// </summary>
        public EnumExecResultType ExecResult;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 期权自对冲操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOptionSelfCloseActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易所期权自对冲操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeOptionSelfCloseActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 期权自对冲操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地期权自对冲编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 期权行权的头寸是否自对冲
        /// </summary>
        public EnumOptSelfCloseFlagType OptSelfCloseFlag;

    };

    /// <summary>
    /// 延时换汇同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncDelaySwapField
    {
        /// <summary>
        /// 换汇流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DelaySwapSeqNo;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 源币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;

        /// <summary>
        /// 源金额
        /// </summary>
        public double FromAmount;

        /// <summary>
        /// 源换汇冻结金额(可用冻结)
        /// </summary>
        public double FromFrozenSwap;

        /// <summary>
        /// 源剩余换汇额度(可提冻结)
        /// </summary>
        public double FromRemainSwap;

        /// <summary>
        /// 目标币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;

        /// <summary>
        /// 目标金额
        /// </summary>
        public double ToAmount;

    };

    /// <summary>
    /// 查询延时换汇同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySyncDelaySwapField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 延时换汇流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DelaySwapSeqNo;

    };

    /// <summary>
    /// 投资单元
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestUnitField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 投资者单元名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorUnitName;

        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;

        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;

        /// <summary>
        /// 保证金率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询投资单元
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestUnitField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 二级代理商资金校验模式
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecAgentCheckModeField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 境外中介机构资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;

        /// <summary>
        /// 是否需要校验自己的资金账户
        /// </summary>
        public int CheckSelfAccount;

    };

    /// <summary>
    /// 二级代理商信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecAgentTradeInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 境外中介机构资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 二级代理商姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 市场行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;

        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;

        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

        /// <summary>
        /// 业务日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;

    };

    /// <summary>
    /// 行情基础属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBaseField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;

        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;

    };

    /// <summary>
    /// 行情静态属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataStaticField
    {
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;

    };

    /// <summary>
    /// 行情最新成交属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataLastMatchField
    {
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

    };

    /// <summary>
    /// 行情最优价属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBestPriceField
    {
        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;

        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;

        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;

        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;

    };

    /// <summary>
    /// 行情申买二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBid23Field
    {
        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;

        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;

        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;

        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;

    };

    /// <summary>
    /// 行情申卖二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAsk23Field
    {
        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;

        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;

        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;

        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;

    };

    /// <summary>
    /// 行情申买四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBid45Field
    {
        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;

        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;

        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;

        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;

    };

    /// <summary>
    /// 行情申卖四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAsk45Field
    {
        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;

        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;

        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;

        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;

    };

    /// <summary>
    /// 行情更新时间属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataUpdateTimeField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

        /// <summary>
        /// 业务日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;

    };

    /// <summary>
    /// 行情交易所代码属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 指定的合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSpecificInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 合约状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentStatusField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 结算组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SettlementGroupID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 合约交易状态
        /// </summary>
        public EnumInstrumentStatusType InstrumentStatus;

        /// <summary>
        /// 交易阶段编号
        /// </summary>
        public int TradingSegmentSN;

        /// <summary>
        /// 进入本状态时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EnterTime;

        /// <summary>
        /// 进入本状态原因
        /// </summary>
        public EnumInstStatusEnterReasonType EnterReason;

    };

    /// <summary>
    /// 查询合约状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentStatusField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

    };

    /// <summary>
    /// 投资者账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 浮动盈亏算法
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcPositionProfitAlgorithmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 盈亏算法
        /// </summary>
        public EnumAlgorithmType Algorithm;

        /// <summary>
        /// 备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string Memo;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 会员资金折扣
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDiscountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 资金折扣比例
        /// </summary>
        public double Discount;

    };

    /// <summary>
    /// 查询转帐银行
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTransferBankField
    {
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;

    };

    /// <summary>
    /// 转帐银行
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferBankField
    {
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;

        /// <summary>
        /// 银行名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

    };

    /// <summary>
    /// 查询投资者持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPositionDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPositionDetailField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 买卖
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 开仓日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 开仓价
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 成交类型
        /// </summary>
        public EnumTradeTypeType TradeType;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;

        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;

        /// <summary>
        /// 逐日盯市持仓盈亏
        /// </summary>
        public double PositionProfitByDate;

        /// <summary>
        /// 逐笔对冲持仓盈亏
        /// </summary>
        public double PositionProfitByTrade;

        /// <summary>
        /// 投资者保证金
        /// </summary>
        public double Margin;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchMargin;

        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;

        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;

        /// <summary>
        /// 昨结算价
        /// </summary>
        public double LastSettlementPrice;

        /// <summary>
        /// 结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;

        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;

        /// <summary>
        /// 按照时间顺序平仓的笔数,大商所专用
        /// </summary>
        public int TimeFirstVolume;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 资金账户口令域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingAccountPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 交易所行情报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMDTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所交易员连接状态
        /// </summary>
        public EnumTraderConnectStatusType TraderConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 上次报告日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;

        /// <summary>
        /// 上次报告时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

        /// <summary>
        /// 启动日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;

        /// <summary>
        /// 启动时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 本席位最大成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;

        /// <summary>
        /// 本席位最大报单备拷
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;

    };

    /// <summary>
    /// 查询行情报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMDTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

    };

    /// <summary>
    /// 查询客户通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 客户通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;

        /// <summary>
        /// 经纪公司通知内容序列号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string SequenceLabel;

    };

    /// <summary>
    /// 用户权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserRightField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 客户权限类型
        /// </summary>
        public EnumUserRightTypeType UserRightType;

        /// <summary>
        /// 是否禁止
        /// </summary>
        public int IsForbidden;

    };

    /// <summary>
    /// 查询结算信息确认域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySettlementInfoConfirmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 装载结算信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLoadSettlementInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 经纪公司可提资金算法表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerWithdrawAlgorithmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 可提资金算法
        /// </summary>
        public EnumAlgorithmType WithdrawAlgorithm;

        /// <summary>
        /// 资金使用率
        /// </summary>
        public double UsingRatio;

        /// <summary>
        /// 可提是否包含平仓盈利
        /// </summary>
        public EnumIncludeCloseProfitType IncludeCloseProfit;

        /// <summary>
        /// 本日无仓且无成交客户是否受可提比例限制
        /// </summary>
        public EnumAllWithoutTradeType AllWithoutTrade;

        /// <summary>
        /// 可用是否包含平仓盈利
        /// </summary>
        public EnumIncludeCloseProfitType AvailIncludeCloseProfit;

        /// <summary>
        /// 是否启用用户事件
        /// </summary>
        public int IsBrokerUserEvent;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 货币质押比率
        /// </summary>
        public double FundMortgageRatio;

        /// <summary>
        /// 权益算法
        /// </summary>
        public EnumBalanceAlgorithmType BalanceAlgorithm;

    };

    /// <summary>
    /// 资金账户口令变更域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingAccountPasswordUpdateV1Field
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 原来的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;

        /// <summary>
        /// 新的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;

    };

    /// <summary>
    /// 资金账户口令变更域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingAccountPasswordUpdateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 原来的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;

        /// <summary>
        /// 新的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询组合合约分腿
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombinationLegField
    {
        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;

    };

    /// <summary>
    /// 查询组合合约分腿
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySyncStatusField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

    };

    /// <summary>
    /// 组合交易合约的单腿
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombinationLegField
    {
        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;

        /// <summary>
        /// 派生层数
        /// </summary>
        public int ImplyLevel;

    };

    /// <summary>
    /// 数据同步状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSyncStatusField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 数据同步状态
        /// </summary>
        public EnumDataSyncStatusType DataSyncStatus;

    };

    /// <summary>
    /// 查询联系人
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLinkManField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 联系人
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLinkManField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 联系人类型
        /// </summary>
        public EnumPersonTypeType PersonType;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdentifiedCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string PersonName;

        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮政编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority;

        /// <summary>
        /// 开户邮政编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UOAZipCode;

        /// <summary>
        /// 全称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string PersonFullName;

    };

    /// <summary>
    /// 查询经纪公司用户事件
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerUserEventField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户事件类型
        /// </summary>
        public EnumUserEventTypeType UserEventType;

    };

    /// <summary>
    /// 查询经纪公司用户事件
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserEventField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户事件类型
        /// </summary>
        public EnumUserEventTypeType UserEventType;

        /// <summary>
        /// 用户事件序号
        /// </summary>
        public int EventSequenceNo;

        /// <summary>
        /// 事件发生日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventDate;

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventTime;

        /// <summary>
        /// 用户事件信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
        public string UserEventInfo;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 查询签约银行请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryContractBankField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;

    };

    /// <summary>
    /// 查询签约银行响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcContractBankField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;

        /// <summary>
        /// 银行名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;

    };

    /// <summary>
    /// 投资者组合持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPositionCombineDetailField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 开仓日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;

        /// <summary>
        /// 撮合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 买卖
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 持仓量
        /// </summary>
        public int TotalAmt;

        /// <summary>
        /// 投资者保证金
        /// </summary>
        public double Margin;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchMargin;

        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;

        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;

        /// <summary>
        /// 组合持仓合约编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 成交组号
        /// </summary>
        public int TradeGroupID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 预埋单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcParkedOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 预埋报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;

        /// <summary>
        /// 用户类型
        /// </summary>
        public EnumUserTypeType UserType;

        /// <summary>
        /// 预埋单状态
        /// </summary>
        public EnumParkedOrderStatusType Status;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 输入预埋单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcParkedOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 预埋撤单单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;

        /// <summary>
        /// 用户类型
        /// </summary>
        public EnumUserTypeType UserType;

        /// <summary>
        /// 预埋撤单状态
        /// </summary>
        public EnumParkedOrderStatusType Status;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 查询预埋单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryParkedOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询预埋撤单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryParkedOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 删除预埋单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRemoveParkedOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 预埋报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 删除预埋撤单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRemoveParkedOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 预埋撤单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 经纪公司可提资金算法表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorWithdrawAlgorithmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 可提资金比例
        /// </summary>
        public double UsingRatio;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 货币质押比率
        /// </summary>
        public double FundMortgageRatio;

    };

    /// <summary>
    /// 查询组合持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPositionCombineDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合持仓合约编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 成交均价
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAveragePriceField
    {
        /// <summary>
        /// 当日均价
        /// </summary>
        public double AveragePrice;

    };

    /// <summary>
    /// 校验投资者密码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcVerifyInvestorPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

    };

    /// <summary>
    /// 用户IP
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserIPField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// IP地址掩码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPMask;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 用户事件通知信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingNoticeInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;

        /// <summary>
        /// 序列系列号
        /// </summary>
        public short SequenceSeries;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 用户事件通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumInvestorRangeType InvestorRange;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 序列系列号
        /// </summary>
        public short SequenceSeries;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询交易事件通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradingNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询错误报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryErrOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 错误报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcErrOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 查询错误报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcErrorConditionalOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 报单来源
        /// </summary>
        public EnumOrderSourceType OrderSource;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 报单类型
        /// </summary>
        public EnumOrderTypeType OrderType;

        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;

        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;

        /// <summary>
        /// 相关报单
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;

        /// <summary>
        /// 郑商所成交数量
        /// </summary>
        public int ZCETotalTradedVolume;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 查询错误报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryErrOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 错误报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcErrOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 营业部编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 查询交易所状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeSequenceField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易所状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeSequenceField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 合约交易状态
        /// </summary>
        public EnumInstrumentStatusType MarketStatus;

    };

    /// <summary>
    /// 根据价格查询最大报单数量
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQueryMaxOrderVolumeWithPriceField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 最大允许报单数量
        /// </summary>
        public int MaxVolume;

        /// <summary>
        /// 报单价格
        /// </summary>
        public double Price;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询经纪公司交易参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerTradingParamsField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 经纪公司交易参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerTradingParamsField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 保证金价格类型
        /// </summary>
        public EnumMarginPriceTypeType MarginPriceType;

        /// <summary>
        /// 盈亏算法
        /// </summary>
        public EnumAlgorithmType Algorithm;

        /// <summary>
        /// 可用是否包含平仓盈利
        /// </summary>
        public EnumIncludeCloseProfitType AvailIncludeCloseProfit;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 期权权利金价格类型
        /// </summary>
        public EnumOptionRoyaltyPriceTypeType OptionRoyaltyPriceType;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 查询经纪公司交易算法
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerTradingAlgosField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 经纪公司交易算法
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerTradingAlgosField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 持仓处理算法编号
        /// </summary>
        public EnumHandlePositionAlgoIDType HandlePositionAlgoID;

        /// <summary>
        /// 寻找保证金率算法编号
        /// </summary>
        public EnumFindMarginRateAlgoIDType FindMarginRateAlgoID;

        /// <summary>
        /// 资金处理算法编号
        /// </summary>
        public EnumHandleTradingAccountAlgoIDType HandleTradingAccountAlgoID;

    };

    /// <summary>
    /// 查询经纪公司资金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQueryBrokerDepositField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 经纪公司资金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerDepositField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;

        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 期货结算准备金
        /// </summary>
        public double Balance;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;

        /// <summary>
        /// 可提资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

    };

    /// <summary>
    /// 查询保证金监管系统经纪公司密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCFMMCBrokerKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 保证金监管系统经纪公司密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCFMMCBrokerKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司统一编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 密钥生成日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;

        /// <summary>
        /// 密钥生成时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateTime;

        /// <summary>
        /// 密钥编号
        /// </summary>
        public int KeyID;

        /// <summary>
        /// 动态密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;

        /// <summary>
        /// 动态密钥类型
        /// </summary>
        public EnumCFMMCKeyKindType KeyKind;

    };

    /// <summary>
    /// 保证金监管系统经纪公司资金账户密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCFMMCTradingAccountKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司统一编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 密钥编号
        /// </summary>
        public int KeyID;

        /// <summary>
        /// 动态密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;

    };

    /// <summary>
    /// 请求查询保证金监管系统经纪公司资金账户密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCFMMCTradingAccountKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 用户动态令牌参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserOTPParamField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 动态令牌提供商
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string OTPVendorsID;

        /// <summary>
        /// 动态令牌序列号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string SerialNumber;

        /// <summary>
        /// 令牌密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AuthKey;

        /// <summary>
        /// 漂移值
        /// </summary>
        public int LastDrift;

        /// <summary>
        /// 成功值
        /// </summary>
        public int LastSuccess;

        /// <summary>
        /// 动态令牌类型
        /// </summary>
        public EnumOTPTypeType OTPType;

    };

    /// <summary>
    /// 手工同步用户动态令牌
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcManualSyncBrokerUserOTPField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 动态令牌类型
        /// </summary>
        public EnumOTPTypeType OTPType;

        /// <summary>
        /// 第一个动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string FirstOTP;

        /// <summary>
        /// 第二个动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SecondOTP;

    };

    /// <summary>
    /// 投资者手续费率模板
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCommRateModelField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;

        /// <summary>
        /// 模板名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CommModelName;

    };

    /// <summary>
    /// 请求查询投资者手续费率模板
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCommRateModelField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;

    };

    /// <summary>
    /// 投资者保证金率模板
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarginModelField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 保证金率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;

        /// <summary>
        /// 模板名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string MarginModelName;

    };

    /// <summary>
    /// 请求查询投资者保证金率模板
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMarginModelField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 保证金率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;

    };

    /// <summary>
    /// 仓单折抵信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcEWarrantOffsetField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询仓单折抵信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryEWarrantOffsetField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询投资者品种/跨品种保证金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorProductGroupMarginField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 品种/跨品种标示
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者品种/跨品种保证金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorProductGroupMarginField
    {
        /// <summary>
        /// 品种/跨品种标示
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 多头冻结的保证金
        /// </summary>
        public double LongFrozenMargin;

        /// <summary>
        /// 空头冻结的保证金
        /// </summary>
        public double ShortFrozenMargin;

        /// <summary>
        /// 占用的保证金
        /// </summary>
        public double UseMargin;

        /// <summary>
        /// 多头保证金
        /// </summary>
        public double LongUseMargin;

        /// <summary>
        /// 空头保证金
        /// </summary>
        public double ShortUseMargin;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchMargin;

        /// <summary>
        /// 交易所多头保证金
        /// </summary>
        public double LongExchMargin;

        /// <summary>
        /// 交易所空头保证金
        /// </summary>
        public double ShortExchMargin;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 折抵总金额
        /// </summary>
        public double OffsetAmount;

        /// <summary>
        /// 多头折抵总金额
        /// </summary>
        public double LongOffsetAmount;

        /// <summary>
        /// 空头折抵总金额
        /// </summary>
        public double ShortOffsetAmount;

        /// <summary>
        /// 交易所折抵总金额
        /// </summary>
        public double ExchOffsetAmount;

        /// <summary>
        /// 交易所多头折抵总金额
        /// </summary>
        public double LongExchOffsetAmount;

        /// <summary>
        /// 交易所空头折抵总金额
        /// </summary>
        public double ShortExchOffsetAmount;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询监控中心用户令牌
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQueryCFMMCTradingAccountTokenField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 监控中心用户令牌
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCFMMCTradingAccountTokenField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司统一编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 密钥编号
        /// </summary>
        public int KeyID;

        /// <summary>
        /// 动态令牌
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string Token;

    };

    /// <summary>
    /// 查询产品组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryProductGroupField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 投资者品种/跨品种保证金产品组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcProductGroupField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;

    };

    /// <summary>
    /// 交易所公告
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBulletinField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 公告编号
        /// </summary>
        public int BulletinID;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 公告类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string NewsType;

        /// <summary>
        /// 紧急程度
        /// </summary>
        public byte NewsUrgency;

        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;

        /// <summary>
        /// 消息摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string Abstract;

        /// <summary>
        /// 消息来源
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComeFrom;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;

        /// <summary>
        /// WEB地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 201)]
        public string URLLink;

        /// <summary>
        /// 市场代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;

    };

    /// <summary>
    /// 查询交易所公告
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBulletinField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 公告编号
        /// </summary>
        public int BulletinID;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 公告类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string NewsType;

        /// <summary>
        /// 紧急程度
        /// </summary>
        public byte NewsUrgency;

    };

    /// <summary>
    /// 转帐开户请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqOpenAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 汇钞标志
        /// </summary>
        public EnumCashExchangeCodeType CashExchangeCode;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 转帐销户请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqCancelAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 汇钞标志
        /// </summary>
        public EnumCashExchangeCodeType CashExchangeCode;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 变更银行账户请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqChangeAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 新银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;

        /// <summary>
        /// 新银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 转账请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqTransferField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;

        /// <summary>
        /// 费用支付标志
        /// </summary>
        public EnumFeePayFlagType FeePayFlag;

        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;

        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 转账交易状态
        /// </summary>
        public EnumTransferStatusType TransferStatus;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 银行发起银行资金转期货响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspTransferField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;

        /// <summary>
        /// 费用支付标志
        /// </summary>
        public EnumFeePayFlagType FeePayFlag;

        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;

        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 转账交易状态
        /// </summary>
        public EnumTransferStatusType TransferStatus;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 冲正请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqRepealField
    {
        /// <summary>
        /// 冲正时间间隔
        /// </summary>
        public int RepealTimeInterval;

        /// <summary>
        /// 已经冲正次数
        /// </summary>
        public int RepealedTimes;

        /// <summary>
        /// 银行冲正标志
        /// </summary>
        public EnumBankRepealFlagType BankRepealFlag;

        /// <summary>
        /// 期商冲正标志
        /// </summary>
        public EnumBrokerRepealFlagType BrokerRepealFlag;

        /// <summary>
        /// 被冲正平台流水号
        /// </summary>
        public int PlateRepealSerial;

        /// <summary>
        /// 被冲正银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;

        /// <summary>
        /// 被冲正期货流水号
        /// </summary>
        public int FutureRepealSerial;

        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;

        /// <summary>
        /// 费用支付标志
        /// </summary>
        public EnumFeePayFlagType FeePayFlag;

        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;

        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 转账交易状态
        /// </summary>
        public EnumTransferStatusType TransferStatus;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 冲正响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspRepealField
    {
        /// <summary>
        /// 冲正时间间隔
        /// </summary>
        public int RepealTimeInterval;

        /// <summary>
        /// 已经冲正次数
        /// </summary>
        public int RepealedTimes;

        /// <summary>
        /// 银行冲正标志
        /// </summary>
        public EnumBankRepealFlagType BankRepealFlag;

        /// <summary>
        /// 期商冲正标志
        /// </summary>
        public EnumBrokerRepealFlagType BrokerRepealFlag;

        /// <summary>
        /// 被冲正平台流水号
        /// </summary>
        public int PlateRepealSerial;

        /// <summary>
        /// 被冲正银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;

        /// <summary>
        /// 被冲正期货流水号
        /// </summary>
        public int FutureRepealSerial;

        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;

        /// <summary>
        /// 费用支付标志
        /// </summary>
        public EnumFeePayFlagType FeePayFlag;

        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;

        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 转账交易状态
        /// </summary>
        public EnumTransferStatusType TransferStatus;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 查询账户信息请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqQueryAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 查询账户信息响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspQueryAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 银行可用金额
        /// </summary>
        public double BankUseAmount;

        /// <summary>
        /// 银行可取金额
        /// </summary>
        public double BankFetchAmount;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 期商签到签退
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcFutureSignIOField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

    };

    /// <summary>
    /// 期商签到响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspFutureSignInField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// PIN密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;

        /// <summary>
        /// MAC密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;

    };

    /// <summary>
    /// 期商签退请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqFutureSignOutField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

    };

    /// <summary>
    /// 期商签退响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspFutureSignOutField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 查询指定流水号的交易结果请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqQueryTradeResultBySerialField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 流水号
        /// </summary>
        public int Reference;

        /// <summary>
        /// 本流水号发布者的机构类型
        /// </summary>
        public EnumInstitutionTypeType RefrenceIssureType;

        /// <summary>
        /// 本流水号发布者机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 查询指定流水号的交易结果响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspQueryTradeResultBySerialField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 流水号
        /// </summary>
        public int Reference;

        /// <summary>
        /// 本流水号发布者的机构类型
        /// </summary>
        public EnumInstitutionTypeType RefrenceIssureType;

        /// <summary>
        /// 本流水号发布者机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;

        /// <summary>
        /// 原始返回代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string OriginReturnCode;

        /// <summary>
        /// 原始返回码描述
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string OriginDescrInfoForReturnCode;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

    };

    /// <summary>
    /// 日终文件就绪请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqDayEndFileReadyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 文件业务功能
        /// </summary>
        public EnumFileBusinessCodeType FileBusinessCode;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

    };

    /// <summary>
    /// 返回结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReturnResultField
    {
        /// <summary>
        /// 返回代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;

        /// <summary>
        /// 返回码描述
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;

    };

    /// <summary>
    /// 验证期货资金密码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcVerifyFuturePasswordField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 验证客户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcVerifyCustInfoField
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 验证期货资金密码和客户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcVerifyFuturePasswordAndCustInfoField
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 验证期货资金密码和客户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDepositResultInformField
    {
        /// <summary>
        /// 出入金流水号，该流水号为银期报盘返回的流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 返回代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;

        /// <summary>
        /// 返回码描述
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;

    };

    /// <summary>
    /// 交易核心向银期报盘发出密钥同步请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqSyncKeyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易核心给银期报盘的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

    };

    /// <summary>
    /// 交易核心向银期报盘发出密钥同步响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspSyncKeyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易核心给银期报盘的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 查询账户信息通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcNotifyQueryAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 银行可用金额
        /// </summary>
        public double BankUseAmount;

        /// <summary>
        /// 银行可取金额
        /// </summary>
        public double BankFetchAmount;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 银期转账交易流水表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferSerialField
    {
        /// <summary>
        /// 平台流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 交易发起方日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 期货公司编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 期货公司帐号类型
        /// </summary>
        public EnumFutureAccTypeType FutureAccType;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 交易金额
        /// </summary>
        public double TradeAmount;

        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;

        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;

        /// <summary>
        /// 有效标志
        /// </summary>
        public EnumAvailabilityFlagType AvailabilityFlag;

        /// <summary>
        /// 操作员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperatorCode;

        /// <summary>
        /// 新银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankNewAccount;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 请求查询转帐流水
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTransferSerialField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 期商签到通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcNotifyFutureSignInField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// PIN密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;

        /// <summary>
        /// MAC密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;

    };

    /// <summary>
    /// 期商签退通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcNotifyFutureSignOutField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 交易核心向银期报盘发出密钥同步处理结果的通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcNotifySyncKeyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易核心给银期报盘的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 请求查询银期签约关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryAccountregisterField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 客户开销户信息表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcAccountregisterField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDay;

        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 期货公司编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期货公司分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 开销户类别
        /// </summary>
        public EnumOpenOrDestroyType OpenOrDestroy;

        /// <summary>
        /// 签约日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string RegDate;

        /// <summary>
        /// 解约日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OutDate;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 银期开户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOpenAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 汇钞标志
        /// </summary>
        public EnumCashExchangeCodeType CashExchangeCode;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 银期销户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCancelAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 汇钞标志
        /// </summary>
        public EnumCashExchangeCodeType CashExchangeCode;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;

        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public EnumBankAccTypeType BankSecuAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 银期变更银行账号信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcChangeAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 新银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;

        /// <summary>
        /// 新银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 银行密码标志
        /// </summary>
        public EnumPwdFlagType BankPwdFlag;

        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public EnumPwdFlagType SecuPwdFlag;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

        /// <summary>
        /// 长客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;

    };

    /// <summary>
    /// 二级代理操作员银期权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecAgentACIDMapField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 境外中介机构资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;

    };

    /// <summary>
    /// 二级代理操作员银期权限查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecAgentACIDMapField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 灾备中心交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserRightsAssignField
    {
        /// <summary>
        /// 应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int DRIdentityID;

    };

    /// <summary>
    /// 经济公司是否有在本标示的交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserRightAssignField
    {
        /// <summary>
        /// 应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int DRIdentityID;

        /// <summary>
        /// 能否交易
        /// </summary>
        public int Tradeable;

    };

    /// <summary>
    /// 灾备交易转换报文
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDRTransferField
    {
        /// <summary>
        /// 原交易中心代码
        /// </summary>
        public int OrigDRIdentityID;

        /// <summary>
        /// 目标交易中心代码
        /// </summary>
        public int DestDRIdentityID;

        /// <summary>
        /// 原应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string OrigBrokerID;

        /// <summary>
        /// 目标易用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string DestBrokerID;

    };

    /// <summary>
    /// Fens用户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcFensUserInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 登录模式
        /// </summary>
        public EnumLoginModeType LoginMode;

    };

    /// <summary>
    /// 当前银期所属交易中心
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCurrTransferIdentityField
    {
        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int IdentityID;

    };

    /// <summary>
    /// 禁止登录用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLoginForbiddenUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

    };

    /// <summary>
    /// 查询禁止登录用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLoginForbiddenUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// UDP组播组信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMulticastGroupInfoField
    {
        /// <summary>
        /// 组播组IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string GroupIP;

        /// <summary>
        /// 组播组IP端口
        /// </summary>
        public int GroupPort;

        /// <summary>
        /// 源地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string SourceIP;

    };

    /// <summary>
    /// 资金账户基本准备金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingAccountReserveField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询禁止登录IP
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLoginForbiddenIPField
    {
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

    };

    /// <summary>
    /// 查询IP列表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryIPListField
    {
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

    };

    /// <summary>
    /// 查询用户下单权限分配表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserRightsAssignField
    {
        /// <summary>
        /// 应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 银期预约开户确认请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReserveOpenAccountConfirmField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 预约开户银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankReserveOpenSeq;

        /// <summary>
        /// 预约开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BookDate;

        /// <summary>
        /// 预约开户验证密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BookPsw;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 银期预约开户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReserveOpenAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;

        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;

        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;

        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;

        /// <summary>
        /// 最后分片标志
        /// </summary>
        public EnumLastFragmentType LastFragment;

        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CustomerName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 性别
        /// </summary>
        public EnumGenderType Gender;

        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;

        /// <summary>
        /// 客户类型
        /// </summary>
        public EnumCustTypeType CustType;

        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;

        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;

        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;

        /// <summary>
        /// 资金账户状态
        /// </summary>
        public EnumMoneyAccountStatusType MoneyAccountStatus;

        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public EnumYesNoIndicatorType VerifyCertNoFlag;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;

        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public EnumBankAccTypeType BankAccType;

        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;

        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;

        /// <summary>
        /// 预约开户状态
        /// </summary>
        public EnumReserveOpenAccStasType ReserveOpenAccStas;

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 银行账户属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcAccountPropertyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 银行统一标识类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;

        /// <summary>
        /// 银行账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;

        /// <summary>
        /// 银行账户的开户人名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string OpenName;

        /// <summary>
        /// 银行账户的开户行
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string OpenBank;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 账户来源
        /// </summary>
        public EnumAccountSourceTypeType AccountSourceType;

        /// <summary>
        /// 开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 注销日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelDate;

        /// <summary>
        /// 录入员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string OperatorID;

        /// <summary>
        /// 录入日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateDate;

        /// <summary>
        /// 录入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateTime;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询当前交易中心
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCurrDRIdentityField
    {
        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int DRIdentityID;

    };

    /// <summary>
    /// 当前交易中心
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCurrDRIdentityField
    {
        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int DRIdentityID;

    };

    /// <summary>
    /// 查询二级代理商资金校验模式
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecAgentCheckModeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 查询二级代理商信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecAgentTradeInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 境外中介机构资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;

    };

    /// <summary>
    /// 用户系统信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserSystemInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端系统内部信息长度
        /// </summary>
        public int ClientSystemInfoLen;

        /// <summary>
        /// 用户端系统内部信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 273)]
        public byte[] ClientSystemInfo;

        /// <summary>
        /// 用户公网IP
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientPublicIP;

        /// <summary>
        /// 终端IP端口
        /// </summary>
        public int ClientIPPort;

        /// <summary>
        /// 登录成功时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ClientLoginTime;

        /// <summary>
        /// App代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string ClientAppID;

    };

    /// <summary>
    /// 用户发出获取安全安全登陆方法请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserAuthMethodField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 用户发出获取安全安全登陆方法回复
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserAuthMethodField
    {
        /// <summary>
        /// 当前可以用的认证模式
        /// </summary>
        public int UsableAuthMethod;

    };

    /// <summary>
    /// 用户发出获取安全安全登陆方法请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqGenUserCaptchaField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 生成的图片验证码信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspGenUserCaptchaField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 图片信息长度
        /// </summary>
        public int CaptchaInfoLen;

        /// <summary>
        /// 图片信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2561)]
        public string CaptchaInfo;

    };

    /// <summary>
    /// 用户发出获取安全安全登陆方法请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqGenUserTextField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 短信验证码生成的回复
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspGenUserTextField
    {
        /// <summary>
        /// 短信验证码序号
        /// </summary>
        public int UserTextSeq;

    };

    /// <summary>
    /// 用户发出带图形验证码的登录请求请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLoginWithCaptchaField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 终端IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;

        /// <summary>
        /// 登录备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;

        /// <summary>
        /// 图形验证码的文字内容
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Captcha;

        /// <summary>
        /// 终端IP端口
        /// </summary>
        public int ClientIPPort;

    };

    /// <summary>
    /// 用户发出带短信验证码的登录请求请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLoginWithTextField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 终端IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;

        /// <summary>
        /// 登录备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;

        /// <summary>
        /// 短信验证码文字内容
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Text;

        /// <summary>
        /// 终端IP端口
        /// </summary>
        public int ClientIPPort;

    };

    /// <summary>
    /// 用户发出带动态验证码的登录请求请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLoginWithOTPField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 终端IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;

        /// <summary>
        /// 登录备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;

        /// <summary>
        /// OTP密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OTPPassword;

        /// <summary>
        /// 终端IP端口
        /// </summary>
        public int ClientIPPort;

    };

    /// <summary>
    /// api握手请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqApiHandshakeField
    {
        /// <summary>
        /// api与front通信密钥版本号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CryptoKeyVersion;

    };

    /// <summary>
    /// front发给api的握手回复
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspApiHandshakeField
    {
        /// <summary>
        /// 握手回复数据长度
        /// </summary>
        public int FrontHandshakeDataLen;

        /// <summary>
        /// 握手回复数据
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 301)]
        public string FrontHandshakeData;

        /// <summary>
        /// API认证是否开启
        /// </summary>
        public int IsApiAuthEnabled;

    };

    /// <summary>
    /// api给front的验证key的请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqVerifyApiKeyField
    {
        /// <summary>
        /// 握手回复数据长度
        /// </summary>
        public int ApiHandshakeDataLen;

        /// <summary>
        /// 握手回复数据
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 301)]
        public string ApiHandshakeData;

    };

    /// <summary>
    /// 操作员组织架构关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDepartmentUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者范围
        /// </summary>
        public EnumDepartmentRangeType InvestorRange;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 查询频率，每秒查询比数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQueryFreqField
    {
        /// <summary>
        /// 查询频率
        /// </summary>
        public int QueryFreq;

    };

}; // end of namespace
