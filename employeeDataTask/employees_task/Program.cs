namespace employees_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employe = new Employees();
            Console.WriteLine("enter the first_name==>");
            employe.setFnameEmployee(Console.ReadLine());
            Console.WriteLine("enter the last_name==>");
            employe.setLnameEmployee(Console.ReadLine());
            Console.WriteLine("enter the Ssn===>");
            employe.setSsnEmployee(decimal.Parse(Console.ReadLine()));
            do
            {
                try
                {
                    Console.WriteLine("enter the age==>");
                    employe.setAgeEmployee(int.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (employe.getAgeEmployee() < 23 || employe.getAgeEmployee() > 45);

            do
            {
                try
                {
                    Console.WriteLine("enter the adress==>");
                    employe.setAdressEmployee(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (employe.getAdressEmployee() != "cairo" && employe.getAdressEmployee() !="alex"  && employe.getAdressEmployee()!= "giza");


            employe.print();



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
                if(_Adress == "cairo" || _Adress == "alex" || _Adress == "giza" ) {

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
            public string getLnameEmployee() {  return lname; }
            public int getAgeEmployee() { return age;}
            public string getAdressEmployee() { return Adress; }
            public string getFnameEmployee() { return fname;}
            
            public void print()
            {
                Console.WriteLine($" the first_name {this.fname} \n the last_name {this.lname} \n the ssn :- {ssn} \n the age :-{this.age} \n the adress:- {this.Adress}");
            }


        }
    }
}