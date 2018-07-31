using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 工厂模式
/// </summary>
namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂
            var factory = new SenderFactory();
            factory.GetSender("SmsSender").Send();
            #endregion
            #region 抽象工厂
            Provider provider = new SmsFactory();
            provider.Produce().Send();
            #endregion
            Console.ReadLine();
        }
    }
}
