using System;

namespace DatabaseDAL.Entities
{
	public class Presentation
	{

		#region InnerClass
		public enum PresentationFields
		{
			PresentId,
			UnitL1,
			UnitL2,
			UnitL3,
			UnitL4,
			ActorChanged,
			TimeChanged
		}
		#endregion


		#region Properties

		public long  PresentId{ get; set; }
		public long?  UnitL1{ get; set; }
		public long?  UnitL2{ get; set; }
		public long?  UnitL3{ get; set; }
		public string  UnitL4{ get; set; }
		public long?  ActorChanged{ get; set; }
		public DateTime?  TimeChanged{ get; set; }

		#endregion

	}
}
