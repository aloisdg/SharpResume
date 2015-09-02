using System;

namespace SharpResume.Model
{
	public class Reference : IEquatable<Reference>
	{
		public string Name { get; set; }
		public string Comment { get; set; }

		public bool Equals(Reference other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return string.Equals(Name, other.Name) && string.Equals(Comment, other.Comment);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Reference) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Name != null ? Name.GetHashCode() : 0)*397) ^ (Comment != null ? Comment.GetHashCode() : 0);
			}
		}

		public static bool operator ==(Reference left, Reference right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Reference left, Reference right)
		{
			return !Equals(left, right);
		}
	}
}