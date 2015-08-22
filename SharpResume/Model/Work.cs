using SharpResume.Dateable;

namespace SharpResume.Model
{
	public class Work : ADateable
	{
		public string Company { get; set; }
		public string Position { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }
		public string[] Highlights { get; set; }
	}
}