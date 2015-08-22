using System;

namespace SharpResume.Model
{
	public class Publication
	{
		public string Name { get; set; }
		public string Publisher { get; set; }
		public DateTime Release { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }
	}
}