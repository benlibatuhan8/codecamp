using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
     public interface IProductDal:IEntityRepository<Product>// Bu interface I Entityi producta göre evirdi.
        
        // Product tablosunun Data Acces Layerını yazdığımız için isimlendirmesi böyle .Dal ve .Dao Sektörde bunlar için kullanılır Dao(Data Acces Object).
    {
        //Interfacenin kendisi değil ama tüm operasyonları default publicdir. Operasyonların başına public yazmana gerek yok.

        

    }
}
