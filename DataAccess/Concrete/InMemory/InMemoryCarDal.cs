using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            new Car{BrandId=1,CarId=1,DailyPrice=100000,Description="BMW",ModelYear=2022},
            new Car{BrandId=2,CarId=2,DailyPrice=200000,Description="Mercedes",ModelYear=2023 },
            new Car{BrandId=3,CarId=3,DailyPrice=300000,Description="Kia",ModelYear=2023},
            new Car{BrandId=4,CarId=4,DailyPrice=400000,Description="Toyota",ModelYear=2021},
            new Car{BrandId=3,CarId=5,DailyPrice=500000,Description="VW",ModelYear=2020},
            };
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
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
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Car car)
        {
            return _cars;
        }

        public List<Car> GetByID(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext carContext = new CarContext())
            {
                return filter == null ? carContext.Set<Car>().ToList() : carContext.Set<Car>().Where(filter).ToList();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarContext carContext = new CarContext())
            {
                return carContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }    
}
