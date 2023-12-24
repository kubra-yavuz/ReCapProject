using System;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetAllByBrandId(int id)
        {
            return _brandDal.GetAll(b => b.BrandId == id);
        }
    }
}

