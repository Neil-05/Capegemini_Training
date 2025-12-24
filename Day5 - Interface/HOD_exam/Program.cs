interface IExaminer{
    void ConductExam();
}

abstract class employee{
   public int EmployeeId { get; set; }
    public department department { get; set; }

        public abstract void DisplayRole();
}
class department{
    public int deptId{get;set;}
    public string deptName{get;set;}
}
class HOD: employee{
    public string hodName{get;set;}

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Head of Department");
    }
}

class Examiner : employee, IExaminer
    {
        public string ExaminerDetails { get; set; }
        public int RoomNo { get; set; }

        public override void DisplayRole()
        {
            Console.WriteLine("Role: Examiner");
        }

        public void ConductExam()
        {
            Console.WriteLine($"Exam conducted in Room {RoomNo}");
        }
    }
class Exam{
    public int examId{get;set;}
    public string examName{get;set;}
    public Examiner examiner{get;set;}
}

class student{
    public int studentId{get;set;}
    public string studentName{get;set;}
    public Exam Exam{get;set;}
}

class semester{
    public int semesterid{get;set;}
}

 class Program
{
    static void Main(string[] args)
    {
        // Department input
        department dept = new department();
        Console.Write("Enter Department ID: ");
        dept.deptId = int.Parse(Console.ReadLine());

        Console.Write("Enter Department Name: ");
        dept.deptName = Console.ReadLine();

        // Examiner input
        Examiner examiner = new Examiner();
        Console.Write("Enter Examiner Employee ID: ");
        examiner.EmployeeId = int.Parse(Console.ReadLine());

        examiner.department = dept;

        Console.Write("Enter Examiner Details: ");
        examiner.ExaminerDetails = Console.ReadLine();

        Console.Write("Enter Room Number: ");
        examiner.RoomNo = int.Parse(Console.ReadLine());

        // Semester input
        semester sem = new semester();
        Console.Write("Enter Semester ID: ");
        sem.semesterid = int.Parse(Console.ReadLine());

        // Exam input
        Exam exam = new Exam();
        Console.Write("Enter Exam ID: ");
        exam.examId = int.Parse(Console.ReadLine());

        Console.Write("Enter Exam Name: ");
        exam.examName = Console.ReadLine();

        exam.examiner = examiner;

        // Student input
        student student = new student();
        Console.Write("Enter Student ID: ");
        student.studentId = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        student.studentName = Console.ReadLine();

        student.Exam = exam;

        // Output
        Console.WriteLine("\n--- DETAILS ---");
        Console.WriteLine("Student: " + student.studentName);
        Console.WriteLine("Exam: " + student.Exam.examName);
        Console.WriteLine("Semester: " + sem.semesterid);

        examiner.DisplayRole();
        examiner.ConductExam();
    }
}
