using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BookShop.BLL
{
    public partial class BookType
    {
        //简但工厂
        //private readonly BookShop.IDAL.IBookType dal = BookShop.DALFactory.SimpleFactory.GetBookTypeDal();

        //抽象工厂
        private readonly BookShop.IDAL.IBookType dal = BookShop.DALFactory.AbstractFactory.GetBookTypeDal();

        public bool Delete(BookShop.Model.BookType bookType)
        {
            return Delete(int.Parse(bookType.TypeId));
        }

        
    }
}
