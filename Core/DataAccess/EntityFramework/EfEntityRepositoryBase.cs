﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class, IEntity, new()
        where TContext:DbContext,new()
        
       
    {
        public void Add(TEntity car)
        {
            using (TContext context = new TContext())
            {
                var addedCar = context.Entry(car);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity car)
        {
            using (TContext context = new TContext())
            {
                var deletedCar = context.Entry(car);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

       
        public List<TEntity> GetByID(int id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity car)
        {
            using (TContext context = new TContext())
            {
                var updatedCar = context.Entry(car);
                updatedCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
