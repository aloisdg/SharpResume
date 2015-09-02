using System;

namespace SharpResume.Model
{
	public class Profile : IEquatable<Profile>
	{
		public string Network { get; set; }
		public string Username { get; set; }
		public string Url { get; set; }

		public bool Equals(Profile other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Network, other.Network)
				&& string.Equals(Username, other.Username)
				&& string.Equals(Url, other.Url);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Profile)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Network != null ? Network.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Username != null ? Username.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Url != null ? Url.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(Profile left, Profile right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Profile left, Profile right)
		{
			return !Equals(left, right);
		}
	}
}