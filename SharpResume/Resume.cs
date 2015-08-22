using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpResume
{
	public class Resume
	{
		public Basics Basics { get; set; }
		public Work[] Work { get; set; }
		public Volunteer[] Volunteer { get; set; }
		public Education[] Education { get; set; }
		public Award[] Awards { get; set; }
		public Publication[] Publications { get; set; }
		public Skill[] Skills { get; set; }
		public Language[] Languages { get; set; }
		public Interest[] Interests { get; set; }
		public Reference[] References { get; set; }
	}

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

	public class Location
	{
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public string City { get; set; }
		public string CountryCode { get; set; }
		public string Region { get; set; }
	}

	public class Profile
	{
		public string Network { get; set; }
		public string Username { get; set; }
		public string Url { get; set; }
	}

	public class Work
	{
		public string Company { get; set; }
		public string Position { get; set; }
		public string Website { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string Summary { get; set; }
		public string[] Highlights { get; set; }
	}

	public class Volunteer
	{
		public string Organization { get; set; }
		public string Position { get; set; }
		public string Website { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string Summary { get; set; }
		public string[] Highlights { get; set; }
	}

	public class Education
	{
		public string Institution { get; set; }
		public string Area { get; set; }
		public string StudyType { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string Gpa { get; set; }
		public string[] Courses { get; set; }
	}

	public class Award
	{
		public string Title { get; set; }
		public string Date { get; set; }
		public string Awarder { get; set; }
		public string Summary { get; set; }
	}

	public class Publication
	{
		public string Name { get; set; }
		public string Publisher { get; set; }
		public string ReleaseDate { get; set; }
		public string Website { get; set; }
		public string Summary { get; set; }
	}

	public class Skill
	{
		public string Name { get; set; }
		public string Level { get; set; }
		public string[] Keywords { get; set; }
	}

	public class Language
	{
		public string language { get; set; }
		public string Fluency { get; set; }
	}

	public class Interest
	{
		public string Name { get; set; }
		public string[] Keywords { get; set; }
	}

	public class Reference
	{
		public string Name { get; set; }
		public string reference { get; set; }
	}

}
