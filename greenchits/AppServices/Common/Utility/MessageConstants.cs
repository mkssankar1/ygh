using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenChits.Common.Utility
{
    public static class MessageConstants
    {
        #region DivisionControl

        public const string SUCCESS_DC_MSG001 = "Division saved successfully.";

        public const string SUCCESS_DC_MSG002 = "Division updated successfully.";

        public const string SUCCESS_DC_MSG003 = "Division deleted successfully.";

        public const string WARNING_DC_MSG001 = "Default Division cannot be deleted.";
        
        public const string WARNING_DC_MSG002 = "Division cannot be deleted as it is associated to Employee.";

        public const string WARNING_DC_MSG003 = "Division already exists.";

        public const string WARNING_DC_MSG004 = "Default Division must be there for Employer.";

        #endregion

        #region Demographic

        public const string SUCCESS_DEM_MSG001 = "Employer demographic values updated successfully.";

        public const string SUCCESS_DCM_MSG001 = "Carrier demographic values saved successfully.";

        public const string SUCCESS_DEMP_MSG001 = "Employee demographic values saved successfully.";

        public const string SUCCESS_BANK_MSG001 = "Debit Card details updated successfully";

        public const string WARNING_BANK_MSG001 = "Date of Birth is greater than current date.";

        public const string WARNING_BANK_MSG002 = "Access code entered already exists for another employer. Please enter different access code.";
               
        #endregion

        #region AddressControl

        public const string SUCCESS_AC_MSG001 = "Address added successfully.";

        public const string SUCCESS_AC_MSG002 = "Address updated successfully.";

        public const string SUCCESS_AC_MSG003 = "Address deleted successfully.";

        public const string WARNING_AC_MSG001 = "Address cannot be deleted as it mapped to a Division.";

        public const string WARNING_AC_MSG003 = "Address cannot be deleted as it is associated with beneficiary or dependent.";

        public const string WARNING_AC_MSG004 = "Address cannot be deleted as it is associated with Invoice.";        

        #endregion

        #region Contact Control

        public const string SUCCESS_CT_MSG001 = "Contact added successfully.";

        public const string SUCCESS_CT_MSG002 = "Contact updated successfully.";

        public const string SUCCESS_CT_MSG003 = "Contact deleted successfully.";

        #endregion

        #region Contribution Schedule Control

        public const string SUCCESS_CS_MSG001 = "Contribution schedule added successfully.";

        public const string SUCCESS_CS_MSG002 = "Contribution schedule updated successfully.";

        public const string SUCCESS_CS_MSG003 = "Contribution schedule deleted successfully.";

        public const string SUCCESS_CS_DEPMSG001 = "Deposit mode saved successfully.";

        public const string ALERT_CS_MSG001 = "Contribution schedule cannot be deleted as it is associated at Benefit Level.";

        public const string ALERT_CS_MSG002 = "Contribution schedule cannot be deleted as it is associated at Employee Benefit Level.";

        public const string WARNING_CS_MSG001 = "Desposit Mode is required for adding contribution schedule. Select a Deposit Mode and save.";

        public const string WARNING_CS_MSG002 = "Please select contribution schedule in the grid and save.";

        #endregion

        #region Payroll Schedule Control

        public const string SUCCESS_PR_MSG001 = "Payroll schedule added successfully.";

        public const string SUCCESS_PR_MSG002 = "Payroll schedule updated successfully.";

        public const string SUCCESS_PR_MSG003 = "Payroll schedule deleted successfully.";

        public const string ALERT_PR_MSG001 = "Payroll schedule cannot be deleted as it is associated at Benefit Level.";

        public const string ALERT_PR_MSG002 = "Payroll schedule cannot be deleted as it is associated at Employee Benefit Level.";

        #endregion

        #region Payment Processng Control

        public const string SUCCESS_PP_MSG001 = "Reimbursement schedule added successfully.";

        public const string SUCCESS_PP_MSG002 = "Reimbursement schedule updated successfully.";

        public const string SUCCESS_PP_MSG003 = "Reimbursement schedule deleted successfully.";

        public const string ALERT_PP_MSG001 = "Reimbursement schedule cannot be deleted as it is associated at Benefit Level.";

        public const string ALERT_PP_MSG002 = "Contribution schedule cannot be deleted as it is associated at Employee Benefit Level.";

        #endregion

        #region Carrier Benefit Control

        public const string SUCCESS_CB_MSG001 = "Benefits added successfully.";

        public const string SUCCESS_CB_MSG002 = "Benefits updated successfully.";

        public const string SUCCESS_CB_MSG003 = "Benefits deleted successfully.";

        #endregion

        #region FSA

        public const string SUCCESS_FS_MSG001 = "Benefit details saved successfully.";

        public const string SUCCESS_FS_MSG002 = "Benefits details updated successfully.";

        public const string SUCCESS_FS_MSG003 = "Benefits details deleted successfully.";

        public const string SUCCESS_FS_MSG004 = "Details saved successfully.";

        public const string SUCCESS_FS_MSG005 = "Grace/Carryover period updated successfully.";

        public const string SUCCESS_FS_MSG006 = "Run-out period updated successfully.";

        public const string SUCCESS_FS_MSG007 = "Benefit details updated successfully.";        

        public const string SUCCESS_FS_MSG009 = "Benefit details added successfully.";

        public const string SUCCESS_FS_MSG0010 = "Benefit details renewed successfully.";

        public const string SUCCESS_FS_MSG0011 = "Benefit Cloned successfully.";

        public const string WARNING_FS_MSG001 = "Please select and enter correct data for Grace Date/Grace Days to apply Grace Period to this benefit.";

        public const string WARNING_FS_MSG004 = "Please select and enter correct data for Percentage to Carry Over and/or Not to Exceed to apply Carry Over to this benefit.";

        public const string WARNING_FS_MSG002 = "Please enter both Active Employee Run-out and Terminated Employee Run-Out period value."; 

        public const string WARNING_FS_MSG003 = "Effective From Date should be greater than Employer Effective Date"; 

        public const string WARNING_FS_MSG005 = "Effective From Date and Effective Till must be between Max and Min date of Contribution Schedule's added to this Employer.";

        public const string WARNING_FS_MSG006 = "Benifit Details cannot be deleted as it is assoiciated with Employee.";

        public const string WARNING_FS_MSG007 = "Please enter Active Employee Run-out period value.";

        public const string WARNING_FS_MSG008 = "Please enter Terminated Employee Run-Out period value.";

        #endregion

        #region Users

        public const string USERS_PASSWORD_LOCKED = "The user has been locked successfully.";
        public const string USERS_PASSWORD_RESET = "The Password has been reset successfully and sent to the email address provided.";
        public const string USERS_UNLOCK = "The user has been unlocked successfully.";

        public const string PORTALUSER_ER_LOCK = "The ER portal user has been locked successfully.";
        public const string PORTALUSER_ER_UNLOCK = "The ER portal user has been unlocked successfully.";

        public const string PORTALUSER_EE_LOCK = "The EE portal user has been locked successfully.";
        public const string PORTALUSER_EE_UNLOCK = "The EE portal user has been unlocked successfully.";

        #endregion

        #region Roles

        public const string SUCCESS_RL_MSG001 = "Role added successfully.";
        public const string SUCCESS_RL_MSG002 = "Role updated successfully.";
        public const string WARNING_RL_MSG003 = "Role was not added successfully.";
        public const string WARNING_RL_MSG004 = "A Role with the entered Role Name already exists.";
        public const string WARNING_RL_MSG005 = "Role cannot be deleted as it is associated with Users.";

        #endregion

        #region AssignCarrierControl

        public const string SUCCESS_ACR_MSG001 = "Carrier assigned successfully.";

        public const string SUCCESS_ACR_MSG002 = "Carrier updated successfully.";

        public const string SUCCESS_ACR_MSG003 = "Carrier deleted successfully.";

        public const string WARNING_ACR_MSG001 = "Carrier cannot be deleted since it is associated at Benefit level.";

        public const string WARNING_ACR_MSG002 = "Check for the following errors in all selected rows. Please note selected rows can also be in different page in Current Popup.<li>Is Group No. not entered in any of the selected rows?</li><li>Are valid dates entered in Effective From and Effective Till fields in all selected rows?</li><li>Check If Effective From and Effective Till Dates is greater than '01/01/1901'.</li><li>Is Effective From date greater than Effective Till date in any of the selected rows?</li>";

        public const string WARNING_ACR_MSG003 = "Effective From date should be lesser than Effective Till date in all selected rows.";

        public const string WARNING_ACR_MSG004 = "Group No. is required field in all selected rows.";

        public const string WARNING_ACR_MSG005 = "Carrier cannot be deleted since it is associated with Plan.";

        #endregion

        #region AssignContributionSceduleControl

        public const string SUCCESS_ACS_MSG001 = "Contribution Schedule is assigned to Benefit successfully.";

        public const string SUCCESS_ACS_MSG002 = "Contribution schedule updated successfully.";

        public const string SUCCESS_ACS_MSG003 = "Contribution schedule deleted successfully.";

        #endregion

        #region AssignPayrollSceduleControl

        public const string SUCCESS_APR_MSG001 = "Payroll Schedule is assigned to Benefit successfully.";

        public const string SUCCESS_APR_MSG002 = "Payroll schedule updated successfully.";

        public const string SUCCESS_APR_MSG003 = "Payroll schedule deleted successfully.";

        #endregion

        #region AssignPmtProcessingScheduleControl

        public const string SUCCESS_APP_MSG001 = "Payment schedule assigned successfully.";

        public const string SUCCESS_APP_MSG002 = "Payment schedule updated successfully.";

        public const string SUCCESS_APP_MSG003 = "Payment schedule deleted successfully.";

        #endregion

        #region BankControl

        public const string SUCCESS_BK_MSG001 = "Bank account added successfully.";

        public const string SUCCESS_BK_MSG002 = "Bank account updated successfully.";

        public const string SUCCESS_BK_MSG003 = "Bank account deleted successfully.";

        public const string WARNING_BK_MSG001 = "Are you sure you want to Insert Bank Information without entering Account details? If Account details are entered click on save button in the grid to save the Account details.";

        public const string WARNING_BK_MSG002 = "Account no already exists. Please re-enter the account no.";

        public const string WARNING_BK_MSG003 = "Bank Account cannot be deleted as it is associated with Invoice";

        public const string WARNING_BK_MSG004 = "Bank Account cannot be deleted as it is associated with Benefit";

        #endregion
        #region CarrierBenefitControl

        public const string SUCCESS_CRB_MSG001 = "Carrier benefit saved successfully.";

        public const string SUCCESS_CRB_MSG002 = "Carrier benefit updated successfully.";

        public const string SUCCESS_CRB_MSG003 = "Carrier benefit deleted successfully.";

        public const string SUCCESS_CRB_MSG004 = "Benefit is assigned to Carrier successfully.";

        public const string Warning_CRB_MSG001 = "Benefit you are trying to delete is already associated with the Plan. Please delete the plan for this carrier and try again.";

        #endregion

        #region Note Control

        public const string SUCCESS_NT_MSG001 = "Note added successfully.";

        public const string SUCCESS_NT_MSG002 = "Note updated successfully.";

        public const string SUCCESS_NT_MSG003 = "Note deleted successfully.";


        #endregion

        #region Limits Tier Control

        public const string SUCCESS_LTC_MSG001 = "Limits Tier saved successfully.";

        public const string SUCCESS_LTC_MSG002 = "Limits Tier updated successfully.";

        public const string SUCCESS_LTC_MSG003 = "Limits Tier deleted successfully.";

        #endregion

        #region Limits Benefits Control

        public const string SUCCESS_LBC_MSG001 = "Limits Benefits saved successfully.";

        public const string SUCCESS_LBC_MSG002 = "Limits Benefits updated successfully.";

        public const string SUCCESS_LBC_MSG003 = "Limits Benefits deleted successfully.";
        public const string WARNING_LBC_MSG001 = "Assigned Begin date already exists";

        #endregion

        #region Assign Bank Account to Benefit
        public const string SUCCESS_ABATB_MSG001 = "Bank Account is assigned to Benefit successfully.";
        public const string SUCCESS_ABATB_MSG003 = "Bank Account to Benefit is updated successfully.";
        public const string SUCCESS_ABATB_MSG002 = "Benefit Bank Mapping deleted successfully.";
        public const string WARNING_ABATB_MSG001 = "Assign both Merchant Category Code and Substantiation Rule for this Employer to set Debit card 'Yes' at benefit banking.";
        #endregion

        #region Assign Payment Schedule to Benefit
        public const string SUCCESS_APSTB_MSG001 = "Reimbursement Schedule is assigned to Benefit successfully.";
        #endregion

        #region Benefit Rates & Contributions

        public const string SUCCESS_BR_MSG000 = "Benefit rates created successfully.";
        public const string SUCCESS_BR_MSG001 = "Benefit rates updated successfully.";
        public const string SUCCESS_BR_MSG002 = "Benefit rates deleted successfully.";

        public const string SUCCESS_BC_MSG000 = "Benefit contributions created successfully.";
        public const string SUCCESS_BC_MSG001 = "Benefit contributions updated successfully.";
        public const string SUCCESS_BC_MSG002 = "Benefit contributions deleted successfully.";

        #endregion

        #region AddressGridControl

        public const string SUCCESS_AGC_MSG001 = "Address added successfully.";

        public const string SUCCESS_AGC_MSG002 = "Address updated successfully.";

        public const string SUCCESS_AGC_MSG003 = "Address deleted successfully.";

        public const string ALERT_AGC_MSG001 = "Primary Address already available";

        #endregion

        #region ContactGridControl

        public const string SUCCESS_CGC_MSG001 = "Contact added successfully.";

        public const string SUCCESS_CGC_MSG002 = "Contact updated successfully.";

        public const string SUCCESS_CGC_MSG003 = "Contact deleted successfully.";

        public const string ALERT_CGC_MSG001 = "Primary Contact already available";

        #endregion

        #region Miscellaneous


        #endregion

        #region Individual Beneficiary Control

        public const string SUCCESS_IBC_MSG001 = "Individual Beneficiary added successfully.";

        public const string SUCCESS_IBC_MSG002 = "Individual Beneficiary updated successfully.";

        public const string SUCCESS_IBC_MSG003 = "Individual Beneficiary deleted successfully.";

        public const string WARNING_IBC_MSG001 = "Cumulative Beneficiary percentage can not be greater than 100.";

        public const string WARNING_IBC_MSG002 = "Add Primary Individual Beneficiary before adding Secondary Individual Beneficiary";

        #endregion

        #region Company Beneficiary Control

        public const string SUCCESS_CBC_MSG001 = "Company Beneficiary added successfully.";

        public const string SUCCESS_CBC_MSG002 = "Company Beneficiary updated successfully.";

        public const string SUCCESS_CBC_MSG003 = "Company Beneficiary deleted successfully.";

        public const string WARNING_CBC_MSG001 = "Add Primary Company Beneficiary before adding Secondary Company Beneficiary";

        #endregion

        #region Employee Dependents
        public const string SUCCESS_EEDEP_MSG001 = "Dependent added successfully.";

        public const string SUCCESS_EEDEP_MSG002 = "Dependent updated successfully.";

        public const string SUCCESS_EEDEP_MSG003 = "Dependent deleted successfully.";

        public const string WARNING_EEDEP_MSG001 = "Select if Debit Card eligible or not.";

        public const string WARNING_EEDEP_MSG002 = "Dependent cannot be deleted as it is associated with benefit";

        public const string WARNING_EEDEP_MSG003 = "Please select a Dependent.";

        #endregion

        #region Global Information

        public const string SUCCESS_TPADEMP_MSG001 = "TPA demographic values saved successfully.";

        public const string SUCCESS_BCINS_MSG001 = "Business Code saved successfully.";

        public const string SUCCESS_ASINS_MSG001 = "Available Service saved successfully.";

        public const string SUCCESS_BCUPD_MSG001 = "Business Code updated successfully.";

        public const string WARNING_BCUPD_MSG001 = "Business Code already exists.";

        public const string WARNING_BCUPD_MSG002 = "Business Code cannot be deleted as it is associated at Employer Level.";

        public const string SUCCESS_ASUPD_MSG001 = "Available Service updated successfully.";

        public const string WARNING_ASUPD_MSG001 = "Service code already exists.";

        public const string SUCCESS_BCDEL_MSG001 = "Business Code deleted successfully.";

        public const string SUCCESS_ASDEL_MSG001 = "Available Service deleted successfully.";

        public const string SUCESS_TCSV_MSG001 = "Tier updated successfully.";

        public const string SUCCESS_TCAD_MSG002 = "Tier added successfully.";

        public const string SUCESS_TCDE_MSG003 = "Tier deleted successfully.";

        public const string WARNING_AS_MSG001 = "Available Services cannot be deleted as it is associated at benefit level.";

        public const string WARNING_AS_MSG002 = "Available Services cannot be updated as it is associated at benefit level.";

        public const string WARNING_TCDE_MSG004 = "Tier cannot be deleted as it is associated at benefit level.";

        public const string SUCCESS_SR_MSG001 = "Substantiation Rules added successfully.";
        public const string SUCCESS_SR_MSG002 = "Substantiation Rules updated successfully.";
        public const string WARNING_SR_MSG001 = "Please enter correct values.";
        public const string SUCCESS_GMCC_MSG001 = "Merchant Category Code added successfully.";
        public const string SUCCESS_GMCC_MSG002 = "Merchant Category Code updated successfully.";
        public const string WARNING_GMCC_MSG002 = "A Merchant Category Code with this Code already exists.";
        public const string SUCCESS_SR_MSG003 = "Substantiation Rules deleted successfully.";
        public const string WARNING_SR_MSG002 = "Please add Days to wait for substantiation.";
        public const string WARNING_GMCC_MSG003 = "Merchant Category Code cannot be deleted as it is associated with employer.";
        public const string WARNING_GMCC_MSG004 = "Merchant Category Code Category Code cannot be deleted as it is associated with copay.";

        public const string SUCCESS_ASR_MSG001 = "Auto Substantiation Rule added successfully.";
        public const string SUCCESS_ASR_MSG002 = "Auto Substantiation Rule updated successfully.";
        public const string SUCCESS_ASR_MSG003 = "Auto Substantiation Rule deleted successfully.";
        public const string SUCCESS_ASR_MSG004 = "Selected MCC codes are assigned to the Auto Substantiation Rule successfully";

        public const string SUCCESS_ERC_MSG001 = "Employer Copay added successfully.";
        public const string SUCCESS_ERC_MSG002 = "Employer Copay updated successfully.";

        public const string SUCCESS_ESS_MSG001 = "Smtp Settings added successfully.";
        public const string SUCCESS_ESS_MSG002 = "Smtp Settings updated successfully.";
        public const string WARNING_ESS_MSG001 = "Save TPA details before adding Smtp Settings.";

        public const string SUCCESS_COM_MSG001 = "Communication details added successfully.";
        public const string SUCCESS_COM_MSG002 = "Communication details updated successfully.";
        public const string SUCCESS_COM_MSG003 = "Communication triggered and updated successfully";
        public const string SUCCESS_COM_MSG004 = "Communication triggered and added successfully";
        public const string WARNING_COM_MSG001 = "File Name already exists for this Communication detail. Change the file name/Select a different file and try to save.";
        public const string WARNING_COM_MSG002 = "File upload failed. Select a file and upload again.";
        public const string WARNING_COM_MSG003 = "File size to upload should be less than 5MB.";
        public const string WARNING_COM_MSG004 = "Maximum number of file to uploaded is 5.";
        public const string WARNING_COM_MSG005 = "File is already deleted.";
        public const string WARNING_COM_MSG006 = "The Selected Term is already deleted.";  

        #endregion

        #region Users
        public const string SUCCESS_US_MSG001 = "User added successfully. An email has been sent to the user with the Login details. ";
        public const string SUCCESS_US_MSG002 = "User updated successfully.";
        public const string USERS_LOGIN_MSG001 = "Login ID is in use. Please choose a different Login ID.";
        public const string USERS_LOGIN_MSG002 = "Login ID available";
        public const string USERS_LOGIN_MSG003 = "Login ID already in use";
        public const string USERS_PASSWORDCHANGE_MSG001 = "Password changed.";
        public const string USERS_PASSWORDCHANGE_MSG002 = "Password cannot be changed. The current password does not match with the stored password.";
        public const string USERS_PASSWORDCHANGE_MSG003 = "The current password and the new password cannot be the same.";
        #endregion

        #region Email Messages
        public const string USERBODY_ADDRESSING = "<html><body>Hi,<br/><br/>A user account for the user has been created.<br/><br/>Login ID is: ";
        public const string USERBODY_PASSWORD = "<br/>Password is: ";
        public const string USER_REGARDS = "<br/><br/>Regards,<br/>Flex Admin</body></html>";
        public const string USERS_RESET_BODY = "<html><body>Hi,<br/><br/>Your password has been reset. <br/>The new password is: ";
        #endregion

        #region Available Services

        public const string SUCCESS_ABD_MSG001 = "Available Service assigned successfully.";

        public const string SUCCESS_ABD_MSG003 = "Available Service deleted successfully.";

        public const string SUCCESS_ABD_MSG004 = "Employment class assigned successfully.";

        #endregion

        #region Card Setup

        public const string SUCCESS_CSMCC_MSG001 = "Merchant Category Code assigned successfully.";

        public const string SUCCESS_CSMCC_MSG002 = "Merchant Category Code updated successfully.";

        public const string SUCCESS_CSMCC_MSG003 = "Merchant Category Code deleted successfully.";

        public const string SUCCESS_ERSR_MSG001 = "Employer Substantiation Rules added successfully.";

        public const string SUCCESS_ERSR_MSG002 = "Employer Substantiation Rules updated successfully.";

        public const string SUCCESS_ERSR_MSG003 = "Employer Substantiation Rules deleted successfully.";

        public const string SUCCESS_ERSR_MSG004 = "Substantiation rules are populated from the TPA";

        public const string WARNING_ERSR_MSG004 = "Please enter correct values.";

        public const string WARNING_ERSR_MSG005 = "Please add Days to wait for substantiation.";

        public const string WARNING_ERSR_MSG006 = "No Substantiation Rule has been setup at TPA level";

        public const string INFO_ERSR_MSG001 = "Substantiation Rules are populated from TPA level and this Employer doesn't have any Debit card associated at Benefit level";

        public const string INFO_ERSR_MSG002 = "Substantiation Rules are populated from TPA level and this Employer has Debit card associated at Benefit level";

        public const string INFO_ERSR_MSG003 = "This Employer has Debit card associated at Benefit level";

        public const string INFO_ERSR_MSG004 = "This Employer doesn't have Debit card associated at Benefit level";
 
        #endregion

        #region Add Employee
        public const string SUCCESS_ADEE_MSG001 = "Employee added successfully";
        #endregion

        #region Billing 

        public const string SUCCESS_BBR_MSG001 = "Benefit Rate added successfully.";

        public const string SUCCESS_BBR_MSG002 = "Benefit Rate updated successfully.";

        public const string SUCCESS_BBR_MSG003 = "Benefit Rate assigned successfully.";

        public const string SUCCESS_BBR_MSG004 = "Benefit Rate deleted successfully.";

        public const string WARNING_BBR_MSG001 = "Sequence Order already exists. Enter a new sequence number.";

        public const string WARNING_BBR_MSG002 = "Benefit rate cannot be deleted as it is associated at Employer level";

        public const string WARNING_BBR_MSG003 = "Selected benefit is already assigned to a benefit rate. Please select another benefit";

        public const string WARNING_BBR_MSG004 = "Select an Invoice method before adding Benefit rates.";

        public const string WARNING_BBR_MSG005 = "Select a valid Invoice method.";

        public const string WARNING_BBR_MSG006 = "All benefit rates for this Option have been assigned to Employer.";

        public const string WARNING_BBR_MSG007 = "No records were added at TPA level Billing Benefit Rates for this Option. Please add a record at TPA level Billing Benefit Rates for this Option.";

        public const string WARNING_BBR_MSG008 = "The combination of Benefit and Basis for this employer already exists. Please choose another combination.";

        public const string SUCCESS_BBADJ_MSG001 = "Adjustment added successfully";

        public const string SUCCESS_BBADJ_MSG002 = "Adjustment updated successfully";

        public const string SUCCESS_BBADJ_MSG003 = "Adjustment deleted successfully";

        public const string SUCCESS_BBADJ_MSG004 = "Adjustment cannot be deleted as it is associated elsewhere";

        public const string SUCCESS_BBMC_MSG001 = "One Time Rate added successfully.";

        public const string SUCCESS_BBMC_MSG002 = "One Time Rate updated successfully.";

        public const string SUCCESS_BBMC_MSG003 = "One Time Rate deleted successfully";

        public const string WARNING_BBMC_MSG001 = "One Time Rate cannot be deleted as it is associated at Employer level.";

        public const string SUCCESS_BBRER_MSG001 = "Invoice method saved successfully.";

        public const string SUCCESS_BBMC_MSG004 = "One Time Rate is assigned to Employer successfully."; 

        public const string WARNING_BBMC_MSG002 = "Please select a benefit rate from the below list";

        public const string WARNING_BBMC_MSG003 = "Please enter valid date for Effective From, Effective Till fields in all selected rows.";

        public const string WARNING_BBMC_MSG004 = "'Effective From' date should be less than 'Effective Till' date for all selected rows.";

        public const string WARNING_BOTR_MSG001 = "Please select an one time rate from the below list";

        #endregion Billing

        #region Invoicing

        public const string SUCCESS_INV_MSG001 = "Account assigned successfully.";

        public const string SUCCESS_INV_MSG002 = "Address assigned successfully.";

        public const string SUCCESS_INV_MSG003 = "Invoice details saved successfully.";

        public const string SUCCESS_INV_MSG004 = "Invoice details updated successfully.";

        public const string WARNING_INV_MSG001 = "File Share Path is a required feild.";

        public const string WARNING_INV_MSG002 = "Select an account from the account list.";

        public const string WARNING_INV_MSG003 = "Select an address from address list.";

        public const string SUCCESS_INVTMP_MSG001 = "Invoice Template detail added successfully.";

        public const string SUCCESS_INVTMP_MSG002 = "Invoice Template detail updated successfully.";

        public const string WARNING_INVTMP_MSG001 = "Invoice Template should be in PDF file format.";

        public const string WARNING_INVTMP_MSG002 = "Upload an Invoice Template PDF file.";

        public const string WARNING_INVTMP_MSG003 = "Default invoice template already exists. Remove default selection previously set in invoice template and update this record as default template. ";

        public const string WARNING_INVTMP_MSG004 = "File Name already exists. Change the file name and try to save.";

        public const string WARNING_INVTMP_MSG005 = "Download Failure.";

        public const string WARNING_INVTMP_MSG006 = "Default Invoice template cannot be deleted."; 
        #endregion Invoicing

        #region Manage Import

        public const string MANAGE_IMPORT_MSG001 = "Employee Details added successfully.";
        public const string MANAGE_IMPORT_MSG002 = "Invalid Bank Account Type";
        public const string MANAGE_IMPORT_MSG003 = "Invalid State";
        public const string MANAGE_IMPORT_MSG004 = "Invalid Address Type";
        public const string MANAGE_IMPORT_MSG005 = "Invalid Division";
        public const string MANAGE_IMPORT_MSG006 = "An Employee with this SSN already exists for this Employer";
        public const string MANAGE_IMPORT_MSG007 = "The Access Code of the Employer is invalid or does not exist";

        #endregion

        #region Employee Communication

        public const string EE_COMM_MSG001 = "Employee Debit Card Communication details saved successfully";
        public const string EE_COMM_MSG002 = "Email details for this Employee is required when communication method selected is Email";
        public const string EE_COMM_MSG003 = "Fax information is required in the primary address of Employee when communication method selected is Fax";

        #endregion

        #region Providers

        public const string PROVIDER_MSG001 = "Provider has been added successfully.";
        public const string PROVIDER_MSG002 = "Provider has been updated successfully.";
        public const string PROVIDER_MSG003 = "A Provider with this TaxID and ServiceProviderName already exists.";
        public const string PROVIDER_MSG004 = "A Provider with this TaxID already exists.";
        public const string PROVIDER_MSG005 = "A Provider with this ServiceProviderName already exists.";

        #endregion

        #region Payments

        public const string SUCCESS_PI_MSG001 = "Payment information added successfully.";

        public const string SUCCESS_PI_MSG002 = "The Billing is Enabled.";

        public const string SUCCESS_PI_MSG003 = "The Billing is Disabled.";

        public const string WARNING_PI_MSG001 = "Valid Employer Name is required.";

        public const string WARNING_PI_MSG002 = "Error while saving the Billing Status";


        #endregion Invoicing

        #region "Duplicate Claims"
        public const string SUCCESS_DUC_MSG001 = "Duplicate claim settings for the carrier has been added succesfully.";
        public const string SUCCESS_DUC_MSG002 = "Duplicate claim settings for the carrier has been updated succesfully.";
        public const string SUCCESS_DUC_MSG003 = "Duplicate claim settings for the carrier has been deleted succesfully.";
        public const string CONFIRM_DUC_MSG001 = "Are you sure to delete duplicate claim settings done?";
        public const string CONFIRM_DUC_MSG002 = "Are you sure to cancel the changes done? Settings which were previously saved will be populated. ";
        #endregion

        #region "Claims"
        public const string SUCCESS_CLM_MSG001 = "Claim has been added successfully";
        public const string SUCCESS_CLM_MSG002 = "Claim has been updated successfully";
        public const string WARNING_CLM_MSG001 = "There are no Benefits for the combination of Employer,Employee and Service From selected";
        public const string WARNING_CLM_MSG002 = "Service From date is invalid";
        public const string WARNING_CLM_MSG003 = "Please select the employer for populating benefits";
        public const string WARNING_CLM_MSG004 = "A claim of this kind has already been submitted for this carrier. Below are the details. Do you want to continue saving?";
        public const string INFO_CLM_MSG001 = "Please select Benefit Type,Carrier,Service Category and Service Description for the newly entered Service From Date";
        public const string INFO_CLM_MSG002 = "Please verify Benefit Type, Carrier,Service Category and Service Description for the newly entered Service From Date";
        public const string INFO_CLM_MSG003 = "This claim has already been processed,data will not be available for edit";

        #endregion

        #region Basic Group Admin
        public const string SUCCESS_EE_MSG001 = "Employee status updated successfully";

        public const string SUCCESS_EE_MSG002 = "Employee class updated successfully";

        public const string WARNING_EE_MSG001 = "No records to display";

        public const string WARNING_EE_MSG002 = "Select a different status to update";

        public const string WARNING_EE_MSG003 = "Selected employer is not active. Employer status should be active before updating employee status"; 
        #endregion

        #region Special Enrollment Benefits - Group Administration
        public const string SUCCESS_SEBG_MSG001 = "Special Enrollment Benefits for employees updated successfully";

        public const string WARNING_SEBG_MSG001 = "No records to display";

        public const string WARNING_SEBG_MSG002 = "Special Enrollment end date is not within end date of Employer benefit";

        #endregion 

        #region Variable

        public const string SUCCESS_VL_MSG001 = "Variable added successfully.";
        public const string WARNING_VL_MSG002 = "Adding of a Variable failed";
        public const string WARNING_VL_MSG003 = "A Variable with the entered Variable Name already exists.";
        public const string WARNING_VL_MSG004 = "Query is not entered.";
        public const string WARNING_VL_MSG005 = "Value/Query is Required";
        public const string SUCCESS_VL_MSG006 = "Variable updated successfully.";
        public const string WARNING_VL_MSG007 = "Variable update failed";
        public const string SUCCESS_VL_MSG008 = "Query entered is Valid";

        #endregion

        #region Employee Dependents
        public const string SUCCESS_EEBENE_MSG001 = "Beneficiary added successfully.";

        public const string SUCCESS_EEBENE_MSG002 = "Beneficiary updated successfully.";

        public const string SUCCESS_EEBENE_MSG003 = "Beneficiary deleted successfully.";
        #endregion

		#region "AuthorizedUsers"
		public const string SUCCESS_AUTH_MSG001 = "Authorized User added successfully.";

		public const string SUCCESS_AUTH_MSG002 = "Authorized User updated successfully.";

		public const string SUCCESS_AUTH_MSG003 = "Authorized User deleted successfully.";

		public const string FAILURE_AUTH_MSG001 = "Authorized User addition failed. Please try again or contact administrator";

		public const string FAILURE_AUTH_MSG002 = "Authorized User save failed. Please try again or contact administrator";
		#endregion

        #region Employment 
        public const string SUCCESS_EEE_MSG001 = "Employment details added successfully";
        public const string SUCCESS_EEE_MSG002 = "Employment details saved successfully";
        public const string WARNING_EEE_MSG001 = "Assigned begin date already exists for this employee"; 

        #endregion

        #region TPA Employee Class
        public const string SUCCESS_TMC_MSG001 = "Enrollment Class details added successfully";
        public const string SUCCESS_TMC_MSG002 = "Enrollment Class details saved successfully";
        public const string WARNING_TMC_MSG001 = "Assigned class name already exists. Change the class name and try again";
        public const string WARNING_TMC_MSG002 = "Enrollment Class details cannot not be deleted as it is associated with employee";
        public const string WARNING_TMC_MSG003 = "Enrollment Class details cannot be deleted. FullTime is a default class";
        public const string WARNING_TMC_MSG004 = "Enrollment Class details cannot be renamed. FullTime is a default class";
        public const string WARNING_TMC_MSG005 = "Enrollment Class details cannot not be deleted as it is associated with employer benefit";
        #endregion 

		#region BenefitText

	    public const string SUCCESS_BTC_MSG001 = "Benefit text added successfully";
		public const string SUCCESS_BTC_MSG002 = "Benefit text saved successfully";
	    public const string WARNING_BTC_MSG001 = "Benefit text save failed. Please contact administrator.";
	    #endregion

		#region EnrollmentText
		public const string SUCCESS_ERTC_MSG001 = "Enrollment text added successfully";
		public const string SUCCESS_ERTC_MSG002 = "Enrollment text saved successfully";
		public const string WARNING_ERTC_MSG001 = "Enrollment text save failed. Please contact administrator.";
		#endregion

        #region Benefit Enrollment
        public const string SUCCESS_BETC_MSG001 = "Benefit Enrollment details saved successfully";
        public const string SUCCESS_BETC_MSG002 = "Benefit Enrollment Rule details added successfully";
        public const string SUCCESS_BETC_MSG003 = "Benefit Enrollment Rule details saved successfully";
        public const string WARNING_BETC_MSG001 = "Selected Enrollment Rule already exists for this benefit";
        
        public const string WARNING_BETC_MSG002 = "Selected Eligibility Rule already exists for this benefit";
        public const string SUCCESS_BETC_MSG004 = "Benefit Eligibility Rule details added successfully";
        public const string SUCCESS_BETC_MSG005 = "Benefit Eligibility Rule details saved successfully";  


        #endregion
        #region Terms
        public const string SUCCESS_TT_MSG001 = "Term details added successfully";
        public const string SUCCESS_TT_MSG002 = "Term details updated successfully";
        public const string SUCCESS_TT_MSG003 = "Term details deleted successfully";
        public const string WARNING_TT_MSG001 = "Term details cannot be deleted as it is Mapped with Term Groups and Benefits. ";
        public const string WARNING_TT_MSG002 = "Term with the same name already exists. ";

        #endregion
        #region TermGroups
        public const string SUCCESS_TG_MSG001 = "Term Group details added successfully";
        public const string SUCCESS_TG_MSG002 = "Term Group details updated successfully";
        public const string SUCCESS_TG_MSG003 = "Term Group details deleted successfully";
        public const string WARNING_TG_MSG001 = "Term Group details cannot be deleted as it is associated with Terms.";
        public const string WARNING_TG_MSG002 = "Term Group details cannot be deleted as it is Mapped with Terms and Benefits. ";
        public const string WARNING_TG_MSG003 = "Term Group with the same name already exists. ";
        #endregion

        #region "Map Term Groups"

        public const string MapTermSaveSucces = "Term is mapped to Term Groups and Benefits successfully.";
        public const string MapTermSaveWarning = "Term is associated to Plan Details and cannot be removed from selected item.";
        //public const string MapTermSaveFailure = "There was an error while saving. Please contact adminstrator.";
        #endregion
        #region "Extended Enrollment Benefits"

        public const string ExtendedBenefitSaveSucces = "Extended Enrollment Benefits saved successfully";
		public const string ExtendedBenefitSaveFailure = "There was an error while saving. Please contact adminstrator.";
	    #endregion

        #region Employee mapping

        public const string SUCCESS_AEM_MSG001 = "Employee map updated successfully.";

        public const string SUCCESS_AEM_MSG002 = "An employee with the same SSN and Date of Birth already exists with the new employer. Please note that demographic details are NOT carried over to the new employee.";

        public const string WARNING_AEM_MSG001 = "New-Employer and TaxID combination is invalid";

        public const string WARNING_AEM_MSG002 = "Employee has more than one HSA benefit or benefits other than HSA. Hence cannot be mapped to new employer";
        
        public const string WARNING_AEM_MSG003 = "Benefit cannot be mapped to new employer due to any of reasons below: <br/>1.This type of benefit is not available for new employer <br/>2.New employer benefit may be inactive or not applicable for existing segment <br/>3.Existing employee benefit effective from and to date does not fall within effective from and to dates for same benefit offered by new employer";

        public const string WARNING_AEM_MSG004 = "New employer benefit does not have contribution schedule associated to it";
       
        #endregion
        
        #region Plan Control

        public const string SUCCESS_PC_MSG001 = "Plan added successfully.";

        public const string SUCCESS_PC_MSG002 = "Plan updated successfully."; 

        public const string SUCCESS_PC_MSG003 = "Document attached to the Plan successfully";

        public const string SUCCESS_PC_MSG004 = "Plan deleted successfully.";

        public const string WARNING_PC_MSG001 = "File size to upload should be less than 5MB.";

        public const string WARNING_PC_MSG002 = "The File with this fileName already exists. Change the file name and upload again.";

        public const string WARNING_PC_MSG003 = "No file is selected. Please browse a file";

        public const string WARNING_PC_MSG004 = "The file Type selected is invalid.";

        public const string WARNING_PC_MSG005 = "Plan cannot be deleted as it is associated with the Employer.";

        public const string WARNING_PC_MSG006 = "Plan cannot be deleted as it is associated with the Employee.";
      
        #endregion

        #region Plan Payment

        public const string SUCCESS_BPP_MSG001 = "Plan Payment added successfully.";

        public const string SUCCESS_BPP_MSG002 = "Plan Billing updated successfully.";  

        public const string SUCCESS_BPP_MSG003 = "Plan Billing added successfully.";

        public const string WARNING_BPP_MSG001 = "Plan Payment Not Created. Please contact Administarator.";

        public const string WARNING_BPP_MSG002 = "Plan Billing Not Created. Please contact Administarator."; 

        #endregion


        #region Employee Contribution

        public const string SUCCESS_ECB_MSG001 = "Benefit Contribution Schedule added successfully.";

        public const string SUCCESS_ECB_MSG002 = "Benefit Contribution Schedule deleted successfully.";

        public const string WARNING_ECB_MSG001 = "Benefit Contribution Schedule cannot be added.";

        public const string WARNING_ECB_MSG002 = "Please select the Contribution Schedule.";

        #endregion

    }
}
