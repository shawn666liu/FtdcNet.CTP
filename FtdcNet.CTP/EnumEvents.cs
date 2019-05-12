/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2019/5/12 13:31:52
/////////////////////////////////////////////////////////////////////////

using System;

namespace CTP
{

    // 注意，注意：所有索引值必须与c语言enums.h中的值一一对应，否则回调将会错乱

    /// <summary>
    /// 所有的OnErrRtnXXXX回调事件
    /// </summary>
    public enum EnumOnErrRtnType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///报单录入错误回报, ThostFtdcInputOrderField
        /// </summary>
        OnErrRtnOrderInsert,
        /// <summary>
        ///报单操作错误回报, ThostFtdcOrderActionField
        /// </summary>
        OnErrRtnOrderAction,
        /// <summary>
        ///执行宣告录入错误回报, ThostFtdcInputExecOrderField
        /// </summary>
        OnErrRtnExecOrderInsert,
        /// <summary>
        ///执行宣告操作错误回报, ThostFtdcExecOrderActionField
        /// </summary>
        OnErrRtnExecOrderAction,
        /// <summary>
        ///询价录入错误回报, ThostFtdcInputForQuoteField
        /// </summary>
        OnErrRtnForQuoteInsert,
        /// <summary>
        ///报价录入错误回报, ThostFtdcInputQuoteField
        /// </summary>
        OnErrRtnQuoteInsert,
        /// <summary>
        ///报价操作错误回报, ThostFtdcQuoteActionField
        /// </summary>
        OnErrRtnQuoteAction,
        /// <summary>
        ///批量报单操作错误回报, ThostFtdcBatchOrderActionField
        /// </summary>
        OnErrRtnBatchOrderAction,
        /// <summary>
        ///期权自对冲录入错误回报, ThostFtdcInputOptionSelfCloseField
        /// </summary>
        OnErrRtnOptionSelfCloseInsert,
        /// <summary>
        ///期权自对冲操作错误回报, ThostFtdcOptionSelfCloseActionField
        /// </summary>
        OnErrRtnOptionSelfCloseAction,
        /// <summary>
        ///申请组合录入错误回报, ThostFtdcInputCombActionField
        /// </summary>
        OnErrRtnCombActionInsert,
        /// <summary>
        ///期货发起银行资金转期货错误回报, ThostFtdcReqTransferField
        /// </summary>
        OnErrRtnBankToFutureByFuture,
        /// <summary>
        ///期货发起期货资金转银行错误回报, ThostFtdcReqTransferField
        /// </summary>
        OnErrRtnFutureToBankByFuture,
        /// <summary>
        ///系统运行时期货端手工发起冲正银行转期货错误回报, ThostFtdcReqRepealField
        /// </summary>
        OnErrRtnRepealBankToFutureByFutureManual,
        /// <summary>
        ///系统运行时期货端手工发起冲正期货转银行错误回报, ThostFtdcReqRepealField
        /// </summary>
        OnErrRtnRepealFutureToBankByFutureManual,
        /// <summary>
        ///期货发起查询银行余额错误回报, ThostFtdcReqQueryAccountField
        /// </summary>
        OnErrRtnQueryBankBalanceByFuture,
    };

    /// <summary>
    /// 所有的OnFrontXXXX回调事件
    /// </summary>
    public enum EnumOnFrontType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
        /// </summary>
        OnFrontConnected,
        /// <summary>
        ///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
        ///@param nReason 错误原因
        ///        0x1001 网络读失败
        ///        0x1002 网络写失败
        ///        0x2001 接收心跳超时
        ///        0x2002 发送心跳失败
        ///        0x2003 收到错误报文, int
        /// </summary>
        OnFrontDisconnected,
    };

    /// <summary>
    /// 所有的OnRspXXXX回调事件
    /// </summary>
    public enum EnumOnRspType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///登录请求响应, ThostFtdcRspUserLoginField
        /// </summary>
        OnRspUserLogin,
        /// <summary>
        ///登出请求响应, ThostFtdcUserLogoutField
        /// </summary>
        OnRspUserLogout,
        /// <summary>
        ///错误应答, ThostFtdcRspInfoField
        /// </summary>
        OnRspError,
        /// <summary>
        ///订阅行情应答, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspSubMarketData,
        /// <summary>
        ///取消订阅行情应答, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspUnSubMarketData,
        /// <summary>
        ///订阅询价应答, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspSubForQuoteRsp,
        /// <summary>
        ///取消订阅询价应答, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspUnSubForQuoteRsp,
        /// <summary>
        ///客户端认证响应, ThostFtdcRspAuthenticateField
        /// </summary>
        OnRspAuthenticate,
        /// <summary>
        ///用户口令更新请求响应, ThostFtdcUserPasswordUpdateField
        /// </summary>
        OnRspUserPasswordUpdate,
        /// <summary>
        ///资金账户口令更新请求响应, ThostFtdcTradingAccountPasswordUpdateField
        /// </summary>
        OnRspTradingAccountPasswordUpdate,
        /// <summary>
        ///查询用户当前支持的认证模式的回复, ThostFtdcRspUserAuthMethodField
        /// </summary>
        OnRspUserAuthMethod,
        /// <summary>
        ///获取图形验证码请求的回复, ThostFtdcRspGenUserCaptchaField
        /// </summary>
        OnRspGenUserCaptcha,
        /// <summary>
        ///获取短信验证码请求的回复, ThostFtdcRspGenUserTextField
        /// </summary>
        OnRspGenUserText,
        /// <summary>
        ///报单录入请求响应, ThostFtdcInputOrderField
        /// </summary>
        OnRspOrderInsert,
        /// <summary>
        ///预埋单录入请求响应, ThostFtdcParkedOrderField
        /// </summary>
        OnRspParkedOrderInsert,
        /// <summary>
        ///预埋撤单录入请求响应, ThostFtdcParkedOrderActionField
        /// </summary>
        OnRspParkedOrderAction,
        /// <summary>
        ///报单操作请求响应, ThostFtdcInputOrderActionField
        /// </summary>
        OnRspOrderAction,
        /// <summary>
        ///查询最大报单数量响应, ThostFtdcQueryMaxOrderVolumeField
        /// </summary>
        OnRspQueryMaxOrderVolume,
        /// <summary>
        ///投资者结算结果确认响应, ThostFtdcSettlementInfoConfirmField
        /// </summary>
        OnRspSettlementInfoConfirm,
        /// <summary>
        ///删除预埋单响应, ThostFtdcRemoveParkedOrderField
        /// </summary>
        OnRspRemoveParkedOrder,
        /// <summary>
        ///删除预埋撤单响应, ThostFtdcRemoveParkedOrderActionField
        /// </summary>
        OnRspRemoveParkedOrderAction,
        /// <summary>
        ///执行宣告录入请求响应, ThostFtdcInputExecOrderField
        /// </summary>
        OnRspExecOrderInsert,
        /// <summary>
        ///执行宣告操作请求响应, ThostFtdcInputExecOrderActionField
        /// </summary>
        OnRspExecOrderAction,
        /// <summary>
        ///询价录入请求响应, ThostFtdcInputForQuoteField
        /// </summary>
        OnRspForQuoteInsert,
        /// <summary>
        ///报价录入请求响应, ThostFtdcInputQuoteField
        /// </summary>
        OnRspQuoteInsert,
        /// <summary>
        ///报价操作请求响应, ThostFtdcInputQuoteActionField
        /// </summary>
        OnRspQuoteAction,
        /// <summary>
        ///批量报单操作请求响应, ThostFtdcInputBatchOrderActionField
        /// </summary>
        OnRspBatchOrderAction,
        /// <summary>
        ///期权自对冲录入请求响应, ThostFtdcInputOptionSelfCloseField
        /// </summary>
        OnRspOptionSelfCloseInsert,
        /// <summary>
        ///期权自对冲操作请求响应, ThostFtdcInputOptionSelfCloseActionField
        /// </summary>
        OnRspOptionSelfCloseAction,
        /// <summary>
        ///申请组合录入请求响应, ThostFtdcInputCombActionField
        /// </summary>
        OnRspCombActionInsert,
        /// <summary>
        ///请求查询报单响应, ThostFtdcOrderField
        /// </summary>
        OnRspQryOrder,
        /// <summary>
        ///请求查询成交响应, ThostFtdcTradeField
        /// </summary>
        OnRspQryTrade,
        /// <summary>
        ///请求查询投资者持仓响应, ThostFtdcInvestorPositionField
        /// </summary>
        OnRspQryInvestorPosition,
        /// <summary>
        ///请求查询资金账户响应, ThostFtdcTradingAccountField
        /// </summary>
        OnRspQryTradingAccount,
        /// <summary>
        ///请求查询投资者响应, ThostFtdcInvestorField
        /// </summary>
        OnRspQryInvestor,
        /// <summary>
        ///请求查询交易编码响应, ThostFtdcTradingCodeField
        /// </summary>
        OnRspQryTradingCode,
        /// <summary>
        ///请求查询合约保证金率响应, ThostFtdcInstrumentMarginRateField
        /// </summary>
        OnRspQryInstrumentMarginRate,
        /// <summary>
        ///请求查询合约手续费率响应, ThostFtdcInstrumentCommissionRateField
        /// </summary>
        OnRspQryInstrumentCommissionRate,
        /// <summary>
        ///请求查询交易所响应, ThostFtdcExchangeField
        /// </summary>
        OnRspQryExchange,
        /// <summary>
        ///请求查询产品响应, ThostFtdcProductField
        /// </summary>
        OnRspQryProduct,
        /// <summary>
        ///请求查询合约响应, ThostFtdcInstrumentField
        /// </summary>
        OnRspQryInstrument,
        /// <summary>
        ///请求查询行情响应, ThostFtdcDepthMarketDataField
        /// </summary>
        OnRspQryDepthMarketData,
        /// <summary>
        ///请求查询投资者结算结果响应, ThostFtdcSettlementInfoField
        /// </summary>
        OnRspQrySettlementInfo,
        /// <summary>
        ///请求查询转帐银行响应, ThostFtdcTransferBankField
        /// </summary>
        OnRspQryTransferBank,
        /// <summary>
        ///请求查询投资者持仓明细响应, ThostFtdcInvestorPositionDetailField
        /// </summary>
        OnRspQryInvestorPositionDetail,
        /// <summary>
        ///请求查询客户通知响应, ThostFtdcNoticeField
        /// </summary>
        OnRspQryNotice,
        /// <summary>
        ///请求查询结算信息确认响应, ThostFtdcSettlementInfoConfirmField
        /// </summary>
        OnRspQrySettlementInfoConfirm,
        /// <summary>
        ///请求查询投资者持仓明细响应, ThostFtdcInvestorPositionCombineDetailField
        /// </summary>
        OnRspQryInvestorPositionCombineDetail,
        /// <summary>
        ///查询保证金监管系统经纪公司资金账户密钥响应, ThostFtdcCFMMCTradingAccountKeyField
        /// </summary>
        OnRspQryCFMMCTradingAccountKey,
        /// <summary>
        ///请求查询仓单折抵信息响应, ThostFtdcEWarrantOffsetField
        /// </summary>
        OnRspQryEWarrantOffset,
        /// <summary>
        ///请求查询投资者品种/跨品种保证金响应, ThostFtdcInvestorProductGroupMarginField
        /// </summary>
        OnRspQryInvestorProductGroupMargin,
        /// <summary>
        ///请求查询交易所保证金率响应, ThostFtdcExchangeMarginRateField
        /// </summary>
        OnRspQryExchangeMarginRate,
        /// <summary>
        ///请求查询交易所调整保证金率响应, ThostFtdcExchangeMarginRateAdjustField
        /// </summary>
        OnRspQryExchangeMarginRateAdjust,
        /// <summary>
        ///请求查询汇率响应, ThostFtdcExchangeRateField
        /// </summary>
        OnRspQryExchangeRate,
        /// <summary>
        ///请求查询二级代理操作员银期权限响应, ThostFtdcSecAgentACIDMapField
        /// </summary>
        OnRspQrySecAgentACIDMap,
        /// <summary>
        ///请求查询产品报价汇率, ThostFtdcProductExchRateField
        /// </summary>
        OnRspQryProductExchRate,
        /// <summary>
        ///请求查询产品组, ThostFtdcProductGroupField
        /// </summary>
        OnRspQryProductGroup,
        /// <summary>
        ///请求查询做市商合约手续费率响应, ThostFtdcMMInstrumentCommissionRateField
        /// </summary>
        OnRspQryMMInstrumentCommissionRate,
        /// <summary>
        ///请求查询做市商期权合约手续费响应, ThostFtdcMMOptionInstrCommRateField
        /// </summary>
        OnRspQryMMOptionInstrCommRate,
        /// <summary>
        ///请求查询报单手续费响应, ThostFtdcInstrumentOrderCommRateField
        /// </summary>
        OnRspQryInstrumentOrderCommRate,
        /// <summary>
        ///请求查询资金账户响应, ThostFtdcTradingAccountField
        /// </summary>
        OnRspQrySecAgentTradingAccount,
        /// <summary>
        ///请求查询二级代理商资金校验模式响应, ThostFtdcSecAgentCheckModeField
        /// </summary>
        OnRspQrySecAgentCheckMode,
        /// <summary>
        ///请求查询二级代理商信息响应, ThostFtdcSecAgentTradeInfoField
        /// </summary>
        OnRspQrySecAgentTradeInfo,
        /// <summary>
        ///请求查询期权交易成本响应, ThostFtdcOptionInstrTradeCostField
        /// </summary>
        OnRspQryOptionInstrTradeCost,
        /// <summary>
        ///请求查询期权合约手续费响应, ThostFtdcOptionInstrCommRateField
        /// </summary>
        OnRspQryOptionInstrCommRate,
        /// <summary>
        ///请求查询执行宣告响应, ThostFtdcExecOrderField
        /// </summary>
        OnRspQryExecOrder,
        /// <summary>
        ///请求查询询价响应, ThostFtdcForQuoteField
        /// </summary>
        OnRspQryForQuote,
        /// <summary>
        ///请求查询报价响应, ThostFtdcQuoteField
        /// </summary>
        OnRspQryQuote,
        /// <summary>
        ///请求查询期权自对冲响应, ThostFtdcOptionSelfCloseField
        /// </summary>
        OnRspQryOptionSelfClose,
        /// <summary>
        ///请求查询投资单元响应, ThostFtdcInvestUnitField
        /// </summary>
        OnRspQryInvestUnit,
        /// <summary>
        ///请求查询组合合约安全系数响应, ThostFtdcCombInstrumentGuardField
        /// </summary>
        OnRspQryCombInstrumentGuard,
        /// <summary>
        ///请求查询申请组合响应, ThostFtdcCombActionField
        /// </summary>
        OnRspQryCombAction,
        /// <summary>
        ///请求查询转帐流水响应, ThostFtdcTransferSerialField
        /// </summary>
        OnRspQryTransferSerial,
        /// <summary>
        ///请求查询银期签约关系响应, ThostFtdcAccountregisterField
        /// </summary>
        OnRspQryAccountregister,
        /// <summary>
        ///请求查询签约银行响应, ThostFtdcContractBankField
        /// </summary>
        OnRspQryContractBank,
        /// <summary>
        ///请求查询预埋单响应, ThostFtdcParkedOrderField
        /// </summary>
        OnRspQryParkedOrder,
        /// <summary>
        ///请求查询预埋撤单响应, ThostFtdcParkedOrderActionField
        /// </summary>
        OnRspQryParkedOrderAction,
        /// <summary>
        ///请求查询交易通知响应, ThostFtdcTradingNoticeField
        /// </summary>
        OnRspQryTradingNotice,
        /// <summary>
        ///请求查询经纪公司交易参数响应, ThostFtdcBrokerTradingParamsField
        /// </summary>
        OnRspQryBrokerTradingParams,
        /// <summary>
        ///请求查询经纪公司交易算法响应, ThostFtdcBrokerTradingAlgosField
        /// </summary>
        OnRspQryBrokerTradingAlgos,
        /// <summary>
        ///请求查询监控中心用户令牌, ThostFtdcQueryCFMMCTradingAccountTokenField
        /// </summary>
        OnRspQueryCFMMCTradingAccountToken,
        /// <summary>
        ///期货发起银行资金转期货应答, ThostFtdcReqTransferField
        /// </summary>
        OnRspFromBankToFutureByFuture,
        /// <summary>
        ///期货发起期货资金转银行应答, ThostFtdcReqTransferField
        /// </summary>
        OnRspFromFutureToBankByFuture,
        /// <summary>
        ///期货发起查询银行余额应答, ThostFtdcReqQueryAccountField
        /// </summary>
        OnRspQueryBankAccountMoneyByFuture,
    };

    /// <summary>
    /// 所有的OnRtnXXXX回调事件
    /// </summary>
    public enum EnumOnRtnType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///深度行情通知, ThostFtdcDepthMarketDataField
        /// </summary>
        OnRtnDepthMarketData,
        /// <summary>
        ///询价通知, ThostFtdcForQuoteRspField
        /// </summary>
        OnRtnForQuoteRsp,
        /// <summary>
        ///报单通知, ThostFtdcOrderField
        /// </summary>
        OnRtnOrder,
        /// <summary>
        ///成交通知, ThostFtdcTradeField
        /// </summary>
        OnRtnTrade,
        /// <summary>
        ///合约交易状态通知, ThostFtdcInstrumentStatusField
        /// </summary>
        OnRtnInstrumentStatus,
        /// <summary>
        ///交易所公告通知, ThostFtdcBulletinField
        /// </summary>
        OnRtnBulletin,
        /// <summary>
        ///交易通知, ThostFtdcTradingNoticeInfoField
        /// </summary>
        OnRtnTradingNotice,
        /// <summary>
        ///提示条件单校验错误, ThostFtdcErrorConditionalOrderField
        /// </summary>
        OnRtnErrorConditionalOrder,
        /// <summary>
        ///执行宣告通知, ThostFtdcExecOrderField
        /// </summary>
        OnRtnExecOrder,
        /// <summary>
        ///报价通知, ThostFtdcQuoteField
        /// </summary>
        OnRtnQuote,
        /// <summary>
        ///保证金监控中心用户令牌, ThostFtdcCFMMCTradingAccountTokenField
        /// </summary>
        OnRtnCFMMCTradingAccountToken,
        /// <summary>
        ///期权自对冲通知, ThostFtdcOptionSelfCloseField
        /// </summary>
        OnRtnOptionSelfClose,
        /// <summary>
        ///申请组合通知, ThostFtdcCombActionField
        /// </summary>
        OnRtnCombAction,
        /// <summary>
        ///银行发起银行资金转期货通知, ThostFtdcRspTransferField
        /// </summary>
        OnRtnFromBankToFutureByBank,
        /// <summary>
        ///银行发起期货资金转银行通知, ThostFtdcRspTransferField
        /// </summary>
        OnRtnFromFutureToBankByBank,
        /// <summary>
        ///银行发起冲正银行转期货通知, ThostFtdcRspRepealField
        /// </summary>
        OnRtnRepealFromBankToFutureByBank,
        /// <summary>
        ///银行发起冲正期货转银行通知, ThostFtdcRspRepealField
        /// </summary>
        OnRtnRepealFromFutureToBankByBank,
        /// <summary>
        ///期货发起银行资金转期货通知, ThostFtdcRspTransferField
        /// </summary>
        OnRtnFromBankToFutureByFuture,
        /// <summary>
        ///期货发起期货资金转银行通知, ThostFtdcRspTransferField
        /// </summary>
        OnRtnFromFutureToBankByFuture,
        /// <summary>
        ///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知, ThostFtdcRspRepealField
        /// </summary>
        OnRtnRepealFromBankToFutureByFutureManual,
        /// <summary>
        ///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知, ThostFtdcRspRepealField
        /// </summary>
        OnRtnRepealFromFutureToBankByFutureManual,
        /// <summary>
        ///期货发起查询银行余额通知, ThostFtdcNotifyQueryAccountField
        /// </summary>
        OnRtnQueryBankBalanceByFuture,
        /// <summary>
        ///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知, ThostFtdcRspRepealField
        /// </summary>
        OnRtnRepealFromBankToFutureByFuture,
        /// <summary>
        ///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知, ThostFtdcRspRepealField
        /// </summary>
        OnRtnRepealFromFutureToBankByFuture,
        /// <summary>
        ///银行发起银期开户通知, ThostFtdcOpenAccountField
        /// </summary>
        OnRtnOpenAccountByBank,
        /// <summary>
        ///银行发起银期销户通知, ThostFtdcCancelAccountField
        /// </summary>
        OnRtnCancelAccountByBank,
        /// <summary>
        ///银行发起变更银行账号通知, ThostFtdcChangeAccountField
        /// </summary>
        OnRtnChangeAccountByBank,
    };

}; // end of namespace
