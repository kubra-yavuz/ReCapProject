using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ColorManager:IColorService
	{
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetAllByColorId(int id)
        {
            return _colorDal.GetAll(c => c.ColorId == id);
        }
    }
}

