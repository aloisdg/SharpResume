using System;

namespace SharpResume.Model
{
	public class Interest : IEquatable<Interest>
	{
		public string Name { get; set; }
		public string[] Keywords { get; set; }

		public bool Equals(Interest other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Name, other.Name) && Equals(Keywords, other.Keywords);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Interest)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Keywords != null ? Keywords.GetHashCode() : 0);
			}
		}

		public static bool operator ==(Interest left, Interest right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Interest left, Interest right)
		{
			return !Equals(left, right);
		}
	}
}