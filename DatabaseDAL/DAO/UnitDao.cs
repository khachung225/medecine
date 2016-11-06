using System.Collections.Generic;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class UnitFactory
    {

        #region data Members

        UnitSql _dataObject = null;

        #endregion

        #region Constructor

        public UnitFactory()
        {
            _dataObject = new UnitSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Unit
        /// </summary>
        /// <param name="businessObject">Unit object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Unit businessObject)
        {
           return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Unit
        /// </summary>
        /// <param name="businessObject">Unit object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Unit businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Unit by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Unit GetByPrimaryKey(long keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Units
        /// </summary>
        /// <returns>list</returns>
        public List<Unit> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Unit by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Unit> GetAllBy(Unit.UnitFields fieldName, object value)
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
        /// delete Unit by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Unit.UnitFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
