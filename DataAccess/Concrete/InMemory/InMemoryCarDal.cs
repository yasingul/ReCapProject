using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1415, DailyPrice=150000, ModelYear=2015, Description="Toyota Spor Car"},
                new Car {Id=2, BrandId=2, ColorId=1005, DailyPrice=50000, ModelYear=2012, Description="Suzuki Car"},
                new Car {Id=3, BrandId=3, ColorId=1356, DailyPrice=3000000, ModelYear=2021, Description="Ferrari Spor Car"},
                new Car {Id=4, BrandId=2, ColorId=0025, DailyPrice=100000, ModelYear=2018, Description="Suzuki Spor Car"},
                new Car {Id=5, BrandId=4, ColorId=9658, DailyPrice=225000, ModelYear=1985, Description="Ford Classic Spor Car"},
                new Car {Id=6, BrandId=4, ColorId=1851, DailyPrice=20000, ModelYear=2000, Description="Ford Car"}
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
