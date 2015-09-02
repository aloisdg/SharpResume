using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpResume.Model
{
	public class Location : IEquatable<Location>
	{
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public string City { get; set; }
		public string CountryCode { get; set; }
		public string Region { get; set; }

		public bool Equals(Location other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Address, other.Address)
				&& string.Equals(PostalCode, other.PostalCode)
				&& string.Equals(City, other.City)
				&& string.Equals(CountryCode, other.CountryCode)
				&& string.Equals(Region, other.Region);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Location)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Address != null ? Address.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (PostalCode != null ? PostalCode.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (City != null ? City.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (CountryCode != null ? CountryCode.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Region != null ? Region.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(Location left, Location right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Location left, Location right)
		{
			return !Equals(left, right);
		}
	}
}
