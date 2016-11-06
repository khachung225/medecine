using System;

namespace DatabaseDAL.Entities
{
	public class Unit
	{

		#region InnerClass
		public enum UnitFields
		{
			UnitId,
			UnitShortName,
			UnitName,
			ActorChanged,
			TimeChanged
		}
		#endregion


		#region Properties

		public long  UnitId{ get; set; }
		public string  UnitShortName{ get; set; }
		public string  UnitName{ get; set; }
		public long  ActorChanged{ get; set; }
		public DateTime  TimeChanged{ get; set; }

		#endregion

	}
}
