using System;
using SharpResume.Dateable;

namespace SharpResume.Model
{
	public class Volunteer : ADateable, IEquatable<Volunteer>
	{
		public string Organization { get; set; }
		public string Position { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }
		public string[] Highlights { get; set; }

		public bool Equals(Volunteer other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Organization, other.Organization)
				&& string.Equals(Position, other.Position)
				&& string.Equals(Website, other.Website)
				&& string.Equals(Summary, other.Summary)
				&& Equals(Highlights, other.Highlights)
				&& Start.Equals(other.Start)
				&& End.Equals(other.End);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Volunteer)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Organization != null ? Organization.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Position != null ? Position.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Website != null ? Website.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Summary != null ? Summary.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Highlights != null ? Highlights.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ Start.GetHashCode();
				hashCode = (hashCode * 397) ^ End.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(Volunteer left, Volunteer right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Volunteer left, Volunteer right)
		{
			return !Equals(left, right);
		}
	}
}