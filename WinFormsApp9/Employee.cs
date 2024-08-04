using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{



    class receptionist:Employee {
       

        internal void readFromFile()
        {
            StreamReader db = new StreamReader("E:\\Receptioist.txt");

            db.Close();

        }


    }

    class AssistantDr : Employee {
        
      internal  void readFromFile()
        {
            StreamReader ds = new StreamReader("E:\\Employees.txt");
            ds.Close();
            
        }
     
       


    }

     class Employee
    {

        
        internal string name;
        internal string Age;
        internal string Id;
        internal string Salary;
        private int salaryWbonus;
        internal string depaa;
        internal string Bonus;

        internal void setname(string n) {
            name = n;

        
        
        }
        internal string getName() {
            return name;
        }
        internal void setAge(string age) {
            Age = age;
        
        
        }
        internal string getAge() {
        
        return Age;
        }
        internal void setId(string idd) {
            Id= idd;    
        
        
        }
        internal string getId() { return Id; }

        internal void setBonus(string bonus) {
            salaryWbonus=  int.Parse(Salary) + int.Parse(bonus);
        
        }

        internal string getBonus() {
        return  Convert.ToString( salaryWbonus);
        
        }
        internal void setdep(string dep) {
        depaa = dep;
        
        }
        internal string getDep() {
        return depaa;
        }
    }
}
