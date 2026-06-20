string? region = null;

String? upperRegion = region?.ToUpper();
Console.WriteLine($"Region(conditional):{upperRegion}");


string displayRegion = region ??"Unassigned";
Console.WriteLine($"Region(coalesced):{displayRegion}");


region ??="Addis Ababa";
Console.WriteLine($"Region(assigned):region");


string studentName="Abeba";
string studentId="stu-001";
int enrollmentCount=3;
decimal grantAmount=1999.99m;
DateTime enrolledAt=DateTime.UtcNow;
string? campusRegion=null;

Console.WriteLine($"Student:{studentName}({studentId})");
Console.WriteLine($"courses:{enrollmentCount}");
Console.WriteLine($"Grant:{grantAmount}");
Console.WriteLine($"Enrolled:{enrolledAt:yyyy-MM-dd}");
Console.WriteLine($"Campus:{campusRegion ??"Not assigned"}");



//EXERCIES 2


//double grantPerStudent=1999.99;
//double totalallocation = grantPerStudent*100_000;
//Console.WriteLine($"Total allocated(double):{totalallocation}");


decimal grantPerStudent =1999.99m;
decimal totalAllocation = grantPerStudent*100_000m;

Console.WriteLine($"Total allocated (decimal): {totalAllocation}");
Console.WriteLine($"Total allocated (formatted): {totalAllocation:F2}");


//EXERCISE 3

var enrollment = new EnrollmentRecord("stu-001","cs-401",DateTime.UtcNow);
Console.WriteLine(enrollment);

var corrected = enrollment with {CourseCode="cs-402"};
Console.WriteLine(corrected);

var duplicate = new EnrollmentRecord("stu-001","cs-401",enrollment.EnrolledAt);
Console.WriteLine($"Same data?{enrollment==duplicate}");

//part 2
var course = new Course{Code ="cs-401", Title= "Advanced",Capacity=30};
Console.WriteLine($"Code:{course.Code},Course:{course.Title} Capacity:{course.Capacity}");

try{
    course.Capacity=-5;
}
catch(ArgumentOutOfRangeException ex){
    Console.WriteLine($"caught:{ex.Message}");
}

try{
    course.Title="";
}
catch(ArgumentException ex){
 Console.WriteLine($"caught:{ex.Message}");
}


//Exercise part 3
var s =new Student{Id ="S1",Name="Abebe",Age=20,GPA=3.75m};
Console.WriteLine($"id={s.Id},name={s.Name},Age={s.Age},GPA={s.GPA}");

//Exercise 3B
void PrintGradeReport(IEnumerable<IGradable>assessments){
    Console.WriteLine("--Grade Report----");
    foreach(var item in assessments){
        Console.WriteLine($"{item.Title}:{item.CalculateGrade():F2}%");
    }
}

IGradable[] cohortAssessments = [
new Quiz { Title = "C# Basics", CorrectAnswers = 18, TotalQuestions = 20 },
new LabAssignment { Title = "Registration API", FunctionalityScore = 90m, CodeQualityScore =85m}
];

PrintGradeReport(cohortAssessments);