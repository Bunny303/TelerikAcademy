using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLibrary;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructorTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School();
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course javascript = new Course("Javascript");
            School school = new School();
            school.AddCourse(javascript);
            Assert.AreEqual(javascript.Name, school.Courses[0].Name);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School();
            Course javascript = new Course("Javascript");
            school.AddCourse(javascript);
            school.RemoveCourse(javascript);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingCourseTest()
        {
            List<Course> courses = new List<Course>();
            School school = new School();
            Course javascript = new Course("Javascript");
            school.RemoveCourse(javascript);
        }
    }
}
