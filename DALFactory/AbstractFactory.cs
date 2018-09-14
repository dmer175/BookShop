using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BookShop.DALFactory
{
    public partial class AbstractFactory
    {
        public static BookShop.IDAL.IBookType GetBookTypeDal()
        {
            string temp = ConfigurationManager.AppSettings["BookTypeDal"];
            string [] temp2= temp.Split(',');
            //反射:创建对象
            //1.获取程序集对象
            Assembly asm= Assembly.Load(temp2[1]);//程序集的名称
            //2.创建实例
            object obj= asm.CreateInstance(temp2[0]);//类的完整名称(带命名空间)

            //as是用于检查在兼容的引用类型之间执行某些类型的转换，注意只有引用类型才可以，
            //如果兼容as会返回对同一个对象的一个非null的引用，否则返回一个null。

            //简单的说就是，如果一个对象可以被转换成as后面的那个类型，那么就会返回这个类型的对象，否则就会得到一个null。

            return obj as BookShop.IDAL.IBookType;
        }
    }
}
