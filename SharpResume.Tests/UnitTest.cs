using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using SharpResume.Model;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SharpResume.Tests
{
	[TestClass]
	public class UnitTest
	{
		const string JsonName = "resume.json";
		static readonly string _json = File.ReadAllText(Path.Combine(
			Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
			JsonName));
		readonly Resume _resume = Resume.Create(_json);
		readonly dynamic _expected = JObject.Parse(_json);

		[TestMethod]
		public void TestName()
		{
			string name = _expected.basics.name;
			Assert.AreEqual(name, _resume.Basics.Name);
		}

		[TestMethod]
		public void TestCoursesCount()
		{
			var educations = _expected.education.ToObject<List<Education>>();
			Assert.AreEqual(educations.Count, _resume.Education.Length);
		}
	}
}
