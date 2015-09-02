using System;

namespace SharpResume.Model
{
	public class Basics : IEquatable<Basics>
	{
		public string Name { get; set; }
		public string Label { get; set; }
		public string Picture { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }
		public Location Location { get; set; }
		public Profile[] Profiles { get; set; }

		public bool Equals(Basics other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Name, other.Name)
				&& string.Equals(Label, other.Label)
				&& string.Equals(Picture, other.Picture)
				&& string.Equals(Email, other.Email)
				&& string.Equals(Phone, other.Phone)
				&& string.Equals(Website, other.Website)
				&& string.Equals(Summary, other.Summary)
				&& Equals(Location, other.Location)
				&& Equals(Profiles, other.Profiles);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Basics)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Name != null ? Name.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Label != null ? Label.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Picture != null ? Picture.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Website != null ? Website.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Summary != null ? Summary.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Location != null ? Location.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Profiles != null ? Profiles.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(Basics left, Basics right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Basics left, Basics right)
		{
			return !Equals(left, right);
		}
	}
}