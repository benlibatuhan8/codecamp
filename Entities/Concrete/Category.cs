using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity // I ENtityden implemente etmemizin sebebi Category classı  bir veritabanı tablosudur(etiketleme) . IEntity bu classın addressini tutabilir
    {
        //Çıplak Class Kalmasın
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
