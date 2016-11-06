using System;

namespace DatabaseDAL.Entities
{
	public class Medecine
	{

		#region InnerClass
		public enum MedecineFields
		{
			MedecineId,
			Medecine_ShorName,
			Medecine_Name,
			Contain,
			Used,
			Dosage_Children,
			Dosage_Adult,
			IsBaby,
			Present_Id,
			ActorChanged,
			TimeChanged
		}
		#endregion


		#region Properties

		public long  MedecineId{ get; set; }
		public string  Medecine_ShorName{ get; set; }
		public string  Medecine_Name{ get; set; }
		public string  Contain{ get; set; }
		public string  Used{ get; set; }
		public string  Dosage_Children{ get; set; }
		public string  Dosage_Adult{ get; set; }
		public bool?  IsBaby{ get; set; }
		public long?  Present_Id{ get; set; }
		public long?  ActorChanged{ get; set; }
		public DateTime?  TimeChanged{ get; set; }

		#endregion

	}
}
