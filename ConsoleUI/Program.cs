using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BrandGetAllTest();
            //CarTest();
            //ColorTest();
            //CustomerTest();
            
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CustomerId + "/" + customer.CustomerName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorsDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName + "/" + color.ColorId);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName);
            }
                               
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandsDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName + "/"+ brand.BrandId);
            } 
        }

       
       
    }
}
