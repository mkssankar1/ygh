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
    public class UserController
    {
        public Status InsertUser(UserExtend user)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(dbUserEnity.Email.ToString(),  SqlDbType.VarChar, 30, user.Email,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.UserName.ToString(),    SqlDbType.VarChar, 30, user.UserName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.Password.ToString(),    SqlDbType.VarChar, 30, user.Password,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.FirstName.ToString(),  SqlDbType.VarChar, 30,user.FirstName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.LastName.ToString(),  SqlDbType.VarChar, 30,user.LastName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.Gender.ToString(), SqlDbType.Int, 20,user.Gender,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.DOB.ToString(),    SqlDbType.DateTime,30,user.DOB,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.Status.ToString(), SqlDbType.Int, 10,user.Status,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.SaltKey.ToString(),    SqlDbType.VarChar, 6,CommonFunctions.SaltKey(),ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.ActiveGuid.ToString(),  SqlDbType.VarChar, 50, Guid.NewGuid().ToString(),ParameterDirection.Input),
                    DataParameter.GetSqlParam("RETURN_VALUE",    SqlDbType.Int, 0,ParameterDirection.Output),

                };
            try
            {
                return new Status() { StatusId = CommonDBFunctions.ExecuteNonQuery(spUser.spUserInsert.ToString(), parameter), MsgDesc = AppConstant.SuccessMsg };
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Status CheckUserActivation(string guid)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(dbUserEnity.ActiveGuid.ToString(),  SqlDbType.VarChar, 50, guid,ParameterDirection.Input),
                    DataParameter.GetSqlParam("RETURN_VALUE",    SqlDbType.Int, 0,ParameterDirection.Output),

                };
            try
            {
                
                int RES = CommonDBFunctions.ExecuteNonQuery(spUser.spCheckActivation.ToString(), parameter,true);
                string success = (RES == 1) ? AppConstant.SuccessMsg : (RES == 2) ? "Activation done already" : "No activation code";
                return new Status() { StatusId = AppConstant.Success , MsgDesc = success };
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public Status Login1(UserEnity user)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(dbUserEnity.UserName.ToString(),  SqlDbType.VarChar, 50, user.UserName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.Password.ToString(),  SqlDbType.VarChar, 50, user.Password,ParameterDirection.Input),
                    DataParameter.GetSqlParam("RETURN_VALUE",    SqlDbType.Int, 0,ParameterDirection.Output),

                };
            try
            {

                int RES = CommonDBFunctions.ExecuteNonQuery(spUser.spUserLogin.ToString(), parameter, true);
                string success = string.Empty;
                switch (RES)
                {
                    case 1: 
                        success= AppConstant.SuccessMsg;
                        break;
                     case 2: 
                        success= "User Removed";
                        break;
                     case 8: 
                        success= "User Locked";
                        break;
                     case 9: 
                        success="Not activation";
                        break;
                }

                return new Status() { StatusId = AppConstant.Success, MsgDesc = success };
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Login Login(UserEnity user)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(dbUserEnity.UserName.ToString(),  SqlDbType.VarChar, 50, user.UserName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.Password.ToString(),  SqlDbType.VarChar, 50, user.Password,ParameterDirection.Input),
                };

            DataHelper helper = null;
            SqlDataReader sqlReader = null;
            Login objLogin = new Login();
            try
            {
                helper = new DataHelper(CommonFunctions.GetConnectionString());
                var drUserDetails = helper.ExecuteDataSet(spUser.spUserLogin.ToString(), parameter);
                if (drUserDetails.Tables.Count > 0)
                {
                    foreach (DataRow dr in drUserDetails.Tables[0].Rows)
                    {
                        string success = string.Empty;
                        switch (Convert.ToInt32(dr["LOGINSTATUS"]))
                        {
                            case 1:
                                success = AppConstant.SuccessMsg;
                                break;
                            case 2:
                                success = "User Removed";
                                break;
                            case 8:
                                success = "User Locked";
                                break;
                            case 9:
                                success = "Not activation";
                                break;
                        }

                       objLogin.status = new Status() { StatusId = AppConstant.Success, MsgDesc = success };
                    }
                    if (drUserDetails.Tables.Count == 2)
                    {
                        foreach (DataRow dr in drUserDetails.Tables[1].Rows)
                        {
                            objLogin.user = new UserEnity();
                            objLogin.user.UserType = (Convert.ToInt32(dr[dbUserEnity.Type.ToString()]) ==1)?"user":"admin";
                            objLogin.user.CreatedUser = UtilCipher.Encrypt(dr[dbUserEnity.CustomerID.ToString()].ToString());
                            objLogin.user.Email = dr[dbUserEnity.Email.ToString()].ToString();
                            objLogin.user.FirstName = dr[dbUserEnity.FirstName.ToString()].ToString();
                            objLogin.user.LastName = dr[dbUserEnity.LastName.ToString()].ToString();
                            objLogin.user.LastLogin = Convert.ToDateTime(dr[dbUserEnity.LastLogin.ToString()].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
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
            return objLogin;
        }

        /*
        public int InsertContact(UserEnity user)
        {
            DbParameter[] parameter = new SqlParameter[7];

            parameter[0] = new SqlParameter(dbUserEnity.EMAIL.ToString(), user.strEmail);
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbUserEnity.FNAME.ToString(), user.strFName);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;

            parameter[2] = new SqlParameter(dbUserEnity.LNAME.ToString(), user.strLName);
            parameter[2].Direction = ParameterDirection.Input;
            parameter[2].DbType = DbType.String;

            parameter[3] = new SqlParameter(dbUserEnity.MOBILE.ToString(), user.strMobile);
            parameter[3].Direction = ParameterDirection.Input;
            parameter[3].DbType = DbType.String;

            parameter[4] = new SqlParameter(dbUserEnity.GENDER.ToString(), user.strGender);
            parameter[4].Direction = ParameterDirection.Input;
            parameter[4].DbType = DbType.String;

            parameter[5] = new SqlParameter(dbUserEnity.DOB.ToString(), user.dtDOB);
            parameter[5].Direction = ParameterDirection.Input;
            parameter[5].DbType = DbType.Date;

            parameter[6] = new SqlParameter(dbUserEnity.TYPE.ToString(), user.intType);
            parameter[6].Direction = ParameterDirection.Input;
            parameter[6].DbType = DbType.Int32;
            try
            {
                return CommonDBFunctions.ExecuteNonQuery(spUser.spContactUserInsert.ToString(), parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(UserEnity user)
        {
            DbParameter[] parameter = new SqlParameter[2];

            parameter[0] = new SqlParameter(dbUserEnity.USERID.ToString(), Convert.ToInt64(UtilCipher.Decrypt(user.strUid)));
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbUserEnity.MODIFIEDUSER.ToString(), user.strModifiedUser);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;
            try
            {
                return CommonDBFunctions.ExecuteNonQuery(spUser.spUserDelete.ToString(), parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(UserEnity user)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam(dbUserEnity.USERID.ToString(),  SqlDbType.BigInt, 16, Convert.ToInt64(user.strUid),ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.EMAIL.ToString(),  SqlDbType.VarChar, 30, user.strEmail,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.FNAME.ToString(),  SqlDbType.VarChar, 30,user.strFName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.LNAME.ToString(),  SqlDbType.VarChar, 30,user.strLName,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.MOBILE.ToString(), SqlDbType.VarChar, 20,user.strMobile,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.GENDER.ToString(), SqlDbType.VarChar, 10,user.strGender,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.DOB.ToString(),    SqlDbType.DateTime,30,user.dtDOB,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.STATUS.ToString(), SqlDbType.Int, 10,user.intStatus,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.TYPE.ToString(),   SqlDbType.Int, 10,user.intType,ParameterDirection.Input),
                    DataParameter.GetSqlParam(dbUserEnity.MODIFIEDUSER.ToString(),SqlDbType.BigInt, 12,Convert.ToInt64(user.strModifiedUser),ParameterDirection.Input),
                };
            try
            {
                return CommonDBFunctions.ExecuteNonQuery(spUser.spUserUpdate.ToString(), parameter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public UserEnity getUserLogin(UserEnity user)
        {
            DbParameter[] parameter = new DbParameter[2];

            parameter[0] = new SqlParameter(dbUserEnity.EMAIL.ToString(), user.strEmail);
            parameter[0].Direction = ParameterDirection.Input;
            parameter[0].DbType = DbType.String;

            parameter[1] = new SqlParameter(dbUserEnity.PWD.ToString(), user.strPassword);
            parameter[1].Direction = ParameterDirection.Input;
            parameter[1].DbType = DbType.String;

            DataHelper helper = null;
            SqlDataReader sqlReader = null;
            try
            {
                helper = new DataHelper(CommonFunctions.GetConnectionString());
                var drUserDetails = helper.ExecuteDataSet(spUser.spUserLogin.ToString(), parameter);
                if (drUserDetails.Tables.Count > 0)
                {
                    foreach (DataRow dr in drUserDetails.Tables[0].Rows)
                    {
                        user.intLoginStatus = Convert.ToInt32(dr[dbUserEnity.LOGINSTATUS.ToString()]);
                    }
                    if (drUserDetails.Tables.Count == 2)
                    {
                        foreach (DataRow dr in drUserDetails.Tables[1].Rows)
                        {
                            user.intType = Convert.ToInt32(dr[dbUserEnity.TYPE.ToString()]);

                            user.strUid = UtilCipher.Encrypt(dr[dbUserEnity.USERID.ToString()].ToString());
                          //  user.strUid = UtilCipher.Decrypt(dr[dbUserEnity.USERID.ToString()].ToString());
                            user.strEmail = dr[dbUserEnity.EMAIL.ToString()].ToString();
                            user.strFName = dr[dbUserEnity.FNAME.ToString()].ToString();
                            user.strLName = dr[dbUserEnity.LNAME.ToString()].ToString();
                        }
                    }
                }
            }
            catch (Exception e)
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
            return user;
        }


        public List<UserAccountDetail> GetUserAccountDetail(Int64 userId, int intType, int intStatus = 0)
        {
            DbParameter[] parameter =
                {
                    DataParameter.GetSqlParam("USERID", SqlDbType.BigInt, 0,userId,ParameterDirection.Input),
                    DataParameter.GetSqlParam("Type", SqlDbType.BigInt, 0,intType,ParameterDirection.Input),
                    DataParameter.GetSqlParam("Status", SqlDbType.BigInt, 0,intStatus,ParameterDirection.Input)
                };
            DataHelper helper = null;
            SqlDataReader sqlReader = null;
            List<UserAccountDetail> objUserAccountDetailList = new List<UserAccountDetail>();
            try
            {
                helper = new DataHelper(CommonFunctions.GetConnectionString());
                sqlReader = helper.ExecuteReader("spGetUserDetails", parameter).AsSqlReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        UserAccountDetail objUserAccountDetail = new UserAccountDetail
                        {
                            strUid = UtilCipher.Encrypt(sqlReader[dbUserEnity.USERID.ToString()].ToString()),
                            strEmail = sqlReader[dbUserEnity.EMAIL.ToString()].ToString(),
                            strFName = sqlReader[dbUserEnity.FNAME.ToString()].ToString(),
                            strLName = sqlReader[dbUserEnity.LNAME.ToString()].ToString(),
                            dtDOB = Convert.ToDateTime(sqlReader[dbUserEnity.DOB.ToString()]),
                            strGender = sqlReader[dbUserEnity.GENDER.ToString()].ToString(),
                            intStatus = Convert.ToInt32(sqlReader[dbUserEnity.STATUS.ToString()]),
                            strMobile = sqlReader[dbUserEnity.MOBILE.ToString()].ToString(),
                            strCreatedUser =UtilCipher.Encrypt( sqlReader[dbUserEnity.CreatedUser.ToString()].ToString()),
                            StrAccountNo = sqlReader[dbUserAccount.ACCOUNTNO.ToString()].ToString(),
                            DtCreateDate = Convert.ToDateTime(sqlReader[dbUserEnity.CreatedDate.ToString()])
                        };
                        objUserAccountDetailList.Add(objUserAccountDetail);
                    }
                }
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
            return objUserAccountDetailList;
        }*/
    }
}
