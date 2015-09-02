using System;

namespace SharpResume.Model
{
	public class Award : IEquatable<Award>
	{
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public string Awarder { get; set; }
		public string Summary { get; set; }

		public bool Equals(Award other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Title, other.Title)
				&& Date.Equals(other.Date)
				&& string.Equals(Awarder, other.Awarder)
				&& string.Equals(Summary, other.Summary);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Award)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Title != null ? Title.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ Date.GetHashCode();
				hashCode = (hashCode * 397) ^ (Awarder != null ? Awarder.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Summary != null ? Summary.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(Award left, Award right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Award left, Award right)
		{
			return !Equals(left, right);
		}
	}
}