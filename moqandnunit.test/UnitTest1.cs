using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Tests
{
	[TestFixture]
	public class StudentTests
	{
		[Test]
		public void TestStudentCreation()
		{
			// Arrange
			var student = new Student { Name = "John", ClassAndSection = "ClassA" };

			// Act and Assert
			Assert.AreEqual("John", student.Name);
			Assert.AreEqual("ClassA", student.ClassAndSection);
		}
	}

	[TestFixture]
	public class TeacherTests
	{
		[Test]
		public void TestTeacherCreation()
		{
			// Arrange
			var teacher = new Teacher { Name = "Mrs. Smith", ClassAndSection = "ClassB" };

			// Act and Assert
			Assert.AreEqual("Mrs. Smith", teacher.Name);
			Assert.AreEqual("ClassB", teacher.ClassAndSection);
		}
	}

	[TestFixture]
	public class SubjectTests
	{
		[Test]
		public void TestSubjectCreation()
		{
			// Arrange
			var subject = new Subject { Name = "Math", SubjectCode = "MATH101", Teacher = "Mr. Johnson" };

			// Act and Assert
			Assert.AreEqual("Math", subject.Name);
			Assert.AreEqual("MATH101", subject.SubjectCode);
			Assert.AreEqual("Mr. Johnson", subject.Teacher);
		}
	}

	[TestFixture]
	public class SchoolSystemTests
	{
		[Test]
		public void TestAddStudent()
		{
			// Arrange
			var schoolSystem = new SchoolSystem();
			var student = new Student { Name = "Alice", ClassAndSection = "ClassC" };

			// Act
			schoolSystem.AddStudent(student);

			// Assert
			Assert.IsTrue(schoolSystem.Students.Contains(student));
		}

		[Test]
		public void TestGetStudentsInClass()
		{
			// Arrange
			var schoolSystem = new SchoolSystem();
			var student1 = new Student { Name = "Bob", ClassAndSection = "ClassA" };
			var student2 = new Student { Name = "Carol", ClassAndSection = "ClassA" };
			schoolSystem.AddStudent(student1);
			schoolSystem.AddStudent(student2);

			// Act
			var studentsInClassA = schoolSystem.GetStudentsInClass("ClassA");

			// Assert
			CollectionAssert.AreEqual(new List<Student> { student1, student2 }, studentsInClassA);
		}
	}

	public class SchoolSystem
	{
		public List<Student> Students { get; } = new List<Student>();

		public void AddStudent(Student student)
		{
			Students.Add(student);
		}

		public List<Student> GetStudentsInClass(string className)
		{
			return Students.Where(student => student.ClassAndSection == className).ToList();
		}
	}
}
