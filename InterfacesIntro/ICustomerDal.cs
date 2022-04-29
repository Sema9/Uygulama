using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    internal interface ICustomerDal //Dal(Vei erişim katmanı)
    {
        void Add();
        void Update();
        void Delete();  
        
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added SQL"); 
        }

        public void Delete()
        {
            Console.WriteLine("Deleted SOL"); 
        }

        public void Update()
        {
            Console.WriteLine("Updated SQL");  
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added MYSQL");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted MYSOL");
        }

        public void Update()
        {
            Console.WriteLine("Updated MYSQL");
        }
    }

    class Oracle : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added ORACLE");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted ORACLE");
        }

        public void Update()
        {
            Console.WriteLine("Updated ORACLE");
        }
    }

    class ServerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
    }
}
