using System.Collections.Generic;
using DatabaseDAL.DataLayer;
using DatabaseDAL.Entities;

namespace DatabaseDAL.DAO
{
    public class PresentationFactory
    {

        #region data Members

        PresentationSql _dataObject = null;

        #endregion

        #region Constructor

        public PresentationFactory()
        {
            _dataObject = new PresentationSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new Presentation
        /// </summary>
        /// <param name="businessObject">Presentation object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(Presentation businessObject)
        {
           return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing Presentation
        /// </summary>
        /// <param name="businessObject">Presentation object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(Presentation businessObject)
        {
            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get Presentation by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public Presentation GetByPrimaryKey(long keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all Presentations
        /// </summary>
        /// <returns>list</returns>
        public List<Presentation> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of Presentation by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<Presentation> GetAllBy(Presentation.PresentationFields fieldName, object value)
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
        /// delete Presentation by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(Presentation.PresentationFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
