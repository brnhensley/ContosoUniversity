namespace ContosoUniversity.Models
{
    public enum Grade
	{
		A, B, C, D, F
	}

	public class Enrollment
	{
		public int EnrollmentID { get; set; }
		public int CourseID { get; set; }		// Foreign Key
		public int StudentID { get; set; }		// Foreign Key
		public Grade? Grade { get; set; }		// Grade? means the property can be null

    	// navigation property
		public Course Course { get; set; }
		public Student Student { get; set; }
	}
}