using System;

namespace SharpResume.Dateable
{
	public abstract class ADateable : IDateable
	{
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
	}
}