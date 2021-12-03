using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace PrjMoneyLoans
{
    public class DBLConMoney
    {

       
SqlConnection Sqlcon = new SqlConnection();
#region Connection
        public DBLConMoney()
        {
             Sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["DBMoneyLoanConnectionString"].ConnectionString;

            try
            {
                Sqlcon.Open();
            }

            catch
            {
                ClsSessionLoan.ErrorMessages();
            }

        }
        private void CheckSqlCon(ref SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch
            {
                ClsSessionLoan.ErrorMessages();
            }
        }

#endregion
  //========================================================================
#region Depositors
        public DataTable GetDepositors(int Depositorid = 0, string DepositorName = null,
                                                            string phone = null,
                                                            string Address = null,
                                                            string OtherPhone = null,
                                                            string Notes = null)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;

            Chkpreviliges.CommandText = "GetDepositors_loan";

            SqlParameter param = new SqlParameter("@Depositorid", SqlDbType.Int);
            param.Value = Depositorid;
            Chkpreviliges.Parameters.Add(param);

            param = new SqlParameter("@DepositorName", SqlDbType.NVarChar);
            param.Value = DepositorName;
            Chkpreviliges.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar);
            param.Value = phone;
            Chkpreviliges.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar);
            param.Value = Address;
            Chkpreviliges.Parameters.Add(param);

            param = new SqlParameter("@OtherPhone", SqlDbType.NVarChar);
            param.Value = OtherPhone;
            Chkpreviliges.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            Chkpreviliges.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
          //========================================================================
        public void SaveDepositorsInfo(int DepositorID, string DepositorName, string phone, string Address,string OtherPhone, string Notes)
        {
             SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;
 
            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveDepositorsInfo_loan";

            SqlParameter param = new SqlParameter("@DepositorID", SqlDbType.Int);                   
            param.Value = DepositorID;                                                              
            chkusr.Parameters.Add(param);                                                           	
            //  @Address			                                                                
            param = new SqlParameter("@DepositorName", SqlDbType.NVarChar);                         
            param.Value = DepositorName;                                                            
            chkusr.Parameters.Add(param);                                                           	
            // @NationalityId		

            param = new SqlParameter("@phone", SqlDbType.NVarChar);
            param.Value = phone;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@Address", SqlDbType.NVarChar);
            param.Value = Address;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@OtherPhone", SqlDbType.NVarChar);
            param.Value = OtherPhone;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
          }

        //========================================================================
        public DataTable DeleteDepositor(int DepositorID)
        {
            DataTable dtresult = new DataTable();

            SqlCommand DelMajor = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteDepositor_loan";

            SqlParameter param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

 //========================================================================

        public DataTable GetDepositorMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetDepositorMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
#endregion
//##################################################
#region  lookupTables
         //===========================
        public DataTable GetLkupTableNames(int LookUpTableId = 0, string LookUpTableName=null)
        {


            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetLkupTableNames_loan";

            DataTable dtResult = new DataTable();

            SqlParameter param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
            param.Value = LookUpTableId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@LookUpTableName", SqlDbType.NVarChar);
            param.Value = LookUpTableName;
            chkusr.Parameters.Add(param);
          
            
            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        //===========================

        public DataTable GetLkupValues(int ValueMember = 0, string DisplayMember = null, int LookUpTableId = -1)
        {
            DataTable dtresult = new DataTable();
            try
            {


                SqlCommand Employees = new SqlCommand();

                CheckSqlCon(ref Sqlcon);
                Employees.Connection = Sqlcon;

                Employees.CommandType = CommandType.StoredProcedure;
                Employees.CommandText = "GetLkupValues_loan";


                SqlParameter param = new SqlParameter("@ValueMember", SqlDbType.Int);
                param.Value = ValueMember;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@DisplayMember", SqlDbType.NVarChar);
                param.Value = DisplayMember;
                Employees.Parameters.Add(param);



                param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
                param.Value = LookUpTableId;
                Employees.Parameters.Add(param);

                SqlDataAdapter adtr = new SqlDataAdapter(Employees);

                adtr.Fill(dtresult);


                Sqlcon.Close();
            }
            catch
            {


            }

            return dtresult;
        }
        public DataTable SaveLkupValues(int ValueMember, string DisplayMember, int LookUpTableId)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Employees = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            Employees.Connection = Sqlcon;

            Employees.CommandType = CommandType.StoredProcedure;
            Employees.CommandText = "SaveLkupValues_loan";


            SqlParameter param = new SqlParameter("@ValueMember", SqlDbType.Int);
            param.Value = ValueMember;
            Employees.Parameters.Add(param);

            param = new SqlParameter("@DisplayMember", SqlDbType.NVarChar);
            param.Value = DisplayMember;
            Employees.Parameters.Add(param);


            param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
            param.Value = LookUpTableId;
            Employees.Parameters.Add(param);


            SqlDataAdapter adtr = new SqlDataAdapter(Employees);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        public DataTable DeleteLkupValues(int ValueMember, int LookUpTableId)
        {
            DataTable dtresult = new DataTable();

            SqlCommand DelMajor = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteLkupValues_loan";

            SqlParameter param = new SqlParameter("@ValueMember", SqlDbType.Int);
            param.Value = ValueMember;
            DelMajor.Parameters.Add(param);


            param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
            param.Value = LookUpTableId;
            DelMajor.Parameters.Add(param);


            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        public DataTable GetLkupValuesMaxNo(int LookUpTableId)
        {


            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetLkupValuesMaxNo_loan";



            SqlParameter param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
            param.Value = LookUpTableId;
            chkusr.Parameters.Add(param);



            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
#endregion
        //##################################################

#region LkupTblNames
         public DataTable DeleteLookUpTable(int LookUpTableId)
                {
                    DataTable dtresult = new DataTable();

                    SqlCommand DelMajor = new SqlCommand();
                    CheckSqlCon(ref Sqlcon);
                    DelMajor.Connection = Sqlcon;

                    DelMajor.CommandType = CommandType.StoredProcedure;

                    DelMajor.CommandText = "DeleteLkupTableNames_loan";

                    SqlParameter param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
                    param.Value = LookUpTableId;
                    DelMajor.Parameters.Add(param);

                    SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

                    adtr.Fill(dtresult);

                    Sqlcon.Close();

                    return dtresult;
                }
         public DataTable GetLookUpTableMaxNo( )
                {
                    //GetHalqaMaxNo

                    SqlCommand chkusr = new SqlCommand();
                    CheckSqlCon(ref Sqlcon);
                    chkusr.Connection = Sqlcon;

                    chkusr.CommandType = CommandType.StoredProcedure;

                    chkusr.CommandText = "GetLookUpTableMaxNo_loan";

                    DataTable dtResult = new DataTable();

        
                    SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

                    adtr.Fill(dtResult);

                    Sqlcon.Close();

                    return dtResult;
                }
         public DataTable SaveLkupTblNames(int LookUpTableId, string LookUpTableName, string LookUpTableNameArb, string DisplayMember, string ValueMember)
                {

                    DataTable dtresult = new DataTable();
                    SqlCommand chkusr = new SqlCommand();
                    CheckSqlCon(ref Sqlcon);
                    chkusr.Connection = Sqlcon;
                    //Savesubject

                    chkusr.CommandType = CommandType.StoredProcedure;

                    chkusr.CommandText = "SaveLookupTable_loan";

                    SqlParameter param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
                    param.Value = LookUpTableId;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@LookUpTableName", SqlDbType.NVarChar);
                    param.Value = LookUpTableName;
                    chkusr.Parameters.Add(param);
           
                    param = new SqlParameter("@LookUpTableNameArb", SqlDbType.NVarChar);
                    param.Value = LookUpTableNameArb;
                    chkusr.Parameters.Add(param);


                    param = new SqlParameter("@DisplayMember", SqlDbType.NVarChar);
                    param.Value = DisplayMember;
                    chkusr.Parameters.Add(param);


                    param = new SqlParameter("@ValueMember", SqlDbType.NVarChar);
                    param.Value = ValueMember;
                    chkusr.Parameters.Add(param);

                    SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

                    adtr.Fill(dtresult);

                    Sqlcon.Close();

                    return dtresult;



                }
         public DataTable GetLkupTableNames(int LookUpTableId)
                {
                    DataTable dtresult = new DataTable();

                    SqlCommand Employees = new SqlCommand();

                    CheckSqlCon(ref Sqlcon);
                    Employees.Connection = Sqlcon;

                    Employees.CommandType = CommandType.StoredProcedure;
                    Employees.CommandText = "GetLkupTableNames_loan";

                    SqlParameter param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
                    param.Value = LookUpTableId;
                    Employees.Parameters.Add(param);
 
                    SqlDataAdapter adtr = new SqlDataAdapter(Employees);

                    adtr.Fill(dtresult);

                    Sqlcon.Close();

                    return dtresult;
                }
    #endregion
        //##################################################
#region Nationality
        //=========================
        public DataTable DeleteNationality(int Nationalityid)
        {
            DataTable dtresult = new DataTable();

            SqlCommand DelMajor = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteNationality_loan";

            SqlParameter param = new SqlParameter("@Nationalityid", SqlDbType.Int);
            param.Value = Nationalityid;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        public DataTable SaveNationality(int Nationalityid, string Nationality,   int DocTypeId = 0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Employees = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            Employees.Connection = Sqlcon;

            Employees.CommandType = CommandType.StoredProcedure;
            Employees.CommandText = "SaveNationality_loan";

            SqlParameter param = new SqlParameter("@Nationalityid", SqlDbType.Int);
            param.Value = Nationalityid;
            Employees.Parameters.Add(param);

            param = new SqlParameter("@Nationality", SqlDbType.NVarChar);
            param.Value = Nationality;
            Employees.Parameters.Add(param);

 

            param = new SqlParameter("@DocTypeId", SqlDbType.Int);
            param.Value = DocTypeId;
            Employees.Parameters.Add(param);


            SqlDataAdapter adtr = new SqlDataAdapter(Employees);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //===================================

        public DataTable GetNationality(int Nationalityid = 0, string Nationality = "" )
        {
            DataTable dtresult = new DataTable();

            SqlCommand Employees = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            Employees.Connection = Sqlcon;

            Employees.CommandType = CommandType.StoredProcedure;
            Employees.CommandText = "GetNationality_loan";


            SqlParameter param = new SqlParameter("@Nationalityid", SqlDbType.Int);
            param.Value = Nationalityid;
            Employees.Parameters.Add(param);

            param = new SqlParameter("@Nationality", SqlDbType.NVarChar);
            param.Value = Nationality.Trim();
            Employees.Parameters.Add(param);


           
            SqlDataAdapter adtr = new SqlDataAdapter(Employees);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }


        public DataTable GetNationalityMaxNo()
        {


            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetNationalityMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
 
        #endregion

//##################################################
#region Accounts
        public DataTable GetAccounts(int AccountId = 0, int PersonId = 0, DateTime? RegisterDate = null,  int AccountStatusId = 0, string phone = null, string OtherPhone = null, int CityId = 0, string District = null, string Address = null, string Notes = null, string PersonName=null)
        {
            DataTable dtresult = new DataTable();
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;
            chkusr.CommandText = "GetAccounts_loan";

            SqlParameter param = new SqlParameter("@AccountId", SqlDbType.Int);
            param.Value = AccountId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PersonId", SqlDbType.Int);
            param.Value = PersonId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@RegisterDate", SqlDbType.DateTime);
            param.Value = RegisterDate;
            chkusr.Parameters.Add(param);
  
            //  @AccountStatusId	
            param = new SqlParameter("@AccountStatusId", SqlDbType.Int);
            param.Value = AccountStatusId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar);
            param.Value = phone;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@OtherPhone", SqlDbType.NVarChar);
            param.Value = OtherPhone;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@CityId", SqlDbType.Int );
            param.Value = CityId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@District", SqlDbType.NVarChar);
            param.Value = District;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar);
            param.Value = Address;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PersonName", SqlDbType.NVarChar);
            param.Value = PersonName;
            chkusr.Parameters.Add(param);
 
            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //========================================================================

        
        public DataTable SaveAccounts(int AccountId, int PersonId, DateTime RegisterDate, int AccountStatusId, string phone, string OtherPhone, int CityId, string District, string Address ,string Notes)
        {
            
            DataTable dtresult = new DataTable();
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;
 
            chkusr.CommandType = CommandType.StoredProcedure;
             chkusr.CommandText = "SaveAccounts_loan";

            SqlParameter param = new SqlParameter("@AccountId", SqlDbType.Int);   
            param.Value = AccountId;                                              
            chkusr.Parameters.Add(param);                                         	

            param = new SqlParameter("@PersonId", SqlDbType.Int);                 
            param.Value = PersonId;                                               
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@RegisterDate", SqlDbType.DateTime );       
            param.Value = RegisterDate;                                           	
            chkusr.Parameters.Add(param);
  
          
            //  @AccountStatusId	
            param = new SqlParameter("@AccountStatusId", SqlDbType.Int);
            param.Value = AccountStatusId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar);
            param.Value = phone;
            chkusr.Parameters.Add(param);
 
             param = new SqlParameter("@OtherPhone", SqlDbType.NVarChar);
            param.Value = OtherPhone;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@CityId", SqlDbType.Int);
            param.Value = CityId;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@District", SqlDbType.NVarChar);
            param.Value = District;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar);
            param.Value = Address;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
         }
         //========================================================================
        public DataTable DeleteAccount(int AccountId)
        {
            DataTable dtresult = new DataTable();
            SqlCommand DelMajor = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteAccount_loan";

            SqlParameter param = new SqlParameter("@AccountId", SqlDbType.Int);
            param.Value = AccountId;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //========================================================================

        public DataTable GetAccountsMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetAccountsMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        #endregion
        //##################################################
    #region Persons
        public DataTable GetPersonsMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetPersonsMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        //========================================
        public DataTable SavePersons(int PersonId = 0, string PersonName = null, DateTime? BithDate = null, string PlaceOfBirth = null, string DocId = null, int GenderId = 0, string Job = null, int NationalityId = 0,  int MaritalStatusId = 0, int QualificationID = 0, int HealthStatusId = 0, int StudyStageId = 0, int AccountId = 0, int PersonStatusId=0,string Notes=null)
        {

            DataTable dtresult = new DataTable();
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;
            chkusr.CommandText = "SavePersons_loan";

            SqlParameter param = new SqlParameter("@PersonId", SqlDbType.Int);
            param.Value = PersonId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PersonName", SqlDbType.NVarChar );
            param.Value = PersonName;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@BithDate", SqlDbType.DateTime);
            param.Value = BithDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PlaceOfBirth", SqlDbType.NVarChar);
            param.Value = PlaceOfBirth;
            chkusr.Parameters.Add(param);

             param = new SqlParameter("@DocId", SqlDbType.NVarChar);
            param.Value = DocId;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@GenderId", SqlDbType.Int);
            param.Value = GenderId;
            chkusr.Parameters.Add(param);

             param = new SqlParameter("@Job", SqlDbType.NVarChar);
            param.Value = Job;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@NationalityId", SqlDbType.Int );
            param.Value = NationalityId;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@MaritalStatusId", SqlDbType.Int);
            param.Value = MaritalStatusId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@QualificationID", SqlDbType.Int);
            param.Value = QualificationID;
            chkusr.Parameters.Add(param);

   
            param = new SqlParameter("@HealthStatusId", SqlDbType.Int);
            param.Value = HealthStatusId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@StudyStageId", SqlDbType.Int);
            param.Value = StudyStageId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountId", SqlDbType.Int);
            param.Value = AccountId;
            chkusr.Parameters.Add(param);


            param = new SqlParameter("@PersonStatusId", SqlDbType.Int);
            param.Value = PersonStatusId;
            chkusr.Parameters.Add(param);



            param = new SqlParameter("@Notes", SqlDbType.NVarChar );
            param.Value = Notes;
            chkusr.Parameters.Add(param);
 
 
            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
         //===================================
        public DataTable GetPersons(int PersonId = 0, string PersonName = null, DateTime? BithDate = null, string PlaceOfBirth = null, string DocId = null, int GenderId = 0, string Job = null, int NationalityId = 0,  int MaritalStatusId = 0, int QualificationID = 0, int HealthStatusId = 0, int StudyStageId = 0, int AccountId = 0, int PersonStatusId=0, string Notes=null)
        {
            DataTable dtresult = new DataTable();
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;
            chkusr.CommandText = "GetPersons_loan";

            SqlParameter param = new SqlParameter("@PersonId", SqlDbType.Int);
            param.Value = PersonId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PersonName", SqlDbType.NVarChar);
            param.Value = PersonName;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@BithDate", SqlDbType.DateTime);
            param.Value = BithDate;
            chkusr.Parameters.Add(param);

            //  @AccountTypeId			
            param = new SqlParameter("@PlaceOfBirth", SqlDbType.NVarChar);
            param.Value = PlaceOfBirth;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DocId", SqlDbType.NVarChar);
            param.Value = DocId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@GenderId", SqlDbType.Int);
            param.Value = GenderId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Job", SqlDbType.NVarChar);
            param.Value = Job;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@NationalityId", SqlDbType.Int);
            param.Value = NationalityId;
            chkusr.Parameters.Add(param);
             
            param = new SqlParameter("@MaritalStatusId", SqlDbType.Int);
            param.Value = MaritalStatusId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@QualificationID", SqlDbType.Int);
            param.Value = QualificationID;
            chkusr.Parameters.Add(param);

            
            param = new SqlParameter("@HealthStatusId", SqlDbType.Int);
            param.Value = HealthStatusId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@StudyStageId", SqlDbType.Int);
            param.Value = StudyStageId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountId", SqlDbType.Int);
            param.Value = AccountId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PersonStatusId", SqlDbType.Int);
            param.Value = PersonStatusId;
            chkusr.Parameters.Add(param);
            
            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
 
        public DataTable DeletePerson(int PersonId)
        {
            DataTable dtresult = new DataTable();
            SqlCommand DelMajor = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeletePerson_loan";

            SqlParameter param = new SqlParameter("@PersonId", SqlDbType.Int);
            param.Value = PersonId;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
       #endregion



        #region Users

        //##################################################

        public DataTable GetUsers(string username = null, string Pwd = null)
        {

            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);

            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;
            chkusr.CommandText = "GetUsers_loan";

            SqlParameter param = new SqlParameter("@username", SqlDbType.NVarChar);
            param.Value = username;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Pwd", SqlDbType.NVarChar);
            param.Value = Pwd;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

//##################################################
        #endregion users


        //##################################################e
#region DATAEntryLkupValues_loan
        public DataTable GEtDATAEntryLkupValues(int ItemId = 0, int AccountId = 0,int LookUpTableId = -1,int ValueMember = 0, string TxtValue=null, bool ChkValue=false, int SelectedValue=0, int ValueTypeId=0)
        {
            DataTable dtresult = new DataTable();
            try
            {
 
                SqlCommand Employees = new SqlCommand();

                CheckSqlCon(ref Sqlcon);
                Employees.Connection = Sqlcon;

                Employees.CommandType = CommandType.StoredProcedure;
                Employees.CommandText = "GEtDATAEntryLkupValues_loan";
 
                SqlParameter param = new SqlParameter("@ItemId", SqlDbType.Int);
                param.Value = ItemId;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@AccountId", SqlDbType.Int);
                param.Value = AccountId;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
                param.Value = LookUpTableId;
                Employees.Parameters.Add(param);
                
 
                param = new SqlParameter("@ValueMember", SqlDbType.Int);
                param.Value = ValueMember;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@TxtValue", SqlDbType.NVarChar);
                param.Value = TxtValue;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@ChkValue", SqlDbType.Bit);
                param.Value = ChkValue;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@SelectedValue", SqlDbType.Int);
                param.Value = SelectedValue;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@ValueTypeId", SqlDbType.Int);
                param.Value = ValueTypeId;
                Employees.Parameters.Add(param);
 
                SqlDataAdapter adtr = new SqlDataAdapter(Employees);
                adtr.Fill(dtresult);


                Sqlcon.Close();
            }
            catch
            {


            }

            return dtresult;
        }

        public DataTable SaveDATAEntryLkupValues(int ItemId = 0, int AccountId = 0, int LookUpTableId = -1, int ValueMember = 0, string TxtValue = null, bool ChkValue = false, int SelectedValue = 0, int ValueTypeId = 0)
        {
            DataTable dtresult = new DataTable();
            try
            {
                 SqlCommand Employees = new SqlCommand();

                CheckSqlCon(ref Sqlcon);
                Employees.Connection = Sqlcon;

                Employees.CommandType = CommandType.StoredProcedure;
                Employees.CommandText = "SaveDATAEntryLkupValues_loan";

                SqlParameter param = new SqlParameter("@ItemId", SqlDbType.Int);
                param.Value = ItemId;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@AccountId", SqlDbType.Int);
                param.Value = AccountId;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@LookUpTableId", SqlDbType.Int);
                param.Value = LookUpTableId;
                Employees.Parameters.Add(param);


                param = new SqlParameter("@ValueMember", SqlDbType.Int);
                param.Value = ValueMember;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@TxtValue", SqlDbType.NVarChar);
                param.Value = TxtValue;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@ChkValue", SqlDbType.Bit );
                param.Value = ChkValue;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@SelectedValue", SqlDbType.Int);
                param.Value = SelectedValue;
                Employees.Parameters.Add(param);

                param = new SqlParameter("@ValueTypeId", SqlDbType.Int);
                param.Value = ValueTypeId;
                Employees.Parameters.Add(param);

                SqlDataAdapter adtr = new SqlDataAdapter(Employees);
                adtr.Fill(dtresult);


                Sqlcon.Close();
            }
            catch
            {


            }

            return dtresult;
        }

        #endregion
        //##################################################

        #region Cash
        public DataTable GetCash(int EntryId=0, int DepositorID=0, DateTime? EntryDate=null, Decimal Cash=0, string Notes=null, int DepositTypeId=0, int OptFinanceYearId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetCash_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);
 
            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Cash", SqlDbType.Decimal);
            param.Value = Cash;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@OptFinanceYearId", SqlDbType.Int);
            param.Value = OptFinanceYearId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        //========================================================================
        public void SaveCash(int EntryId, int DepositorID, DateTime EntryDate, Decimal Cash, string Notes, int DepositTypeId=0)
        {
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveCash_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);


            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime );
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@Cash", SqlDbType.Decimal);
            param.Value = Cash;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
        }

        //========================================================================
        public DataTable ChkUpdateCashAmount(int EntryId, int DepositorID, DateTime EntryDate, Decimal Cash,  int DepositTypeId=0, string Notes="")
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "ChkUpdateCashAmount_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);


            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime );
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@Cash", SqlDbType.Decimal);
            param.Value = Cash;
            chkusr.Parameters.Add(param);

          
            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
 //========================================================================
         public void SaveCashTransAction_loan(int EntryId, int DepositorID, DateTime EntryDate, Decimal Cash, int DepositTypeId=0, int CashProcessId=0)
        {
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveCashTransAction_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);

            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime );
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@Cash", SqlDbType.Decimal);
            param.Value = Cash;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@CashProcessId", SqlDbType.Int);
            param.Value = CashProcessId;
            chkusr.Parameters.Add(param);

            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
        }
         //-----------------------

        public void SaveCashLogger(int CashEntryId,  int DepositorID, DateTime EntryDate, Decimal Cash, int DepositTypeId = 0, int CashProcessId = 0)
        {
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveCashLogger_loan";

            SqlParameter param = new SqlParameter("@CashEntryId", SqlDbType.Int);
            param.Value = CashEntryId;
            chkusr.Parameters.Add(param);


            param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);

            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Cash", SqlDbType.Decimal);
            param.Value = Cash;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@CashProcessId", SqlDbType.Int);
            param.Value = CashProcessId;
            chkusr.Parameters.Add(param);

            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
        }


        //

        //======================================================================== 

        public DataTable DeleteCash(int EntryId)
        {
            DataTable dtresult = new DataTable();

            SqlCommand DelMajor = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteCash_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //========================================================================
        public DataTable GetCashDepositType(int DepositorID=0, int DepositTypeId=0, DateTime? EntryDate = null)
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetCashDepositType_loan";

            SqlParameter param = new SqlParameter("@DepositorID", SqlDbType.Int);
            param.Value = DepositorID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);


            DataTable dtResult = new DataTable();
 
            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        //===============================================
        public DataTable GetCashBalance(int OptFinanceYearId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetCashBalance_loan";

            SqlParameter   param = new SqlParameter("@OptFinanceYearId", SqlDbType.Int);
            param.Value = OptFinanceYearId;
            chkusr.Parameters.Add(param);


           SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //===============================================

        public DataTable GetCashMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetCashMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        #endregion
        //===============================================
        //##################################################

        #region Loans

          public DataTable GetInstalmentCalc_loan(int LoanEntryId = 0)
                {
                    DataTable dtresult = new DataTable();

                    SqlCommand chkusr = new SqlCommand();
                    CheckSqlCon(ref Sqlcon);
                    chkusr.Connection = Sqlcon;

                    chkusr.CommandType = CommandType.StoredProcedure;

                    chkusr.CommandText = "GetInstalmentCalc_loan";

                    SqlParameter param = new SqlParameter("@LoanEntryId", SqlDbType.Int);
                    param.Value = LoanEntryId;
                    chkusr.Parameters.Add(param);
  
                    SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

                    adtr.Fill(dtresult);

                    Sqlcon.Close();

                    return dtresult;
                }



        public DataTable GetLoans(int EntryId = 0, int AccountID = 0, DateTime? EntryDate = null, Decimal LoanAmount = 0, string Notes = null, int OptRemainder=0, int OptFinanceYearId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetLoans_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);

            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@LoanAmount", SqlDbType.Decimal);
            param.Value = LoanAmount;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@OptRemainder", SqlDbType.Int);
            param.Value = OptRemainder;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@OptFinanceYearId", SqlDbType.Int);
            param.Value = OptFinanceYearId;
            chkusr.Parameters.Add(param);

 
            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        //========================================================================
          public DataTable GetLoanTransactions(int EntryId = 0, int AccountID = 0, int LoanEntryId=0, DateTime? EntryDate = null, Decimal LoanAmount = 0, string Notes = null, int OptRemainder=0, int PaymentEntryId = 0)
                {
                    DataTable dtresult = new DataTable();

                    SqlCommand chkusr = new SqlCommand();
                    CheckSqlCon(ref Sqlcon);
                    chkusr.Connection = Sqlcon;

                    chkusr.CommandType = CommandType.StoredProcedure;

                    chkusr.CommandText = "GetLoanTransActions_loan";

                    SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
                    param.Value = EntryId;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@AccountID", SqlDbType.Int);
                    param.Value = AccountID;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@LoanEntryId", SqlDbType.Int);
                    param.Value = LoanEntryId;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@PaymentEntryId", SqlDbType.Int);
                    param.Value = PaymentEntryId;
                    chkusr.Parameters.Add(param);
  
                    //  @EntryDate			                                                                
                    param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
                    param.Value = EntryDate;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@LoanAmount", SqlDbType.Decimal);
                    param.Value = LoanAmount;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@Notes", SqlDbType.NVarChar);
                    param.Value = Notes;
                    chkusr.Parameters.Add(param);

                    param = new SqlParameter("@OptRemainder", SqlDbType.Int);
                    param.Value = OptRemainder;
                    chkusr.Parameters.Add(param);
 
                    SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

                    adtr.Fill(dtresult);

                    Sqlcon.Close();

                    return dtresult;
                }
                //========================================================================
        public void SaveLoans(int EntryId, int AccountID, DateTime EntryDate, Decimal LoanAmount, string Notes, decimal InstalmentAmount=0, int InstalmentCalcId=0, int Period=0, int RepayWayId=0, int DepositTypeId=0)
        {
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveLoans_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);

            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@LoanAmount", SqlDbType.Decimal);
            param.Value = LoanAmount;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

//--------------------------------------------
            param = new SqlParameter("@InstalmentAmount", SqlDbType.Decimal);
            param.Value = InstalmentAmount;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@InstalmentCalcId", SqlDbType.Int);
            param.Value = InstalmentCalcId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Period", SqlDbType.Int);
            param.Value = Period;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@RepayWayId", SqlDbType.Int);
            param.Value = RepayWayId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);



            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
        }
        public void SaveLoans_UpdInstalment(int EntryId, int AccountID, Decimal LastInstallment, Decimal Remainder, DateTime? EntryDate=null, int PaymentEntryId = 0)
        {
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveLoans_UpdInstalment_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int); ///---loanEntryId
            param.Value = EntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PaymentEntryId", SqlDbType.Int);
            param.Value = PaymentEntryId;
            chkusr.Parameters.Add(param);
              
            param = new SqlParameter("@LastInstallment", SqlDbType.Decimal);
            param.Value = LastInstallment;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Remainder", SqlDbType.Decimal);
            param.Value = Remainder;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);


            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
        }

        //========================================================================
        public DataTable DeleteLoans(int EntryId)
        {
            DataTable dtresult = new DataTable();

            SqlCommand DelMajor = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteLoans_loan";

            SqlParameter param = new SqlParameter("@EntryId", SqlDbType.Int);
            param.Value = EntryId;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //========================================================================

        public DataTable GetLoansMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetLoansMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        #endregion
        //===============================================
        //##################################################

        //#########################################################
        #region Instalments
        public DataTable GetInstalments(int InstalmentEntryId = 0, int LoanEntryId=0, int AccountID = 0,  Decimal InstalmentAmount = 0M,   int OptRemainder = 0,  int PaymentEntryId=0, int OptFinanceYearId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetInstalments_loan";

            SqlParameter param = new SqlParameter("@InstalmentEntryId", SqlDbType.Int);
            param.Value = InstalmentEntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@LoanEntryId", SqlDbType.Int);
            param.Value = LoanEntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@InstalmentAmount", SqlDbType.Decimal);
            param.Value = InstalmentAmount;
            chkusr.Parameters.Add(param);

            
            param = new SqlParameter("@OptRemainder", SqlDbType.Int);
            param.Value = OptRemainder;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@OptFinanceYearId", SqlDbType.Int);
            param.Value = OptFinanceYearId;
            chkusr.Parameters.Add(param);



             param = new SqlParameter("@PaymentEntryId", SqlDbType.Int);
            param.Value = PaymentEntryId;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        //========================================================================
        public void SaveInstalments(int InstalmentEntryId=0, int LoanEntryId = 0, int AccountID=0,  Decimal InstalmentAmount=0M, int PaymentEntryId=0)
        {
            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SaveInstalments_loan";

            SqlParameter param = new SqlParameter("@InstalmentEntryId", SqlDbType.Int);
            param.Value = InstalmentEntryId;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@LoanEntryId", SqlDbType.Int);
            param.Value = LoanEntryId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);
             
            param = new SqlParameter("@InstalmentAmount", SqlDbType.Decimal);
            param.Value = InstalmentAmount;
            chkusr.Parameters.Add(param);
 
            param = new SqlParameter("@PaymentEntryId", SqlDbType.Int);
            param.Value = PaymentEntryId;
            chkusr.Parameters.Add(param);

            chkusr.ExecuteNonQuery();

            Sqlcon.Close();
        }

        //========================================================================
        public DataTable DeleteInstalments(int InstalmentEntryId)
        {
            DataTable dtresult = new DataTable();

            SqlCommand DelMajor = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            DelMajor.Connection = Sqlcon;

            DelMajor.CommandType = CommandType.StoredProcedure;

            DelMajor.CommandText = "DeleteInstalments_loan";

            SqlParameter param = new SqlParameter("@InstalmentEntryId", SqlDbType.Int);
            param.Value = InstalmentEntryId;
            DelMajor.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(DelMajor);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }

        //========================================================================

        public DataTable GetInstalmentsMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetInstalmentsMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
        #endregion
        //===============================================
        public DataTable SavePaymentAmount(int PaymentEntryId=0, int AccountID=0, DateTime? EntryDate=null, Decimal PaymentAmount = 0M, string Notes=null, int PaymentWayId=0, string ChequeNo=null, DateTime? ChequeDate=null, string BankName=null, int DepositTypeId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "SavePaymentAmount_loan";

            SqlParameter param = new SqlParameter("@PaymentEntryId", SqlDbType.Int);
            param.Value = PaymentEntryId;
            chkusr.Parameters.Add(param);
            
            param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);

            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PaymentAmount", SqlDbType.Decimal);
            param.Value = PaymentAmount;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PaymentWayId", SqlDbType.Int);
            param.Value = PaymentWayId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@ChequeNo", SqlDbType.NVarChar);
            param.Value = ChequeNo;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@ChequeDate", SqlDbType.DateTime);
            param.Value = ChequeDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@BankName", SqlDbType.NVarChar);
            param.Value = BankName;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            chkusr.Parameters.Add(param);

 
            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        //===============================================

        public DataTable GetPaymentAmount(int PaymentEntryId=0, int LoanEntryId= 0, int AccountID = 0, DateTime? EntryDate = null, Decimal PaymentAmount = 0M, string Notes = null, int PaymentWayId = 0, string ChequeNo = null, DateTime? ChequeDate = null, string BankName = null, int OptRemainder = 0, int OptFinanceYearId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand chkusr = new SqlCommand();

            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetPaymentAmount_loan";

            SqlParameter param = new SqlParameter("@PaymentEntryId", SqlDbType.Int);
            param.Value = PaymentEntryId;
            chkusr.Parameters.Add(param);

           param = new SqlParameter("@AccountID", SqlDbType.Int);
            param.Value = AccountID;
            chkusr.Parameters.Add(param);

            //  @EntryDate			                                                                
            param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PaymentAmount", SqlDbType.Decimal);
            param.Value = PaymentAmount;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@Notes", SqlDbType.NVarChar);
            param.Value = Notes;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@PaymentWayId", SqlDbType.Int);
            param.Value = PaymentWayId;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@LoanEntryId", SqlDbType.Int);
            param.Value = LoanEntryId;
            chkusr.Parameters.Add(param);



            param = new SqlParameter("@ChequeNo", SqlDbType.NVarChar);
            param.Value = ChequeNo;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@ChequeDate", SqlDbType.DateTime);
            param.Value = ChequeDate;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@BankName", SqlDbType.NVarChar);
            param.Value = BankName;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@OptRemainder", SqlDbType.Int);
            param.Value = OptRemainder;
            chkusr.Parameters.Add(param);

            param = new SqlParameter("@OptFinanceYearId", SqlDbType.Int);
            param.Value = OptFinanceYearId;
            chkusr.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
        }
        public DataTable GetPaymentsMaxNo()
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;

            chkusr.CommandText = "GetPaymentsMaxNo_loan";

            DataTable dtResult = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }

        //##################################################

        public DataTable GetPaymentWay()
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;

            Chkpreviliges.CommandText = "GetPaymentWay_loan";

            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;


        }
        //##################################################
       public DataTable GetNetCashBalance(int DepositTypeId=0)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;

            Chkpreviliges.CommandText = "GetNetCashBalance_loan";


            SqlParameter param = new SqlParameter("@DepositTypeId", SqlDbType.Int);
            param.Value = DepositTypeId;
            Chkpreviliges.Parameters.Add(param);
 
            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);
              
            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;


        }
        //##################################################

        public DataTable ChkCashDate(DateTime? EntryDate=null)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;

            Chkpreviliges.CommandText = "ChkCashDate_Loan";
 
            SqlParameter param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            Chkpreviliges.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
         }
        //##################################################
       public DataTable ChkLoanDate(DateTime? EntryDate=null)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;

            Chkpreviliges.CommandText = "ChkLoanDate_Loan";
 
            SqlParameter param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            Chkpreviliges.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
         }
        //##################################################
    public DataTable ChkInstalmentDate(DateTime? EntryDate=null)
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;

            Chkpreviliges.CommandText = "ChkInstalmentDate_Loan";
 
            SqlParameter param = new SqlParameter("@EntryDate", SqlDbType.DateTime);
            param.Value = EntryDate;
            Chkpreviliges.Parameters.Add(param);

            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
         }
        //##################################################

        public DataTable CheckNewFinanceYear()
        {
            DataTable dtresult = new DataTable();

            SqlCommand Chkpreviliges = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            Chkpreviliges.Connection = Sqlcon;

            Chkpreviliges.CommandType = CommandType.StoredProcedure;
            Chkpreviliges.CommandText = "CheckNewFinanceYear_loan";
  
            SqlDataAdapter adtr = new SqlDataAdapter(Chkpreviliges);

            adtr.Fill(dtresult);

            Sqlcon.Close();

            return dtresult;
         }
        //=========================================================
        //##################################################

        public DataTable GetTitle(string TitleName="")
        {
            SqlCommand chkusr = new SqlCommand();
            CheckSqlCon(ref Sqlcon);
            chkusr.Connection = Sqlcon;

            chkusr.CommandType = CommandType.StoredProcedure;
            chkusr.CommandText = "GetTitle_loan";
 
            SqlParameter param = new SqlParameter("@TitleName", SqlDbType.NVarChar);
            param.Value = TitleName;
            chkusr.Parameters.Add(param);
 
            DataTable dtResult = new DataTable();

            SqlDataAdapter adtr = new SqlDataAdapter(chkusr);

            adtr.Fill(dtResult);

            Sqlcon.Close();

            return dtResult;
        }
         //##################################################


    }

}





 