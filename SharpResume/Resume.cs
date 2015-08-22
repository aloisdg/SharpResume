using SharpResume.Model;

namespace SharpResume
{
	public class Resume
	{
		public Basics Basics { get; set; }
		public Work[] Work { get; set; }
		public Volunteer[] Volunteer { get; set; }
		public Education[] Education { get; set; }
		public Award[] Awards { get; set; }
		public Publication[] Publications { get; set; }
		public Skill[] Skills { get; set; }
		public Language[] Languages { get; set; }
		public Interest[] Interests { get; set; }
		public Reference[] References { get; set; }
	}
}
