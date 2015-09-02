using System;

namespace SharpResume.Model
{
	public class Publication : IEquatable<Publication>
	{
		public string Name { get; set; }
		public string Publisher { get; set; }
		public DateTime Release { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }

		public bool Equals(Publication other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Name, other.Name)
				&& string.Equals(Publisher, other.Publisher)
				&& Release.Equals(other.Release)
				&& string.Equals(Website, other.Website)
				&& string.Equals(Summary, other.Summary);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Publication)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Name != null ? Name.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Publisher != null ? Publisher.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ Release.GetHashCode();
				hashCode = (hashCode * 397) ^ (Website != null ? Website.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Summary != null ? Summary.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(Publication left, Publication right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Publication left, Publication right)
		{
			return !Equals(left, right);
		}
	}
}