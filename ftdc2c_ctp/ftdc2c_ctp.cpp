/////////////////////////////////////////////////////////////////////////
//// Ftdc C++ => C Adapter
//// Author : shawn666.liu@hotmail.com   
//// Generated at 2019/5/12 13:31:41
/////////////////////////////////////////////////////////////////////////

#include "ftdc2c_ctp.h"
#include "quoter.h"
#include "trader.h"
#include <DataCollect.h>

FTDC2C_API int MYDECL CTPGetSystemInfo(char pSystemInfo[], int& nLen) {
	return CTP_GetSystemInfo(pSystemInfo, nLen);
}

FTDC2C_API void MYDECL MdDestroyApi(void* pApi) {
	delete static_cast<Quoter*>(pApi);
}

FTDC2C_API void MYDECL MdRegisterCallback(void* pApi, CbOnFrontEvent c1, CbOnRspEvent c2, CbOnRtnEvent c3, void* pObject) {
	Quoter *p = static_cast<Quoter*>(pApi);
	p->mOnFrontEvent = c1;
	p->mOnRspEvent = c2;
	p->mOnRtnEvent = c3;
	if (pObject == nullptr)
		pObject = pApi;
	p->pObject = pObject;
}


FTDC2C_API void* MYDECL MdCreateApi(const char* pszFlowPath, const bool bIsUsingUdp, const bool bIsMulticast) {
	return new Quoter(pszFlowPath, bIsUsingUdp, bIsMulticast);
}

FTDC2C_API const char* MYDECL MdGetApiVersion() {
	return CThostFtdcMdApi::GetApiVersion();
}

FTDC2C_API void MYDECL MdInit(void* pApi) {
	(static_cast<Quoter*>(pApi))->RawApi->Init();
}

FTDC2C_API const char* MYDECL MdGetTradingDay(void* pApi) {
	return (static_cast<Quoter*>(pApi))->RawApi->GetTradingDay();
}

FTDC2C_API void MYDECL MdRegisterFront(void* pApi, char* pszFrontAddress) {
	(static_cast<Quoter*>(pApi))->RawApi->RegisterFront(pszFrontAddress);
}

FTDC2C_API void MYDECL MdRegisterNameServer(void* pApi, char* pszNsAddress) {
	(static_cast<Quoter*>(pApi))->RawApi->RegisterNameServer(pszNsAddress);
}

FTDC2C_API void MYDECL MdRegisterFensUserInfo(void* pApi, CThostFtdcFensUserInfoField* pFensUserInfo) {
	(static_cast<Quoter*>(pApi))->RawApi->RegisterFensUserInfo(pFensUserInfo);
}

FTDC2C_API int MYDECL MdSubscribeMarketData(void* pApi, char* ppInstrumentID[], int nCount) {
	return (static_cast<Quoter*>(pApi))->RawApi->SubscribeMarketData(ppInstrumentID, nCount);
}

FTDC2C_API int MYDECL MdUnSubscribeMarketData(void* pApi, char* ppInstrumentID[], int nCount) {
	return (static_cast<Quoter*>(pApi))->RawApi->UnSubscribeMarketData(ppInstrumentID, nCount);
}

FTDC2C_API int MYDECL MdSubscribeForQuoteRsp(void* pApi, char* ppInstrumentID[], int nCount) {
	return (static_cast<Quoter*>(pApi))->RawApi->SubscribeForQuoteRsp(ppInstrumentID, nCount);
}

FTDC2C_API int MYDECL MdUnSubscribeForQuoteRsp(void* pApi, char* ppInstrumentID[], int nCount) {
	return (static_cast<Quoter*>(pApi))->RawApi->UnSubscribeForQuoteRsp(ppInstrumentID, nCount);
}

FTDC2C_API int MYDECL MdReqUserLogin(void* pApi, CThostFtdcReqUserLoginField* pReqUserLoginField, int nRequestID) {
	return (static_cast<Quoter*>(pApi))->RawApi->ReqUserLogin(pReqUserLoginField, nRequestID);
}

FTDC2C_API int MYDECL MdReqUserLogout(void* pApi, CThostFtdcUserLogoutField* pUserLogout, int nRequestID) {
	return (static_cast<Quoter*>(pApi))->RawApi->ReqUserLogout(pUserLogout, nRequestID);
}

FTDC2C_API void MYDECL TdDestroyApi(void* pApi) {
	delete static_cast<Trader*>(pApi);
}

FTDC2C_API void MYDECL TdRegisterCallback(void* pApi, CbOnErrRtnEvent c1, CbOnFrontEvent c2, CbOnRspEvent c3, CbOnRtnEvent c4, void* pObject) {
	Trader *p = static_cast<Trader*>(pApi);
	p->mOnErrRtnEvent = c1;
	p->mOnFrontEvent = c2;
	p->mOnRspEvent = c3;
	p->mOnRtnEvent = c4;
	if (pObject == nullptr)
		pObject = pApi;
	p->pObject = pObject;
}


FTDC2C_API void* MYDECL TdCreateApi(const char* pszFlowPath) {
	return new Trader(pszFlowPath);
}

FTDC2C_API const char* MYDECL TdGetApiVersion() {
	return CThostFtdcTraderApi::GetApiVersion();
}

FTDC2C_API void MYDECL TdInit(void* pApi) {
	(static_cast<Trader*>(pApi))->RawApi->Init();
}

FTDC2C_API const char* MYDECL TdGetTradingDay(void* pApi) {
	return (static_cast<Trader*>(pApi))->RawApi->GetTradingDay();
}

FTDC2C_API void MYDECL TdRegisterFront(void* pApi, char* pszFrontAddress) {
	(static_cast<Trader*>(pApi))->RawApi->RegisterFront(pszFrontAddress);
}

FTDC2C_API void MYDECL TdRegisterNameServer(void* pApi, char* pszNsAddress) {
	(static_cast<Trader*>(pApi))->RawApi->RegisterNameServer(pszNsAddress);
}

FTDC2C_API void MYDECL TdRegisterFensUserInfo(void* pApi, CThostFtdcFensUserInfoField* pFensUserInfo) {
	(static_cast<Trader*>(pApi))->RawApi->RegisterFensUserInfo(pFensUserInfo);
}

FTDC2C_API void MYDECL TdSubscribePrivateTopic(void* pApi, THOST_TE_RESUME_TYPE nResumeType) {
	(static_cast<Trader*>(pApi))->RawApi->SubscribePrivateTopic(nResumeType);
}

FTDC2C_API void MYDECL TdSubscribePublicTopic(void* pApi, THOST_TE_RESUME_TYPE nResumeType) {
	(static_cast<Trader*>(pApi))->RawApi->SubscribePublicTopic(nResumeType);
}

FTDC2C_API int MYDECL TdReqAuthenticate(void* pApi, CThostFtdcReqAuthenticateField* pReqAuthenticateField, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqAuthenticate(pReqAuthenticateField, nRequestID);
}

FTDC2C_API int MYDECL TdRegisterUserSystemInfo(void* pApi, CThostFtdcUserSystemInfoField* pUserSystemInfo) {
	return (static_cast<Trader*>(pApi))->RawApi->RegisterUserSystemInfo(pUserSystemInfo);
}

FTDC2C_API int MYDECL TdSubmitUserSystemInfo(void* pApi, CThostFtdcUserSystemInfoField* pUserSystemInfo) {
	return (static_cast<Trader*>(pApi))->RawApi->SubmitUserSystemInfo(pUserSystemInfo);
}

FTDC2C_API int MYDECL TdReqUserLogin(void* pApi, CThostFtdcReqUserLoginField* pReqUserLoginField, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserLogin(pReqUserLoginField, nRequestID);
}

FTDC2C_API int MYDECL TdReqUserLogout(void* pApi, CThostFtdcUserLogoutField* pUserLogout, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserLogout(pUserLogout, nRequestID);
}

FTDC2C_API int MYDECL TdReqUserPasswordUpdate(void* pApi, CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserPasswordUpdate(pUserPasswordUpdate, nRequestID);
}

FTDC2C_API int MYDECL TdReqTradingAccountPasswordUpdate(void* pApi, CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, nRequestID);
}

FTDC2C_API int MYDECL TdReqUserAuthMethod(void* pApi, CThostFtdcReqUserAuthMethodField* pReqUserAuthMethod, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserAuthMethod(pReqUserAuthMethod, nRequestID);
}

FTDC2C_API int MYDECL TdReqGenUserCaptcha(void* pApi, CThostFtdcReqGenUserCaptchaField* pReqGenUserCaptcha, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqGenUserCaptcha(pReqGenUserCaptcha, nRequestID);
}

FTDC2C_API int MYDECL TdReqGenUserText(void* pApi, CThostFtdcReqGenUserTextField* pReqGenUserText, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqGenUserText(pReqGenUserText, nRequestID);
}

FTDC2C_API int MYDECL TdReqUserLoginWithCaptcha(void* pApi, CThostFtdcReqUserLoginWithCaptchaField* pReqUserLoginWithCaptcha, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserLoginWithCaptcha(pReqUserLoginWithCaptcha, nRequestID);
}

FTDC2C_API int MYDECL TdReqUserLoginWithText(void* pApi, CThostFtdcReqUserLoginWithTextField* pReqUserLoginWithText, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserLoginWithText(pReqUserLoginWithText, nRequestID);
}

FTDC2C_API int MYDECL TdReqUserLoginWithOTP(void* pApi, CThostFtdcReqUserLoginWithOTPField* pReqUserLoginWithOTP, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqUserLoginWithOTP(pReqUserLoginWithOTP, nRequestID);
}

FTDC2C_API int MYDECL TdReqOrderInsert(void* pApi, CThostFtdcInputOrderField* pInputOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqOrderInsert(pInputOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqParkedOrderInsert(void* pApi, CThostFtdcParkedOrderField* pParkedOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqParkedOrderInsert(pParkedOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqParkedOrderAction(void* pApi, CThostFtdcParkedOrderActionField* pParkedOrderAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqParkedOrderAction(pParkedOrderAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqOrderAction(void* pApi, CThostFtdcInputOrderActionField* pInputOrderAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqOrderAction(pInputOrderAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqQueryMaxOrderVolume(void* pApi, CThostFtdcQueryMaxOrderVolumeField* pQueryMaxOrderVolume, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQueryMaxOrderVolume(pQueryMaxOrderVolume, nRequestID);
}

FTDC2C_API int MYDECL TdReqSettlementInfoConfirm(void* pApi, CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqSettlementInfoConfirm(pSettlementInfoConfirm, nRequestID);
}

FTDC2C_API int MYDECL TdReqRemoveParkedOrder(void* pApi, CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqRemoveParkedOrder(pRemoveParkedOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqRemoveParkedOrderAction(void* pApi, CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqExecOrderInsert(void* pApi, CThostFtdcInputExecOrderField* pInputExecOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqExecOrderInsert(pInputExecOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqExecOrderAction(void* pApi, CThostFtdcInputExecOrderActionField* pInputExecOrderAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqExecOrderAction(pInputExecOrderAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqForQuoteInsert(void* pApi, CThostFtdcInputForQuoteField* pInputForQuote, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqForQuoteInsert(pInputForQuote, nRequestID);
}

FTDC2C_API int MYDECL TdReqQuoteInsert(void* pApi, CThostFtdcInputQuoteField* pInputQuote, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQuoteInsert(pInputQuote, nRequestID);
}

FTDC2C_API int MYDECL TdReqQuoteAction(void* pApi, CThostFtdcInputQuoteActionField* pInputQuoteAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQuoteAction(pInputQuoteAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqBatchOrderAction(void* pApi, CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqBatchOrderAction(pInputBatchOrderAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqOptionSelfCloseInsert(void* pApi, CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqOptionSelfCloseInsert(pInputOptionSelfClose, nRequestID);
}

FTDC2C_API int MYDECL TdReqOptionSelfCloseAction(void* pApi, CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqOptionSelfCloseAction(pInputOptionSelfCloseAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqCombActionInsert(void* pApi, CThostFtdcInputCombActionField* pInputCombAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqCombActionInsert(pInputCombAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryOrder(void* pApi, CThostFtdcQryOrderField* pQryOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryOrder(pQryOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryTrade(void* pApi, CThostFtdcQryTradeField* pQryTrade, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryTrade(pQryTrade, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInvestorPosition(void* pApi, CThostFtdcQryInvestorPositionField* pQryInvestorPosition, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInvestorPosition(pQryInvestorPosition, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryTradingAccount(void* pApi, CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryTradingAccount(pQryTradingAccount, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInvestor(void* pApi, CThostFtdcQryInvestorField* pQryInvestor, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInvestor(pQryInvestor, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryTradingCode(void* pApi, CThostFtdcQryTradingCodeField* pQryTradingCode, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryTradingCode(pQryTradingCode, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInstrumentMarginRate(void* pApi, CThostFtdcQryInstrumentMarginRateField* pQryInstrumentMarginRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInstrumentCommissionRate(void* pApi, CThostFtdcQryInstrumentCommissionRateField* pQryInstrumentCommissionRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryExchange(void* pApi, CThostFtdcQryExchangeField* pQryExchange, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryExchange(pQryExchange, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryProduct(void* pApi, CThostFtdcQryProductField* pQryProduct, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryProduct(pQryProduct, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInstrument(void* pApi, CThostFtdcQryInstrumentField* pQryInstrument, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInstrument(pQryInstrument, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryDepthMarketData(void* pApi, CThostFtdcQryDepthMarketDataField* pQryDepthMarketData, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryDepthMarketData(pQryDepthMarketData, nRequestID);
}

FTDC2C_API int MYDECL TdReqQrySettlementInfo(void* pApi, CThostFtdcQrySettlementInfoField* pQrySettlementInfo, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQrySettlementInfo(pQrySettlementInfo, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryTransferBank(void* pApi, CThostFtdcQryTransferBankField* pQryTransferBank, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryTransferBank(pQryTransferBank, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInvestorPositionDetail(void* pApi, CThostFtdcQryInvestorPositionDetailField* pQryInvestorPositionDetail, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryNotice(void* pApi, CThostFtdcQryNoticeField* pQryNotice, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryNotice(pQryNotice, nRequestID);
}

FTDC2C_API int MYDECL TdReqQrySettlementInfoConfirm(void* pApi, CThostFtdcQrySettlementInfoConfirmField* pQrySettlementInfoConfirm, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInvestorPositionCombineDetail(void* pApi, CThostFtdcQryInvestorPositionCombineDetailField* pQryInvestorPositionCombineDetail, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryCFMMCTradingAccountKey(void* pApi, CThostFtdcQryCFMMCTradingAccountKeyField* pQryCFMMCTradingAccountKey, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryEWarrantOffset(void* pApi, CThostFtdcQryEWarrantOffsetField* pQryEWarrantOffset, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryEWarrantOffset(pQryEWarrantOffset, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInvestorProductGroupMargin(void* pApi, CThostFtdcQryInvestorProductGroupMarginField* pQryInvestorProductGroupMargin, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryExchangeMarginRate(void* pApi, CThostFtdcQryExchangeMarginRateField* pQryExchangeMarginRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryExchangeMarginRate(pQryExchangeMarginRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryExchangeMarginRateAdjust(void* pApi, CThostFtdcQryExchangeMarginRateAdjustField* pQryExchangeMarginRateAdjust, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryExchangeRate(void* pApi, CThostFtdcQryExchangeRateField* pQryExchangeRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryExchangeRate(pQryExchangeRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQrySecAgentACIDMap(void* pApi, CThostFtdcQrySecAgentACIDMapField* pQrySecAgentACIDMap, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQrySecAgentACIDMap(pQrySecAgentACIDMap, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryProductExchRate(void* pApi, CThostFtdcQryProductExchRateField* pQryProductExchRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryProductExchRate(pQryProductExchRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryProductGroup(void* pApi, CThostFtdcQryProductGroupField* pQryProductGroup, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryProductGroup(pQryProductGroup, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryMMInstrumentCommissionRate(void* pApi, CThostFtdcQryMMInstrumentCommissionRateField* pQryMMInstrumentCommissionRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryMMInstrumentCommissionRate(pQryMMInstrumentCommissionRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryMMOptionInstrCommRate(void* pApi, CThostFtdcQryMMOptionInstrCommRateField* pQryMMOptionInstrCommRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryMMOptionInstrCommRate(pQryMMOptionInstrCommRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInstrumentOrderCommRate(void* pApi, CThostFtdcQryInstrumentOrderCommRateField* pQryInstrumentOrderCommRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInstrumentOrderCommRate(pQryInstrumentOrderCommRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQrySecAgentTradingAccount(void* pApi, CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQrySecAgentTradingAccount(pQryTradingAccount, nRequestID);
}

FTDC2C_API int MYDECL TdReqQrySecAgentCheckMode(void* pApi, CThostFtdcQrySecAgentCheckModeField* pQrySecAgentCheckMode, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQrySecAgentCheckMode(pQrySecAgentCheckMode, nRequestID);
}

FTDC2C_API int MYDECL TdReqQrySecAgentTradeInfo(void* pApi, CThostFtdcQrySecAgentTradeInfoField* pQrySecAgentTradeInfo, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQrySecAgentTradeInfo(pQrySecAgentTradeInfo, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryOptionInstrTradeCost(void* pApi, CThostFtdcQryOptionInstrTradeCostField* pQryOptionInstrTradeCost, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryOptionInstrCommRate(void* pApi, CThostFtdcQryOptionInstrCommRateField* pQryOptionInstrCommRate, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryOptionInstrCommRate(pQryOptionInstrCommRate, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryExecOrder(void* pApi, CThostFtdcQryExecOrderField* pQryExecOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryExecOrder(pQryExecOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryForQuote(void* pApi, CThostFtdcQryForQuoteField* pQryForQuote, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryForQuote(pQryForQuote, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryQuote(void* pApi, CThostFtdcQryQuoteField* pQryQuote, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryQuote(pQryQuote, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryOptionSelfClose(void* pApi, CThostFtdcQryOptionSelfCloseField* pQryOptionSelfClose, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryOptionSelfClose(pQryOptionSelfClose, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryInvestUnit(void* pApi, CThostFtdcQryInvestUnitField* pQryInvestUnit, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryInvestUnit(pQryInvestUnit, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryCombInstrumentGuard(void* pApi, CThostFtdcQryCombInstrumentGuardField* pQryCombInstrumentGuard, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryCombInstrumentGuard(pQryCombInstrumentGuard, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryCombAction(void* pApi, CThostFtdcQryCombActionField* pQryCombAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryCombAction(pQryCombAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryTransferSerial(void* pApi, CThostFtdcQryTransferSerialField* pQryTransferSerial, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryTransferSerial(pQryTransferSerial, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryAccountregister(void* pApi, CThostFtdcQryAccountregisterField* pQryAccountregister, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryAccountregister(pQryAccountregister, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryContractBank(void* pApi, CThostFtdcQryContractBankField* pQryContractBank, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryContractBank(pQryContractBank, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryParkedOrder(void* pApi, CThostFtdcQryParkedOrderField* pQryParkedOrder, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryParkedOrder(pQryParkedOrder, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryParkedOrderAction(void* pApi, CThostFtdcQryParkedOrderActionField* pQryParkedOrderAction, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryParkedOrderAction(pQryParkedOrderAction, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryTradingNotice(void* pApi, CThostFtdcQryTradingNoticeField* pQryTradingNotice, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryTradingNotice(pQryTradingNotice, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryBrokerTradingParams(void* pApi, CThostFtdcQryBrokerTradingParamsField* pQryBrokerTradingParams, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryBrokerTradingParams(pQryBrokerTradingParams, nRequestID);
}

FTDC2C_API int MYDECL TdReqQryBrokerTradingAlgos(void* pApi, CThostFtdcQryBrokerTradingAlgosField* pQryBrokerTradingAlgos, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos, nRequestID);
}

FTDC2C_API int MYDECL TdReqQueryCFMMCTradingAccountToken(void* pApi, CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken, nRequestID);
}

FTDC2C_API int MYDECL TdReqFromBankToFutureByFuture(void* pApi, CThostFtdcReqTransferField* pReqTransfer, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqFromBankToFutureByFuture(pReqTransfer, nRequestID);
}

FTDC2C_API int MYDECL TdReqFromFutureToBankByFuture(void* pApi, CThostFtdcReqTransferField* pReqTransfer, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqFromFutureToBankByFuture(pReqTransfer, nRequestID);
}

FTDC2C_API int MYDECL TdReqQueryBankAccountMoneyByFuture(void* pApi, CThostFtdcReqQueryAccountField* pReqQueryAccount, int nRequestID) {
	return (static_cast<Trader*>(pApi))->RawApi->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount, nRequestID);
}

