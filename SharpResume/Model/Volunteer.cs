using SharpResume.Dateable;

namespace SharpResume.Model
{
	public class Volunteer : ADateable
	{
		public string Organization { get; set; }
		public string Position { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }
		public string[] Highlights { get; set; }
	}
}