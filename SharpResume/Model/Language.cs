using System;

namespace SharpResume.Model
{
	public class Language : IEquatable<Language>
	{
		public string Name { get; set; }
		public string Fluency { get; set; }

		public bool Equals(Language other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Name, other.Name) && string.Equals(Fluency, other.Fluency);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Language)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Fluency != null ? Fluency.GetHashCode() : 0);
			}
		}

		public static bool operator ==(Language left, Language right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Language left, Language right)
		{
			return !Equals(left, right);
		}
	}
}