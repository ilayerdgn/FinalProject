using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

//Standart oluşturma
namespace Core.DataAccess
{ //Tekrarladığı için tip belirtmeden generic bir şekilde aynı işlemler gerçekleşirebilir

    public interface IEntityRepository<T> where T:class, IEntity,new()//generic constraint
        //class olabilir değil referans tip olabilir demek bunu önlemek için IEntity yazarak sadece ondan referans alanlar veya ıentity olabilir
        //new(): newlenebilir olmalı demek bu nedenle artık IEntity kullanılamaz. Sadece referans alanları kullanır
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); Artık ihtiyaç kalmadı
    }
}
