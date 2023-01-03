using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{BrandID=1,CarID=1,DailyPrice=100000,Description="BMW",ModelYear=2022},
            new Car{BrandID=2,CarID=2,DailyPrice=200000,Description="Mercedes",ModelYear=2023 },
            new Car{BrandID=3,CarID=3,DailyPrice=300000,Description="Kia",ModelYear=2023},
            new Car{BrandID=4,CarID=4,DailyPrice=400000,Description="Toyota",ModelYear=2021},
            new Car{BrandID=3,CarID=5,DailyPrice=500000,Description="VW",ModelYear=2020},
            };
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandID == car.BrandID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.CarID = car.CarID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.BrandID==car.BrandID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Car car)
        {
            return _cars;
        }

        public List<Car> GetByID(int carID) => _cars.Where(c => c.CarID == carID).ToList();

       
        
    }
}
