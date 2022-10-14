public class Student : Person {
    private int class_school;
    private string school;

    public Student(string nameprefix, string name, string surname, int age, int class_school, string allergy, string religion, string school)
    :base (nameprefix,name,surname,age,allergy,religion)
    {
    this.class_school = class_school;
    this.school = school;}
}

   
    
    
