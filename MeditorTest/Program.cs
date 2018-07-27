using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 中介者模式
/// </summary>
namespace MeditorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new HouseMediator();
            var landLordA = new LandLord("房东A");
            var landLordB = new LandLord("房东B");
            var render = new Render("租房者A");

            landLordA.SetMediator(mediator);
            landLordB.SetMediator(mediator);
            render.SetMediator(mediator);
            mediator.AddLord(landLordA);
            mediator.AddLord(landLordB);
            mediator.AddRender(render);

            render.SendMessage("我要租房子，价格在3000左右!");

            Console.ReadLine();
        }
    }
}
