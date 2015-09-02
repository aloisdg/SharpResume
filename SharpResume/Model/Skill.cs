using System;

namespace SharpResume.Model
{
	public class Skill : IEquatable<Skill>
	{
		public string Name { get; set; }
		public string Level { get; set; }
		public string[] Keywords { get; set; }

		public bool Equals(Skill other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Name, other.Name)
				&& string.Equals(Level, other.Level)
				&& Equals(Keywords, other.Keywords);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Skill)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Name != null ? Name.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Level != null ? Level.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Keywords != null ? Keywords.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(Skill left, Skill right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Skill left, Skill right)
		{
			return !Equals(left, right);
		}
	}
}