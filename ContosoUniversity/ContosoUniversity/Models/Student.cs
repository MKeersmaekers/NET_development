using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string LastName { get; set; }
		public string FirstMidName { get; set; }
		[NotMapped]
		public string FullName { get {
				return FirstMidName + " " + LastName;
					} }
		public DateTime EnrollmentDate { get; set; }

		public ICollection<Enrollment>? Enrollments { get; set; }
	}
}


