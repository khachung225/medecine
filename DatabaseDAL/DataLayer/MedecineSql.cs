using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DataLayer
{
	/// <summary>
	/// Data access layer class for Medecine
	/// </summary>
	class MedecineSql : DataLayerBase 
	{

        #region Constructor

		/// <summary>
		/// Class constructor
		/// </summary>
		public MedecineSql()
		{
			// Nothing for now.
		}

        #endregion

        #region Public Methods

        /// <summary>
        /// insert new row in the table
        /// </summary>
		/// <param name="businessObject">business object</param>
		/// <returns>true of successfully insert</returns>
		public bool Insert(Medecine businessObject)
		{
			SqlCommand	sqlCommand = new SqlCommand();
			sqlCommand.CommandText = "dbo.[Medecine_Insert]";
			sqlCommand.CommandType = CommandType.StoredProcedure;

			// Use connection object of base class
			sqlCommand.Connection = MainConnection;

			try
			{
                
				sqlCommand.Parameters.Add(new SqlParameter("@MedecineId", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MedecineId));
				sqlCommand.Parameters.Add(new SqlParameter("@Medecine_ShorName", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Medecine_ShorName));
				sqlCommand.Parameters.Add(new SqlParameter("@Medecine_Name", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Medecine_Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Contain", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Contain));
				sqlCommand.Parameters.Add(new SqlParameter("@Used", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Used));
				sqlCommand.Parameters.Add(new SqlParameter("@Dosage_Children", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dosage_Children));
				sqlCommand.Parameters.Add(new SqlParameter("@Dosage_Adult", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dosage_Adult));
				sqlCommand.Parameters.Add(new SqlParameter("@IsBaby", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsBaby));
				sqlCommand.Parameters.Add(new SqlParameter("@Present_Id", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Present_Id));
				sqlCommand.Parameters.Add(new SqlParameter("@ActorChanged", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ActorChanged));
				sqlCommand.Parameters.Add(new SqlParameter("@TimeChanged", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TimeChanged));

								
				MainConnection.Open();
				
				sqlCommand.ExecuteNonQuery();
                
				return true;
			}
			catch(Exception ex)
			{				
				throw new Exception("Medecine::Insert::Error occured.", ex);
			}
			finally
			{			
				MainConnection.Close();
				sqlCommand.Dispose();
			}
		}

         /// <summary>
        /// update row in the table
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <returns>true for successfully updated</returns>
        public bool Update(Medecine businessObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Medecine_Update]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
				sqlCommand.Parameters.Add(new SqlParameter("@MedecineId", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.MedecineId));
				sqlCommand.Parameters.Add(new SqlParameter("@Medecine_ShorName", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Medecine_ShorName));
				sqlCommand.Parameters.Add(new SqlParameter("@Medecine_Name", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Medecine_Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Contain", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Contain));
				sqlCommand.Parameters.Add(new SqlParameter("@Used", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Used));
				sqlCommand.Parameters.Add(new SqlParameter("@Dosage_Children", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dosage_Children));
				sqlCommand.Parameters.Add(new SqlParameter("@Dosage_Adult", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Dosage_Adult));
				sqlCommand.Parameters.Add(new SqlParameter("@IsBaby", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsBaby));
				sqlCommand.Parameters.Add(new SqlParameter("@Present_Id", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Present_Id));
				sqlCommand.Parameters.Add(new SqlParameter("@ActorChanged", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ActorChanged));
				sqlCommand.Parameters.Add(new SqlParameter("@TimeChanged", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TimeChanged));

                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Medecine::Update::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Select by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>Medecine business object</returns>
        public Medecine SelectByPrimaryKey(long keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Medecine_SelectByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MedecineId", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys));

                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    Medecine businessObject = new Medecine();

                    PopulateBusinessObjectFromReader(businessObject, dataReader);

                    return businessObject;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Medecine::SelectByPrimaryKey::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select all rescords
        /// </summary>
        /// <returns>list of Medecine</returns>
        public List<Medecine> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Medecine_SelectAll]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {
                
                MainConnection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {                
                throw new Exception("Medecine::SelectAll::Error occured.", ex);
            }
            finally
            {
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Select records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>list of Medecine</returns>
        public List<Medecine> SelectByField(string fieldName, object value)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Medecine_SelectByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));

                MainConnection.Open();
                
                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectsFromReader(dataReader);

            }
            catch (Exception ex)
            {
                throw new Exception("Medecine::SelectByField::Error occured.", ex);
            }
            finally
            {

                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete by primary key
        /// </summary>
        /// <param name="keys">primary keys</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(long keys)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Medecine_DeleteByPrimaryKey]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

				sqlCommand.Parameters.Add(new SqlParameter("@MedecineId", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keys));


                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Medecine::DeleteByKey::Error occured.", ex);
            }
            finally
            {                
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        /// <summary>
        /// Delete records by field
        /// </summary>
        /// <param name="fieldName">name of field</param>
        /// <param name="value">value of field</param>
        /// <returns>true for successfully deleted</returns>
        public bool DeleteByField(string fieldName, object value)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "dbo.[Medecine_DeleteByField]";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class
            sqlCommand.Connection = MainConnection;

            try
            {

                sqlCommand.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                sqlCommand.Parameters.Add(new SqlParameter("@Value", value));
                
                MainConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {                
                throw new Exception("Medecine::DeleteByField::Error occured.", ex);
            }
            finally
            {             
                MainConnection.Close();
                sqlCommand.Dispose();
            }

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Populate business object from data reader
        /// </summary>
        /// <param name="businessObject">business object</param>
        /// <param name="dataReader">data reader</param>
        internal void PopulateBusinessObjectFromReader(Medecine businessObject, IDataReader dataReader)
        {


				businessObject.MedecineId = dataReader.GetInt64(dataReader.GetOrdinal(Medecine.MedecineFields.MedecineId.ToString()));

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Medecine_ShorName.ToString())))
				{
					businessObject.Medecine_ShorName = dataReader.GetString(dataReader.GetOrdinal(Medecine.MedecineFields.Medecine_ShorName.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Medecine_Name.ToString())))
				{
					businessObject.Medecine_Name = dataReader.GetString(dataReader.GetOrdinal(Medecine.MedecineFields.Medecine_Name.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Contain.ToString())))
				{
					businessObject.Contain = dataReader.GetString(dataReader.GetOrdinal(Medecine.MedecineFields.Contain.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Used.ToString())))
				{
					businessObject.Used = dataReader.GetString(dataReader.GetOrdinal(Medecine.MedecineFields.Used.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Dosage_Children.ToString())))
				{
					businessObject.Dosage_Children = dataReader.GetString(dataReader.GetOrdinal(Medecine.MedecineFields.Dosage_Children.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Dosage_Adult.ToString())))
				{
					businessObject.Dosage_Adult = dataReader.GetString(dataReader.GetOrdinal(Medecine.MedecineFields.Dosage_Adult.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.IsBaby.ToString())))
				{
					businessObject.IsBaby = dataReader.GetBoolean(dataReader.GetOrdinal(Medecine.MedecineFields.IsBaby.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.Present_Id.ToString())))
				{
					businessObject.Present_Id = dataReader.GetInt64(dataReader.GetOrdinal(Medecine.MedecineFields.Present_Id.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.ActorChanged.ToString())))
				{
					businessObject.ActorChanged = dataReader.GetInt64(dataReader.GetOrdinal(Medecine.MedecineFields.ActorChanged.ToString()));
				}

				if (!dataReader.IsDBNull(dataReader.GetOrdinal(Medecine.MedecineFields.TimeChanged.ToString())))
				{
					businessObject.TimeChanged = dataReader.GetDateTime(dataReader.GetOrdinal(Medecine.MedecineFields.TimeChanged.ToString()));
				}


        }

        /// <summary>
        /// Populate business objects from the data reader
        /// </summary>
        /// <param name="dataReader">data reader</param>
        /// <returns>list of Medecine</returns>
        internal List<Medecine> PopulateObjectsFromReader(IDataReader dataReader)
        {

            List<Medecine> list = new List<Medecine>();

            while (dataReader.Read())
            {
                Medecine businessObject = new Medecine();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;

        }

        #endregion

	}
}
