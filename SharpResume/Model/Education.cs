using System;
using SharpResume.Dateable;

namespace SharpResume.Model
{
	public class Education : ADateable, IEquatable<Education>
	{
		public string Institution { get; set; }
		public string Area { get; set; }
		public string StudyType { get; set; }
		public string Gpa { get; set; }
		public string[] Courses { get; set; }

		public bool Equals(Education other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Institution, other.Institution)
				&& string.Equals(Area, other.Area)
				&& string.Equals(StudyType, other.StudyType)
				&& string.Equals(Gpa, other.Gpa)
				&& Equals(Courses, other.Courses)
				&& Start.Equals(other.Start)
				&& End.Equals(other.End);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Education) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Institution != null ? Institution.GetHashCode() : 0);
				hashCode = (hashCode*397) ^ (Area != null ? Area.GetHashCode() : 0);
				hashCode = (hashCode*397) ^ (StudyType != null ? StudyType.GetHashCode() : 0);
				hashCode = (hashCode*397) ^ (Gpa != null ? Gpa.GetHashCode() : 0);
				hashCode = (hashCode*397) ^ (Courses != null ? Courses.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ Start.GetHashCode();
				hashCode = (hashCode * 397) ^ End.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(Education left, Education right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Education left, Education right)
		{
			return !Equals(left, right);
		}
	}
}