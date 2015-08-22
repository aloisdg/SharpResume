using System.Linq.Expressions;
using Newtonsoft.Json;
using SharpResume.Model;

namespace SharpResume
{
	public class Resume
	{
		public Basics Basics { get; set; }
		public Work[] Works { get; set; }
		public Volunteer[] Volunteers { get; set; }
		public Education[] Educations { get; set; }
		public Award[] Awards { get; set; }
		public Publication[] Publications { get; set; }
		public Skill[] Skills { get; set; }
		public Language[] Languages { get; set; }
		public Interest[] Interests { get; set; }
		public Reference[] References { get; set; }

		public static Resume Create(string json)
		{
			return JsonConvert.DeserializeObject<Resume>(json);
		}
	}
}
