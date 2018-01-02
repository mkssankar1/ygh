using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using GreenChits.DataAccess;
using GreenChits.Common;
using GreenChits.Common.Constants;
using GreenChits.Common.Utility;
using GreenChits.Model;
using GreenChits.Common.Security;

namespace GreenChits.Controllers
{
    public class GroupController
    {
        public Status Insert(GroupDetails objGroup)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(DbGroupDetails.GroupName.ToString(),  SqlDbType.VarChar, 50, objGroup.GroupName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(DbGroupDetails.Desc.ToString(),  SqlDbType.VarChar, 500, objGroup.Desc,ParameterDirection.Input),
                    DataParameter.GetSqlParam(DbGroupDetails.CreatedBy.ToString(),  SqlDbType.Int, 11, objGroup.CreatedUser,ParameterDirection.Input),
                    DataParameter.GetSqlParam("RETURN_VALUE",    SqlDbType.Int, 0,ParameterDirection.Output),
                };
            try
            {
                return new Status() { StatusId = CommonDBFunctions.ExecuteNonQuery("spGroupInsert", parameter,true), MsgDesc = AppConstant.SuccessMsg };
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Status CheckGroup(string group)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(DbGroupDetails.GroupName.ToString(),  SqlDbType.VarChar, 50, group,ParameterDirection.Input),
                    DataParameter.GetSqlParam("RETURN_VALUE",    SqlDbType.Int, 0,ParameterDirection.Output),
                };
            try
            {
                return new Status() { StatusId = CommonDBFunctions.ExecuteNonQuery("spGroupCheck", parameter, true), MsgDesc = AppConstant.SuccessMsg };
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public GroupList GetGroup(int userId)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(dbUserEnity.CustomerID.ToString(),  SqlDbType.Int, 50, userId,ParameterDirection.Input),
                };
            try
            {
                GroupList objGroupList = new GroupList();
                var drUserDetails = CommonDBFunctions.ExecuteDataSet(spUser.spUserLogin.ToString(), parameter);
                if (drUserDetails.Tables.Count > 0)
                {
                  //  new Status() { StatusId = AppConstant.Success, MsgDesc = success };
                    if (drUserDetails.Tables.Count == 1)
                    {
                        if (drUserDetails.Tables[1].Rows.Count > 0)
                        {
                            objGroupList.status = new Status() { StatusId = AppConstant.Success, MsgDesc = AppConstant.SuccessMsg };
                        }
                        else
                        {
                            objGroupList.status = new Status() { StatusId = AppConstant.Information, MsgDesc = "No record" };
                        }
                        foreach (DataRow dr in drUserDetails.Tables[1].Rows)
                        {
                            GroupDetails objGroup = new GroupDetails();
                            objGroup.GroupName = dr[dbUserEnity.FirstName.ToString()].ToString();
                            objGroup.StatusMsg = dr[dbUserEnity.FirstName.ToString()].ToString();
                            objGroup.Desc = dr[dbUserEnity.FirstName.ToString()].ToString();
                            objGroup.CreatedUser = dr[dbUserEnity.FirstName.ToString()].ToString();
                           // objGroup.Status = dr[dbUserEnity.FirstName.ToString()].ToString();
                            objGroup.CreatedDate = Convert.ToDateTime(dr[dbUserEnity.LastLogin.ToString()].ToString());
                            objGroup.GroupID= UtilCipher.Encrypt(dr[dbUserEnity.CustomerID.ToString()].ToString());
                            objGroup.IsAdmin = Convert.ToBoolean(dr[dbUserEnity.FirstName.ToString()]);
                            objGroupList.groups.Add(objGroup);
                        }
                    }
                }


                return objGroupList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<BankAccountEnity> GetUserBankAccount(String userId)
        {
            DbParameter[] parameter = new DbParameter[1];

            parameter[0] = new SqlParameter(dbBankEnity.USERID.ToString(), Convert.ToInt64(userId));
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.Int64;
           
            DataHelper helper = null;
            SqlDataReader sqlReader = null;
            List<BankAccountEnity> objBankAccountEnityList = new List<BankAccountEnity>();
            try
            {
                //helper = new DataHelper(CommonFunctions.GetConnectionString());
                //sqlReader = helper.ExecuteReader("spGetUserBankAccount", parameter).AsSqlReader();
                //if (sqlReader.HasRows)
                //{
                //    while (sqlReader.Read())
                //    {
                //        BankAccountEnity objBankAccountEnity = new BankAccountEnity
                //        {
                //            strUserBankId = sqlReader[dbBankEnity.USERBANKID.ToString()].ToString(),
                //            strAccountName = sqlReader[dbBankEnity.ACCOUNTNAME.ToString()].ToString(),
                //            strBankName = sqlReader[dbBankEnity.BANKNAME.ToString()].ToString(),
                //            intAccountNo = Convert.ToInt64(sqlReader[dbBankEnity.ACCOUNTNO.ToString()]),
                //            intAccountType = Convert.ToInt32(sqlReader[dbBankEnity.ACCOUNTTYPE.ToString()]),
                //            strBranchName = sqlReader[dbBankEnity.BRANCHNAME.ToString()].ToString(),
                //            strPlace = sqlReader[dbBankEnity.PLACE.ToString()].ToString(),
                //            strIfsc = sqlReader[dbBankEnity.IFSC.ToString()].ToString(),
                //            strMicr = sqlReader[dbBankEnity.MICR.ToString()].ToString(),
                //            intChitsType = Convert.ToInt32(sqlReader[dbBankEnity.CHITSTYPE.ToString()])
                //        };
                //        objBankAccountEnityList.Add(objBankAccountEnity);
                //    }
                //}
            }
            catch (Exception)
            {
                
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                    sqlReader.Dispose();
                }
            }
            return objBankAccountEnityList;
        }

    /*
        public int InsertContact(UserEnity user)
        {
            DbParameter[] parameter = new SqlParameter[7];

            parameter[0] = new SqlParameter(dbBankEnity.EMAIL.ToString(), objBank.strEmail);
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbBankEnity.FNAME.ToString(), objBank.strFName);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;

            parameter[2] = new SqlParameter(dbBankEnity.LNAME.ToString(), objBank.strLName);
            parameter[2].Direction = ParameterDirection.Input;
            parameter[2].DbType = DbType.String;

            parameter[3] = new SqlParameter(dbBankEnity.MOBILE.ToString(), objBank.strMobile);
            parameter[3].Direction = ParameterDirection.Input;
            parameter[3].DbType = DbType.String;

            parameter[4] = new SqlParameter(dbBankEnity.GENDER.ToString(), objBank.strGender);
            parameter[4].Direction = ParameterDirection.Input;
            parameter[4].DbType = DbType.String;

            parameter[5] = new SqlParameter(dbBankEnity.DOB.ToString(), objBank.dtDOB);
            parameter[5].Direction = ParameterDirection.Input;
            parameter[5].DbType = DbType.Date;

            parameter[6] = new SqlParameter(dbBankEnity.TYPE.ToString(), objBank.intType);
            parameter[6].Direction = ParameterDirection.Input;
            parameter[6].DbType = DbType.Int32;
            try
            {
                return CommonDBFunctions.ExecuteNonQuery(spobjBank.spContactUserInsert.ToString(), parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(UserEnity user)
        {
            DbParameter[] parameter = new SqlParameter[2];

            parameter[0] = new SqlParameter(dbBankEnity.USERID.ToString(), Convert.ToInt64(UtilCipher.Decrypt(objBank.strUid)));
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbBankEnity.MODIFIEDobjBank.ToString(), objBank.strModifiedUser);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;
            try
            {
                return CommonDBFunctions.ExecuteNonQuery(spobjBank.spUserDelete.ToString(), parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(UserEnity user)
        {
            DbParameter[] parameter = new SqlParameter[11];

            parameter[0] = new SqlParameter(dbBankEnity.EMAIL.ToString(), objBank.strEmail);
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbBankEnity.PWD.ToString(), objBank.strPassword);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;

            parameter[2] = new SqlParameter(dbBankEnity.FNAME.ToString(), objBank.strFName);
            parameter[2].Direction = ParameterDirection.Input;
            parameter[2].DbType = DbType.String;

            parameter[3] = new SqlParameter(dbBankEnity.LNAME.ToString(), objBank.strLName);
            parameter[3].Direction = ParameterDirection.Input;
            parameter[3].DbType = DbType.String;

            parameter[4] = new SqlParameter(dbBankEnity.MOBILE.ToString(), objBank.strMobile);
            parameter[4].Direction = ParameterDirection.Input;
            parameter[4].DbType = DbType.String;

            parameter[5] = new SqlParameter(dbBankEnity.GENDER.ToString(), objBank.strGender);
            parameter[5].Direction = ParameterDirection.Input;
            parameter[5].DbType = DbType.String;

            parameter[6] = new SqlParameter(dbBankEnity.DOB.ToString(), objBank.dtDOB);
            parameter[6].Direction = ParameterDirection.Input;
            parameter[6].DbType = DbType.Date;

            parameter[7] = new SqlParameter(dbBankEnity.STATUS.ToString(), objBank.intStatus);
            parameter[7].Direction = ParameterDirection.Input;
            parameter[7].DbType = DbType.Int32;

            parameter[8] = new SqlParameter(dbBankEnity.TYPE.ToString(), objBank.intType);
            parameter[8].Direction = ParameterDirection.Input;
            parameter[8].DbType = DbType.Int32;

            parameter[9] = new SqlParameter(dbBankEnity.MODIFIEDobjBank.ToString(), objBank.strModifiedUser);
            parameter[9].Direction = ParameterDirection.Input;
            parameter[9].DbType = DbType.Int64;

            parameter[10] = new SqlParameter(dbBankEnity.USERID.ToString(), Convert.ToInt64(UtilCipher.Decrypt(objBank.strUid)));
            parameter[10].Direction = ParameterDirection.Input;
            parameter[10].DbType = DbType.Int64;
            try
            {
                return CommonDBFunctions.ExecuteNonQuery(spobjBank.spUserUpdate.ToString(), parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public UserEnity getUserLogin(UserEnity user)
        {
            DbParameter[] parameter = new DbParameter[2];

            parameter[0] = new SqlParameter(dbBankEnity.EMAIL.ToString(), objBank.strEmail);
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbBankEnity.PWD.ToString(), objBank.strPassword);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;

            DataHelper helper = null;
            SqlDataReader sqlReader = null;
            try
            {
                helper = new DataHelper(CommonFunctions.GetConnectionString());
                var drUserDetails = helper.ExecuteDataSet(spobjBank.spUserLogin.ToString(), parameter);
                if (drUserDetails.Tables.Count > 0)
                {
                    foreach (DataRow dr in drUserDetails.Tables[0].Rows)
                    {
                        objBank.intLoginStatus = Convert.ToInt32(dr[dbBankEnity.LOGINSTATUS.ToString()]);
                    }
                    if (drUserDetails.Tables.Count == 2)
                    {
                        foreach (DataRow dr in drUserDetails.Tables[1].Rows)
                        {
                            objBank.intType  = Convert.ToInt32(dr[dbBankEnity.TYPE.ToString()]);

                            string ss = dr[dbBankEnity.USERID.ToString()].ToString();
                            objBank.strUid   = UtilCipher.Encrypt("siva");
                            objBank.strEmail = dr[dbBankEnity.EMAIL.ToString()].ToString();
                            objBank.strFName = dr[dbBankEnity.FNAME.ToString()].ToString();
                            objBank.strLName = dr[dbBankEnity.LNAME.ToString()].ToString();
                        }
                    }
                }
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                    sqlReader.Dispose();
                }
            }
            return user;
        }
        */
    }
}
