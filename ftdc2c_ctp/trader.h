/////////////////////////////////////////////////////////////////////////
//// Ftdc C++ => C Adapter
//// Author : shawn666.liu@hotmail.com   
//// Generated at 2019/5/12 13:31:41
/////////////////////////////////////////////////////////////////////////

#pragma once
#include <ThostFtdcTraderApi.h>
#include "enums.h"

class Trader : public CThostFtdcTraderSpi
{
public:
	CThostFtdcTraderApi* RawApi{ nullptr };
	CbOnErrRtnEvent mOnErrRtnEvent{ nullptr };
	CbOnFrontEvent mOnFrontEvent{ nullptr };
	CbOnRspEvent mOnRspEvent{ nullptr };
	CbOnRtnEvent mOnRtnEvent{ nullptr };
	void* pObject;

	Trader(const char* pszFlowPath) {
		RawApi = CThostFtdcTraderApi::CreateFtdcTraderApi(pszFlowPath);
		RawApi->RegisterSpi(this);
		pObject = this;
	}


	virtual ~Trader() {
		if (RawApi){
			RawApi->RegisterSpi(nullptr);
			RawApi->Release();
			RawApi = nullptr;
		}
	};

	void OnFrontConnected() override {
		mOnFrontEvent(pObject, int(EnumOnFrontEvent::OnFrontConnected), 0);
	};
	void OnFrontDisconnected(int nReason) override {
		mOnFrontEvent(pObject, int(EnumOnFrontEvent::OnFrontDisconnected), nReason);
	};
	void OnHeartBeatWarning(int nTimeLapse) override {
	};
	void OnRspAuthenticate(CThostFtdcRspAuthenticateField* pRspAuthenticateField, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspAuthenticate), pRspAuthenticateField, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspUserLogin(CThostFtdcRspUserLoginField* pRspUserLogin, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspUserLogin), pRspUserLogin, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspUserLogout(CThostFtdcUserLogoutField* pUserLogout, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspUserLogout), pUserLogout, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspUserPasswordUpdate), pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspTradingAccountPasswordUpdate), pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspUserAuthMethod(CThostFtdcRspUserAuthMethodField* pRspUserAuthMethod, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspUserAuthMethod), pRspUserAuthMethod, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspGenUserCaptcha(CThostFtdcRspGenUserCaptchaField* pRspGenUserCaptcha, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspGenUserCaptcha), pRspGenUserCaptcha, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspGenUserText(CThostFtdcRspGenUserTextField* pRspGenUserText, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspGenUserText), pRspGenUserText, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspOrderInsert(CThostFtdcInputOrderField* pInputOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspOrderInsert), pInputOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspParkedOrderInsert(CThostFtdcParkedOrderField* pParkedOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspParkedOrderInsert), pParkedOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspParkedOrderAction), pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspOrderAction(CThostFtdcInputOrderActionField* pInputOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspOrderAction), pInputOrderAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField* pQueryMaxOrderVolume, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQueryMaxOrderVolume), pQueryMaxOrderVolume, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspSettlementInfoConfirm), pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspRemoveParkedOrder), pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspRemoveParkedOrderAction), pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspExecOrderInsert), pInputExecOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspExecOrderAction(CThostFtdcInputExecOrderActionField* pInputExecOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspExecOrderAction), pInputExecOrderAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspForQuoteInsert), pInputForQuote, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQuoteInsert(CThostFtdcInputQuoteField* pInputQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQuoteInsert), pInputQuote, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQuoteAction(CThostFtdcInputQuoteActionField* pInputQuoteAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQuoteAction), pInputQuoteAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspBatchOrderAction(CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspBatchOrderAction), pInputBatchOrderAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspOptionSelfCloseInsert), pInputOptionSelfClose, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspOptionSelfCloseAction(CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspOptionSelfCloseAction), pInputOptionSelfCloseAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspCombActionInsert), pInputCombAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryOrder(CThostFtdcOrderField* pOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryOrder), pOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryTrade(CThostFtdcTradeField* pTrade, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryTrade), pTrade, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField* pInvestorPosition, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInvestorPosition), pInvestorPosition, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryTradingAccount(CThostFtdcTradingAccountField* pTradingAccount, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryTradingAccount), pTradingAccount, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInvestor(CThostFtdcInvestorField* pInvestor, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInvestor), pInvestor, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryTradingCode(CThostFtdcTradingCodeField* pTradingCode, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryTradingCode), pTradingCode, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField* pInstrumentMarginRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInstrumentMarginRate), pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField* pInstrumentCommissionRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInstrumentCommissionRate), pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryExchange(CThostFtdcExchangeField* pExchange, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryExchange), pExchange, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryProduct(CThostFtdcProductField* pProduct, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryProduct), pProduct, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInstrument(CThostFtdcInstrumentField* pInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInstrument), pInstrument, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField* pDepthMarketData, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryDepthMarketData), pDepthMarketData, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField* pSettlementInfo, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQrySettlementInfo), pSettlementInfo, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryTransferBank(CThostFtdcTransferBankField* pTransferBank, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryTransferBank), pTransferBank, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField* pInvestorPositionDetail, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInvestorPositionDetail), pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryNotice(CThostFtdcNoticeField* pNotice, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryNotice), pNotice, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQrySettlementInfoConfirm), pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField* pInvestorPositionCombineDetail, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInvestorPositionCombineDetail), pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField* pCFMMCTradingAccountKey, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryCFMMCTradingAccountKey), pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField* pEWarrantOffset, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryEWarrantOffset), pEWarrantOffset, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField* pInvestorProductGroupMargin, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInvestorProductGroupMargin), pInvestorProductGroupMargin, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField* pExchangeMarginRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryExchangeMarginRate), pExchangeMarginRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField* pExchangeMarginRateAdjust, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryExchangeMarginRateAdjust), pExchangeMarginRateAdjust, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryExchangeRate(CThostFtdcExchangeRateField* pExchangeRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryExchangeRate), pExchangeRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField* pSecAgentACIDMap, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQrySecAgentACIDMap), pSecAgentACIDMap, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryProductExchRate(CThostFtdcProductExchRateField* pProductExchRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryProductExchRate), pProductExchRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryProductGroup(CThostFtdcProductGroupField* pProductGroup, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryProductGroup), pProductGroup, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryMMInstrumentCommissionRate(CThostFtdcMMInstrumentCommissionRateField* pMMInstrumentCommissionRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryMMInstrumentCommissionRate), pMMInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryMMOptionInstrCommRate(CThostFtdcMMOptionInstrCommRateField* pMMOptionInstrCommRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryMMOptionInstrCommRate), pMMOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInstrumentOrderCommRate(CThostFtdcInstrumentOrderCommRateField* pInstrumentOrderCommRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInstrumentOrderCommRate), pInstrumentOrderCommRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQrySecAgentTradingAccount(CThostFtdcTradingAccountField* pTradingAccount, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQrySecAgentTradingAccount), pTradingAccount, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQrySecAgentCheckMode(CThostFtdcSecAgentCheckModeField* pSecAgentCheckMode, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQrySecAgentCheckMode), pSecAgentCheckMode, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQrySecAgentTradeInfo(CThostFtdcSecAgentTradeInfoField* pSecAgentTradeInfo, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQrySecAgentTradeInfo), pSecAgentTradeInfo, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryOptionInstrTradeCost(CThostFtdcOptionInstrTradeCostField* pOptionInstrTradeCost, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryOptionInstrTradeCost), pOptionInstrTradeCost, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryOptionInstrCommRate(CThostFtdcOptionInstrCommRateField* pOptionInstrCommRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryOptionInstrCommRate), pOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryExecOrder(CThostFtdcExecOrderField* pExecOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryExecOrder), pExecOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryForQuote(CThostFtdcForQuoteField* pForQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryForQuote), pForQuote, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryQuote(CThostFtdcQuoteField* pQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryQuote), pQuote, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryOptionSelfClose(CThostFtdcOptionSelfCloseField* pOptionSelfClose, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryOptionSelfClose), pOptionSelfClose, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryInvestUnit(CThostFtdcInvestUnitField* pInvestUnit, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryInvestUnit), pInvestUnit, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryCombInstrumentGuard(CThostFtdcCombInstrumentGuardField* pCombInstrumentGuard, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryCombInstrumentGuard), pCombInstrumentGuard, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryCombAction(CThostFtdcCombActionField* pCombAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryCombAction), pCombAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryTransferSerial(CThostFtdcTransferSerialField* pTransferSerial, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryTransferSerial), pTransferSerial, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryAccountregister(CThostFtdcAccountregisterField* pAccountregister, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryAccountregister), pAccountregister, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspError(CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspError), nullptr, pRspInfo, nRequestID, bIsLast);
	};
	void OnRtnOrder(CThostFtdcOrderField* pOrder) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnOrder), pOrder);
	};
	void OnRtnTrade(CThostFtdcTradeField* pTrade) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnTrade), pTrade);
	};
	void OnErrRtnOrderInsert(CThostFtdcInputOrderField* pInputOrder, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnOrderInsert), pInputOrder, pRspInfo);
	};
	void OnErrRtnOrderAction(CThostFtdcOrderActionField* pOrderAction, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnOrderAction), pOrderAction, pRspInfo);
	};
	void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField* pInstrumentStatus) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnInstrumentStatus), pInstrumentStatus);
	};
	void OnRtnBulletin(CThostFtdcBulletinField* pBulletin) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnBulletin), pBulletin);
	};
	void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField* pTradingNoticeInfo) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnTradingNotice), pTradingNoticeInfo);
	};
	void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField* pErrorConditionalOrder) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnErrorConditionalOrder), pErrorConditionalOrder);
	};
	void OnRtnExecOrder(CThostFtdcExecOrderField* pExecOrder) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnExecOrder), pExecOrder);
	};
	void OnErrRtnExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnExecOrderInsert), pInputExecOrder, pRspInfo);
	};
	void OnErrRtnExecOrderAction(CThostFtdcExecOrderActionField* pExecOrderAction, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnExecOrderAction), pExecOrderAction, pRspInfo);
	};
	void OnErrRtnForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnForQuoteInsert), pInputForQuote, pRspInfo);
	};
	void OnRtnQuote(CThostFtdcQuoteField* pQuote) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnQuote), pQuote);
	};
	void OnErrRtnQuoteInsert(CThostFtdcInputQuoteField* pInputQuote, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnQuoteInsert), pInputQuote, pRspInfo);
	};
	void OnErrRtnQuoteAction(CThostFtdcQuoteActionField* pQuoteAction, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnQuoteAction), pQuoteAction, pRspInfo);
	};
	void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField* pForQuoteRsp) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnForQuoteRsp), pForQuoteRsp);
	};
	void OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField* pCFMMCTradingAccountToken) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnCFMMCTradingAccountToken), pCFMMCTradingAccountToken);
	};
	void OnErrRtnBatchOrderAction(CThostFtdcBatchOrderActionField* pBatchOrderAction, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnBatchOrderAction), pBatchOrderAction, pRspInfo);
	};
	void OnRtnOptionSelfClose(CThostFtdcOptionSelfCloseField* pOptionSelfClose) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnOptionSelfClose), pOptionSelfClose);
	};
	void OnErrRtnOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnOptionSelfCloseInsert), pInputOptionSelfClose, pRspInfo);
	};
	void OnErrRtnOptionSelfCloseAction(CThostFtdcOptionSelfCloseActionField* pOptionSelfCloseAction, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnOptionSelfCloseAction), pOptionSelfCloseAction, pRspInfo);
	};
	void OnRtnCombAction(CThostFtdcCombActionField* pCombAction) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnCombAction), pCombAction);
	};
	void OnErrRtnCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnCombActionInsert), pInputCombAction, pRspInfo);
	};
	void OnRspQryContractBank(CThostFtdcContractBankField* pContractBank, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryContractBank), pContractBank, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryParkedOrder(CThostFtdcParkedOrderField* pParkedOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryParkedOrder), pParkedOrder, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryParkedOrderAction), pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryTradingNotice(CThostFtdcTradingNoticeField* pTradingNotice, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryTradingNotice), pTradingNotice, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField* pBrokerTradingParams, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryBrokerTradingParams), pBrokerTradingParams, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField* pBrokerTradingAlgos, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQryBrokerTradingAlgos), pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQueryCFMMCTradingAccountToken), pQueryCFMMCTradingAccountToken, pRspInfo, nRequestID, bIsLast);
	};
	void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField* pRspTransfer) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnFromBankToFutureByBank), pRspTransfer);
	};
	void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField* pRspTransfer) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnFromFutureToBankByBank), pRspTransfer);
	};
	void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField* pRspRepeal) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnRepealFromBankToFutureByBank), pRspRepeal);
	};
	void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField* pRspRepeal) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnRepealFromFutureToBankByBank), pRspRepeal);
	};
	void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField* pRspTransfer) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnFromBankToFutureByFuture), pRspTransfer);
	};
	void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField* pRspTransfer) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnFromFutureToBankByFuture), pRspTransfer);
	};
	void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField* pRspRepeal) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnRepealFromBankToFutureByFutureManual), pRspRepeal);
	};
	void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField* pRspRepeal) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnRepealFromFutureToBankByFutureManual), pRspRepeal);
	};
	void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField* pNotifyQueryAccount) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnQueryBankBalanceByFuture), pNotifyQueryAccount);
	};
	void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnBankToFutureByFuture), pReqTransfer, pRspInfo);
	};
	void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnFutureToBankByFuture), pReqTransfer, pRspInfo);
	};
	void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField* pReqRepeal, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnRepealBankToFutureByFutureManual), pReqRepeal, pRspInfo);
	};
	void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField* pReqRepeal, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnRepealFutureToBankByFutureManual), pReqRepeal, pRspInfo);
	};
	void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount, CThostFtdcRspInfoField* pRspInfo) override {
		mOnErrRtnEvent(pObject, int(EnumOnErrRtnEvent::OnErrRtnQueryBankBalanceByFuture), pReqQueryAccount, pRspInfo);
	};
	void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField* pRspRepeal) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnRepealFromBankToFutureByFuture), pRspRepeal);
	};
	void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField* pRspRepeal) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnRepealFromFutureToBankByFuture), pRspRepeal);
	};
	void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspFromBankToFutureByFuture), pReqTransfer, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspFromFutureToBankByFuture), pReqTransfer, pRspInfo, nRequestID, bIsLast);
	};
	void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) override {
		mOnRspEvent(pObject, int(EnumOnRspEvent::OnRspQueryBankAccountMoneyByFuture), pReqQueryAccount, pRspInfo, nRequestID, bIsLast);
	};
	void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField* pOpenAccount) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnOpenAccountByBank), pOpenAccount);
	};
	void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField* pCancelAccount) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnCancelAccountByBank), pCancelAccount);
	};
	void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField* pChangeAccount) override {
		mOnRtnEvent(pObject, int(EnumOnRtnEvent::OnRtnChangeAccountByBank), pChangeAccount);
	};

}; // end of class