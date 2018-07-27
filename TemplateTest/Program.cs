using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 模板方法模式
/// </summary>
namespace TemplateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            abstractModel model = new StudentAModel("小明");
            abstractModel model2 = new StudentBModel("小红");

            model.Question();
            model2.Question();

            Console.ReadLine();
        }
    }
}
