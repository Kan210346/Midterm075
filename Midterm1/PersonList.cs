using System.Collections.Generic;
using System;
class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }

    public void FetchPersonNum() {
        Console.WriteLine("participant");
        Console.WriteLine("--------------");
        int TeacherNum = 0;
        int StudentNum = 0;
        int CollegianNum = 0;

        foreach(Person person in this.personList) {
            if (person is Student) {
                StudentNum++;
            } else if (person is Teacher) {
                TeacherNum++;
                } else if (person is Collegian) {
                CollegianNum++;

            }
            else {}
        }
        Console.WriteLine("All registered teacher : {0}",TeacherNum);
        Console.WriteLine("All registered Student : {0}",StudentNum);
        Console.WriteLine("All registered Collegian : {0}",CollegianNum);
        Console.ReadLine();
        Console.Clear();

    }
}