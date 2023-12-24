using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		List<Car> GetAllByCarId(int id);
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
		
	}
}

