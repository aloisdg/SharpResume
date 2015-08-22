namespace SharpResume.Model
{
	public class Basics
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
	}
}