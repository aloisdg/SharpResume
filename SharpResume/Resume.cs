using System;
using System.Linq.Expressions;
using Newtonsoft.Json;
using SharpResume.Model;

namespace SharpResume
{
	public class Resume : IEquatable<Resume>
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

		public static Resume Create(string json)
		{
			return JsonConvert.DeserializeObject<Resume>(json);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Basics != null ? Basics.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Work != null ? Work.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Volunteer != null ? Volunteer.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Education != null ? Education.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Awards != null ? Awards.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Publications != null ? Publications.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Skills != null ? Skills.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Languages != null ? Languages.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Interests != null ? Interests.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (References != null ? References.GetHashCode() : 0);
				return hashCode;
			}
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Resume)obj);
		}

		public bool Equals(Resume other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Equals(Basics, other.Basics) && Equals(Work, other.Work) && Equals(Volunteer, other.Volunteer) && Equals(Education, other.Education) && Equals(Awards, other.Awards) && Equals(Publications, other.Publications) && Equals(Skills, other.Skills) && Equals(Languages, other.Languages) && Equals(Interests, other.Interests) && Equals(References, other.References);
		}

		public static bool operator ==(Resume resume1, Resume resume2)
		{
			return resume1.Equals(resume2);
		}

		public static bool operator !=(Resume resume1, Resume resume2)
		{
			return !resume1.Equals(resume2);
		}
	}
}
