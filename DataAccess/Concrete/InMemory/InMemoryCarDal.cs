using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;
    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car{CarId=1, BrandId=2, ColorId=3, DailyPrice=30000, Description= "Son Model",ModelYear=2019},
            new Car{CarId=12, BrandId=22, ColorId=33, DailyPrice=500000, Description= "Son Model",ModelYear=2020},
            new Car{CarId=13, BrandId=23, ColorId=34, DailyPrice=7000000, Description= "Son Model",ModelYear=2021},
            new Car{CarId=14, BrandId=24, ColorId=35, DailyPrice=900000, Description= "Son Model",ModelYear=2022},
            new Car{CarId=15, BrandId=25, ColorId=36, DailyPrice=80000, Description= "Son Model",ModelYear=2023},
        };
    }
    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        _cars.Remove(carToDelete);
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        return _cars.FirstOrDefault();

    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Car entity)
    {
        throw new NotImplementedException();
    }
}
