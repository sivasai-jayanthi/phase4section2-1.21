using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
	public class Student
	{
		public string Name { get; set; }
		public string ClassAndSection { get; set; }
	}

	public class Teacher
	{
		public string Name { get; set; }
		public string ClassAndSection { get; set; }
	}

	public class Subject
	{
		public string Name { get; set; }
		public string SubjectCode { get; set; }
		public string Teacher { get; set; }
	}
}
