using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Common.Constants
{
    public enum spUser
    {
        spUserInsert,
        spUserDelete,
        spUserUpdate,
        spUserLogin,
        spContactUserInsert,
        spCheckActivation
    }

    public enum spBank
    {
        spUserBankAccountInsert,
        spUserDelete,
        spUserUpdate,
        spUserLogin,
        spContactUserInsert
    }

    public enum dbBankEnity
    {
        USERBANKID,
        USERID,
        ACCOUNTNAME,
        BANKNAME,
        BRANCHNAME,
        ACCOUNTNO,
        ACCOUNTTYPE,
        PLACE,
        IFSC,
        MICR,
        CHITSTYPE,
        STATUS,
        MODIFIEDDATE,
        CREATEDUSER,
        MODIFIEDUSER
    }



    public enum dbUserEnity
    {
        CustomerID,
        FirstName,
        LastName, 
        Prefix,
        DOB,
        Email, 
        AlterEmail, 
        MaritalStatus,
        Gender, 
        UserName,
        Password,
        Status, 
        CreatedDate,
        CreatedBy,
        ModifiedDate,
        ModifiedBy,
        Type,
        Qualification,
        PassGuid,
        ActiveGuid,
        FirstLogin, 
        ReferralID, 
        SaltKey,
        Lock,
        LastLogin
    }

    public enum dbUserAccount
    {
        ACCNOID,
        USERID,
        GroupId,
        ACCOUNTNO,
        PIN,
        ACCSTATUS,
        CREATEDDATE
    }

    public enum DbGroupDetails
    {
        GroupId,
        GroupName,
        Desc,
        ApprovalDate,
        ApprovalByUser,
        CreatedBy
    }

    public enum DbLoguser
    {
        Status,
        ModifiedUser,
        CreatedDate,
        CreatedUser,
        ModifiedDate
    }
    	

    public class DBConstant
    {





        #region Employer Portal SP Names
        public const string GetEmployerMasterData = "spGetEmployerMasterData";
        #endregion

        #region Input Parameters Names

        public const string benefitGroupIDList = "benefitGroupIDList";
        public const string pageId = "pageId";
        public const string menuFlag = "menuFlag";
        public const string userId = "userId";

        public const string eeBenefitGUID = "eeBenefitGUID";
        public const string eeBenefitSegment = "eeBenefitSegment";
        public const string eeBenefitName = "eeBenefitName";
        public const string eeBenefitStatusLookup = "eeBenefitStatusLookup";
        public const string eeBenefitActionLookup = "eeBenefitActionLookup";
        public const string eeBenefitReasonLookup = "eeBenefitReasonLookup";
        public const string eeBenefitDescription = "eeBenefitDescription";
        public const string eeBenefitEffectiveDate = "eeBenefitEffectiveDate";
        public const string eeBenefitEndDate = "eeBenefitEndDate";
        public const string eeBenefitTermDate = "eeBenefitTermDate";
        public const string erBenefitContributionScheduleMapGUID = "erBenefitContributionScheduleMapGUID";
        public const string eeBenefitDeductionMethodLookup = "eeBenefitDeductionMethodLookup";
        public const string eeBenefitAnnualAmt = "eeBenefitAnnualAmt";
        public const string eeBenefitPerPayAmt = "eeBenefitPerPayAmt";
        public const string eeBenefitAdjAmt = "eeBenefitAdjAmt";
        public const string erContribution = "erContribution";
        public const string eeContribution = "eeContribution";
        public const string eeBenefitTierID = "eeBenefitTierID";
        public const string erBenefitRateDetailGUID = "erBenefitRateDetailGUID";
        public const string eedependantIDList = "eedependantIDList";
        public const string IndividualFlag = "IndividualFlag";
        public const string IsExistDefaultDiv = "IsExistDefaultDiv";
        public const string erBenefitGUID = "erBenefitGUID";
        public const string employeeGUID = "employeeGUID";
        public const string totalPeriod = "totalPeriod";
        public const string tierID = "tierID";
        public const string erBenefitID = "erBenefitID";
        public const string wizardName = "wizardName";
        public const string carrierName = "carrierName";
        public const string employerName = "employerName";
        public const string isActive = "isActive";
        public const string password = "password";
        public const string result = "result";
        public const string SourceGUID = "SourceGUID";
        public const string SourceTypeID = "SourceTypeID";
        public const string startRowIndex = "startRowIndex";
        public const string MaxRows = "MaxRows";
        public const string totalrecords = "totalrecords";
        public const string prefixText = "prefixText";
        public const string BusinessIndustryCode = "BusinessIndustryCode";
        public const string IsAssociatedContributions = "IsAssociatedContributions";
        public const string IsAssociatedPayroll = "IsAssociatedPayrolls";
        public const string IsAssociatedRecords = "IsAssociatedRecords";
        public const string AddressSourceGUID = "AddressSourceGUID";
        public const string CountPrimaryFlag = "countPrimaryFlag";
        public const string AddressFlag = "AddressFlag";
        public const string DeleteFlag = "DeleteFlag";
        public const string AdjustmentMapXML = "AdjustmentMapXML";
        //Employer Extension table columns parameters
        public const string EmployerGUID = "EmployerGUID";
        public const string OldEmployerGUID = "OldEmployerGUID";
        public const string ERBusinessActivity = "ERBusinessActivity";
        public const string ERCode = "ERCode";
        public const string ERDateIncorporatedDate = "ERDateIncorporatedDate";
        public const string ERTypeOfOrganization = "ERTypeOfOrganization";
        public const string EREmail = "EREmail";
        public const string ERWebsite = "ERWebsite";
        public const string ERIdentityTheftProtectionFlag = "ERIdentityTheftProtectionFlag";
        public const string ERPursuantState = "ERPursuantState";
        public const string ERCRMID = "ERCRMID";
        public const string ERName = "ERName";
        public const string ERTaxID = "ERTaxID";
        public const string ERAccessCode = "ERAccessCode";
        public const string AccessCodeEE = "AccessCode";
        public const string CreatedUser = "CreatedUser";
        public const string ModifiedByUser = "ModifiedByUser";
        public const string CompletedFlag = "CompletedFlag";
        public const string BenefitContributionScheduleMapXML = "BenefitContributionScheduleMapXML";
        public const string BenefitPayrollScheduleMapXML = "BenefitPayrollScheduleMapXML";
        public const string BenefitPaymentProcessingMapXML = "BenefitPaymentProcessingMapXML";
        public const string BenefitCarrierMapXML = "BenefitCarrierMapXML";

        //Employer table columns
        public const string EmployerID = "EmployerID";
        public const string EREffectiveDate = "EREffectiveDate";
        public const string ERTermDate = "ERTermDate";
        public const string ERActualTerminationDate = "ERActualTerminationDate";
        public const string ERRunoutDate = "ERRunoutDate";

        public const string TPAGUID = "TPAGUID";
        public const string ERNonDiscriminationModeID = "ERNonDiscriminationModeID";
        public const string ERStatusID = "StatusID";
        //tbl_EmployerAcclarisExtension columns
        public const string ERDebitCardEffectiveDate = "ERDebitCardEffectiveDate";
        public const string ERPayMode = "ERPayMode";
        public const string ERDebitCardClientCode = "ERDebitCardClientCode";
        public const string ERDebitCardProgCode = "ERDebitCardProgCode";
        public const string ERDepositMode = "ERDepositMode";
        public const string EROngoingFileMode = "EROngoingFileMode";
        public const string ERPrintVendorCode = "ERPrintVendorCode";
        public const string ERNameOnDebitCard = "ERNameOnDebitCard";
        public const string ToggleFlag = "toggleFlag";
        public const string EREnrollmentTextUseDefault = "EREnrollmentTextUseDefault";

        //tbl_ContributionScheduleDetails columns
        public const string ContributionScheduleDetailGUID = "ContributionScheduleDetailGUID";
        public const string ContributionScheduleDetailID = "ContributionScheduleDetailID";
        public const string ERContributionGUID = "ERContributionGUID";
        public const string ContributionScheduleDate = "ContributionScheduleDate";
        public const string ContributionScheduleCycle = "ContributionScheduleCycle";

        //tbl_PayrollScheduleDetails columns
        public const string PayrollScheduleDetailGUID = "PayrollScheduleDetailGUID";
        public const string PayrollScheduleDetailID = "PayrollScheduleDetailID";
        public const string ERPayrollGUID = "ERPayrollGUID";
        public const string PayrollScheduleDate = "PayrollScheduleDate";
        public const string PayrollScheduleCycle = "PayrollScheduleCycle";

        //tbl_refLookup table sp parameters
        public const string LookupGroupID = "lookupGroupID";
        public const string LookupDataOrderByShort = "LookupDataOrderByShort";
        public const string LookupGroupIDList = "lookupGrpIDList";
        public const string erAccessCodeList = "erAccessCodeList";

        //tbl_ERBenefitLimitsBenefits parameters
        public const string BenefitLimitsBenefits_BenefitLimitsBenefitsGUID = "BenefitLimitsBenefitsGUID";
        public const string BenefitLimitsBenefits_SourceBenefitGUID = "SourceBenefitGUID";
        public const string BenefitLimitsBenefits_FrequencyLookUpId = "FrequencyLookUpId";
        public const string BenefitLimitsBenefits_MinAmount = "MinAmount";
        public const string BenefitLimitsBenefits_MaxAmount = "MaxAmount";
        public const string BenefitLimitsBenefits_PaymentMaximum = "PaymentMaximum";
        public const string BenefitLimitsBenefits_CreatedUser = "CreatedUser";
        public const string BenefitLimitsBenefits_ModifiedByUser = "ModifiedByUser";
        public const string BenefitLimitsBenefits_FrequencyType = "FrequencyType";
        public const string BenefitLimitsBenefits_SourceTypeLookup = "SourceTypeLookup";
        public const string BenefitLimitsBenefits_SourceType = "SourceType";

        //tbl_tbl_ERBenefitLimitsTier parameters
        public const string BenefitLimitsTier_BenefitLimitsTierGUID = "BenefitLimitsTierGUID";
        public const string BenefitLimitsTier_SourceBenefitGUID = "SourceBenefitGUID";
        public const string BenefitLimitsTier_FrequencyLookUpId = "FrequencyLookUpId";
        public const string BenefitLimitsTier_TierID = "TierID";
        public const string BenefitLimitsTier_MinAmount = "MinAmount";
        public const string BenefitLimitsTier_MaxAmount = "MaxAmount";
        public const string BenefitLimitsTier_PaymentMaximum = "PaymentMaximum";
        public const string BenefitLimitsTier_CreatedUser = "CreatedUser";
        public const string BenefitLimitsTier_ModifiedByUser = "ModifiedByUser";
        public const string BenefitLimitsTier_FrequencyType = "FrequencyType";
        public const string BenefitLimitsTier_TierType = "TierType";
        public const string BenefitLimitsTier_SourceTypeLookup = "SourceTypeLookup";
        public const string BenefitLimitsTier_SourceType = "SourceType";
        public const string LimitsTierBeginDate = "LimitsTierBeginDate";

        public const string BenefitTypeLookup = "BenefitTypeLookup";
        public const string BenefitType = "BenefitType";
        public const string LimitsBeginDate = "LimitsBeginDate";

        //tbl_AvailableServices parameters
        public const string AvailServicesGuid = "AvailServicesGuid";
        public const string AvailServicesID = "AvailServicesID";
        public const string AvailServiceCode = "AvailServiceCode";
        public const string AvailServiceDescription = "AvailServiceDescription";
        public const string BenefitTypeIDLookUp = "BenefitTypeIDLookup";
        public const string BenefiteName = "BenefiteName";
        public const string BenefitAvailableServiceMapXML = "BenefitAvailableServiceMapXML";
        public const string AcclarisServiceCode = "AcclarisServiceCode";

        //tbl_TPALimitsBenefits parameters 
        public const string TPALimitBenefit_TPALimitsBenefitsGUID = "TPALimitsBenefitsGUID";
        public const string TPALimitBenefit_TPABenefitGUID = "TPABenefitGUID";
        public const string TPALimitBenefit_FrequencyLookUpId = "FrequencyLookUpId";
        public const string TPALimitBenefit_MinAmount = "MinAmount";
        public const string TPALimitBenefit_MaxAmount = "MaxAmount";
        public const string TPALimitBenefit_PaymentMaximum = "PaymentMaximum";
        public const string TPALimitBenefit_CreatedUser = "CreatedUser";
        public const string TPALimitBenefit_ModifiedByUser = "ModifiedByUser";
        public const string TPALimitBenefit_CreatedDate = "CreatedDate";
        public const string TPALimitBenefit_ModifiedDate = "ModifiedDate";
        public const string TPALimitBenefit_FrequencyType = "FrequencyType";

        //tbl_TPALimitsTier parameters
        public const string TPALimitTier_TPALimitsTierGUID = "TPALimitsTierGUID";
        public const string TPALimitTier_TPATierGUID = "TPATierGUID";
        public const string TPALimitTier_FrequencyLookUpId = "FrequencyLookUpId";
        public const string TPALimitTier_TierTypeLookUpId = "TierTypeLookUpId";
        public const string TPALimitTier_MinAmount = "MinAmount";
        public const string TPALimitTier_MaxAmount = "MaxAmount";
        public const string TPALimitTier_PaymentMaximum = "PaymentMaximum";
        public const string TPALimitTier_CreatedUser = "CreatedUser";
        public const string TPALimitTier_ModifiedByUser = "ModifiedByUser";
        public const string TPALimitTier_CreatedDate = "CreatedDate";
        public const string TPALimitTier_ModifiedDate = "ModifiedDate";
        public const string TPALimitTier_FrequencyType = "FrequencyType";
        public const string TPALimitTier_TierType = "TierType";
        public const string GetDivisionCount = "GetDivisionCount";
        public const string PrimaryEditFlag = "EditFlag";
        public const string TierTempID = "TierTempID";

        //tbl_User
        public const string User_UserGUID = "UserGUID";
        public const string User_UserName = "UserName";
        public const string User_Password = "Password";

        public const string Employer = "Employer";
        public const string Employee = "Employee";

        public const string User_SecurityQuestion = "SecurityQuestion";
        public const string User_SecurityAnswer = "SecurityAnswer";
        public const string User_StatusLookup = "StatusLookup";
        public const string User_FailedAttempts = "FailedAttempts";
        public const string User_Role = "RoleGUID";
        public const string User_CreatedUser = "CreatedUser";
        public const string User_ModifiedByUser = "ModifiedByUser";
        public const string User_UserEmail = "UserEmail";
        public const string User_LoginID = "LoginID";
        public const string UserFirstname = "UserFirstname";
        public const string UserLastname = "UserLastname";
        public const string User_IsLocked = "IsLocked";
        public const string User_IsDefaultFlag = "IsDefaultFlag";

        //tbl_Roles
        public const string Role_RoleGUID = "RoleGUID";
        public const string Role_RoleDescription = "RoleDescription";
        public const string Role_RoleName = "RoleName";
        public const string Role_RoleID = "RoleID";
        public const string Role_ModifiedByUser = "ModifiedByUser";
        public const string Role_IsDefaultFlag = "IsDefaultFlag";
        public const string Role_CreatedUser = "CreatedUser";

        //tbl_RolePermissionSetMap
        public const string RolePermission_RolePermissionSetMapGUID = "RolePermissionSetMapGUID";
        public const string RolePermission_RoleGUID = "RoleGUID";
        public const string RolePermission_AccessLevelLookup = "AccessLevelLookup";
        public const string RolePermission_PermissionName = "PermissionName";
        public const string RolePermission_PermissionSetGUID = "PermissionSetGUID";
        public const string RolePermission_CreatedUser = "CreatedUser";
        public const string RolePermissionSetMapXml = "RolePermissionSetMapXml";

        //tbl_PermissionSet
        public const string Permission_GROUP = "GROUP";
        public const string Permission_PermissionSetName = "PermissionSetName";
        public const string Permission_GroupName = "GroupName";
        public const string Permission_PermissionSetID = "PermissionSetID";
        public const string Permission_LevelOrder = "LevelOrder";
        public const string Permission_ParentPermissionSetID = "ParentPermissionSetID";

        //tbl_GlobalSubstantiationRule
        public const string GlobalSubstantiationRuleGUID = "GlobalSubstantiationRuleGUID";
        public const string SubstantiationTriggerWaitDays = "SubstantiationTriggerWaitDays";
        public const string FirstNotificationsWaitDays = "FirstNotificationsWaitDays";
        public const string SecondNotificationWaitDays = "SecondNotificationWaitDays";
        public const string ThirdNotificationWaitDays = "ThirdNotificationWaitDays";
        public const string EndRuleDays = "EndRuleDays";
        public const string EndRuleLookup = "EndRuleLookup";
        public const string GlobalSubRule_CreatedUser = "CreatedUser";
        public const string GlobalSubRule_ModifiedByUser = "ModifiedByUser";

        //tblGlobalMccCode
        public const string tblGlobalMccCodeGUID = "GlobalMccCodeGUID";
        public const string GlobalMccCode = "MccCode";
        public const string GloablMccDescription = "MccDescription";
        public const string ERMerchandiseMapXML = "ERMerchandiseMapXML";
        public const string GlobalCreatedUser = "CreatedUser";
        public const string GlobalModifiedByUser = "ModifiedByUser";

        //tbl_TPAInvoceDetails
        public const string GenerateInvoiceDate = "GenerateInvoiceDate";
        public const string MinAmount = "MinAmount";
        public const string BankAccountGUID = "BankAccountGUID";
        public const string TPAInvoicingDetailGUID = "TPAInvoicingDetailGUID";
        public const string ContactName = "ContactName";
        public const string ContactPhoneAreaCode = "ContactPhoneAreaCode";
        public const string ContactPhoneExt = "ContactPhoneExt";
        public const string ContactPhoneNo = "ContactPhoneNo";
        public const string ActiveInvoiceTemplateGUID = "ActiveInvoiceTemplateGUID";
        public const string ContactEmail = "ContactEmail";
        public const string LogoPath = "LogoPath";
        public const string InvoiceNote = "InvoiceNote";
        public const string AccountName = "AccountName";
        public const string DueDateDaysAfterInvoiceDate = "DueDateDaysAfterInvoiceDate";
        public const string InvoiceGenerationDay = "InvoiceGenerationDay";

        //tbl_ERSubstantiationRule
        public const string ER_ERSubstantiationRuleGUID = "ERSubstantiationRuleGUID";
        public const string ER_EmployerGUID = "EmployerGUID";
        public const string ER_ERSubstantiationRuleID = "ERSubstantiationRuleID";
        public const string ER_SubstantiationTriggerWaitDays = "SubstantiationTriggerWaitDays";
        public const string ER_FirstNotificationsWaitDays = "FirstNotificationsWaitDays";
        public const string ER_SecondNotificationWaitDays = "SecondNotificationWaitDays";
        public const string ER_ThirdNotificationWaitDays = "ThirdNotificationWaitDays";
        public const string ER_EndRuleDays = "EndRuleDays";
        public const string ER_EndRuleLookup = "EndRuleLookup";
        public const string ER_DebitCardEffectiveDate = "DebitCardEffectiveDate";
        public const string ER_DebitCardTermDate = "DebitCardTermDate";
        public const string ER_DebitCardStatusLookup = "DebitCardStatusLookup";
        public const string ER_ModifiedByUser = "ModifiedByUser";
        public const string ER_CreatedUser = "CreatedUser";
        public const string HasDebitCardFlag = "HasDebitCardFlag";

        //
        public const string startDate = "startDate";
        public const string endDate = "endDate";


        //tbl_GlobalBillingRate
        public const string RateID = "RateID";
        public const string RateName = "RateName";
        public const string RateDescription = "RateDescription";
        public const string Sequence = "Sequence";
        public const string Rate = "Rate";
        public const string RateGUID = "RateGUID";
        public const string Basis = "Basis";
        public const string BasisName = "BasisName";
        public const string BillingPaidByLookup = "BillingPaidByLookup";
        public const string BillingPaidBy = "BillingPaidBy";
        public const string BenefitRateERMapXML = "BenefitRateERMapXML";
        public const string spInsertBenefitRateERMap = "spInsertBenefitRateERMap";

        //tbl_Provider
        public const string ProviderGUID = "ProviderGUID";
        public const string ProviderID = "ProviderID";
        public const string TaxID = "TaxID";
        public const string ServiceProviderName = "ServiceProviderName";
        public const string NationalProviderIdentificationNumber = "NationalProviderIdentificationNumber";
        public const string ContactFirstName = "ContactFirstName";
        public const string ContactLastName = "ContactLastName";
        public const string ProviderCreatedUser = "CreatedUser";
        public const string ProviderContactFirstName = "ContactFirstName";
        public const string ProviderContactLastName = "ContactLastName";
        public const string ProviderModifiedUser = "ModifiedUser";

        //tbl_Claims
        public const string ClaimNo = "ClaimNo";
        public const string ClaimGUID = "ClaimGUID";
        public const string ClaimantGUID = "ClaimantGUID";
        public const string ClaimantTypeLookup = "ClaimantTypeLookup";
        public const string ServiceFrom = "ServiceFrom";
        public const string ServiceTo = "ServiceTo";
        public const string ServiceTill = "ServiceTill";
        public const string ClaimAmount = "ClaimAmount";
        public const string IneligibleAmount = "IneligibleAmount";
        public const string PaymentTypeLookup = "PaymentTypeLookup";
        public const string PaymentType = "PaymentType";
        public const string CheckNumber = "CheckNumber";
        public const string StatusTypeLookup = "StatusTypeLookup";
        public const string ReasonTypeLookup = "ReasonTypeLookup";
        public const string CarrierClaimNo = "CarrierClaimNo";
        public const string Claims_RecievedDate = "RecievedDate";
        public const string ReceivedDate = "ReceivedDate";
        public const string ReceivedFromDate = "ReceivedFromDate";
        public const string ReceivedToDate = "ReceivedToDate";
        public const string MaxEffectiveTill = "MaxEffectiveTill";
        public const string AcclarisProcessedFlag = "AcclarisProcessedFlag";

        // tbl_Variable
        public const string VariableGUID = "VariableGUID";
        public const string VariableName = "VariableName";
        public const string IsQuery = "IsQuery";
        public const string Query = "Query";
        public const string RefLookUpId = "RefLookUpId";

        //tbl_EEEmployment
        public const string EmploymentGUID = "EmploymentGUID";
        public const string BeginDate = "BeginDate";
        public const string EmploymentTypeLookup = "EmploymentTypeLookup";
        public const string EmploymentType = "EmploymentType";
        public const string BaseRate = "BaseRate";
        public const string BaseRateBasisLookup = "BaseRateBasisLookup";
        public const string BaseRateBasis = "BaseRateBasis";
        public const string PayFrequencyLookup = "PayFrequencyLookup";
        public const string PayFrequency = "PayFrequency";
        public const string DefaultHours = "DefaultHours";
        public const string AnnualSalary = "AnnualSalary";
        public const string EmployeeClassGUID = "EmployeeClassGUID";
        public const string EmployeeClassName = "EmployeeClassName";
        public const string EmployeeClassMap = "EmployeeClassMap";
        public const string BenefitEmployeeClassMapXML = "BenefitEmployeeClassMapXML";

        //tbl_BenefitEnrollmentWindow
        public const string BenefitEnrollmentWindowGUID = "BenefitEnrollmentWindowGUID";
        public const string EnrollmentBeginDate = "EnrollmentBeginDate";
        public const string EnrollmentEndDate = "EnrollmentEndDate";
        public const string AggregatorTypeID = "AggregatorTypeID";
        public const string EnrollmentTypeID = "EnrollmentTypeID";
        public const string BenefitEnrollmentRuleList = "BenefitEnrollmentRuleList";
        public const string BenefitEligibilitytRuleList = "BenefitEligibilitytRuleList";

        //tbl_ERBenefitEnrollmentRuleMap        
        public const string ERBenefitEnrollmentRuleMapGUID = "ERBenefitEnrollmentRuleMapGUID";
        public const string EnrollmentRuleGroupID = "EnrollmentRuleGroupID";
        public const string EnrollmentRuleName = "EnrollmentRuleName";
        public const string EnrollmentRuleID = "EnrollmentRuleID";
        public const string EnrollmentRuleValue = "EnrollmentRuleValue";
        public const string DependancyERBenefitGUIDs = "DependancyERBenefitGUIDs";
        public const string DependentBenefitNames = "DependentBenefitNames";

        //tbl_ERBenefitEligibilityRuleMap
        public const string ERBenefitEligibilityRuleMapGUID = "ERBenefitEligibilityRuleMapGUID";
        public const string EligibilityRuleID = "EligibilityRuleID";
        public const string EligibilityRule = "EligibilityRule";
        public const string RuleValue = "RuleValue";
        public const string EligibilityRuleIDList = "EligibilityRuleIDList";
        public const string EREligibilityDetailsXml = "EREligibilityDetailsXml";
        public const string ERBenefitEligibilityRuleMapGUIDs = "ERBenefitEligibilityRuleMapGUIDs";
        public const string ValueType = "ValueType";

        #endregion Input Parameters Names

        #region Output Params
        public const string ErrorCode = "errorCode";
        public const string ErrorMessage = "ErrorMessage";
        #endregion

        #region Stored procedure Names

        public const string spGetBenefitNameByGroupID = "spGetBenefitNameByGroupID";
        public const string spUpdateEEBenefit = "spUpdateEEBenefit";
        public const string spGetEEDependentsByBenefitGUID = "spGetEEDependentsByBenefitGUID";
        public const string spGetEEBenefitContributionScheduleByBenefitGUID = "spGetEEBenefitContributionScheduleByBenefitGUID";
        public const string spGetEEBenefitDetails = "spGetEEBenefitDetails";
        public const string spGetPermSetbyPageID = "spGetPermSetbyPageID";
        public const string spGetPageName = "spGetPageName";
        public const string spGetPermissionSetAccessByUserId = "spGetPermissionSetAccessByUserId";
        public const string spGetEEBenefitByBenefitGUID = "spGetEEBenefitByBenefitGUID";
        public const string spGetAllEEBenefit = "spGetAllEEBenefit";
        public const string spGetAllSearchEEBenefit = "spGetAllSearchEEBenefit";
        public const string spEEBenefitSearchDropDownData = "spEEBenefitSearchDropDownData";
        public const string spInsertEEBenefit = "spInsertEEBenefit";
        public const string spGetAnnualTotalbyRateTier = "spGetAnnualTotalbyRateTier";
        public const string spGetAnnualTotalbyContributionTier = "spGetAnnualTotalbyContributionTier";
        public const string spGetRateTier = "spGetRateTier";
        public const string spGetContributionTier = "spGetContributionTier";
        public const string spGetBenefitType = "spGetBenefitType";
        public const string spGetBenefitName = "spGetBenefitName";
        public const string spGetContributionScheduleByEmployerGUID = "spGetContributionScheduleByEmployerGUID";
        public const string spGetWizardDetails = "spGetWizardDetails";
        public const string spGetAllCarrierByName = "spGetAllCarrierByName";
        public const string spGetAllERContacts = "spGetAllERContacts";
        public const string spGetAllEmployerbyName = "spGetAllEmployerbyName";
        public const string spValidateUser = "spValidateUser";
        public const string spUpdateEmployer = "spUpdateEmployer";
        public const string spGetLookup = "spGetLookup";
        public const string spGetLookupByMultiGrp = "spGetLookupByMultiGrp";
        public const string spGetLookupForEmployeeImport = "spGetLookupForEmployeeImport";
        public const string spInsertBenefitPlan = "spInsertBenefitPlan";
        public const string spInsertBenefitPlanAttachment = "spInsertBenefitPlanAttachment";
        public const string spGetOneBenefitPlan = "spGetOneBenefitPlan";
        public const string spGetCarrierSegementDetails = "spGetCarrierSegementDetails";
        public const string spGetCarrierPlans = "spGetCarrierPlans";
        public const string spGetCarrierBenefitDetails = "spGetCarrierBenefitDetails";
        public const string spClonebenefitPlan = "spClonebenefitPlan";
        public const string spDeleteCarriersBenefitPlans = "spDeleteCarriersBenefitPlans";
        public const string spDeleteEEBenefitCoveredDependents = "spDeleteEEBenefitCoveredDependents";

        public const string spGetStates = "spGetStates";
        public const string spInsertEmployer = "spInsertEmployer";
        public const string spGetEmployer = "spGetEmployer";
        public const string spGetERContributionSchedules = "spGetERContributionSchedules";
        public const string spInsertContributionSchedule = "spInsertContributionSchedule";
        public const string spInsertContributionScheduleDetails = "spInsertContributionScheduleDetails";
        public const string spSelectERContributionScheduleDetails = "spSelectERContributionScheduleDetails";
        public const string spUpdateContributionScheduleDetails = "spUpdateContributionScheduleDetails";
        public const string spSelectContributionScheduleDetail = "spSelectContributionScheduleDetail";
        public const string spDeleteContributionScheduleDetail = "spDeleteContributionScheduleDetail";

        public const string spGetERPayrollSchedules = "spGetERPayrollSchedules";
        public const string spInsertPayrollSchedule = "spInsertPayrollSchedule";
        public const string spInsertPayrollScheduleDetails = "spInsertPayrollScheduleDetails";
        public const string spSelectERPayrollScheduleDetails = "spSelectERPayrollScheduleDetails";
        public const string spUpdatePayrollScheduleDetails = "spUpdatePayrollScheduleDetails";
        public const string spSelectPayrollScheduleDetail = "spSelectPayrollScheduleDetail";
        public const string spDeletePayrollScheduleDetail = "spDeletePayrollScheduleDetail";


        public const string spGetAllEmployer = "spGetAllEmployer";
        public const string spGetDivision = "spGetDivision";
        public const string spGetContacts = "spGetContacts";
        public const string spGetAllAddress = "spGetAllAddress";
        public const string spInsertAddress = "spInsertAddress";
        public const string spInsertDivision = "spInsertDivision";
        public const string spGetCountry = "spGetCountry";
        public const string spGetBenefitTypes = "spGetBenefitTypes";
        public const string spGetTiers = "spGetTiers";
        public const string spUpdateDivision = "spUpdateDivision";
        public const string spUpdateAddress = "spUpdateAddress";
        public const string spGetAllDivision = "spGetAllDivision";
        public const string spInsertContact = "spInsertContact";
        public const string spUpdateContact = "spUpdateContact";
        public const string spDeleteDivision = "spDeleteDivision";
        public const string spGetContact = "spGetContact";
        public const string spGetAddress = "spGetAddress";
        public const string spDeleteAddress = "spDeleteAddress";
        public const string spInsertERContactManagement = "spInsertERContactManagement";
        public const string spUpdateContributionSchedule = "spUpdateContributionSchedule";
        public const string spUpdatePayrollSchedule = "spUpdatePayrollSchedule";
        public const string spUpdateERContactManagement = "spUpdateERContactManagement";
        public const string spGetERContactManagement = "spGetERContactManagement";
        public const string spGetAllERContactManagement = "spGetAllERContactManagement";

        public const string spGetAllERContactManagementforEmployerPortal = "spGetAllERContactManagementforEmployerPortal";

        public const string spGetOneContributionSchedule = "spGetOneContributionScheduleDetail";
        public const string spGetOnePayrollSchedule = "spGetOnePayrollScheduleDetail";
        public const string spDeleteContact = "spDeleteContact";
        public const string spGetBusinessIndustryCode = "spGetBusinessIndustryCode";
        public const string spGetTPAWizardSteps = "spGetTPAWizardSteps";
        public const string spInsertEmployerXml = "spInsertEmployerXml";
        public const string spGetSourceCarriers = "spGetSourceCarriers";
        public const string spGetNotAssociatedCarriers = "spGetNotAssociatedCarriers";
        public const string spInsertBenefitCarrierMap = "spInsertBenefitCarrierMap";
        public const string spInsertCarrierWithGroupCode = "spInsertCarrierWithGroupCode";
        public const string spDeleteContributionSchedule = "spDeleteContributionSchedule";
        public const string spDeleteEEContributionSchedule = "spDeleteEEContributionSchedule";
        public const string spDeletePayrollSchedule = "spDeletePayrollSchedule";
        public const string spDeletePaymentSchedule = "spDeletePaymentSchedule";
        public const string spDeleteCarrierMap = "spDeleteCarrierMap";
        public const string spCheckPlanCarrierMap = "spCheckPlanCarrierMap";
        public const string spInsertCarrierXml = "spInsertCarrierXml";
        public const string spGetWizardId = "spGetWizardId";
        public const string spInsertBenefitLimitsBenefits = "spInsertBenefitLimitsBenefits";
        public const string spInsertBenefitLimitsTier = "spInsertBenefitLimitsTier";
        public const string spGetLimitsBenefits = "spGetLimitsBenefits";
        public const string spGetLimitsBenefitsByBenefitId = "spGetLimitsBenefitsByBenefitId";
        public const string spGetLimitsTierByBenefitId = "spGetLimitsTierByBenefitId";
        public const string spGetLimitsTier = "spGetLimitsTier";
        public const string spUpdateBenefitLimitsBenefits = "spUpdateBenefitLimitsBenefits";
        public const string spUpdateBenefitLimitsTier = "spUpdateBenefitLimitsTier";
        public const string spDeleteBenefitLimitsBenefits = "spDeleteBenefitLimitsBenefits";
        public const string spCheckLimitsBeginDate = "spCheckLimitsBeginDate";
        public const string spCheckLimitsTierBeginDate = "spCheckLimitsTierBeginDate";
        public const string spDeleteBenefitLimitsTier = "spDeleteBenefitLimitsTier";
        public const string spGetAllDepartment = "spGetAllDepartment";
        public const string spUpdateEmployee = "spUpdateEmployee";
        public const string spUpdateEmployeeDemographics = "spUpdateEmployeeDemographics";
        public const string spGetEmployee = "spGetEmployee";
        public const string spDeleteAttachment = "spDeleteAttachment";
        public const string spDeleteAttachments = "spDeleteAttachments";
        public const string spGetAttachments = "spGetAttachments";
        public const string spGetIndividualAttachment = "spGetIndividualAttachment";
        public const string spInsertAttachmentDetails = "spInsertAttachmentDetails";
        public const string spGetAllDependentsForEmployee = "spGetAllDependentsForEmployee";
        public const string spGetAllActiveDependentsForEmployee = "spGetAllActiveDependentsForEmployee";
        public const string spGetAllEmployeeForEmployer = "spGetAllEmployeeForEmployer";
        public const string spGetEmployeesByFilter = "spGetEmployeesByFilter";
        public const string spGetAllEmployee = "spGetAllEmployee";
        public const string spInsertDependent = "spInsertDependent";
        public const string spUpdateDependent = "spUpdateDependent";
        public const string spDeleteDependent = "spDeleteDependent";
        public const string spGetAllEmployerDependent = "spGetAllEmployerDependent";
        public const string spGetDependent = "spGetDependent";
        public const string spDeleteERContactManagement = "spDeleteERContactManagement";
        public const string spGetPrimaryContactCount = "spGetPrimaryContactCount";
        public const string spGetPrimaryAddressCount = "spGetPrimaryAddressCount";
        public const string spGetAllEmployeebyName = "spGetAllEmployeebyName";
        public const string spGetEmployerAcclarisExtension = "spGetEmployerAcclarisExtension";
        public const string spUpdateEmployerAcclarisExtension = "spUpdateEmployerAcclarisExtension";
        public const string spGetERBenefitBankAcctMap = "spGetERBenefitBankAcctMap";
        public const string spGetAllNotAssociatedAvailableServices = "spGetAllNotAssociatedAvailableServices";
        public const string spGetAllSourceAvailableServices = "spGetAllSourceAvailableServices";
        public const string spInsertBenefitAvailableServiceMap = "spInsertBenefitAvailableServiceMap";
        public const string spInsertBenefitEmployeeClassMap = "spInsertBenefitEmployeeClassMap";
        public const string spDeleteAvailableServiceMap = "spDeleteAvailableServiceMap";
        public const string spGetDivisionReferences = "spGetDivisionReferences";
        public const string spGetHRABenefitPlanType = "spGetHRABenefitPlanType";
        public const string spGetHRABenefitPlanDesign = "spGetHRABenefitPlanDesign";
        public const string spGetBenefitPlanDesign = "spGetBenefitPlanDesign";
        public const string spDeleteAddressWithoutPopUp = "spDeleteAddressWithoutPopUp";
        public const string spDeleteEmployeeBenefit = "spDeleteEmployeeBenefit";
        public const string spGetOneERBankAccountDetails = "spGetOneERBankAccountDetails";
        public const string spGetERAssociatedMerchantCategoryCodes = "spGetERAssociatedMerchantCategoryCodes";
        public const string spGetERAssociatedMerchantCategoryCodesByFilter = "spGetERAssociatedMerchantCategoryCodesByFilter";
        public const string spGetSourceMerchantCategoryCodes = "spGetSourceMerchantCategoryCodes";
        public const string spInsertERMerchantCategoryCodeMap = "spInsertERMerchantCategoryCodeMap";
        public const string spDeleteERMerchantCategoryCodeMap = "spDeleteERMerchantCategoryCodeMap";
        public const string spGetAllTPABillingBenefitRates = "spGetAllTPABillingBenefitRates";
        public const string spGetAllTPABillingGroupOptionNames = "spGetAllTPABillingGroupOptionNames";
        public const string spInsertTPABenefitRate = "spInsertTPABenefitRate";
        public const string spUpdateTPABenefitRate = "spUpdateTPABenefitRate";
        public const string spDeleteTPABenefitRate = "spDeleteTPABenefitRate";
        public const string spGetBenifitRate = "spGetBenifitRate";
        public const string spInsertTPAInvoiceDetails = "spInsertTPAInvoiceDetails";
        public const string spGetTPAInvoiceDetail = "spGetTPAInvoiceDetail";
        public const string spSaveOrUpdateERBillingInvoiceMethod = "spSaveOrUpdateERBillingInvoiceMethod";
        public const string spGetERBillingInvoiceMethod = "spGetERBillingInvoiceMethod";
        public const string spGetChargeType = "spGetChargeType";
        public const string spGetAllERBenefitDetails = "spGetAllERBenefitDetails";
        public const string spGetAllSourceERBillingBeneRates = "spGetAllSourceERBillingBeneRates";
        public const string spValidateDivisionDepartment = "spValidateDivisionDepartment";
        public const string spGetBusinessIndustryID = "spGetBusinessIndustryID";
        public const string spEmployerDivisionRef = "spEmployerDivisionRef";
        public const string spExistDefaultDivision = "spExistDefaultDivision";
        public const string spGetAllSequenceOrderValues = "spGetAllSequenceOrderValues";
        public const string spGetEmployerGUIDByAccessCode = "spGetEmployerGUIDByAccessCode";
        public const string spGetEmployeeGUIDByAccessCode = "spGetEmployeeGUIDByAccessCode";
        public const string spGetAddressDetail = "spGetAddressDetail";
        public const string spGetAllInvoiceTemplates = "spGetAllInvoiceTemplates";
        public const string spGetAdjustmentReport = "spGetAdjustmentReport";
        public const string spInsertInvoiceTemplate = "spInsertInvoiceTemplate";
        public const string spUpdateInvoiceTemplate = "spUpdateInvoiceTemplate";
        public const string spDeleteInvoiceTemplate = "spDeleteInvoiceTemplate";
        public const string spGetOneInvoiceTemplateDetail = "spGetOneInvoiceTemplateDetail";
        public const string spCheckERContributionScheduleDate = "spCheckERContributionScheduleDate";
        public const string spCheckForMccAndSubstantionSetup = "spCheckForMccAndSubstantionSetup";
        public const string spDeleteERBenefit = "spDeleteERBenefit";
        public const string spGetAllNotesVisibleToEmployer = "spGetAllNotesVisibleToEmployer";
        public const string spCheckForDeleteERBenefit = "spCheckForDeleteERBenefit";
        public const string spInsertERRenewalBenefitRecord = "spInsertERRenewalBenefitRecord";
        public const string spGetERBenefitNames = "spGetERBenefitNames";
        public const string spCheckEmployerAccessCode = "spCheckEmployerAccessCode";
        public const string spGetMCCByFilter = "spGetMCCByFilter";
        public const string spGetGlobalAdjustmentsByFilter = "spGetGlobalAdjustmentsByFilter";
        public const string spValidateEEBenefitForDuplication = "spValidateEEBenefitForDuplication";
        public const string spFetchEmployerGUIDbyAccessCode = "spFetchEmployerGUIDbyAccessCode";
        public const string spCheckDefaultInvoiceTemplate = "spCheckDefaultInvoiceTemplate";
        public const string spCheckDuplicateEESSN = "spCheckDuplicateEESSN";
        public const string spCheckEmployeeStatus = "spCheckEmployeeStatus";
        public const string spUpdateEmployeeCommunicationInfo = "spUpdateEmployeeCommunicationInfo";
        public const string spValidateForTaxID = "spValidateForTaxID";
        public const string spGetBalanceAmountforEmployer = "spGetBalanceAmountforEmployer";
        public const string spInsertPayment = "spInsertPayment";
        public const string spGetAllPayments = "spGetAllPayments";
        public const string spGetAllSearchPaymentsForEmployer = "spGetAllSearchPaymentsForEmployer";
        public const string spGetOnePayment = "spGetOnePayment";
        public const string spGetAdjustments = "spGetAdjustments";
        public const string spInsertAdjustment = "spInsertAdjustment";
        public const string spGetSourceAdjustments = "spGetSourceAdjustments";
        public const string spInsertAdjustmentMap = "spInsertAdjustmentMap";
        public const string spGetOneAdjustment = "spGetOneAdjustment";
        public const string spGetInvoices = "spGetInvoices";
        public const string spGetSearchInvoices = "spGetSearchInvoices";
        public const string spGetInvoiceSummaryForEntity = "spGetInvoiceSummaryForEntity";
        public const string spDeleteAllEmployeeDetails = "spDeleteAllEmployeeDetails";
        public const string spDeleteAllEmployerDetails = "spDeleteAllEmployerDetails";
        public const string spCheckForEEBenefitRenewal = "spCheckForEEBenefitRenewal";
        public const string spGetAllEmployeeBasedOnStatus = "spGetAllEmployeeBasedOnStatus";
        public const string spUpdateEEGroupStatus = "spUpdateEEGroupStatus";
        public const string spUpdateEEGroupClass = "spUpdateEEGroupClass";
        public const string spGetAllNotAssociatedEmployeeClass = "spGetAllNotAssociatedEmployeeClass";
        public const string spInsertTPASmtpSettings = "spInsertTPASmtpSettings";
        public const string spGetTPASmtpSettings = "spGetTPASmtpSettings";
        public const string spSaveTPASmtpSettings = "spSaveTPASmtpSettings";
        public const string spGetAllDuplicateEmployee = "spGetAllDuplicateEmployee";
        //public const string spInsertCommAttachment = "spInsertCommAttachment";
        //public const string spDeleteCommAttachment = "spDeleteCommAttachment";
        //public const string spGetAllCommAttachments = "spGetAllCommAttachments";
        public const string spInsertCommunication = "spInsertCommunication";
        public const string spUpdateCommunication = "spUpdateCommunication";
        public const string spGetAllCommunication = "spGetAllCommunication";
        public const string spGetOneCommunication = "spGetOneCommunication";
        public const string spDeleteCommunication = "spDeleteCommunication";
        public const string spDeleteCommunicationDetails = "spDeleteCommunicationDetails";
        public const string spGetAllCommunicationDetails = "spGetAllCommunicationDetails";
        public const string spUpdateCommunicationReadFlag = "spUpdateCommunicationReadFlag";
        public const string spValidateEmployeeBenefitImportData = "spValidateEmployeeBenefitImportData";
        public const string spImportEEBenefits = "spImportEEBenefits";
        public const string spGetAllEmployeeClass = "spGetAllEmployeeClass";
        public const string spGetOneEmployeeClass = "spGetOneEmployeeClass";
        public const string spInsertEmployeeClass = "spInsertEmployeeClass";
        public const string spSaveEmployeeClass = "spSaveEmployeeClass";
        public const string spDeleteEmployeeClass = "spDeleteEmployeeClass";
        public const string spCheckDuplicateClassName = "spCheckDuplicateClassName";
        public const string spGetAllEmploymentForEmployee = "spGetAllEmploymentForEmployee";
        public const string spInsertEmploymentForEmployee = "spInsertEmploymentForEmployee";
        public const string spUpdateEmploymentForEmployee = "spUpdateEmploymentForEmployee";
        public const string spDeleteEmploymentForEmployee = "spDeleteEmploymentForEmployee";
        public const string spGetOneEmploymentForEmployee = "spGetOneEmploymentForEmployee";
        public const string spCheckEEEmploymentBeginDate = "spCheckEEEmploymentBeginDate";
        public const string spSaveERBenefitEnrollmentWindow = "spSaveERBenefitEnrollmentWindow";
        public const string spGetERBenefitEnrollmentWindow = "spGetERBenefitEnrollmentWindow";
        public const string spGetEnrollmentRule = "spGetEnrollmentRule";
        public const string spGetERBenefitEnrollmentRule = "spGetERBenefitEnrollmentRule";
        public const string spSaveERBenefitEnrollmentRule = "spSaveERBenefitEnrollmentRule";
        public const string spGetERBenefitEnrollmentRuleList = "spGetERBenefitEnrollmentRuleList";
        public const string spCheckForExistingEnrollmentRules = "spCheckForExistingEnrollmentRules";
        public const string spDeleteERBenefitEnrollmentRule = "spDeleteERBenefitEnrollmentRule";
        public const string spGetERBenefitEligibilityRule = "spGetERBenefitEligibilityRule";
        public const string spGetEligibilityRule = "spGetEligibilityRule";
        public const string spCheckForExistingEligibilityRules = "spCheckForExistingEligibilityRules";
        public const string spSaveERBenefitEligibilityRule = "spSaveERBenefitEligibilityRule";
        public const string spDeleteERBenefitEligibilityRule = "spDeleteERBenefitEligibilityRule";
        public const string spSaveEESpecialEnrollmentDetailsInGroup = "spSaveEESpecialEnrollmentDetailsInGroup";
        public const string spGetAllEmployeesByFilter = "spGetAllEmployeesByFilter";
        public const string spGetERDetailFromGuidOrTaxID = "spGetERDetailFromGuidOrTaxID";
        public const string spValidateBenefitDetail = "spValidateBenefitDetail";
        public const string spHSAEmployeeMap = "spHSAEmployeeMap";
        public const string spValidateEEBenefitEnrollmentDate = "spValidateEEBenefitEnrollmentDate";
        public const string spGetEmployerNameOrTaxIdForEEMap = "spGetEmployerNameOrTaxIdForEEMap";
        public const string spValidateEmployeeImportData = "spValidateEmployeeImportData";
        public const string spGetAllPlanGroupTermValues = "spGetAllPlanGroupTermValues";
        public const string spGetTPAPlanHighlights = "spGetTPAPlanHighlights";
        public const string spGetAllBenefitPlans = "spGetAllBenefitPlans";
        public const string spCheckForAutoSubstantiationMccMap = "spCheckForAutoSubstantiationMccMap";
        public const string spDeleteAllERMerchantCategoryCodeMap = "spDeleteAllERMerchantCategoryCodeMap";

        //Terms
        public const string spGetAllTermClass = "spGetAllTermClass";
        public const string spGetOneTermClass = "spGetOneTermClass";
        public const string spInsertTermClass = "spInsertTermClass";
        public const string spSaveTermClass = "spSaveTermClass";
        public const string spDeleteTermClass = "spDeleteTermClass";
        public const string spGetTermClassGuid = "spGetTermClassGuid";


        //Term Groups
        public const string spGetAllTermGroups = "spGetAllTermGroups";
        public const string spGetOneTermGroups = "spGetOneTermGroups";
        public const string spInsertTermGroups = "spInsertTermGroups";
        public const string spSaveTermGroups = "spSaveTermGroups";
        public const string spDeleteTermGroups = "spDeleteTermGroups";


        //MapTermGroups
        public const string spGetTermGroupNames = "spGetTermGroupTypes";
        public const string spGetAssignedUnAssginedMapTerms = "spGetAssignedUnAssginedMapTerms";
        public const string spGetAllMapTermGroups = "spGetAllMapTermGroups";
        public const string spSaveMapTermGroups = "spSaveMapTermGroups";
        public const string spGetAllFilteredMapTermGroups = "spGetAllFilteredMapTermGroups";


        //Auto Substantiation Rules
        public const string spInsertERAutoSubstantiationRule = "spInsertERAutoSubstantiationRule";
        public const string spUpdateERAutoSubstantiationRule = "spUpdateERAutoSubstantiationRule";
        public const string spGetERAutoSubstantiationRules = "spGetERAutoSubstantiationRules";
        public const string spGetERAutoSubstantiationRule = "spGetERAutoSubstantiationRule";
        public const string spDeleteERAutoSubstantiationRule = "spDeleteERAutoSubstantiationRule";

        public const string spInsertERCopay = "spInsertERCopay";
        public const string spUpdateERCopay = "spUpdateERCopay";
        public const string spGetERCopay = "spGetERCopay";
        public const string spGetERCopays = "spGetERCopays";
        public const string spDeleteERCopay = "spDeleteERCopay";

        public const string spGetERCopayMCCodes = "spGetERCopayMCCodes";
        public const string spInsertERCopayMCCodes = "spInsertERCopayMCCodes";

        //Users 
        public const string spInsertUser = "spInsertUser";
        public const string spUpdateUser = "spUpdateUser";
        public const string spGetUser = "spGetUser";
        public const string spGetUsers = "spGetUsers";
        public const string spGetUsersSearchDropDownData = "spGetUsersSearchDropDownData";

        public const string spGetRegisteredERContacts = "spGetRegisteredERContacts";
        public const string spLockOrUnlockPortalRegisteredUser = "spLockOrUnlockPortalRegisteredUser";
        public const string spResetPortalRegisteredUserPassword = "spResetPortalRegisteredUserPassword";
        public const string spGetPortalRegisteredEmployees = "spGetPortalRegisteredEmployees";
        public const string spGetPortalRegisteredEmployeesForER = "spGetPortalRegisteredEmployeesForER";

        public const string spDeleteUser = "spDeleteUser";
        public const string spCheckAvailability = "spCheckAvailability";
        public const string spGetRoleGUIDForUser = "spGetRoleGUIDForUser";
        public const string spGetRoleNameforUser = "spGetRoleNameforUser";
        public const string spChangePassword = "spChangePassword";
        public const string spValidateVendor = "spValidateVendor";
        public const string spValidateVendorandReturnAccessCodeERGUID = "spValidateVendorandReturnAccessCodeERGUID";

        //Roles
        public const string spUpdateRoles = "spUpdateRoles";
        public const string spDeleteRole_RolePermissionSetMap = "spDeleteRole_RolePermissionSetMap";
        public const string spGetRoles = "spGetRoles";
        public const string spGetRole = "spGetRole";
        public const string spInsertRole = "spInsertRole";
        public const string spUpdateRolePermissionSetMap = "spUpdateRolePermissionSetMap";
        public const string spInsertRolePermissionSetMap = "spInsertRolePermissionSetMap";
        public const string spValidateRoleName = "spValidateRoleName";
        public const string spGetDataForRolePermissionSet = "spGetDataForRolePermissionSet";
        public const string spGetAccessLevelFromLookup = "spGetAccessLevelFromLookup";
        public const string spPermissionSetNames = "spPermissionSetNames";
        public const string spGetGroupNames = "spGetGroupNames";

        //Substantiation Rules
        public const string spUpdateSubRules = "spUpdateSubRules";
        public const string spInsertSubRules = "spInsertSubRules";
        public const string spGetLastGloablSubRules = "spGetLastGloablSubRules";
        public const string spVerifyIfEmployerHasDebitCard = "spVerifyIfEmployerHasDebitCard";

        //Global MCC Codes
        public const string spInsertGlobalMCCCode = "spInsertGlobalMCCCode";
        public const string spGetOneMCCCodes = "spGetOneMCCCodes";
        public const string spGetGlobalMCCCodes = "spGetGlobalMCCCodes";
        public const string spDeleteMCCCodes = "spDeleteMCCCodes";
        public const string spUpdateMCCCodes = "spUpdateMCCCodes";
        public const string spUpdateTPAInvoiceDetails = "spUpdateTPAInvoiceDetails";
        public const string spCheckDuplicateMcc = "spCheckDuplicateMcc";

        //Employer Substantiation Rules
        public const string spInsertERSubRules = "spInsertERSubRules";
        public const string spUpdateERSubRules = "spUpdateERSubRules";
        public const string spGetERSubRules = "spGetERSubRules";

        //Import Employee
        public const string spImportEmployee = "spImportEmployee";
        public const string spGetActiveDependentsForEEEmployee = "spGetActiveDependentsForEEPortal";
        public const string spGetAvailableReportByPermission = "spGetAvailableReportByPermission";
        //*******************************************************************************
        #region Global Information
        //TPA Demographics
        public const string spUpdatetbl_refTPA = "spUpdatetbl_refTPA";
        public const string spGetTPADetail = "spGetTPADetail";
        public const string spValidBusinessIndustryCode = "spValidBusinessIndustryCode";
        //TPA Business Codes
        public const string spInsertBusinessIndustryCode = "spInsertBusinessIndustryCode";
        public const string spUpdateBusinessIndustryCode = "spUpdateBusinessIndustryCode";
        public const string spDeleteBusinessIndustryCode = "spDeleteBusinessIndustryCode";
        public const string spGetAllBusinessIndustryCode = "spGetAllBusinessIndustryCode";
        public const string spGetOneBusinessIndustryCode = "spGetOneBusinessIndustryCode";
        public const string spGetBusinessIndustryByFilter = "spGetBusinessIndustryByFilter";
        public const string spCheckDuplicateBusinessCode = "spCheckDuplicateBusinessCode";
        //TPA Available Services
        public const string spInsertAvailableServices = "spInsertAvailableServices";
        public const string spUpdateAvailableServices = "spUpdateAvailableServices";
        public const string spDeleteAvailableServices = "spDeleteAvailableServices";
        public const string spGetAllAvailableServices = "spGetAllAvailableServices";
        public const string spGetOneAvailableServices = "spGetOneAvailableServices";
        public const string spGetAvailableServiceByFilter = "spGetAvailableServiceByFilter";
        public const string spValidateDuplicateServiceCode = "spValidateDuplicateServiceCode";

        #endregion
        //*******************************************************************************

        //*******************************************************************************
        #region Payment Schedule Related Stored Procedures
        public const string spGetOnePaymentSchedule = "spGetOnePaymentSchedule";
        public const string spGetERPaymentSchedules = "spGetERPaymentSchedules";
        public const string spUpdatePaymentSchedule = "spUpdatePaymentSchedule";
        public const string spInsertPaymentSchedule = "spInsertPaymentSchedule";
        public const string spInsertPaymentScheduleDetails = "spInsertPaymentScheduleDetails";
        public const string spUpdatePaymentScheduleDetails = "spUpdatePaymentScheduleDetails";
        public const string spSelectPaymentScheduleDetail = "spSelectPaymentScheduleDetail";
        public const string spSelectERPaymentScheduleDetails = "spSelectERPaymentScheduleDetails";
        public const string spDeletePaymentScheduleDetail = "spDeletePaymentScheduleDetail";
        #endregion Payment Schedule Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************
        #region Employer Benefit Related Stored Procedures

        public const string spGetERBenefits = "spGetERBenefits";
        public const string spGetBenefit = "spGetBenefit";
        public const string spInsertERBenefit = "spInsertERBenefit";
        public const string spUpdateERBenefit = "spUpdateERBenefit";
        public const string spGetBenefitContributionSchedules = "spGetBenefitContributionSchedules";
        public const string spGetBenefitPayrollSchedules = "spGetBenefitPayrollSchedules";
        public const string spGetBenefitPaymentSchedules = "spGetBenefitPaymentSchedules";
        public const string spInsertBenefitContributionSchMap = "spInsertBenefitContributionSchMap";
        public const string spInsertBenefitPayrollSchMap = "spInsertBenefitPayrollSchMap";
        public const string spInsertBenefitPmtProcessingMap = "spInsertBenefitPmtProcessingMap";
        public const string spDeleteBenefitContributionScheduleMap = "spDeleteBenefitContributionScheduleMap";
        public const string spDeleteBenefitPayrollScheduleMap = "spDeleteBenefitPayrollScheduleMap";
        public const string spDeleteBenefitPaymentScheduleMap = "spDeleteBenefitPaymentScheduleMap";
        public const string spGetERBenefitDesign = "spGetERBenefitDesign";
        public const string spSaveOrUpdateERBenefitDesign = "spSaveOrUpdateERBenefitDesign";
        public const string spGetOneERBenefitDesign = "spGetOneERBenefitDesign";
        public const string spDeleteERBenefitDesign = "spDeleteERBenefitDesign";
        public const string spGetPrimaryBeneficiaryPercentage = "spGetPrimaryBeneficiaryPercentage";
        public const string spUpdateGraceCarryPeriod = "spUpdateGraceCarryPeriod";
        public const string spUpdateRunOutBenefit = "spUpdateRunOutBenefit";
        public const string spUpdateERBenefitExPlan = "spUpdateERBenefitExPlan";
        public const string spUpdateErBenefitOrder = "spUpdateErBenefitOrder";
        public const string spCheckExistingBenefitImportCode = "spCheckExistingBenefitImportCode";
        public const string spERBenefitSearchDropDownData = "spERBenefitSearchDropDownData";
        public const string spGetAllSearchERBenefit = "spGetAllSearchERBenefit";

        #endregion Employer Benefit Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************
        #region Employer Benefit Rates Related Stored Procedures

        public const string spInsertERBenefitRate = "spInsertERBenefitRate";
        public const string spInsertERBenefitRateDetail = "spInsertERBenefitRateDetail";
        public const string spGetERBenefitRate = "spGetERBenefitRate";
        public const string spGetERBenefitRateDetail = "spGetERBenefitRateDetail";
        public const string spDeleteERBenefitRateAndDetails = "spDeleteERBenefitRateAndDetails";
        public const string spUpdateERBenefitRateDetail = "spUpdateERBenefitRateDetail";

        #endregion Employer Benefit Rates Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************

        #region Employee Related Stored Procedures

        public const string spInsertEmployee = "spInsertEmployee";
        public const string spInsertEmployeeForErPortal = "spInsertEmployeeForErPortal";


        #endregion Employer Benefit Rates Related Stored Procedures

        #region Employer Benefit Contributions Related Stored Procedures

        public const string spInsertERBenefitContribution = "spInsertERBenefitContribution";
        public const string spInsertERBenefitContributionDetail = "spInsertERBenefitContributionDetail";
        public const string spGetERBenefitContribution = "spGetERBenefitContribution";
        public const string spGetERBenefitContributionDetail = "spGetERBenefitContributionDetail";
        public const string spDeleteERBenefitContributionAndDetails = "spDeleteERBenefitContributionAndDetails";
        public const string spUpdateERBenefitContributionDetail = "spUpdateERBenefitContributionDetail";
        public const string spUpdateEmployeeDebitCardInfo = "spUpdateEmployeeDebitCardInfo";

        #endregion Employer Benefit Rates Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************
        #region Carrier Related Stored Procedures
        public const string spGetAllCarrier = "spGetAllCarrier";
        public const string spGetOneCarrier = "spGetOneCarrier";
        public const string spGetBenefitCarrierDetails = "spGetBenefitCarrierDetails";
        public const string spInsertCarrier = "spInsertCarrier";
        public const string spUpdateCarrier = "spUpdateCarrier";

        #endregion Carrier Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************
        #region Carrier Benefit Related Stored Procedures
        public const string spGetMappedCarrierBenefits = "spGetMappedCarrierBenefits";
        public const string spGetNotMappedCarrierBenefits = "spGetNotMappedCarrierBenefits";
        public const string spInsertCarrierBenefits = "spInsertCarrierBenefits";
        public const string spDeleteCarrierBenefit = "spDeleteCarrierBenefit";
        public const string spValidateIfBenefitOfferedByCarrierIsAssigned = "spValidateIfBenefitOfferedByCarrierIsAssigned";

        #endregion Carrier Benefit Related Stored Procedures

        //*******************************************************************************

        //*******************************************************************************
        #region Employer Bank Account Related Stored Procedures

        public const string spGetBankAccountInfo = "spGetBankAccountInfo"; // NAME changed WRT to BUG: 29848
        public const string spInsertBankAccountInfo = "spInsertBankAccountInfo";// NAME changed WRT to BUG: 29848
        public const string spUpdateBankAccountInfo = "spUpdateBankAccountInfo";// NAME changed WRT to BUG: 29848
        public const string spGetOneBankAccountInfo = "spGetOneBankAccountInfo";// NAME changed WRT to BUG: 29848

        public const string spDeleteERBankAccountInfo = "spDeleteERBankAccountInfo";
        public const string spGetERBenefitBankAccountInfo = "spGetERBenefitBankAccountInfo";
        public const string spIsAccountNoInUse = "spIsAccountNoInUse";
        public const string spValidateBankAccountNo = "spValidateBankAccountNo";

        #endregion Employer Bank Account Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************
        #region Benefit Bank Account Related Stored Procedures
        public const string spAssociateERBankAcctToERBenefit = "spAssociateERBankAcctToERBenefit";
        public const string spDeleteERBenefitBankAcctMap = "spDeleteERBenefitBankAcctMap";
        public const string spUpdateERBankAcctToERBenefit = "spUpdateERBankAcctToERBenefit";
        #endregion Benefit Bank Account Related Stored Procedures
        //*******************************************************************************

        //*******************************************************************************
        #region Employee Beneficiaries related stored procedures

        public const string spGetEEIndividualBeneficiaries = "spGetEEIndividualBeneficiaries";
        public const string spGetEECompanyBeneficiaries = "spGetEECompanyBeneficiaries";
        public const string spUpdateEECompanyBeneficiary = "spUpdateEECompanyBeneficiary";
        public const string spInsertEECompanyBeneficiary = "spInsertEECompanyBeneficiary";
        public const string spUpdateEEIndividualBeneficiary = "spUpdateEEIndividualBeneficiary";
        public const string spInsertEEIndiviualBeneficiary = "spInsertEEIndiviualBeneficiary";
        public const string spGetOneEECompanyBeneficiary = "spGetOneEECompanyBeneficiary ";
        public const string spGetOneEEIndividualBeneficiary = "spGetOneEEIndividualBeneficiary";
        public const string spDeleteEECompanyBeneficiary = "spDeleteEECompanyBeneficiary";
        public const string spDeleteEEIndividualBeneficiary = "spDeleteEEIndividualBeneficiary";
        public const string spGetAddressNames = "spGetAddressNames";


        #endregion
        //*******************************************************************************

        #region Tier Related Stored Procedure

        public const string spGetAllTiers = "spGetAllTiers";
        public const string spGetOneTier = "spGetOneTier";
        public const string spUpdateTier = "spUpdateTier";
        public const string spInsertTier = "spInsertTier";
        public const string spDeleteTier = "spDeleteTier";
        public const string spValidateTierCode = "spValidateTierCode";
        public const string spGetTiersByFilter = "spGetTiersByFilter";

        #endregion

        #region Global Adjustment Related Stored procedures
        public const string spInsertGlobalAdjustment = "spInsertGlobalAdjustment";
        public const string spUpdateGlobalAdjustment = "spUpdateGlobalAdjustment";
        public const string spDeleteGlobalAdjustment = "spDeleteGlobalAdjustment";
        public const string spGetAllGlobalAdjustments = "spGetAllGlobalAdjustments";
        public const string spGetOneGlobalAdjustment = "spGetOneGlobalAdjustment";

        #endregion Global Adjustment Related Stored procedures

        #region One Time Rate Related Stored procedures
        public const string spInsertMiscCharges = "spInsertMiscCharges";
        public const string spUpdateMiscCharges = "spUpdateMiscCharges";
        public const string spDeleteMiscCharge = "spDeleteMiscCharge";
        public const string spGetOneMiscCharge = "spGetOneMiscCharge";
        public const string spGetAllMiscCharge = "spGetAllMiscCharge";
        public const string spGetAllTPAMiscCharge = "spGetAllTPAMiscCharge";
        public const string spInsertEmployerMiscChargeMap = "spInsertEmployerMiscChargeMap";

        #endregion One Time Rate Related Stored procedures

        #region Audit Related Stored procedures
        public const string spGetAuditDropDownsData = "spGetAuditDropDownsData";
        public const string spGetAuditInformation = "spGetAuditInformation";
        public const string spGetColumnNamesForTable = "spGetColumnNamesForTable";
        #endregion

        #region Invoice Related Stored Procedures
        #endregion

        #region "Duplicate Claim Related Sps"
        public const string spInsertDuplicateClaimSettingsForCarrier = "spInsertDuplicateClaimSettingsForCarrier";
        public const string spUpdateDuplicateClaimSettingsOfCarrier = "spUpdateDuplicateClaimSettingsOfCarrier";
        public const string spGetDuplicateClaimSettingsForCarrier = "spGetDuplicateClaimSettingsForCarrier";
        public const string spDeleteDuplicateClaimSettingsofCarrier = "spDeleteDuplicateClaimSettingsofCarrier";
        #endregion

        #region "Recipient Related Stored Procedures"
        public const string spInsertRecipient = "spInsertRecipient";
        public const string spGetRecipientSQLsBasedOnType = "spGetRecipientSQLsBasedOnType";
        public const string spExecuteQuery = "spExecuteQuery";
        public const string spGetRecipientsByFilter = "spGetRecipientsByFilter";
        public const string spGetAllActiveRecipientsByFilter = "spGetAllActiveRecipientsByFilter";
        #endregion

        #region "Communication Related Stored Procedures"
        public const string spGetAllCommunicationByFilter = "spGetAllCommunicationByFilter";
        #endregion

        #region "Employee Benficiary Related Stored Procedures"
        public const string spGetBeneficiary = "spGetBeneficiary";
        public const string spGetAllBenficiaries = "spGetAllBenficiaries";
        public const string spInsertEmployeeBeneficiary = "spInsertEmployeeBeneficiary";
        public const string spUpdateEmployeeBeneficiary = "spUpdateEmployeeBeneficiary";
        public const string spDeleteBeneficiary = "spDeleteBeneficiary";
        public const string spValidateBeneficiaryPercent = "spValidateBeneficiaryPercent";
        public const string spValidateSecondaryBeneficiaryAdd = "spValidateSecondaryBeneficiaryAdd";

        #endregion

        //tbl_Provider
        public const string spInsertProvider = "spInsertProvider";
        public const string spGetProvider = "spGetProvider";
        public const string spGetProviders = "spGetProviders";
        public const string spGetAddressForProvider = "spGetAddressForProvider";
        public const string spDeleteProvider = "spDeleteProvider";
        public const string spUpdateProvider = "spUpdateProvider";
        public const string spCheckDuplicateProvider = "spCheckDuplicateProvider";

        //tbl_Claims
        public const string spGetEmployeeDetailsForClaims = "spGetEmployeeDetailsForClaims";
        public const string spGetDependentDetailsforClaims = "spGetDependentDetailsforClaims";
        public const string spInsertClaim = "spInsertClaim";
        public const string spGetBenefitsForClaims = "spGetBenefitsForClaims";
        public const string spGetCarriersForClaims = "spGetCarriersForClaims";
        public const string spGetAvailableServicesForClaims = "spGetAvailableServicesForClaims";
        public const string spGetAvailableServiceCodeforClaims = "spGetAvailableServiceCodeforClaims";
        public const string spGetAllClaims = "spGetAllClaims";
        public const string spDeleteClaim = "spDeleteClaim";
        public const string spUpdateClaim = "spUpdateClaim";
        public const string spValidateForDuplicateClaim = "spValidateForDuplicateClaim";
        public const string spGetClaimsSearchDropDownData = "spGetClaimsSearchDropDownData";
        public const string spValidateClaimImportData = "spValidateClaimImportData";
        public const string spImportClaims = "spImportClaims";


        public const string spInsertVariables = "spInsertVariables";
        public const string spValidateVariableName = "spValidateVariableName";
        public const string spGetVariable = "spGetVariable";
        public const string spGetVariableDetails = "spGetVariableDetails";
        public const string spGetVariableDetailsByFilter = "spGetVariableDetailsByFilter";
        public const string spGetAllVariables = "spGetAllVariables";
        public const string spInsertSelecetedVariables = "spInsertSelecetedVariables";
        public const string spDeleteVariable = "spDeleteVariable";
        public const string spUpdateVariable = "spUpdateVariable";
        public const string spIsVariableInCommunication = "spIsVariableInCommunication";
        public const string spGetSelectedVariableType = "spGetSelectedVariableType";
        public const string spGetVariableValueByName = "spGetVariableValueByName";

        #endregion Stored procedure Names

        #region Table column Names
        //tbl_PageName
        public const string PageID = "PageID";
        public const string PageName = "PageName";
        public const string RelativePath = "RelativePath";
        public const string Menuflag = "Menuflag";

        //tbl_PermissionSet        
        public const string PermissionSetName = "PermissionSetName";
        public const string PermissionSetId = "PermissionSetId";
        public const string AccessLevelLookup = "AccessLevelLookup";

        //tbl_EEBenefit
        public const string EEBenefitDescription = "EEBenefitDescription";
        public const string EEBenefitGUID = "EEBenefitGUID";
        public const string EEBenefitEffectiveDate = "EEBenefitEffectiveDate";
        public const string EEBenefitEndDate = "EEBenefitEndDate";
        public const string BenefitStatus = "BenefitStatus";
        public const string EEBenefitTermDate = "EEBenefitTermDate";
        public const string EEBenefitDeductionMethodLookup = "EEBenefitDeductionMethodLookup";
        public const string EEBenefitTierID = "EEBenefitTierID";
        public const string EmployeeBenefitXml = "EmployeeBenefitXml";
        public const string EmployeeIndPlanXml = "EmployeeIndPlanXml";

        public const string ImportCodeErrorMessage = "ImportCodeErrorMessage";
        public const string EffectiveDateErrorMesage = "EffectiveDateErrorMesage";
        public const string TermDateErrorMesage = "TermDateErrorMesage";
        public const string ReasonErrorMessage = "ReasonErrorMessage";
        public const string BenefitStatusErrorMessage = "BenefitStatusErrorMessage";
        public const string EEDependantsErrorMessage = "EEDependantsErrorMessage";
        public const string ContributionImportCodeErrorMessage = "ContributionImportCodeErrorMessage";
        public const string DeductionMethodErrorMessage = "DeductionMethodErrorMessage";
        public const string TierErrorMessage = "TierErrorMessage";
        public const string PaymentTypeErrorMessage = "PaymentTypeErrorMessage";
        public const string BillingFrequencyErrorMessage = "BillingFrequencyErrorMessage";
        public const string RateTierErrorMessage = "RateTierErrorMessage";
        public const string ERContributionErrorMessage = "ERContributionErrorMessage";
        public const string EEContributionErrorMessage = "EEContributionErrorMessage";
        public const string ContributionAdjustmentErrorMessage = "ContributionAdjustmentErrorMessage";
        public const string BenefitSourceLookup = "BenefitSourceLookup";


        //tblCustomfields
        public const string BenefitAction = "BenefitAction";
        public const string Reason = "Reason";
        public const string DeductionMethod = "DeductionMethod";
        public const string ERContribution = "ERContribution";
        public const string EEContribution = "EEContribution";
        public const string EEBenefitTier = "EEBenefitTier";
        public const string EEBenefitAnnualAmt = "EEBenefitAnnualAmt";
        public const string EEBenefitPerPayAmt = "EEBenefitPerPayAmt";
        public const string EEBenefitAdjAmt = "EEBenefitAdjAmt";
        public const string RateTier = "RateTier";
        public const string RateTierID = "RateTierID";
        public const string IsChecked = "IsChecked";
        public const string DependentType = "DependentType";
        public const string DependentGuid = "DependentGuid";
        public const string DepAlternateId = "DepAlternateId";
        public const string EEBenefitReasonLookup = "EEBenefitReasonLookup";
        public const string EEBenefitActionLookup = "EEBenefitActionLookup";
        public const string ContributionAdjustment = "ContributionAdjustment";
        public const string DepSuffix = "DepSuffix";
        public const string DependentTypeId = "DependentTypeId";
        public const string PerPayPeriod = "PerPayPeriod";
        public const string AnnualTotal = "AnnualTotal";

        public const string ContributionsVaryBySexFlag = "ContributionsVaryBySexFlag";
        public const string ContributionsVaryByAgeFlag = "ContributionsVaryByAgeFlag";

        //tbl_WizardSteps
        public const string WizardStepName = "WizardStepName";
        public const string WizardStepOrder = "WizardStepOrder";

        //tbl_User columns
        public const string UserGUID = "UserGUID";
        public const string UserID = "UserID";
        public const string UserName = "UserName";
        public const string Password = "Password";
        public const string SecurityQuestion = "SecurityQuestion";
        public const string SecurityAnswer = "SecurityAnswer";
        public const string Status = "Status";
        public const string FailedAttempts = "FailedAttempts";
        public const string LastLoginOn = "LastLoginOn";
        public const string Role = "Role";
        public const string PasswordChangedOn = "PasswordChangedOn";
        public const string spValidateEREEAccessCode = "spValidateEREEAccessCode";
        public const string spGetAccessCode = "spGetAccessCode";


        //tbl_ERContributionSchedule columns

        public const string ERBenefitContributionScheduleMapGUID = "ERBenefitContributionScheduleMapGUID";
        public const string FrequencyCode = "FrequencyCode";
        public const string Frequency = "Frequency";
        public const string ERContributionID = "ERContributionID";
        public const string ContributionScheduleName = "ContributionScheduleName";
        public const string ContributionFreq = "ContributionFreq";
        public const string ContributionBeginDate = "ContributionBeginDate";
        public const string ContributionEndDate = "ContributionEndDate";
        public const string LastSheduleRunDate = "LastSheduleRunDate";
        public const string PaychecksPerYear = "PaychecksPerYear";
        public const string PaymentHolidayRule = "PaymentHolidayRule";
        public const string PaymentHolidayRuleLookup = "PaymentHolidayRuleLookup";
        public const string Code = "Code";
        public const string DateOf1stDeduction = "DateOf1stDeduction";
        public const string DayOfTheMonthFor1stPayroll = "DayOfTheMonthFor1stPayroll";
        public const string DayOfTheMonthFor2ndPayroll = "DayOfTheMonthFor2ndPayroll";
        public const string EndOfMonthFlag = "EndOfMonthFlag";
        public const string ContributionFreqLookup = "ContributionFreqLookup";
        public const string ImportCode = "ImportCode";
        public const string DateOf2ndDeduction = "DateOf2ndDeduction";
        public const string ScheduleTemplateFrequencyLookup = "ScheduleTemplateFrequencyLookup";
        public const string ScheduleFrequency = "ScheduleFrequency";
        public const string TotalPeriods = "TotalPeriods";


        public const string ERPayrollID = "ERPayrollID";
        public const string PayrollScheduleName = "PayrollScheduleName";
        public const string PayrollFreq = "PayrollFreq";
        public const string PayrollBeginDate = "PayrollBeginDate";
        public const string PayrollEndDate = "PayrollEndDate";
        public const string PayrollFreqLookup = "PayrollFreqLookup";

        //tbl_ERAutoSubstantiationRule
        public const string ERAutoSubstantiationRuleGUID = "ERAutoSubstantiationRuleGUID";
        public const string RuleName = "RuleName";
        public const string EffectiveDate = "EffectiveDate";
        public const string TerminatedDate = "TerminatedDate";
        public const string NumberOfCopays = "NumberOfCopays";

        //tbl_ERCopay
        public const string ERCopayGUID = "ERCopayGUID";
        public const string CopayName = "CopayName";
        public const string Amount = "Amount";
        public const string ERCopayMCCodesXML = "ERCopayMCCodesXML";

        //tbl_Division columns
        public const string DivisionGUID = "DivisionGUID";
        public const string DivisionID = "DivisionID";
        public const string Department = "Department";
        public const string Location = "Location";
        public const string IsDefault = "IsDefault";

        //tbl_Contact columns
        public const string ContactGUID = "ContactGUID";
        public const string ContactID = "ContactID";
        public const string ContactTypeID = "ContactTypeID";
        public const string ContactType = "ContactType";
        public const string Salutation = "Salutation";
        public const string FirstName = "FirstName";
        public const string LastName = "LastName";
        public const string SSN = "SSN";
        public const string DOB = "DOB";
        public const string Designation = "Designation";
        public const string Phone1AreaCode = "Phone1AreaCode";
        public const string PhoneNo1 = "PhoneNo1";
        public const string Phone1Extn = "Phone1Extn";
        public const string Phone2AreaCode = "Phone2AreaCode";
        public const string PhoneNo2 = "PhoneNo2";
        public const string Phone2Ext = "Phone2Ext";
        public const string Voice = "Voice";
        public const string Fax = "Fax";
        public const string Email = "Email";
        public const string RoleTypeID = "RoleTypeID";
        public const string RoleType = "RoleType";
        public const string PortalUsername = "PortalUsername";
        public const string PortalPassword = "PortalPassword";
        public const string PortalLoginSecurityQuestion = "PortalLoginSecurityQuestion";
        public const string PortalLoginSecurityResponse = "PortalLoginSecurityResponse";
        public const string PrimaryContactFlag = "PrimaryContactFlag";
        public const string StatusContactFlag = "StatusContactFlag";
        public const string ContactSourceGUID = "ContactSourceGUID";
        public const string ContAccessCode = "ContAccessCode";
        public const string spUpdateERBenefitCarrier = "spUpdateERBenefitCarrier";
        public const string Percentage = "Percentage";


        //tbl_Address columns
        public const string AddressGUID = "AddressGUID";
        public const string AddressID = "AddressID";
        public const string AddressTypeID = "AddressTypeID";
        public const string AddressType = "AddressType";
        public const string AddressName = "AddressName";
        public const string Address1 = "Address1";
        public const string Address2 = "Address2";
        public const string Address3 = "Address3";
        public const string City = "City";
        public const string StateCode = "StateCode";
        public const string CountryCode = "CountryCode";
        public const string County = "County";
        public const string PostalCode = "PostalCode";
        public const string PhoneNo = "PhoneNo";
        public const string PhoneExtn = "PhoneExtn";
        public const string PhoneAreaCode = "PhoneAreaCode";
        public const string PrimaryAddressFlag = "PrimaryAddressFlag";
        public const string HasDivisionMap = "HasDivisionMap";
        public const string TempDivisionID = "TempDivisionID";
        //tbl_ERPaymentProcessing
        public const string ERPaymentProcessingGUID = "ERPaymentProcessingGUID";
        public const string ERPaymentProcessingID = "ERPaymentProcessingID";
        public const string ERPmtProcessingName = "ERPmtProcessingName";
        public const string ERPmtProcessingFreqLookup = "ERPmtProcessingFreqLookup";
        //public const string ScheduleTemplateFrequencyLookup="ScheduleTemplateFrequencyLookup";
        public const string ERPmtProcessingBeginDate = "ERPmtProcessingBeginDate";
        public const string ERPmtProcessingEndDate = "ERPmtProcessingEndDate";
        public const string ERPmtChecksPerYear = "ERPmtChecksPerYear";
        public const string ERPmtProcessingHolidayRuleLookup = "ERPmtProcessingHolidayRuleLookup";
        public const string CreatedDate = "CreatedDate";
        public const string ModifiedDate = "ModifiedDate";
        public const string PaymentFrequency = "PaymentFrequency"; //This is Not a column. Alias Name for ContributionFreq.Short in tbl_refLookup

        //tbl_PaymentProcessingDetails
        public const string PaymentProcessingDetailGUID = "PaymentProcessingDetailGUID";
        public const string PaymentProcessingDetailID = "PaymentProcessingDetailID";
        public const string PaymentProcessingScheduleDate = "PaymentProcessingScheduleDate";
        public const string PaymentProcessingScheduleCycle = "PaymentProcessingScheduleCycle";


        //tbl_refLookup
        public const string LookupID = "LookupID";
        public const string Short = "Short";
        public const string Description = "Description";

        //tbl_Carrier
        public const string CarrierGUID = "CarrierGUID";
        public const string CarrierID = "CarrierID";
        public const string CarrierName = "CarrierName";
        public const string CarrierTaxID = "CarrierTaxID";
        public const string AccessCode = "AccessCode";
        public const string PhoneExt = "PhoneExt";
        public const string Website = "Website";
        public const string ModifyByUser = "ModifyByUser";
        public const string CarrierBusinessActivity = "CarrierBusinessActivity";
        public const string CarrierCode = "CarrierCode";
        public const string CarrierIncorporatedDate = "CarrierIncorporatedDate";
        public const string CarrierTypeOfOrganization = "CarrierTypeOfOrganization";
        public const string CarrierPursuantState = "CarrierPursuantState";
        public const string CarrierCRMID = "CarrierCRMID";
        public const string CarrierSourceSystemLookUp = "CarrierSourceSystemLookUp";
        public const string CarrierStatusLookup = "CarrierStatusLookup";
        public const string CarrierEffectivedate = "CarrierEffectivedate";
        public const string CarrierTermDate = "CarrierTermDate";
        public const string OutStatus = "OutStatus";
        public const string ContactStatus = "ContactStatus";


        //tbl_ERBenefitCarrierMap
        public const string ER_GroupNo = "GroupNo";
        public const string ER_EffectiveDate = "EffectiveDate";
        public const string ER_EndDate = "EndDate";
        public const string GroupNo = "GroupNo";
        public const string ERBenefitCarrierMapGUID = "ERBenefitCarrierMapGUID";

        //ERBenefit
        public const string ERBenefitGUID = "ERBenefitGUID";
        public const string ERBenefitID = "ERBenefitID";
        public const string BenefitID = "BenefitID";
        public const string BenefitFlexCode = "BenefitFlexCode";
        public const string BenefitTypeName = "BenefitTypeName";
        public const string BenefitName = "BenefitName";
        public const string InvoicingRate = "InvoicingRate";
        public const string EffectiveFrom = "EffectiveFrom";
        public const string EffectiveTill = "EffectiveTill";
        public const string TaxTypeID = "TaxTypeID";
        public const string TaxType = "TaxType";
        public const string StatusID = "StatusID";
        public const string DepositModeID = "DepositModeID";
        public const string DepositMode = "DepositMode";
        public const string ProrateRuleID = "ProrateRuleID";
        public const string ProrateRule = "ProrateRule";
        public const string FundingModeID = "FundingModeID";
        public const string FundingMode = "FundingMode";
        public const string PassThruClaimModeID = "PassThruClaimModeID";
        public const string PassThruClaimMode = "PassThruClaimMode";
        public const string ERInvSystemIdentifierID = "ERInvSystemIdentifierID";
        public const string ERInvSystemIdentifier = "ERInvSystemIdentifier";
        public const string ERInvFundingModeID = "ERInvFundingModeID";
        public const string ERInvFundingMode = "ERInvFundingMode";
        public const string ERInvFundFamilyID = "ERInvFundFamilyID";
        public const string ERInvFundFamily = "ERInvFundFamily";
        public const string AssumptionRuleID = "AssumptionRuleID";
        public const string AssumptionRule = "AssumptionRule";
        public const string TPAVendorGUID = "TPAVendorGUID";
        public const string CobraStatusFlag = "CobraStatusFlag";
        // public const string TPAFundingGUID = "TPAFundingGUID";
        public const string MSPReporting = "MSPReporting";
        public const string BenefitImportCode = "BenefitImportCode";
        public const string BenefitDetailImportCode = "BenefitDetailImportCode";
        public const string MaxAmount = "MaxAmount";
        public const string GracePeriodFlag = "GracePeriodFlag";
        public const string GraceDate = "GraceDate";
        public const string GraceDays = "GraceDays";
        public const string GraceMonths = "GraceMonths";
        public const string ReimburseFromGraceMoneyFlag = "ReimburseFromGraceMoneyFlag";
        public const string RunoutDate = "RunoutDate";
        public const string RunoutDays = "RunoutDays";
        public const string RunoutMonths = "RunoutMonths";
        public const string TermDate = "TermDate";
        public const string TermDays = "TermDays";
        public const string TermMonths = "TermMonths";
        public const string BenefitInfoLink = "BenefitInfoLink";
        public const string OnDebitCardFlag = "OnDebitCardFlag";
        public const string Order = "Order";
        public const string OrdinalPosition = "OrdinalPosition";
        public const string PrefundPercent = "PrefundPercent";
        public const string TotalPrefundAmount = "TotalPrefundAmount";
        public const string RolloverMaxPercent = "RolloverMaxPercent";
        public const string RolloverMaxAmount = "RolloverMaxAmount";
        public const string ParticipantPersonalInvAllowedFlag = "ParticipantPersonalInvAllowedFlag";
        public const string PlanTypeID = "PlanTypeID";
        public const string BusinessRelationshipID = "BusinessRelationshipID";
        public const string PlanTypeDesign = "PlanTypeDesign";
        public const string RenewFlag = "RenewFlag";
        public const string Segment = "Segment";
        public const string SegmentID = "SegmentID";

        //ERBenefitRate
        public const string ERBenefitRateGUID = "ERBenefitRateGUID";
        public const string RatesVaryBySexFlag = "RatesVaryBySexFlag";
        public const string RatesVaryByAgeFlag = "RatesVaryByAgeFlag";
        public const string RatesVaryByEmploymentFlag = "RatesVaryByEmploymentFlag";
        public const string FirstTierLookup = "FirstTierLookup";
        public const string FirstTier = "FirstTier";
        public const string MiddleTiersLengthLookup = "MiddleTiersLengthLookup";
        public const string MiddleTierLength = "MiddleTierLength";
        public const string LastTierLookup = "LastTierLookup";
        public const string refLookup = "refLookup";
        public const string refValueLookup = "refValueLookup";
        public const string AmountRepLookup = "AmountRepLookup";
        public const string AmountRepLookupValue = "AmountRepLookupValue";
        public const string LastTier = "LastTier";
        public const string SelectedTiers = "SelectedTiers";
        public const string ERBenefitRateDetailsXML = "ERBenefitRateDetailsXML";
        public const string ERBenefitRateXML = "ERBenefitRateXML";

        //ERBenefitRateDetail
        public const string ERBenefitRateDetailGUID = "ERBenefitRateDetailGUID";
        public const string Sex = "Sex";
        public const string Age = "Age";
        public const string TierType = "TierType";
        public const string Value = "Value";
        public const string Employment = "Employment";

        //ERBenefitContribution
        public const string ERBenefitContributionGUID = "ERBenefitContributionGUID";
        public const string ContributionVaryBySexFlag = "ContributionVaryBySexFlag";
        public const string ContributionVaryByAgeFlag = "ContributionVaryByAgeFlag";
        public const string ContributionVaryByEmploymentFlag = "ContributionVaryByEmploymentFlag";
        public const string ERBenefitContributionDetailsXML = "ERBenefitContributionDetailsXML";
        public const string ERBenefitContributionXML = "ERBenefitContributionXML";

        //Employee

        public const string EmployeeXML = "EmployeeXML";
        public const string EmployeeExtensionXML = "EmployeeExtensionXML";
        public const string EmployeeAcclarisExtensionXML = "EmployeeAcclarisExtensionXML";
        public const string EEDebitCardFlag = "DebitCardFlag";
        public const string EEDebitCardEffectiveDate = "EEDebitCardEffectiveDate";
        public const string EEDebitCardEffectiveEndDate = "EEDebitCardEffectiveEndDate";
        public const string DebitCardActiveFlag = "DebitCardActiveFlag";
        public const string GetEmployeesforEmployer = "spGetEmployeesForEmployer";
        public const string DebitCardStatus = "DebitCardStatus";

        //tbl_EEBeneficiary
        public const string BeneficiaryGuid = "BeneficiaryGuid";
        public const string EmployeeGuid = "EmployeeGuid";
        public const string BeneficiaryUserType = "BeneficiaryUserType";
        public const string BeneficiaryUserTypeLookup = "BeneficiaryUserTypeLookup";
        public const string BeneficiaryRelationshipTypeLookup = "BeneficiaryRelationshipTypeLookup";
        public const string BeneficiaryRelationship = "BeneficiaryRelationship";
        public const string BeneficiaryTypeLookup = "BeneficiaryTypeLookup";
        public const string BeneficiaryType = "BeneficiaryType";
        public const string CompanyName = "CompanyName";
        public const string EEBeneSSN = "EEBeneSSN";
        public const string EEBeneFirstName = "EEBeneFirstName";
        public const string EEBeneMiddleIntial = "EEBeneMiddleIntial";
        public const string EEBeneLastName = "EEBeneLastName";
        public const string EEBeneEmail = "EEBeneEmail";
        public const string EEBenePhoneAreaCode = "EEBenePhoneAreaCode";
        public const string EEBenePhoneNo = "EEBenePhoneNo";
        public const string EEBenePhoneExtn = "EEBenePhoneExtn";
        public const string EEBenePhoneWithExtn = "EEBenePhoneWithExtn";
        public const string EEBeneficiarySSN = "EEBeneficiarySSN";
        public const string EEBeneTaxId = "EEBeneTaxId";
        public const string EEBeneDateOfBirth = "EEBeneDateOfBirth";
        public const string EEBenePercentage = "EEBenePercentage";
        public const string EEBeneCreatedDate = "EEBeneCreatedDate";

        //tbl_BeneficiaryBenefitMap
        public const string BeneficiaryBenefitMapGUID = "BeneficiaryBenefitMapGUID";


        //Address
        public const string AddressXML = "AddressXML";

        //ERBenefitContributionDetail
        public const string ERBenefitContributionDetailGUID = "ERBenefitContributionDetailGUID";

        //tbl_CarrierBenefitMap
        public const string CarrierBenefitMapGUID = "CarrierBenefitMapGUID";
        //public const string CarrierGUID="CarrierGUID";

        //tbl_refBenefit
        //public const string  BenefitID="BenefitID";
        //public const string  BenefitName="BenefitName";
        public const string BenefitDescription = "BenefitDescription";
        //public const string  BenefitFlexCode="BenefitFlexCode";
        public const string BenefitAcclarisCode = "BenefitAcclarisCode";

        //tbl_refBenefitGroup
        public const string BenefitGroupName = "BenefitGroupName";
        public const string BenefitGroupDescription = "BenefitGroupDescription";

        //tbl_refTPA 
        public const string TPAID = "TPAID";
        public const string TPAName = "TPAName";
        public const string TPATaxID = "TPATaxID";
        public const string TPAOfficalName = "TPAOfficalName";
        public const string PassPhraseKey = "PassPhraseKey";
        public const string TPABusinessActivity = "TPABusinessActivity";
        public const string TPACode = "TPACode";
        public const string TPAIncorporatedDate = "TPAIncorporatedDate";
        public const string TPATypeOfOrganizationLookup = "TPATypeOfOrganizationLookup";
        public const string TPAEmail = "TPAEmail";
        public const string TPAWebsite = "TPAWebsite";
        public const string TPAIdentityTheftProtectionFlag = "TPAIdentityTheftProtectionFlag";
        public const string TPAPursuantStateCode = "TPAPursuantStateCode";
        public const string TPAStatusLookUp = "TPAStatusLookUp";
        public const string TPACRMID = "TPACRMID";
        public const string TPAAccessCode = "TPAAccessCode";
        public const string TPASourceSystemLookUp = "TPASourceSystemLookUp";
        public const string TPABusinessIndustryCodeId = "TPABusinessIndustryCodeId";
        public const string BusinessID = "BusinessID";

        //tbl_refBusinessIndustryCode 
        public const string BusinessIndustryCodeID = "BusinessIndustryCodeID";
        public const string SICCode = "SICCode";
        public const string BusinessIndustryCodeDescr = "BusinessIndustryCodeDescr";
        public const string IsValidFlag = "IsValidFlag";
        public const string IsValid = "IsValid";
        public const string CreatedByUser = "CreatedByUser";
        public const string CreatedByDate = "CreatedByDate";
        //public const string ModifiedByUser = "ModifiedByUser";
        public const string ModifiedByDate = "ModifiedByDate";
        public const string CountDuplicateFlag = "CountDuplicateFlag";
        public const string BusinessTempCode = "BusinessTempCode";
        //tbl_HSAWizards
        public const string WizardName = "WizardName";

        //tbl_TPAWizardMapping
        public const string WizardId = "WizardId";

        //tbl_TPAWizardStepMapping
        public const string WizardStepId = "WizardStepId";

        //tbl_ERBankAccount
        public const string ERBankAccountGUID = "BankAccountGUID";
        public const string ERBankAccountSourceGUID = "BankAccountSourceGUID";
        public const string ERBankAccountSourceTypeLookup = "BankAccountSourceTypeLookup";
        public const string ERBankName = "BankName";
        public const string ERBankEmail = "BankEmail";
        public const string ERAccountName = "AccountName";
        public const string ERBankAccountTypeLookup = "BankAccountTypeLookup";
        public const string ERTransactionTypeLookup = "TransactionTypeLookup";
        public const string TransactionType = "TransactionType";
        public const string ERExportID = "ExportID";
        public const string ERAccountNo = "AccountNo";
        public const string ERMICRRoute = "MICRRoute";
        public const string ERBankRoute = "BankRoute";
        public const string ERMICRDepositeRoute = "MICRDepositeRoute";
        public const string ERCheckStartNo = "CheckStartNo";
        public const string ERACHAccountNumber = "ACHAccountNumber";
        public const string ERACHRoutingNumber = "ACHRoutingNumber";
        public const string ERACHAccountTypeLookup = "ACHAccountTypeLookup";
        public const string AccountType = "AccountType"; // this is not a table column,its a alias name given to tbl_refLookup short field
        public const string UpdateFlag = "UpdateFlag"; // This flag is to update the ERBankAccount all information/Bank Name and Email
        public const string BankDeleteFlag = "BankDeleteFlag";
        public const string AccountTypeID = "AccountTypeID";

        //tbl_ERBenefitBankAcctMap
        public const string TransactionTypeLookup = "TransactionTypeLookup";
        public const string AcclarisAcctFlag = "AcclarisAcctFlag";
        public const string DebitCardFlag = "DebitCardFlag";

        //tbl_Employee
        public const string EmployeeGUID = "EmployeeGUID";
        public const string EmployeeID = "EmployeeID";
        public const string MiddleInitial = "MiddleInitial";
        public const string EEFirstName = "EEFirstName";
        public const string EEMiddleInitial = "EEMiddleInitial";
        public const string EELastName = "EELastName";
        public const string EESalutation = "EESalutation";
        public const string EEDOB = "EEDOB";
        public const string EEGender = "EEGender";
        public const string EEGenderID = "EEGenderID";
        public const string EEStatus = "EEStatus";
        public const string EEBenefitID = "EEBenefitID";
        public const string EEStatusID = "EEStatusID";
        public const string EESSN = "EESSN";
        public const string EEAccessCode = "EEAccessCode";
        public const string EEAlternateGUID = "EEAlternateGUID";
        public const string EEDepartment = "EEDepartment";
        public const string employeeName = "employeeName";
        public const string EEEffectiveDateFrom = "EEEffectiveDateFrom";
        public const string EEEffectiveDateTo = "EEEffectiveDateTo";
        public const string Gender = "Gender";
        public const string EmploymentStatus = "EmploymentStatus";
        public const string Suffix = "Suffix";
        public const string HeightFt = "HeightFt";
        public const string HeightIn = "HeightIn";
        public const string Weight = "Weight";
        public const string Tobacco = "Tobacco";
        public const string Disabled = "Disabled";
        public const string EmploymentClassGUID = "EmploymentClassGUID";
        public const string MaritalStatusID = "MaritalStatusID";
        public const string MaritalStatus = "MaritalStatus";

        //tbl_EmployeeAcclarisExtension
        public const string EEEmail = "EEEmail";
        public const string EEHiredDate = "EEHiredDate";
        public const string EEDateOfSeparation = "EEDateOfSeparation";
        public const string EEPassThruClaimMode = "ClaimPassThruFlag";
        public const string CommunicationStatusLookup = "CommunicationStatusLookup";
        public const string EECommunicationEffectiveFrom = "EECommunicationEffectiveFrom";
        public const string EECommunicationEffectiveTill = "EECommunicationEffectiveTill";
        public const string CommunicationMethodLookup = "CommunicationMethodLookup";
        public const string CardType = "CardType";
        public const string spGetEmployeeCard = "spGetEmployeeCard";
        public const string CommunicationStatus = "CommunicationStatus";
        public const string CommunicationMethod = "CommunicationMethod";

        //tbl_EmployeeExtension
        public const string EEJobTitle = "EEJobTitle";
        public const string FilterEmployeesBy = "FilterEmployeesBy";
        public const string FilterValue = "FilterValue";
        public const string FilterBy = "FilterBy";

        public const string ERAccessCodeErrorMessage = "ERAccessCodeErrorMessage";
        public const string EESSNErrorMessage = "EESSNErrorMessage";
        public const string DivisionErrorMesage = "DivisionErrorMesage";
        public const string EmploymentClassErrorMessage = "EmploymentClassErrorMessage";
        public const string AddressNameErrorMesage = "AddressNameErrorMesage";
        public const string DebitCardErrorMesage = "DebitCardErrorMesage";
        public const string CommunicationErrorMesage = "CommunicationErrorMesage";
        public const string AccountNoErrorMessage = "AccountNoErrorMessage";

        //tbl_EmployeeClass
        public const string ClassGUID = "ClassGUID";
        public const string ClassName = "ClassName";
        public const string ClassDescription = "ClassDescription";
        public const string ClassIsPrimaryChecked = "ClassPrimary";

        //tbl_Term
        public const string TermGUID = "TermGUID";
        public const string TermName = "TermName";
        public const string TermDescription = "TermDescription";
        public const string TermHelpText = "TermHelpText";
        public const string TermOrdinalPosition = "TermOrdinalPosition";
        public const string TermActive = "TermActive";
        public const string TermIsChecked = "ShowPlanHighlights";
        public const string TermID = "TermID";
        public const string TermExclusiveSelection = "TermExclusiveSelection";

        //tbl_TermGroups
        public const string TermGroupGUID = "TermGroupGUID";
        public const string TermGroupID = "TermGroupID";
        public const string TermGroupName = "TermGroupName";
        public const string TermGroupDescription = "TermGroupDescription";
        public const string TermGroupHelpText = "TermGroupHelpText";
        public const string TermGroupOrdinalPosition = "TermGroupOrdinalPosition";
        public const string TermGroupActive = "TermGroupActive";

        //tbl_MapTermGroups
        public const string MapTermGUID = "MapTermGUID";

        //tbl_Plan
        public const string InNetwork = "InNetwork";
        public const string OutNetwork = "OutNetwork";
        public const string PlanGUID = "PlanGUID";
        public const string Overview = "Overview";
        public const string ERBenefitCarrierGUID = "ERBenefitCarrierGUID";
        public const string PlanName = "PlanName";
        public const string PlanDetailXml = "PlanDetailXml";
        public const string PlanAttachmentXml = "PlanAttachmentXml";
        public const string PlanAttachmentGUID = "PlanAttachmentGUID";
        public const string FilePath = "FilePath";
        public const string AttachmentTypeID = "AttachmentTypeID";
        public const string PlanDetailGUID = "PlanDetailGUID";
        public const string AttachmentType = "AttachmentType";
        public const string ShowPlanHighlights = "ShowPlanHighlights";
        public const string SourcePlanGUID = "SourcePlanGUID";

        //tbl_BeneficiaryIndividual
        public const string BeneficiaryIndividualGUID = "BeneficiaryIndividualGUID";
        public const string BeneficiaryIndividualID = "BeneficiaryIndividualID";
        public const string BeneSalutation = "BeneSalutation";
        public const string BeneFirstName = "BeneFirstName";
        public const string BeneLastName = "BeneLastName";
        public const string BeneSSN = "BeneSSN";
        public const string BeneDOB = "BeneDOB";
        public const string BeneEmail = "BeneEmail";
        public const string BeneDesignation = "BeneDesignation";
        public const string BeneAddressGuid = "BeneAddressGuid";
        public const string BeneDependentGUID = "BeneDependentGUID";
        public const string BeneRelationshipLookup = "BeneRelationshipLookup";
        public const string BenePercentage = "BenePercentage";
        public const string PrimaryBeneFlag = "PrimaryBeneFlag";
        public const string BeneRelationship = "BeneRelationship"; //This is not a column name. Alias Name Given to short Column of tbl_reflookup
        public const string PrimarySecondaryBeneficiaryFlag = "PrimarySecondaryBeneficiaryFlag";
        public const string SumOfBeneficiaryPercentage = "SumOfBeneficiaryPercentage";

        //tbl_BeneficiaryCompany
        public const string BeneficiaryCompanyGUID = "BeneficiaryCompanyGUID";
        public const string BeneficiaryCompanyID = "BeneficiaryCompanyID";
        public const string BeneCompanyName = "BeneCompanyName";
        public const string BeneTaxID = "BeneTaxID";
        public const string BenePhoneAreaCode = "BenePhoneAreaCode";
        public const string BenePhoneNo = "BenePhoneNo";
        public const string BenePhoneExt = "BenePhoneExt";


        //tbl_Dependents
        public const string DependentGUID = "DependentGUID";
        public const string DepAccessCode = "DepAccessCode";
        public const string DepFirstName = "DepFirstName";
        public const string DepMiddleInitial = "DepMiddleInitial";
        public const string DepLastName = "DepLastName";
        public const string DepPhoneAreaCode = "DepPhoneAreaCode";
        public const string DepPhoneNumber = "DepPhoneNumber";
        public const string DepPhoneExtension = "DepPhoneExtension";
        public const string DepEmail = "DepEmail";
        public const string DepDateOfBirth = "DepDateOfBirth";
        public const string DepSSN = "DepSSN";
        public const string DepTypeLookup = "DepTypeLookup";
        public const string DepStatusLookup = "DepStatusLookup";
        public const string DepGenderLookup = "DepGenderLookup";
        public const string DepGender = "DepGender";
        public const string DebitCardEligible = "DebitCardEligible";
        public const string DepSalutation = "DepSalutation";
        public const string DepDesignation = "DepDesignation";
        public const string DepRelation = "DepRelation";
        //public const string DepSecondaryId = "DepSecondaryId";
        public const string DepAddressGUID = "AddressGUID";
        public const string DepDebitcardEffectiveFrom = "DebitcardEffectiveFrom";
        public const string DepDebitcardEffectiveTill = "DebitcardEffectiveEffectiveTill";
        public const string IsAssociatedDependents = "IsAssociatedDependents";
        public const string EEBenefitCoveredDependentXML = "EEBenefitCoveredDependentXML";

        //tbl_refTier
        public const string TierID = "TierID";
        public const string TierName = "TierName";
        public const string TierDescription = "TierDescription";
        public const string TierCode = "TierCode";

        //tbl_ERBenefitClassMap
        public const string EmploymentName = "EmploymentName";
        public const string spGetContributionEmployment = "spGetContributionEmployment";
        public const string spGetRateEmployment = "spGetRateEmployment";

        //tbl_ERBenefitDesign
        public const string ERBenefitDesignGUID = "ERBenefitDesignGUID";
        public const string ERBenefitDesignID = "ERBenefitDesignID";
        public const string ExpenseFrom = "ExpenseFrom";
        public const string ExpenseTO = "ExpenseTO";
        public const string EmployeePercent = "EmployeePercent";
        public const string RowIndex = "RowIndex";

        //tbl_ERMccCodeMap
        public const string MccCode = "MccCode";
        public const string MccDescription = "MccDescription";
        public const string GlobalMccCodeGUID = "GlobalMccCodeGUID";
        public const string GlobalMccCodeID = "GlobalMccCodeID";

        //tbl_ERCopayMccCodeMap
        public const string ERCopayMccCodeMapGUID = "ERCopayMccCodeMapGUID";

        //tbl_EEBenefitAcclarisExtension
        public const string EEBenefitElectionDate = "EEBenefitElectionDate";
        public const string EEBenefitElectionEffDate = "EEBenefitElectionEffDate";
        public const string EEBenefitPlanPeriodElectAmt = "EEBenefitPlanPeriodElectAmt";
        public const string EEBenefitPlanPeriodPaidAmt = "EEBenefitPlanPeriodPaidAmt";
        public const string EEBenefitPreFundAmt = "EEBenefitPreFundAmt";
        public const string ESignDate = "ESignDate";
        public const string BenefitSource = "BenefitSource";
        public const string EnrollmentStartDate = "EnrollmentStartDate";
        public const string AccountClosedDate = "AccountClosedDate";
        public const string BenefitActivationCode = "BenefitActivationCode";
        public const string SpecialNotes = "SpecialNotes";

        //tbl_GlobalAdjustment
        public const string GlobalAdjustmentGUID = "GlobalAdjustmentGUID";
        public const string GlobalAdjustmentID = "GlobalAdjustmentID";
        public const string AdjustmentName = "AdjustmentName";
        public const string AdjustmentDescription = "AdjustmentDescription";
        public const string AdjustmentAmount = "AdjustmentAmount";
        public const string AdjustmentRate = "AdjustmentRate";
        public const string AdjustmentTypeLookup = "AdjustmentTypeLookup";
        public const string AdjustmentType = "AdjustmentType";

        //tbl_ERBillingInvoicingMode
        public const string ERBillingInvoicingModeGUID = "ERBillingInvoicingModeGUID";
        public const string ERPrimaryInvoiceModeLookup = "ERPrimaryInvoiceModeLookup";
        public const string ERPrimaryBillingModeLookup = "ERPrimaryBillingModeLookup";
        public const string ERSecondaryBillingModeLookupList = "ERSecondaryBillingModeLookupList";
        public const string ERSecondaryInvoiceModeLookupList = "ERSecondaryInvoiceModeLookupList";

        //tbl_MiscCharge
        public const string MiscChargeGUID = "MiscChargeGUID";
        public const string MiscChargeID = "MiscChargeID";
        public const string MiscChargeSourceGUID = "MiscChargeSourceGUID";
        public const string MiscChargeSourceTypeLookup = "MiscChargeSourceTypeLookup";
        public const string MiscChargeTypeID = "MiscChargeTypeID";
        public const string MiscChargeName = "Name";
        public const string MiscChargeSequence = "Sequence";
        public const string MiscChargeFrequencyLookup = "FrequencyLookup";
        public const string MiscChargeBasisLookup = "BasisLookup";
        public const string MiscChargeEffectiveFrom = "EffectiveFrom";
        public const string MiscChargeEffectiveTill = "EffectiveTill";
        public const string MisChargeRate = "Rate";
        public const string MiscChargeMinimumAmt = "MinimumAmt";
        public const string MiscChargeEventBasedChargeFlag = "EventBasedChargeFlag";
        public const string MisChargeDescription = "Description";
        public const string MiscChargeFrequencyType = "FrequencyType";
        public const string AssignedTPAMisChargesMapXML = "AssignedTPAMisChargesMapXML";

        //tbl_InvoiceTemplate
        public const string InvoiceTemplateGUID = "InvoiceTemplateGUID";
        public const string InvoiceTemplateNo = "InvoiceTemplateNo";
        public const string InvoiceTemplateName = "InvoiceTemplateName";
        public const string InvoiceTemplateFileName = "InvoiceTemplateFileName";
        public const string InvoiceTemplateFilePath = "InvoiceTemplateFilePath";

        //Import Employee
        public const string ImportEmployeeXml = "employeeXML";
        public const string ImportDependentXml = "dependentXML";
        public const string ImportAddressXml = "addressXML";
        public const string ImportBankXml = "bankXML";
        public const string ImportCreatedUserID = "createdUserID";

        //AuditSeachCriteria
        public const string TableName = "TableName";
        public const string AppFunction = "AppFunction";
        public const string PrimaryKey = "PrimaryKey";
        public const string Operation = "Operation";
        public const string TransactionFromDate = "TransactionFromDate";
        public const string TransactionToDate = "TransactionToDate";
        public const string FieldName = "FieldName";
        public const string OldValue = "OldValue";
        public const string NewValue = "NewValue";
        public const string Condition = "Condition";

        //tbl_Invoice
        public const string InvoiceGUID = "InvoiceGUID";
        public const string InvoiceID = "InvoiceID";
        public const string InvoiceNo = "InvoiceNo";
        public const string SourceEntityGUID = "SourceEntityGUID";
        public const string SourceEntityTypeLookup = "SourceEntityTypeLookup";
        public const string InvoiceGeneratedDate = "InvoiceGeneratedDate";
        public const string InvoiceFromDate = "InvoiceFromDate";
        public const string InvoiceToDate = "InvoiceToDate";
        public const string TotalInvoiceAmt = "TotalInvoiceAmt";
        public const string NonCarriedAmount = "NonCarriedAmount";
        public const string InvoiceStatusLookup = "StatusLookup";
        public const string InvoiceSummary = "InvoiceSummary";
        public const string InvoiceFileName = "InvoiceFileName";
        public const string InvoiceFilePath = "InvoiceFilePath";
        public const string LatestInvoice = "LatestInvoice";
        public const string LatestInvoiceAmount = "LatestInvoiceAmount";
        public const string OutstandingBalance = "OutstandingBalance";
        public const string TotalPaymentsRecieved = "TotalPaymentsRecieved";
        public const string InvoiceStatus = "InvoiceStatus";
        public const string AmountPaid = "AmountPaid";
        public const string AmountDue = "AmountDue";
        public const string LatestInvoiceDate = "LatestInvoiceDate";

        //tbl_Payment
        public const string PaymentGUID = "PaymentGUID";
        public const string TransactionID = "TransactionID";
        public const string PaymentModeLookup = "PaymentModeLookup";
        public const string BalanceAmount = "BalanceAmount";
        public const string PaidDate = "PaidDate";
        public const string Memo = "Memo";
        public const string ClearedDate = "ClearedDate";
        public const string CheckACHNumber = "CheckACHNumber";
        public const string PaidAmount = "PaidAmount";
        public const string PayPalIdentifier = "PayPalIdentifier";
        public const string InstrumentNumber = "InstrumentNumber";
        public const string PostmarkDate = "PostmarkDate";

        //tbl_Adjustment
        public const string AdjustmentGUID = "AdjustmentGUID";
        public const string AdjustmentID = "AdjustmentID";
        public const string Notes = "Notes";
        public const string GlobalAjustmentGUID = "GlobalAjustmentGUID";
        public const string AdjustmentRequestStatusLookup = "AdjustmentRequestStatusLookup";
        public const string AdjustmentRequestSubject = "AdjustmentRequestSubject";
        public const string AdjustmentRequestDesc = "AdjustmentRequestDesc";

        //tbl_DuplicateClaimCheck
        public const string DuplicateClaimCheckGUID = "DuplicateClaimCheckGUID";
        public const string IsBeginDateApplicable = "IsBeginDateApplicable";
        public const string BeginDateDays = "BeginDateDays";
        public const string Rule1 = "Rule1";
        public const string IsEndDateApplicable = "IsEndDateApplicable";
        public const string EndDateDays = "EndDateDays";
        public const string Rule2 = "Rule2";
        public const string IsExactMatchOnClaimAmtApplicable = "IsExactMatchOnClaimAmtApplicable";
        public const string Rule3 = "Rule3";
        public const string IsExactMatchOnClaimIneligibleAmtApplicable = "IsExactMatchOnClaimIneligibleAmtApplicable";
        public const string Rule4 = "Rule4";
        public const string IsSameClaimant = "IsSameClaimant";
        public const string LogicalExpression = "LogicalExpression";

        //tbl_TPASmtpSettings
        public const string TPASmtpSettingsGUID = "TPASmtpSettingsGUID";
        public const string From = "From";
        public const string Host = "Host";
        public const string Port = "Port";
        public const string TypeLookup = "TypeLookup";

        //tbl_Communication
        public const string CommunicationGUID = "CommunicationGUID";
        public const string recipientIDList = "recipientIDList";
        public const string CommunicationMessageGUID = "CommunicationMessageGUID";
        public const string CommunicationAttachmentGUID = "CommunicationAttachmentGUID";
        public const string Subject = "Subject";
        public const string Message = "Message";
        public const string OptionLookup = "OptionLookup";
        public const string ScheduleCommunicationGUID = "ScheduleCommunicationGUID";
        public const string ScheduleTaskCode = "ScheduleTaskCode";
        public const string FrequencyLookup = "FrequencyLookup";
        public const string StartDate = "StartDate";
        public const string StartTime = "StartTime";
        public const string RunStartTime = "RunStartTime";
        public const string RunEndTime = "RunEndTime";
        public const string FrequencyInterval = "FrequencyInterval";
        public const string DayOfWeek = "DayOfWeek";
        public const string Date = "Date";
        public const string Month = "Month";
        public const string AttachmentList = "AttachmentList";
        public const string EndDate = "EndDate";
        public const string RecipientList = "RecipientList";
        public const string IsRead = "IsRead";
        public const string CommEntityGUID = "EntityGUID";
        public const string IsSent = "IsSent";
        public const string ReadDate = "ReadDate";
        public const string SentDate = "SentDate";

        //tbl_Recipient
        public const string RecipientNumber = "RecipientNumber";
        public const string RecipientName = "RecipientName";
        public const string RecipientType = "RecipientType";
        public const string QueryType = "QueryType";
        public const string RecipientStatus = "RecipientStatus";
        public const string RecipientCreatedDate = "RecipientCreatedDate";
        #endregion Table column Names

        //tbl_CommunicationReadReceipt
        public const string CommunicationReadRecieptGUID = "CommunicationReadRecieptGUID";

        #region state members
        public const string LanguageID = "languageID";

        //tbl_Note columns
        //public const string NoteGUID = "Not eGUID";
        //public const string NoteID = "NoteID";
        //public const string NoteSourceGUID = "NoteSourceGUID";
        //public const string NoteSourceTypeLookup = "NoteSourceTypeLookup";
        //public const string NoteDate = "NoteDate";
        //public const string PopupNoteOn = "PopupNoteOn";
        //public const string PrivacyNoteFlag = "PrivacyNoteFlag";
        //public const string NoteSubject = "NoteSubject";
        //public const string NoteMessage = "NoteMessage";
        //public const string NoteAttachmentFilePath = "NoteAttachmentFilePath";


        //tbl_ERContactManagement columns
        public const string ERContactManagementGUID = "ERContactManagementGUID";
        public const string ERContactManagementID = "ERContactManagementID";
        public const string SourceGuid = "SourceGUID";
        public const string SourceType = "SourceType";
        public const string SourceTypeId = "SourceTypeId";
        public const string NoteDate = "NoteDate";
        public const string Regarding = "Regarding";
        public const string NoteDescription = "NoteDescription";
        public const string ScheduledOn = "ScheduledOn";
        public const string CompletedOn = "CompletedOn";
        public const string NoteType = "NoteType";
        public const string Completed = "Completed";
        public const string NoteVisibleTo = "NoteVisibleTo";
        public const string NoteTypeID = "NoteTypeID";
        public const string isLocked = "IsLocked";
        public const string StartNoteDate = "@startDate";
        public const string EndNoteDate = "@endDate";
        public const string FilterSubject = "@subject";
        public const string IsLocked = "@IsLocked";
        public const string NoteTypeLookup = "@NoteTypeLookup";
        public const string TotalAttachments = "TotalAttachments";

        //tbl_AttachmentDetails
        public const string AttachmentGUID = "AttachmentGUID";
        public const string AttachmentID = "AttachmentID";
        public const string SourceTypeLookupId = "SourceTypeLookupId";
        public const string SourceTypeLookup = "SourceTypeLookup";
        public const string AttachmentFilePath = "AttachmentFilePath";
        public const string AttachmentFileName = "AttachmentFileName";
        public const string AttachmentFileExtension = "AttachmentFileExtension";
        public const string IsCompressed = "IsCompressed";

        //tbl_refBillingGroupOption
        public const string OptionID = "OptionID";
        public const string BillingGroupOptionName = "BillingGroupOptionName";
        public const string BillingGroupOptionID = "BillingGroupOptionID";
        public const string BillingFrequencyID = "BillingFrequencyID";
        #endregion

        #region Miscellaneous
        public const string CommaSeperatedList = "CommaSeperatedList";
        public const string CommaSeparatedSegmentList = "CommaSeparatedSegmentList";
        public const string CommaSeparatedBenefits = "CommaSeparatedBenefits";
        public const string ReturnFlag = "ReturnFlag";
        public const string RowID = "RowID";
        public const string Success = "Success";
        public const string BeneficiaryGUID = "BeneficiaryGUID";
        public const string tableName = "tableName";
        public const string ValidFlag = "ValidFlag";
        public const string ValidateFor = "ValidateFor";
        public const string ERStatus = "ERStatus";
        public const string SortBy = "SortBy";
        public const string EmployeeExistsForEmployer = "EmployeeExistsForEmployer";
        public const string BenefitExistsForEmployee = "BenefitExistsForEmployee";
        public const string SecondarySortBy = "SecondarySortBy";
        public const string UserType = "UserType";
        public const string DateOfBirth = "DateOfBirth";

        #endregion

        #region Claim Import
        public const string ClaimantSSN = "ClaimantSSN";
        public const string CarrierAccessCode = "CarrierAccessCode";
        public const string ProviderTaxID = "ProviderTaxID";
        public const string IsRowValid = "IsRowValid";
        public const string MethodOfPayment = "MethodOfPayment";
        public const string DuplicateOverride = "DuplicateOverride";
        public const string ERAccessCodeInvalidErrorMessage = "ERAccessCodeInvalidErrorMessage";
        public const string EESSNInvalidErrorMessage = "EESSNInvalidErrorMessage";
        public const string ClaimantSSNIvalidErrorMessage = "ClaimantSSNIvalidErrorMessage";
        public const string CarrierInvalidErrorMesage = "CarrierInvalidErrorMesage";
        public const string BenefitCombOfCarrierERAndEEErrorMessage = "BenefitCombOfCarrierERAndEEErrorMessage";
        public const string AvailServiceInvalidErrorMessage = "AvailServiceInvalidErrorMessage";
        public const string BenefitCarrierInvalidErrorMessage = "BenefitCarrierInvalidErrorMessage";
        public const string PaymentTypeInvalidErrorMessage = "PaymentTypeInvalidErrorMessage";
        public const string StatusTypeInvalidErrorMessage = "StatusTypeInvalidErrorMessage";
        public const string ReasonTypeInvalidErrorMessage = "ReasonTypeInvalidErrorMessage";
        public const string ProviderGUIDInvalidErrorMessage = "ProviderGUIDInvalidErrorMessage";
        public const string ServiceTillDateInvalidErrorMessage = "ServiceTillDateInvalidErrorMessage";
        public const string DuplicateClaimErrorMessage = "DuplicateClaimErrorMessage";
        public const string ClaimList = "ClaimList";
        #endregion

        public const string GroupCode = "GroupCode";
        public const string FromDate = "FromDate";
        public const string ToDate = "ToDate";
        public const string ProcessingStatus = "ProcessingStatus";
        public const string FileName = "FileName";


        #region "Employee Individual Plan"
        public const string EEIndividualBenefitPlanDetailGUID = "EEIndividualBenefitPlanDetailGUID";
        public const string EEIndividualBenefitPLanDetailID = "EEIndividualBenefitPLanDetailID";
        public const string CarrierPolicyID = "CarrierPolicyID";
        public const string Premium = "Premium";
        public const string CarrierPolicyStatus = "CarrierPolicyStatus";
        public const string CarrierPolicyOriginalEffectiveFrom = "CarrierPolicyOriginalEffectiveFrom";
        public const string CarrierPolicyEffectiveFrom = "CarrierPolicyEffectiveFrom";
        public const string CarrierPolicyEffectiveTill = "CarrierPolicyEffectiveTill";

        //public const string TransactionID = "TransactionID";
        public const string PaymentMethodLookup = "PaymentMethodLookup";
        public const string PaymentDate = "PaymentDate";
        public const string PaymentAmount = "PaymentAmount";
        //public const string Memo = "Memo";
        public const string BillingEnabled = "BillingEnabled";
        public const string BillingFrequencyLookup = "BillingFrequencyLookup";
        public const string BillingFrequency = "BillingFrequency";
        public const string BillingAmount = "BillingAmount";
        public const string BillingEffectiveFrom = "BillingEffectiveFrom";
        public const string BillingEffectiveTill = "BillingEffectiveTill";
        #endregion

        #region "Recipient"
        public const string RecipientGUID = "RecipientGUID";
        public const string Number = "Number";
        public const string Name = "Name";
        //public const string  Description="Description"; 		
        public const string StatusLookup = "StatusLookup";
        //public const string  TypeLookup ="TypeLookup"; 		
        public const string SqlName = "SqlName";
        public const string SqlQuery = "SqlQuery";
        public const string IsDynamic = "IsDynamic";
        public const string SelectedRecipients = "SelectedRecipients";
        public const string EEStatusLookup = "EEStatusLookup";
        #endregion

        #region "SelectedRecipient"
        public const string SelectedRecipientID = "SelectedRecipientID";
        public const string EntityGUID = "EntityGUID";
        #endregion

        //tbl_AuthorizedUser
        public const string AuthorizedUserGUID = "AuthorizedUserGUID";
        public const string AuthorizedUserTypeLookup = "AuthorizedUserTypeLookup";
        public const string AuthorizedUserType = "AuthorizedUserType";
        public const string RelationshipTypeLookup = "RelationshipTypeLookup";
        public const string RelationshipType = "RelationshipType";
        public const string PhoneNumber = "PhoneNumber";
        public const string PhoneExtension = "PhoneExtension";
        public const string CompletePhoneNumber = "CompletePhoneNumber";
        public const string AccessTypeLookup = "AccessTypeLookup";
        public const string AccessType = "AccessType";

        //tbl_AuthorizedUserSourceMap
        public const string AuthorizedUserSourceMapGUID = "AuthorizedUserSourceMapGUID";

        //tbl_AuthorizedUserBenefitMap
        public const string AuthorizedUserBenefitMapGUID = "AuthorizedUserBenefitMapGUID";

        //SP's Related AuthorizedUser
        public const string spGetAuthorizedUser = "spGetAuthorizedUser";
        public const string spGetAuthorizedUsers = "spGetAuthorizedUsers";
        public const string spInsertAuthorizedUser = "spInsertAuthorizedUser";
        public const string spUpdateAuthorizedUser = "spUpdateAuthorizedUser";
        public const string spDeleteAuthorizedUser = "spDeleteAuthorizedUser";

        //Misc Authorized User
        public const string AuthorizedUserXML = "AuthorizedUserXML";


        //Misc Beneficiary
        public const string BeneficiaryXML = "BeneficiaryXML";

        //tbl_EnrollmentText
        public const string EnrollmentTextGuid = "EnrollmentTextGuid";
        public const string EnrollmentTextId = "EnrollmentTextId";
        public const string EnrollmentTextTypeId = "EnrollmentTextTypeId";
        public const string EnrollmentTextType = "EnrollmentTextType";
        public const string EnrollmentText = "EnrollmentText";
        public const string IsActive = "IsActive";
        public const string EnrollmentGuids = "EnrollmentTextGUIDS";

        public const string spGetEnrollmentText = "spGetEnrollmentText";
        public const string spSaveEnrollmentText = "spSaveEnrollmentText";
        public const string spDeleteEnrollmentText = "spDeleteEnrollmentText";

        //tbl_BenefitText
        public const string BenefitTextGuid = "BenefitTextGUID";
        public const string BenefitTextId = "BenefitTextID";
        public const string BenefitTextTypeId = "BenefitTextTypeID";
        public const string BenefitTextType = "BenefitTextType";
        public const string BenefitText = "BenefitText";
        public const string TabName = "TabName";
        public const string TabOrder = "TabOrder";
        public const string IsOptionAvailable = "IsOptionAvailable";

        public const string spGetBenefitText = "spGetBenefitText";
        public const string spSaveBenefitText = "spSaveBenefitText";
        public const string spDeleteBenefitText = "spDeleteBenefitText";
        public const string spInsertBulkEnrollmentText = "spInsertBulkEnrollmentText";
        public const string spInsertBulkBenefitText = "spInsertBulkBenefitText";

        //tbl_EESpecialENrollmentDetails
        public const string EESpecialEnrollmentGUID = "EESpecialEnrollmentGUID";
        public const string EEGUID = "EEGUID";

        public const string spSaveEESpecialEnrollmentDetails = "spSaveEESpecialEnrollmentDetails";
        public const string spGetEESpecialEnrollmentDetails = "spGetEESpecialEnrollmentDetails";
        public const string spDeleteEESpecialEnrollmentDetails = "spDeleteEESpecialEnrollmentDetails";

        //Employer Portal New SP Constant
        public const string spGetDivisionReferencesInContact = "spGetDivisionReferencesInContact";

        //Employer Contribution checking New SP Constant
        public const string spCheckContributionForEmployer = "spCheckContributionForEmployer";
        public const string spUpdateEEBenefitContributionSchedule = "spUpdateEEBenefitContributionSchedule";
        public const string spGetERBenefitContributionSchedules = "spGetERBenefitContributionSchedules";
        public const string spGetEEBenefitContributionSchedules = "spGetEEBenefitContributionSchedules";
        //Employer Benefit Account Details
        public const string EEBenefitBillingDetailGuid = "EEBenefitBillingDetailGuid";
        public const string IsCurrent = "IsCurrent";
        public const string EEBenefitPaymentDetailGuid = "EEBenefitPaymentDetailGuid";
        public const string PaymentMethod = "PaymentMethod";
        public const string TransactionId = "TransactionId";
        public const string spGetEEBenefitPaymentBilling = "spGetEEBenefitPaymentBilling";
        public const string spUpdateEEBenefitBillingStatus = "spUpdateEEBenefitBillingStatus";
        public const string spSaveEeBenefitBillingDetails = "spSaveEeBenefitBillingDetails";
        public const string spGetEESingleBenefitPaymentBilling = "spGetEESingleBenefitPaymentBilling";
        public const string ListType = "ListType";
        public const string spDeleteEEBenefitPlanBilling = "spDeleteEEBenefitPlanBilling";
        public const string spDeleteEEBenefitPlanPayment = "spDeleteEEBenefitPlanPayment";
        public const string spSaveEeBenefitPaymentDetails = "spSaveEeBenefitPaymentDetails";
        public const string spEEBenefitApplicationInfo = "spEEBenefitApplicationInfo";

    }
}