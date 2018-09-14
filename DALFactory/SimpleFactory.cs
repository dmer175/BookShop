using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.DALFactory
{
    public partial class SimpleFactory
    {
        //简单工厂的实现  直接new
        public static BookShop.IDAL.IBookType GetBookTypeDal()
        {
            return new BookShop.DAL.BookType();
        }
    }
}
