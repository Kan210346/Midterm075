public class Teacher : Person {
    private bool car;
    private int numbercar;
    private bool admin;
    private string email;
    private string password;
    private string position;

    public Teacher(string nameprefix, string name, string surname, int age, string position, string allergy, string religion, bool car, int numbercar, bool admin, string email, string password )
    : base(nameprefix, name, surname, age, allergy, religion)
    {
    this.car = car;
    this.numbercar = numbercar;
    this.admin = admin;
    this.email = email;
    this.password = password;
    this.position = position;
    }
    public bool Getcar(){
        return this.car;
    }
    public void Setnumbercar(){
        Console.WriteLine("Please In put numbercar : ");
        this.numbercar= int.Parse(Console.ReadLine());
    }
    public bool Getadmin(){
        return this.admin;
    }
    public void Setemail(){
        Console.WriteLine("Please In put Email : ");
        this.email= Console.ReadLine();
    }
    public void Setpassword(){
        Console.WriteLine("Please In put Passsword : ");
        this.password= Console.ReadLine();
    }


}