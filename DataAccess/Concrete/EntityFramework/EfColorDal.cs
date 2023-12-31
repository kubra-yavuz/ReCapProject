﻿using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;


public class EfColorDal : IColorDal
{
    public void Add(Color entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Color entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var deleteEntity = context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public Color Get(Expression<Func<Color, bool>> filter)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Set<Color>().SingleOrDefault(filter);
        }
    }

    public List<Color> GetAll(Expression<Func<Color, bool>> filter=null)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return filter == null ? context.Set<Color>().ToList() :
                context.Set<Color>().Where(filter).ToList();
        }
    }

    public void Update(Color entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

