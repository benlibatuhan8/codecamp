using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implementation of C#
            using (NorthwindContext context=new NorthwindContext()) // contextle işimiz bittiği zaman garbage collector direk onu siliyor. Normal de newleyebilirdik.Performans önemli!!
            {
                var addedEntity = context.Entry(entity); //Referansı yakala
                addedEntity.State = EntityState.Added;   // O referansı ekle
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) 
            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted;   
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context= new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using(NorthwindContext context= new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();  //filtre yoksa context Producta set olsun ve listele
            }                                                                                                             //filtre null değilse datayı filtrele ve getir
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
               updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
