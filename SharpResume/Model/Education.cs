using SharpResume.Dateable;

namespace SharpResume.Model
{
	public class Education : ADateable
	{
		public string Institution { get; set; }
		public string Area { get; set; }
		public string StudyType { get; set; }
		public string Gpa { get; set; }
		public string[] Courses { get; set; }
	}
}