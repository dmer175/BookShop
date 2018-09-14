using System;
using System.Collections.Generic;
using System.Data;
//using System.Linq;
using System.Text;

namespace BookShop.IDAL
{
    public interface IBookType
    {
        int GetMaxId();
        bool Exists(int TypeId);
        bool Add(BookShop.Model.BookType model);
        bool Update(BookShop.Model.BookType model);
        bool Delete(int TypeId);
        bool DeleteList(string TypeIdlist);
        BookShop.Model.BookType GetModel();
        BookShop.Model.BookType DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
