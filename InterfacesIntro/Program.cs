using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                 FirstName ="Sema",
                 LastName ="Alıcı",
                 Address="Gaziantep",
                 Id=1
            };

            Student student = new Student()
            {
                FirstName = "Sema",
                LastName = "Alıcı",
                Department = "Bilgi İşlem",
                Id = 1
            };

            personManager.Add(student);

            //ICustomerDal çağır
            ServerManager serverManager = new ServerManager();
            SqlServerCustomerDal sqlServerCustomerDal= new SqlServerCustomerDal();  
            serverManager.Add(sqlServerCustomerDal);

            MySqlCustomerDal mySqlCustomerDal= new MySqlCustomerDal();
            serverManager.Add(mySqlCustomerDal);

            Oracle oracle= new Oracle();
            serverManager.Add(oracle);

            Console.ReadLine();
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get ; set ; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
