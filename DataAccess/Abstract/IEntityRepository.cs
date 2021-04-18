using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint (Generic kısıt T yi kısıtlıyorsun yanlışlıkla int gibi veri tipleri verme diye )
    //IEntity nin implemente edildiği classlardan farklı classlardan implemente olmaz.
    //IEntity interface olarak soyut bir yapı olduğundan dolayı IEntitynin kendisinden implementasyon yapmak istemiyoruz.
    //new() anahtar kelimesiyle newlenebilir soyut olmayan sınıflardan generic olabileceğini gösterdik.
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);

    }
}
