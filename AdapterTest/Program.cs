using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 适配器模式
/// </summary>
namespace AdapterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            # region 类的适配器
            ClassAdapter.MyAdapter classAdapter = new ClassAdapter.MyAdapter();
            classAdapter.isPs2();
            #endregion

            #region 接口的适配器
            InterfaceAdapter.ConcreteClass concreteClass = new InterfaceAdapter.ConcreteClass();
            concreteClass.method1();

            #endregion

            #region 对象的适配器
            ObjectAdapter.Usber usber = new ObjectAdapter.Usber();
            ObjectAdapter.MyAdapter objectAdapter = new ObjectAdapter.MyAdapter(usber);
            objectAdapter.isPs2();
            #endregion

            Console.ReadLine();
        }
    }
}
