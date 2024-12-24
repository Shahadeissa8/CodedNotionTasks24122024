using CodedNotionTasks24122024.models;

GraduateStudent studentMain = new GraduateStudent(); //before iin my previous update i used "Student studentMain = new Student".
                                                     //However i changed it to what you see here.
                                                     //The reason behind that is that Student is a parent meaning it doesnt have the child within it,
                                                     // however graduate student does use parent inside it 
                                                     //and that is why i changed it.

Console.WriteLine("name: ");
studentMain.Name = Console.ReadLine();
Console.WriteLine("major: ");
studentMain.Major = Console.ReadLine();
Console.WriteLine("gpa: ");
studentMain.GPA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(studentMain.studentSummary());


Console.WriteLine("enter graduate student's supervisor name: ");
studentMain.Supervisor = Console.ReadLine();
Console.WriteLine("enter graduate student's senior project title: ");
studentMain.SeniorProject = Console.ReadLine();

Console.WriteLine("Graduate student summary:-\n");
Console.WriteLine(studentMain.graduate());

