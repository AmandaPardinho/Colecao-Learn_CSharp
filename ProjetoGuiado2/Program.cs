//Student
string studentName = "Sophia Johnson";
string course = "Course";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//Credit
string credit = "Credit";
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//Grade
string grade = "Grade";
int gradeA = 4;
int gradeB = 3;

//Grade vs Course
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

//Total Credit Hours
int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

//Total Grade Points
int totalGradePoints = 0;
totalGradePoints += course1Grade * course1Credit;
totalGradePoints += course2Grade * course2Credit;
totalGradePoints += course3Grade * course3Credit;
totalGradePoints += course4Grade * course4Credit;
totalGradePoints += course5Grade * course5Credit;

Console.WriteLine($"\n{totalGradePoints} {totalCreditHours}");

Console.WriteLine($"{course}\t\t\t\t{grade}\t\t\t{credit}\n");
Console.WriteLine($"{course1Name}\t\t\t {course1Grade}\t\t\t {course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t {course2Grade}\t\t\t {course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t {course3Grade}\t\t\t {course3Credit}");
Console.WriteLine($"{course4Name}\t\t {course4Grade}\t\t\t {course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t {course5Grade}\t\t\t {course5Credit}");
