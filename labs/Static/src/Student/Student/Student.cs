class Student{

    private int id;
    private string name; 
    private static string universityName = "Augusta University";
    private static int studentCount = 0;

    public Student(int id, string name){
        this.id = id;
        this.name = name;
        studentCount++;
    } 

    public static void DisplayStudentCount(){
        // does this work? uncomment next line to check!
        // Console.WriteLine(name);
        
        Console.WriteLine($"Number of students: {studentCount}");
    }

    public override string ToString(){
        return $"id: {id}\n"+
               $"name: {name}\n"+
               $"university: {universityName}";
    }  
}