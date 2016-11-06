using System.Collections.Generic;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class MedecineFactory
    {

        #region data Members

        MedecineSql _dataObject = null;

        #endregion

        #region Constructor

        public MedecineFactory()
        {
            _dataObject = new MedecineSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Medecine
        /// </summary>
        /// <param name="businessObject">Medecine object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Medecine businessObject)
        {
           return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Medecine
        /// </summary>
        /// <param name="businessObject">Medecine object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Medecine businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Medecine by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Medecine GetByPrimaryKey(long keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Medecines
        /// </summary>
        /// <returns>list</returns>
        public List<Medecine> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Medecine by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Medecine> GetAllBy(Medecine.MedecineFields fieldName, object value)
        {
            return _dataObject.SelectByField(fieldName.ToString(), value);  
        }

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(long keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete Medecine by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Medecine.MedecineFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
