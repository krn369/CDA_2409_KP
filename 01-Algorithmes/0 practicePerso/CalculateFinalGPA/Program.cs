/*
Calculate the final GPA and modify the console output to achieve the desired reporting format. 
The GPA is equal to the sum of the total grade points divided by the sum of the total credit hours.
Your goal was to build an application that takes course information for a student, calculates the overall GPA, and displays the results.
 */

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;



Console.WriteLine("Student : " + studentName);
Console.WriteLine("\nCourse \t\t\tGrade \t CreditHours");
Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
/*
 int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;
 */
decimal finalGpa = (decimal)((course1Grade * course1Credit) + (course2Grade * course2Credit) + (course3Grade * course3Credit) + (course4Grade * course4Credit) + (course5Grade * course5Credit)) / totalCreditHours;

Console.WriteLine($"\nFinal GPA: \t\t{Math.Round(finalGpa, 2)}");