using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess
{   //Generic Repository Design Pattern
    //class:Referans tip olabilir demek.
    //IEntity:Bu IEntity olabilir veya IEntityi implemente eden nesne olabilir demektir.
    //new: newlenebilir olmalı.interface newlenemedeği için IEntityde yazamayız.
    public interface IEntityRepository<T> where T:class,IEntity,new()     
        //product veyahut kategori yerine o an ne yazacaksak o gelmeli.O yüzden t koyduk.Ne koyarsak o olacak.
        //Bu t yi sınırlandırmak istiyoruz.Herkes kafasına göre birşey yazmasın."generic constraint".Üstte açıkladık yazılanları.
    {                                                                                       
        List<T> GetAll(Expression<Func<T,bool>> filter=null);   //Linq gibi belli filtrelemeler yapmamıza yarayan kod gibi birşey.
                                                                //filter=null filtre vermeyedebilirsin demektir.Filtre vermediysek tüm datayı istiyoruz demektir.
        T Get(Expression<Func<T, bool>> filter);     //filtre zorunlu. Bize T döndüren bir get operasyonu yazıyoruz.Tek bir nesnenin mesela birkaç hesab içinden herhangi bir hesabın detaylarına inmek içinde kod yazdık.
       
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
