/////////////////////////////////////////////////////////////////////////
//// Ftdc C++ => C Adapter
//// Author : shawn666.liu@hotmail.com   
//// Generated at 2019/5/12 13:31:41
/////////////////////////////////////////////////////////////////////////

#pragma once

#ifdef WIN32
// Windows
#ifdef FTDC2C_EXPORTS
#define FTDC2C_API extern __declspec(dllexport)
#else
#define FTDC2C_API extern __declspec(dllimport)
#endif
#define MYDECL	__stdcall
#else
// Linux
#define FTDC2C_API extern
#define MYDECL  __attribute__((stdcall))
#endif




#include <ThostFtdcUserApiStruct.h>

#ifdef __cplusplus
extern "C" {
#endif

	typedef void(MYDECL *CbOnErrRtnEvent)(void* pObject, int type, void* pParam, void* pRspInfo);
	typedef void(MYDECL *CbOnFrontEvent)(void* pObject, int type, int Reason);
	typedef void(MYDECL *CbOnRspEvent)(void* pObject, int type, void* pParam, void* pRspInfo, int nRequestID, bool bIsLast);
	typedef void(MYDECL *CbOnRtnEvent)(void* pObject, int type, void* pParam);

	FTDC2C_API int MYDECL CTPGetSystemInfo(char pSystemInfo[], int& nLen);

	FTDC2C_API void MYDECL MdDestroyApi(void* pApi);
	FTDC2C_API void MYDECL MdRegisterCallback(void* pApi, CbOnFrontEvent c1, CbOnRspEvent c2, CbOnRtnEvent c3, void* pObject);
	FTDC2C_API void* MYDECL MdCreateApi(const char* pszFlowPath, const bool bIsUsingUdp, const bool bIsMulticast);
	FTDC2C_API const char* MYDECL MdGetApiVersion();
	FTDC2C_API void MYDECL MdInit(void* pApi);
	FTDC2C_API const char* MYDECL MdGetTradingDay(void* pApi);
	FTDC2C_API void MYDECL MdRegisterFront(void* pApi, char* pszFrontAddress);
	FTDC2C_API void MYDECL MdRegisterNameServer(void* pApi, char* pszNsAddress);
	FTDC2C_API void MYDECL MdRegisterFensUserInfo(void* pApi, CThostFtdcFensUserInfoField* pFensUserInfo);
	FTDC2C_API int MYDECL MdSubscribeMarketData(void* pApi, char* ppInstrumentID[], int nCount);
	FTDC2C_API int MYDECL MdUnSubscribeMarketData(void* pApi, char* ppInstrumentID[], int nCount);
	FTDC2C_API int MYDECL MdSubscribeForQuoteRsp(void* pApi, char* ppInstrumentID[], int nCount);
	FTDC2C_API int MYDECL MdUnSubscribeForQuoteRsp(void* pApi, char* ppInstrumentID[], int nCount);
	FTDC2C_API int MYDECL MdReqUserLogin(void* pApi, CThostFtdcReqUserLoginField* pReqUserLoginField, int nRequestID);
	FTDC2C_API int MYDECL MdReqUserLogout(void* pApi, CThostFtdcUserLogoutField* pUserLogout, int nRequestID);

	FTDC2C_API void MYDECL TdDestroyApi(void* pApi);
	FTDC2C_API void MYDECL TdRegisterCallback(void* pApi, CbOnErrRtnEvent c1, CbOnFrontEvent c2, CbOnRspEvent c3, CbOnRtnEvent c4, void* pObject);
	FTDC2C_API void* MYDECL TdCreateApi(const char* pszFlowPath);
	FTDC2C_API const char* MYDECL TdGetApiVersion();
	FTDC2C_API void MYDECL TdInit(void* pApi);
	FTDC2C_API const char* MYDECL TdGetTradingDay(void* pApi);
	FTDC2C_API void MYDECL TdRegisterFront(void* pApi, char* pszFrontAddress);
	FTDC2C_API void MYDECL TdRegisterNameServer(void* pApi, char* pszNsAddress);
	FTDC2C_API void MYDECL TdRegisterFensUserInfo(void* pApi, CThostFtdcFensUserInfoField* pFensUserInfo);
	FTDC2C_API void MYDECL TdSubscribePrivateTopic(void* pApi, THOST_TE_RESUME_TYPE nResumeType);
	FTDC2C_API void MYDECL TdSubscribePublicTopic(void* pApi, THOST_TE_RESUME_TYPE nResumeType);
	FTDC2C_API int MYDECL TdReqAuthenticate(void* pApi, CThostFtdcReqAuthenticateField* pReqAuthenticateField, int nRequestID);
	FTDC2C_API int MYDECL TdRegisterUserSystemInfo(void* pApi, CThostFtdcUserSystemInfoField* pUserSystemInfo);
	FTDC2C_API int MYDECL TdSubmitUserSystemInfo(void* pApi, CThostFtdcUserSystemInfoField* pUserSystemInfo);
	FTDC2C_API int MYDECL TdReqUserLogin(void* pApi, CThostFtdcReqUserLoginField* pReqUserLoginField, int nRequestID);
	FTDC2C_API int MYDECL TdReqUserLogout(void* pApi, CThostFtdcUserLogoutField* pUserLogout, int nRequestID);
	FTDC2C_API int MYDECL TdReqUserPasswordUpdate(void* pApi, CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate, int nRequestID);
	FTDC2C_API int MYDECL TdReqTradingAccountPasswordUpdate(void* pApi, CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate, int nRequestID);
	FTDC2C_API int MYDECL TdReqUserAuthMethod(void* pApi, CThostFtdcReqUserAuthMethodField* pReqUserAuthMethod, int nRequestID);
	FTDC2C_API int MYDECL TdReqGenUserCaptcha(void* pApi, CThostFtdcReqGenUserCaptchaField* pReqGenUserCaptcha, int nRequestID);
	FTDC2C_API int MYDECL TdReqGenUserText(void* pApi, CThostFtdcReqGenUserTextField* pReqGenUserText, int nRequestID);
	FTDC2C_API int MYDECL TdReqUserLoginWithCaptcha(void* pApi, CThostFtdcReqUserLoginWithCaptchaField* pReqUserLoginWithCaptcha, int nRequestID);
	FTDC2C_API int MYDECL TdReqUserLoginWithText(void* pApi, CThostFtdcReqUserLoginWithTextField* pReqUserLoginWithText, int nRequestID);
	FTDC2C_API int MYDECL TdReqUserLoginWithOTP(void* pApi, CThostFtdcReqUserLoginWithOTPField* pReqUserLoginWithOTP, int nRequestID);
	FTDC2C_API int MYDECL TdReqOrderInsert(void* pApi, CThostFtdcInputOrderField* pInputOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqParkedOrderInsert(void* pApi, CThostFtdcParkedOrderField* pParkedOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqParkedOrderAction(void* pApi, CThostFtdcParkedOrderActionField* pParkedOrderAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqOrderAction(void* pApi, CThostFtdcInputOrderActionField* pInputOrderAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqQueryMaxOrderVolume(void* pApi, CThostFtdcQueryMaxOrderVolumeField* pQueryMaxOrderVolume, int nRequestID);
	FTDC2C_API int MYDECL TdReqSettlementInfoConfirm(void* pApi, CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, int nRequestID);
	FTDC2C_API int MYDECL TdReqRemoveParkedOrder(void* pApi, CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqRemoveParkedOrderAction(void* pApi, CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqExecOrderInsert(void* pApi, CThostFtdcInputExecOrderField* pInputExecOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqExecOrderAction(void* pApi, CThostFtdcInputExecOrderActionField* pInputExecOrderAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqForQuoteInsert(void* pApi, CThostFtdcInputForQuoteField* pInputForQuote, int nRequestID);
	FTDC2C_API int MYDECL TdReqQuoteInsert(void* pApi, CThostFtdcInputQuoteField* pInputQuote, int nRequestID);
	FTDC2C_API int MYDECL TdReqQuoteAction(void* pApi, CThostFtdcInputQuoteActionField* pInputQuoteAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqBatchOrderAction(void* pApi, CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqOptionSelfCloseInsert(void* pApi, CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, int nRequestID);
	FTDC2C_API int MYDECL TdReqOptionSelfCloseAction(void* pApi, CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqCombActionInsert(void* pApi, CThostFtdcInputCombActionField* pInputCombAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryOrder(void* pApi, CThostFtdcQryOrderField* pQryOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryTrade(void* pApi, CThostFtdcQryTradeField* pQryTrade, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInvestorPosition(void* pApi, CThostFtdcQryInvestorPositionField* pQryInvestorPosition, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryTradingAccount(void* pApi, CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInvestor(void* pApi, CThostFtdcQryInvestorField* pQryInvestor, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryTradingCode(void* pApi, CThostFtdcQryTradingCodeField* pQryTradingCode, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInstrumentMarginRate(void* pApi, CThostFtdcQryInstrumentMarginRateField* pQryInstrumentMarginRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInstrumentCommissionRate(void* pApi, CThostFtdcQryInstrumentCommissionRateField* pQryInstrumentCommissionRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryExchange(void* pApi, CThostFtdcQryExchangeField* pQryExchange, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryProduct(void* pApi, CThostFtdcQryProductField* pQryProduct, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInstrument(void* pApi, CThostFtdcQryInstrumentField* pQryInstrument, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryDepthMarketData(void* pApi, CThostFtdcQryDepthMarketDataField* pQryDepthMarketData, int nRequestID);
	FTDC2C_API int MYDECL TdReqQrySettlementInfo(void* pApi, CThostFtdcQrySettlementInfoField* pQrySettlementInfo, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryTransferBank(void* pApi, CThostFtdcQryTransferBankField* pQryTransferBank, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInvestorPositionDetail(void* pApi, CThostFtdcQryInvestorPositionDetailField* pQryInvestorPositionDetail, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryNotice(void* pApi, CThostFtdcQryNoticeField* pQryNotice, int nRequestID);
	FTDC2C_API int MYDECL TdReqQrySettlementInfoConfirm(void* pApi, CThostFtdcQrySettlementInfoConfirmField* pQrySettlementInfoConfirm, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInvestorPositionCombineDetail(void* pApi, CThostFtdcQryInvestorPositionCombineDetailField* pQryInvestorPositionCombineDetail, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryCFMMCTradingAccountKey(void* pApi, CThostFtdcQryCFMMCTradingAccountKeyField* pQryCFMMCTradingAccountKey, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryEWarrantOffset(void* pApi, CThostFtdcQryEWarrantOffsetField* pQryEWarrantOffset, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInvestorProductGroupMargin(void* pApi, CThostFtdcQryInvestorProductGroupMarginField* pQryInvestorProductGroupMargin, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryExchangeMarginRate(void* pApi, CThostFtdcQryExchangeMarginRateField* pQryExchangeMarginRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryExchangeMarginRateAdjust(void* pApi, CThostFtdcQryExchangeMarginRateAdjustField* pQryExchangeMarginRateAdjust, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryExchangeRate(void* pApi, CThostFtdcQryExchangeRateField* pQryExchangeRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQrySecAgentACIDMap(void* pApi, CThostFtdcQrySecAgentACIDMapField* pQrySecAgentACIDMap, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryProductExchRate(void* pApi, CThostFtdcQryProductExchRateField* pQryProductExchRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryProductGroup(void* pApi, CThostFtdcQryProductGroupField* pQryProductGroup, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryMMInstrumentCommissionRate(void* pApi, CThostFtdcQryMMInstrumentCommissionRateField* pQryMMInstrumentCommissionRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryMMOptionInstrCommRate(void* pApi, CThostFtdcQryMMOptionInstrCommRateField* pQryMMOptionInstrCommRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInstrumentOrderCommRate(void* pApi, CThostFtdcQryInstrumentOrderCommRateField* pQryInstrumentOrderCommRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQrySecAgentTradingAccount(void* pApi, CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID);
	FTDC2C_API int MYDECL TdReqQrySecAgentCheckMode(void* pApi, CThostFtdcQrySecAgentCheckModeField* pQrySecAgentCheckMode, int nRequestID);
	FTDC2C_API int MYDECL TdReqQrySecAgentTradeInfo(void* pApi, CThostFtdcQrySecAgentTradeInfoField* pQrySecAgentTradeInfo, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryOptionInstrTradeCost(void* pApi, CThostFtdcQryOptionInstrTradeCostField* pQryOptionInstrTradeCost, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryOptionInstrCommRate(void* pApi, CThostFtdcQryOptionInstrCommRateField* pQryOptionInstrCommRate, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryExecOrder(void* pApi, CThostFtdcQryExecOrderField* pQryExecOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryForQuote(void* pApi, CThostFtdcQryForQuoteField* pQryForQuote, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryQuote(void* pApi, CThostFtdcQryQuoteField* pQryQuote, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryOptionSelfClose(void* pApi, CThostFtdcQryOptionSelfCloseField* pQryOptionSelfClose, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryInvestUnit(void* pApi, CThostFtdcQryInvestUnitField* pQryInvestUnit, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryCombInstrumentGuard(void* pApi, CThostFtdcQryCombInstrumentGuardField* pQryCombInstrumentGuard, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryCombAction(void* pApi, CThostFtdcQryCombActionField* pQryCombAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryTransferSerial(void* pApi, CThostFtdcQryTransferSerialField* pQryTransferSerial, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryAccountregister(void* pApi, CThostFtdcQryAccountregisterField* pQryAccountregister, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryContractBank(void* pApi, CThostFtdcQryContractBankField* pQryContractBank, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryParkedOrder(void* pApi, CThostFtdcQryParkedOrderField* pQryParkedOrder, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryParkedOrderAction(void* pApi, CThostFtdcQryParkedOrderActionField* pQryParkedOrderAction, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryTradingNotice(void* pApi, CThostFtdcQryTradingNoticeField* pQryTradingNotice, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryBrokerTradingParams(void* pApi, CThostFtdcQryBrokerTradingParamsField* pQryBrokerTradingParams, int nRequestID);
	FTDC2C_API int MYDECL TdReqQryBrokerTradingAlgos(void* pApi, CThostFtdcQryBrokerTradingAlgosField* pQryBrokerTradingAlgos, int nRequestID);
	FTDC2C_API int MYDECL TdReqQueryCFMMCTradingAccountToken(void* pApi, CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken, int nRequestID);
	FTDC2C_API int MYDECL TdReqFromBankToFutureByFuture(void* pApi, CThostFtdcReqTransferField* pReqTransfer, int nRequestID);
	FTDC2C_API int MYDECL TdReqFromFutureToBankByFuture(void* pApi, CThostFtdcReqTransferField* pReqTransfer, int nRequestID);
	FTDC2C_API int MYDECL TdReqQueryBankAccountMoneyByFuture(void* pApi, CThostFtdcReqQueryAccountField* pReqQueryAccount, int nRequestID);


#ifdef __cplusplus
}
#endif
