using System;

namespace SharpResume.Dateable
{
	public interface IDateable
	{
		DateTime Start { get; set; }
		DateTime End { get; set; }
	}
}