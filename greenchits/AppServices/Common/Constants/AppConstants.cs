using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Common.Constants
{
    public static class AppConstant
    {
        
        #region Security
        public const string UserContext = "UserContext";
        #endregion Security

        #region Sort direction Commands
        public const string Ascending = "ASC";
        public const string Descending = "DESC";
        public const string SortDirection = "SortDirection";
        public const string SortExpression = "SortExpression";
        #endregion

        #region ViewState and Session Constants
        public const string ItemsCount = "ItemsCount";
        public const string DetailsItemsCount = "DetailsItemsCount";
        public const string AddEditMode = "AddEditMode";
        public const string ERPaymentProcessingGUID = "ERPaymentProcessingGUID";
        public const string ERContributionGUID = "ERContributionGUID";
        public const string itemsCountGvContributionSchedule = "itemsCountGvContributionSchedule";
        public const string itemsCountGvContributionScheduleDetail = "itemsCountGvContributionScheduleDetail";
        public const string itemsCountGvPopupContributionSchedule = "itemsCountGvPopupContributionSchedule";
        public const string itemsCountGvAccBilling = "itemsCountGvAccBilling";
        public const string itemsCountGvAccPayment = "itemsCountGvAccPayment";
        public const string ItemsCountGvAgent = "ItemsCountGvAgent";
        public const string ItemsCountGvAgencyAddress = "ItemsCountGvAgencyAddress";
        public const string ERPayrollGUID = "ERPayrollGUID";
        public const string itemsCountGvPayrollSchedule = "itemsCountGvPayrollSchedule";
        public const string itemsCountGvPayrollScheduleDetail = "itemsCountGvPayrollScheduleDetail";
        public const string itemsCountGvPaymentSchedule = "itemsCountGvPaymentSchedule";
        public const string itemsCountGvPaymentScheduleDetails = "itemsCountGvPaymentScheduleDetails";
        public const string itemsCountgvAssignBankToBenefit = "itemsCountgvAssignBankToBenefit";
        public const string CarrierGuid = "CarrierGuid";
        public const string itemsCountGvAssignERCarrier = "itemsCountGvAssignERCarrier";
        public const string itemsCountGvAssignCarrier = "itemsCountGvAssignCarrier";
        public const string ERPaymentProcessingGuid = "ERPaymentProcessingGuid";
        public const string CarrierBenefitItemCount = "CarrierBenefitItemCount";
        public const string BenefitsItemCount = "BenefitsItemCount";
        public const string BeneficiaryIndividualGUID = "BeneficiaryIndividualGUID";
        public const string IndividualBeneficiariesItemCount = "IndividualBeneficiariesItemCount";
        public const string CompanyBeneficiariesItemCount = "CompanyBeneficiariesItemCount";
        public const string TierItemCount = "TierItemCount";
        public const string TierID = "TierID";
        public const string itemsCountGvAssignHRABenifit = "itemsCountGvAssignHRABenifit";
        public const string itemsCountGvEEClass = "itemsCountGvEEClass";
        public const string itemsCountGvAssignEEClass = "itemsCountGvAssignEEClass";
        public const string itemsCountGvAssignERHRABenifit = "itemsCountGvAssignERHRABenifit";
        public const string itemsCountGvERMerchandise = "itemsCountGvERMerchandise";
        public const string itemsCountGvAssignERMerchandise = "itemsCountGvAssignERMerchandise";
        public const string BusinessID = "BusinessID";
        public const string itemsCountGvTPAInvoice="itemsCountGvTPAInvoice";
        public const string itemsCountGvAddTPAInvoice = "itemsCountGvAddTPAInvoice";
        public const string itemsCountGvBillingBenefitRates = "itemsCountGvBillingBenefitRates";
        public const string itemsCountGvPopUpAccounts = "itemsCountGvPopUpAccounts";
        public const string itemsCountGvPopUpAddresses = "itemsCountGvPopUpAddresses";
        public const string InvoiceAccountGuid = "InvoiceAccountGuid";
        public const string InvoiceAddressGuid ="InvoiceAddressGuid";
        public const string InvoiceFilePath = "InvoiceFilePath";
        public const string itemsCountGvPopUpERBenefits = "itemsCountGvPopUpERBenefits";
        public const string ERAutoSubstantiationRuleGUID = "ERAutoSubstantiationRuleGUID";
        public const string ERCopayGUID = "ERCopayGUID";
        public const string itemsCountGvERBillingERBenefitRates = "itemsCountGvERBillingERBenefitRates";
        public const string itemsCountGvPopupERBillingERBeneRates = "itemsCountGvPopupERBillingERBeneRates";
        public const string InvoiceMethodFlag = "InvoiceMethodFlag";
        public const string ERBenefitRateDetails = "ERBenefitRateDetails";
        public const string EREENotesItemCount = "EREENotesItemCount";
        public const string NotesFromDate = "NotesFromDate";
        public const string NotesToDate = "NotesToDate";
        public const string NotesSubject = "NotesSubject";
        public const string LimitsBenefitItemCount = "LimitsBenefitItemCount";
        public const string LimitsTierItemCount = "LimitsTierItemCount";
        public const string AuditItemCount = "AuditItemCount";
        public const string AuditDataTable = "AuditDataTable";
        public const string RowNo = "RowNo";
        public const string TableName = "TableName";
        public const string InvoiceItemCount = "InvoiceItemCount";
        public const string SourceEntityGUID = "SourceEntityGUID";
        public const string SourceEntityTypeLookup = "SourceEntityTypeLookup";
        public const string InvoiceList = "InvoiceList";
        public const string PaymentFromDate = "PaymentFromDate";
        public const string PaymentToDate = "PaymentToDate";
        public const string PaymentCheckACHNumber = "PaymentCheckACHNumber";
        public const string PaymentMethodOfPayment = "PaymentMethodOfPayment";
        public const string ClaimsMode = "ClaimsMode";
        public const string Short = "Short";
        public const string LookupID = "LookupID";
        public const string DivisionItemCount = "DivisionItemCount";
        public const string EmployeeGUID = "EmployeeGUID";
        public const string ClaimList = "ClaimList";
        public const string VariableGUID = "VariableGUID";
	    public const string BenefitTextItemCount = "BenefitTextItemCount";
	    public const string BenefitTextMessage = "BenefitTextMessage";
	    public const string EnrollmentTextMessage = "EnrollmentTextMessage";
	    public const string EnrollmentTextItemCount = "EnrollmentTextItemCount";
        public const string ERBeneEnrollRule = "ERBeneEnrollRule";
        public const string ERBeneEligibilityRule = "ERBeneEligibilityRule";
		public const string SpecialBenefitsItemsCount = "SpecialBenefitsItemsCount";
        public const string EEMapItemsCount = "EEMapItemsCount";
        public const string EEBenefitGUID = "EEBenefitGUID";
        public const string ERBenefitGUID = "ERBenefitGUID"; 
        #endregion

        #region Numbers
        public const string zero = "0";
        #endregion

        #region QueryStrings
        public const string EmployerGUID="EmployerGUID";
        #endregion

        #region ControlIds
        public const string ctrlPager = "ctrlPager";
        public const string ddlGotopage = "ddlGotopage";
        public const string lnksingleClickButton = "lnksingleClickButton";
        public const string lblSlNo = "lblSlNo";
        public const string txtDate = "txtDate";
        public const string ImgContDate = "ImgContDate";
        public const string lblDate = "lblDate";
        public const string lblDayOfWeek = "lblDayOfWeek";
        public const string lblCycle = "lblCycle";
        public const string imgBtnSave = "imgBtnSave";
        public const string imgBtnEdit = "imgBtnEdit";
        public const string imgBtnDelete = "imgBtnDelete";
        public const string imgBtnSimilar = "imgBtnSimilar";
        public const string imgBtnCancel = "imgBtnCancel";
        public const string imgBtnAssign = "imgBtnAssign";
        public const string hdnConScheDetailGuid = "hdnConScheDetailGuid";
        public const string hdnOperationType = "hdnOperationType";
        #endregion

        #region Commands
        public const string DoubleClick = "DoubleClick";
        public const string SingleClick = "SingleClick";
        public const string Edit = "Edit";
        public const string Add = "Add";
        public const string Save = "Save";
        public const string Remove = "Remove";
        #endregion

        #region Attributes
        public const string onClick="onClick";
        public const string onchange = "onchange";
        #endregion

        #region Date Formats
        public const string MMddyyyy = "{0:MM/dd/yyyy}";
        #endregion

        #region Dropdown Values
        public const string Daily="Daily";
        public const string Custom = "Custom";
        public const string Select = "Select";
        #endregion

        #region Script Naming and Names
        public const string ChangeScript = "ChangeScript";
        public const string ddlChange = "ddlChange();";
        #endregion

        #region Character Constants
        public const string blankChar = "";
        public const string percentage = "%";
        #endregion

        #region Message Severity Desc
        public const string ErrorHackerMsg = "your trying to hack the data";
        public const string SuccessMsg = "success";
        public const string ExceptionMsg = "Exception";
        public const string ImgNextDisabled = "~/images/nextsml-disabled.png";
        public const string ImgFirstPageEnabled = "~/images/firstsml.png";
        public const string ImgFirstPageDisabled = "~/images/firstsml-disabled.png";
        public const string ImgLastPageEnabled = "~/images/lastsml.png";
        public const string ImgLastPageDisabled = "~/images/lastsml-disabled.png";
        #endregion

        #region MessageSeverity
        public const int Success = 0;
        public const int InvaildData=1;
        public const int ValidationFailed = 2;
        public const int Exception = 3;
        public const int Information = 4;
        public const int Verbose = 5;
        public const int Warning = 6;
        public const int HackeAccess = 7;
        public const int Error = 8;
        #endregion 



    }
}
