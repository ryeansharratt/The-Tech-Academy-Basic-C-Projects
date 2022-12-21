using StudentDBProject;

internal class Program
{
    public static void Main(string[] args)
    {
        using (var db = new SchoolContext())
        {
            //create and add new student
            Console.WriteLine("Enter new student's name:");
            var name = Console.ReadLine();

            var student = new Student { StudentName = name };
            db.Students.Add(student); //adds student to db
            db.SaveChanges();

            //display students in db
            var query = from b in db.Students //calling the database
                        orderby b.StudentName
                        select b;

            Console.WriteLine("Student names in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.StudentName);
            }
        }
    }
}