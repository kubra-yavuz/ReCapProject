using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IColorService
	{
        List<Color> GetAll();
        List<Color> GetAllByColorId(int id);
    }
}

