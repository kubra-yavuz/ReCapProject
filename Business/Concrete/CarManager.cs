using System;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByCarId(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);

        }

        public void Add(Car car)
        {
            if (car.Name.Length < 2)
            {
                throw new Exception("Araba ismi minimum 2 karakter olmalıdır.");
            }

            if (car.DailyPrice <= 0)
            {
                throw new Exception("Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }

}

