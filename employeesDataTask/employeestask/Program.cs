

namespace employees_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of employee:-");
            int n = int.Parse(Console.ReadLine());
            Employees [] employees = new Employees[n];

            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine($"employee {i+1}=====>");
                Console.WriteLine("Enetr first name:");
                employees[i].setFnameEmployee(Console.ReadLine());

                Console.WriteLine("Enter last name:");
                employees[i].setLnameEmployee(Console.ReadLine());
                do {
                    try
                    {

                        Console.WriteLine("Enter Adress:");
                        employees[i].setAdressEmployee(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }while (employees[i].getAdressEmployee() != "cairo" && employees[i].getAdressEmployee() != "alex" && employees[i].getAdressEmployee() != "giza") ;

                do
                {
                    try
                    {
                        Console.WriteLine("Enter age:");
                        employees[i].setAgeEmployee(int.Parse(Console.ReadLine()));
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while ( employees[i].getAgeEmployee() < 23 || employees[i].getAgeEmployee() > 45);

                Console.WriteLine("Enter Ssn:");
                employees[i].setSsnEmployee(decimal.Parse(Console.ReadLine()));

            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"employee {i + 1} ======>" + employees[i].print());
            }
        }
        struct Employees
        {
            decimal ssn;
            string fname;
            string lname;
            int age;
            string Adress;
            public void setAgeEmployee(int Age)
            {
                if (Age < 23 || Age > 45)
                {
                    throw new Exception("the age must be between 23 to 45");
                }
                else age = Age;
            }
            public void setAdressEmployee(string _Adress)
            {
                if (_Adress == "cairo" || _Adress == "alex" || _Adress == "giza")
                {

                    Adress = _Adress;
                }
                else
                {

                    throw new Exception("The address must be in cairo, alexandria or giza");

                }
            }
            public void setFnameEmployee(string _Fname)
            {
                fname = _Fname;
            }
            public void setLnameEmployee(string _Lname)
            {
                lname = _Lname;
            }
            public void setSsnEmployee(decimal Ssn)
            {
                ssn = Ssn;
            }
            public decimal getSSnmployee() { return ssn; }
            public string getLnameEmployee() { return lname; }
            public int getAgeEmployee() { return age; }
            public string getAdressEmployee() { return Adress; }
            public string getFnameEmployee() { return fname; }

            public string print()
            {
                
                return($" the first_name {this.fname} \n the last_name {this.lname} \n the ssn :- {ssn} \n the age :-{this.age} \n the adress:- {this.Adress}");
            }


        }
    }
}