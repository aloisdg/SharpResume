using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using SharpResume.Model;
using Assert = NUnit.Framework.Assert;

namespace SharpResume.Tests
{
	[TestFixture]
	public class UnitTest
	{
		const string JsonName = "resume.json";
		static readonly string _json = File.ReadAllText(Path.Combine(
			Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
			JsonName));
		readonly Resume _resume = Resume.Create(_json);
		readonly dynamic _expected = JObject.Parse(_json);

		[Test]
		public void TestName()
		{
			string name = _expected.basics.name;
			Assert.AreEqual(name, _resume.Basics.Name);
		}

		[Test]
		public void TestCoursesCount()
		{
			var educations = _expected.education.ToObject<List<Education>>();
			Assert.AreEqual(educations.Count, _resume.Education.Length);
		}
	}
}
