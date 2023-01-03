using Business.Concrete;
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
            
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            inMemoryCarDal.Add(new Entities.Concrete.Car { BrandID = 4, CarID = 6, DailyPrice = 100000, Description = "BMW", ModelYear = 2023 });
            
            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-------------------");

            


            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }
        } 

    }
}
