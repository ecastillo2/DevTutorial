namespace Inheritance;

/// <summary>
/// Person base class - Demonstrates inheritance in a different domain
/// Shows how inheritance models real-world hierarchies
/// </summary>
public class Person
{
    /// <summary>
    /// PROTECTED AND PRIVATE FIELDS
    /// Shows different access levels in inheritance
    /// </summary>
    protected DateTime birthDate;
    private string? socialSecurityNumber;  // Private - NOT inherited

    /// <summary>
    /// PUBLIC PROPERTIES available to all derived classes
    /// </summary>
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    
    /// <summary>
    /// COMPUTED PROPERTY based on protected field
    /// </summary>
    public int Age 
    { 
        get 
        { 
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }

    /// <summary>
    /// FULL NAME - Computed property
    /// </summary>
    public string FullName => $"{FirstName} {LastName}";

    /// <summary>
    /// BASE CONSTRUCTOR
    /// </summary>
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        this.birthDate = birthDate;
        
        Console.WriteLine($"[BASE] Person constructor: {FullName}");
    }

    /// <summary>
    /// VIRTUAL METHOD - Introduce
    /// Can be overridden for specific introductions
    /// </summary>
    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FullName}, {Age} years old");
    }

    /// <summary>
    /// VIRTUAL METHOD - GetOccupation
    /// </summary>
    public virtual string GetOccupation()
    {
        return "Person";
    }

    /// <summary>
    /// NON-VIRTUAL METHOD - Cannot be overridden
    /// </summary>
    public void DisplayContactInfo()
    {
        Console.WriteLine($"Contact {FullName}:");
        Console.WriteLine($"Email: {Email ?? "Not provided"}");
        Console.WriteLine($"Phone: {PhoneNumber ?? "Not provided"}");
    }

    /// <summary>
    /// PROTECTED METHOD - Only accessible to derived classes
    /// </summary>
    protected void CelebrateBirthday()
    {
        Console.WriteLine($"Happy Birthday {FirstName}! You are now {Age + 1}!");
    }
}

/// <summary>
/// Student class - INHERITS from Person
/// Adds academic-specific properties and behaviors
/// </summary>
public class Student : Person
{
    /// <summary>
    /// STUDENT-SPECIFIC PROPERTIES
    /// </summary>
    public string StudentId { get; private set; }
    public string Major { get; set; }
    public double GPA { get; private set; }
    public int CreditsCompleted { get; private set; }
    
    private List<string> enrolledCourses;

    /// <summary>
    /// STUDENT CONSTRUCTOR - Must call base constructor
    /// </summary>
    public Student(string firstName, string lastName, DateTime birthDate, 
                   string studentId, string major) 
        : base(firstName, lastName, birthDate)
    {
        StudentId = studentId;
        Major = major;
        GPA = 0.0;
        CreditsCompleted = 0;
        enrolledCourses = new List<string>();
        
        Console.WriteLine($"[DERIVED] Student constructor: {studentId}");
    }

    /// <summary>
    /// OVERRIDE - Introduce
    /// Student-specific introduction
    /// </summary>
    public override void Introduce()
    {
        base.Introduce();  // Call parent's introduction first
        Console.WriteLine($"I'm a student majoring in {Major}");
        Console.WriteLine($"My student ID is {StudentId}");
    }

    /// <summary>
    /// OVERRIDE - GetOccupation
    /// </summary>
    public override string GetOccupation()
    {
        return $"{Major} Student";
    }

    /// <summary>
    /// NEW METHOD - EnrollInCourse
    /// Student-specific functionality
    /// </summary>
    public void EnrollInCourse(string courseName)
    {
        if (!enrolledCourses.Contains(courseName))
        {
            enrolledCourses.Add(courseName);
            Console.WriteLine($"{FullName} enrolled in {courseName}");
        }
        else
        {
            Console.WriteLine($"Already enrolled in {courseName}");
        }
    }

    /// <summary>
    /// NEW METHOD - CompleteCourst
    /// </summary>
    public void CompleteCourse(string courseName, double grade, int credits)
    {
        if (enrolledCourses.Contains(courseName))
        {
            enrolledCourses.Remove(courseName);
            
            // Update GPA (simplified calculation)
            double totalPoints = GPA * CreditsCompleted + grade * credits;
            CreditsCompleted += credits;
            GPA = totalPoints / CreditsCompleted;
            
            Console.WriteLine($"Completed {courseName} with grade {grade}");
            Console.WriteLine($"New GPA: {GPA:F2}, Total Credits: {CreditsCompleted}");
        }
    }

    /// <summary>
    /// NEW METHOD - DisplayStudentInfo
    /// </summary>
    public void DisplayStudentInfo()
    {
        Console.WriteLine("\n=== Student Information ===");
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"GPA: {GPA:F2}");
        Console.WriteLine($"Credits: {CreditsCompleted}");
        Console.WriteLine($"Current Courses: {string.Join(", ", enrolledCourses)}");
    }
}

/// <summary>
/// Teacher class - Another derived class from Person
/// Shows different inheritance path from same base
/// </summary>
public class Teacher : Person
{
    /// <summary>
    /// TEACHER-SPECIFIC PROPERTIES
    /// </summary>
    public string EmployeeId { get; private set; }
    public string Department { get; set; }
    public int YearsOfExperience { get; private set; }
    
    private List<string> teachingCourses;
    private List<string> qualifications;

    /// <summary>
    /// TEACHER CONSTRUCTOR
    /// </summary>
    public Teacher(string firstName, string lastName, DateTime birthDate, 
                   string employeeId, string department, int experience) 
        : base(firstName, lastName, birthDate)
    {
        EmployeeId = employeeId;
        Department = department;
        YearsOfExperience = experience;
        teachingCourses = new List<string>();
        qualifications = new List<string>();
        
        Console.WriteLine($"[DERIVED] Teacher constructor: {employeeId}");
    }

    /// <summary>
    /// OVERRIDE - Introduce
    /// Teacher-specific introduction
    /// </summary>
    public override void Introduce()
    {
        Console.WriteLine($"Good day! I'm Professor {LastName}");
        Console.WriteLine($"I teach in the {Department} department");
        Console.WriteLine($"I have {YearsOfExperience} years of teaching experience");
    }

    /// <summary>
    /// OVERRIDE - GetOccupation
    /// </summary>
    public override string GetOccupation()
    {
        return $"{Department} Professor";
    }

    /// <summary>
    /// NEW METHOD - AssignCourse
    /// </summary>
    public void AssignCourse(string courseName)
    {
        if (!teachingCourses.Contains(courseName))
        {
            teachingCourses.Add(courseName);
            Console.WriteLine($"Professor {LastName} assigned to teach {courseName}");
        }
    }

    /// <summary>
    /// NEW METHOD - AddQualification
    /// </summary>
    public void AddQualification(string qualification)
    {
        qualifications.Add(qualification);
        Console.WriteLine($"Added qualification: {qualification}");
    }

    /// <summary>
    /// NEW METHOD - GradeStudent
    /// Shows interaction between different derived classes
    /// </summary>
    public void GradeStudent(Student student, string course, double grade)
    {
        Console.WriteLine($"Professor {LastName} grading {student.FullName} in {course}");
        Console.WriteLine($"Grade assigned: {grade}");
        // In real system, this would update student's records
    }

    /// <summary>
    /// NEW METHOD - DisplayTeacherInfo
    /// </summary>
    public void DisplayTeacherInfo()
    {
        Console.WriteLine("\n=== Teacher Information ===");
        Console.WriteLine($"Name: Professor {FullName}");
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Experience: {YearsOfExperience} years");
        Console.WriteLine($"Teaching: {string.Join(", ", teachingCourses)}");
        Console.WriteLine($"Qualifications: {string.Join(", ", qualifications)}");
    }
}

/// <summary>
/// GraduateStudent - MULTI-LEVEL INHERITANCE
/// Inherits from Student, which inherits from Person
/// Shows inheritance chain: Person -> Student -> GraduateStudent
/// </summary>
public class GraduateStudent : Student
{
    /// <summary>
    /// GRADUATE-SPECIFIC PROPERTIES
    /// </summary>
    public string ResearchArea { get; set; }
    public string? AdvisorName { get; set; }
    public bool IsTeachingAssistant { get; set; }

    /// <summary>
    /// CONSTRUCTOR - Calls parent (Student) constructor
    /// </summary>
    public GraduateStudent(string firstName, string lastName, DateTime birthDate,
                          string studentId, string major, string researchArea)
        : base(firstName, lastName, birthDate, studentId, major)
    {
        ResearchArea = researchArea;
        IsTeachingAssistant = false;
        
        Console.WriteLine($"[DERIVED-2] GraduateStudent constructor");
    }

    /// <summary>
    /// OVERRIDE - Introduce (from Person, through Student)
    /// </summary>
    public override void Introduce()
    {
        base.Introduce();  // Calls Student's introduce
        Console.WriteLine($"I'm pursuing graduate studies in {ResearchArea}");
        if (IsTeachingAssistant)
        {
            Console.WriteLine("I also work as a Teaching Assistant");
        }
    }

    /// <summary>
    /// OVERRIDE - GetOccupation
    /// </summary>
    public override string GetOccupation()
    {
        return $"Graduate {Major} Student";
    }

    /// <summary>
    /// NEW METHOD - ConductResearch
    /// </summary>
    public void ConductResearch()
    {
        Console.WriteLine($"{FullName} is conducting research in {ResearchArea}");
        if (!string.IsNullOrEmpty(AdvisorName))
        {
            Console.WriteLine($"Under the guidance of {AdvisorName}");
        }
    }
}