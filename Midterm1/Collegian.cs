public class Collegian : Person {
    private int student_ID;
    private bool admin;
    private string email;
    private string password;


    public Collegian(string nameprefix, string name, string surname, int age, string allergy, string religion, int student_ID, bool admin, string email, string password )
    : base(nameprefix, name, surname, age, allergy, religion){
    
        this.student_ID = student_ID;
        this.admin = admin;
        this.email = email;
        this.password = password;
    
    
    }

    public bool Getadmin(){
        return this.admin;
        
    }
    public void Setemail(){
        Console.WriteLine("Please In put email : ");
        this.email= Console.ReadLine();
    }
    public void Setpassword(){
        Console.WriteLine("Please In put password : ");
        this.password= Console.ReadLine();
    }

}