using CodedNotionTasks24122024.models;

Student studentclass = new Student();
string name, major;
double gpa;
Console.WriteLine("name: ");
name = Console.ReadLine();
Console.WriteLine("major: ");
major = Console.ReadLine();
Console.WriteLine("gpa: ");
gpa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(studentclass.studentSummary( name, major, gpa));
