using System;

namespace Idea_Camp
{
    public class Program
    {
        static PersonList personList;
        
         

        static void Main(string[] args) {
           
            PreparePersonList();
            PrintMenuScreen();
            

                
            }
            static void PreparePersonList(){
                Program.personList = new PersonList();
            }
        
         static void PrintMenuScreen() {
        Console.Clear();

        PrintListMenu();
        InputMenuFromkeyboard();

        }
    static void PrintListMenu() {
        Console.WriteLine("Welcome to registration Idea Camp!!! ");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Are you logged in?");
        Console.WriteLine("1. Register ");
        Console.WriteLine("2. Show the number of participant");
        Console.WriteLine("3. Login Menu");
        Console.WriteLine("Please Choose Menu ");
        Console.WriteLine("--------------------------------------------------------");
            
        }
        static void InputMenuFromkeyboard() {
            Console.Write("Plase input Menu: ");
            int menu = int.Parse(Console.ReadLine());
           
            switch(menu){
            case 1:
            StudentRegisterMenu();
            break;
            case 2:
            Showparticipant();
            break;
            case 3:
            LoginMenu();
            break;
            default:
            break;
        
    
         }
            
            
        }
          static void StudentRegisterMenu(){
        Student Student = new Student(Selectnameprefix(),Inputname(),Inputsurname(),Inputage(),Selectclass_school(),Inputallergy(),Selectreligion(),Inputschool());
        Program.personList.AddNewPerson(Student);
        Console.Clear();
        PrintMenuScreen();
    }
    static void CollegianRegisterMenu(){
        Collegian Collegian = new Collegian (Selectnameprefix(),Inputname(),Inputsurname(),Inputage(),Inputallergy(),Selectreligion(),InputStudent_ID(),Selectadmin(),null,null);      
        if(Collegian.Getadmin() == true){
            Collegian.Setemail();
            Collegian.Setpassword();
        }
        Program.personList.AddNewPerson(Collegian);
        Console.Clear();
        PrintMenuScreen();

    }
         static void TeacherRegisterMenu(){
        Teacher teacher = new Teacher(Selectnameprefix(),Inputname(),Inputsurname(),Inputage(),Selectposition(),Inputallergy(),Selectreligion(),Selectcar(),0,Selectadmin(),null,null);
        if(teacher.Getcar() == true){
            teacher.Setnumbercar();
        }
        if(teacher.Getadmin() == true){
            teacher.Setemail();
            teacher.Setpassword();
        }
        Program.personList.AddNewPerson(teacher);
        Console.Clear();
        PrintMenuScreen();

    }
     static string Selectnameprefix(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Mr.");
        Console.WriteLine("2 : Mrs.");
        Console.WriteLine("3 : Miss");
        Console.Write("----------------------------------------: ");
        Console.Write("Please Select Number of your Name Prefix : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return "Mr.";
            break;
            case 2:
            return "Mrs.";
            break;
            case 3:
            return "Miss.";
            break;
            default:
            return BackTotheSelectnameprefix();    
        }
        }
        static string BackTotheSelectnameprefix(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2,3");
            return Selectnameprefix();
        }
        static string Inputname(){
            Console.Write("name : ");
            return Console.ReadLine();
        }
        static string Inputsurname(){
            Console.Write("surname : ");
            return Console.ReadLine();
        }
        static int Inputage(){
            Console.Write("age : ");
            return int.Parse(Console.ReadLine());
        }
        static string Inputallergy(){
            Console.Write("allergy : ");
            return Console.ReadLine();
        }
        static string Inputschool(){
            Console.Write("school : ");
            return Console.ReadLine();
        }
        static string Selectreligion(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Buddhism");
        Console.WriteLine("2 : Muslim");
        Console.WriteLine("3 : Cristian");
        Console.WriteLine("4 : Other");
        Console.Write("Please Select Number of your Religion : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return "Buddhism";
            break;
            case 2:
            return "Muslim";
            break;
            case 3:
            return "Cristian";
            break;
            case 4:
            return "Other";
            default:
            return BackTotheSelectreligion();
        }
     }
        static string BackTotheSelectreligion(){
            Console.Clear();
            Console.WriteLine("Please use only 1,2,3,4");
            return Selectreligion();
        }
        
        static string Selectposition(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Dean");
        Console.WriteLine("2 : Head of Department");
        Console.WriteLine("3 : Professor");
        Console.Write("Please Select Number of your Position : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return "Dean";
            break;
            case 2:
            return "Head of Department";
            break;
            case 3:
            return "Professor";
            break;
            default:
            return BackTotheSelectPosition();
        }
        }
        static string BackTotheSelectPosition(){
            Console.Clear();
            Console.WriteLine("Please use only 1,2,3");
            return Selectposition();
        }
        static int Selectclass_school(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Class 4");
        Console.WriteLine("2 : Class 5");
        Console.WriteLine("3 : Class 6");      
        Console.Write("Please Select Number of your class_school : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return 4;
            break;
            case 2:
            return 5;
            break;
            case 3:
            return 6;
            break;
            default:
            return BackTotheSelectclass_school();
        }
        }
        static int BackTotheSelectclass_school(){
            Console.Clear();
            Console.WriteLine("Please use only 1,2,3");
            return Selectclass_school();
        }
        static int InputStudent_ID(){
            Console.Write("Student ID : ");
            return int.Parse(Console.ReadLine());
        }
        static int Inputnumbercar(){
            if(Selectcar() == true){
                Console.Write("numbercar : ");
                return int.Parse(Console.ReadLine());
            }
            else{
                return 0;
            }
        }
                
            
        static bool Selectadmin(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Yes");
        Console.WriteLine("Other Number : No");    
        Console.Write("Are you admin? : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return true;
            break;
            default:
            return false;
            break;
            
        }
        }       
        static bool Selectcar(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Yes");
        Console.WriteLine("2 : No");
        Console.Write("Do you use your car?");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return true;
            break;
            case 2:
            return false;
            default:
            return BackTotheSelectcar();
            break;
            
        }
        }
        static bool BackTotheSelectcar(){
            Console.Clear();
            Console.WriteLine("Please use only 1,2");
            return Selectcar();
        }
        static void Showparticipant(){
            Program.personList.PersonNumber();
            PrintListMenu();
        }
        static void LoginMenu(){

            Console.Write("Please Input Email : ");
            string email = Console.ReadLine();
            Console.Write("Please Input Password : ");
            string password = Console.ReadLine();
            
            

        }


    }
    
 }

    

 


        







            
            


        

    

