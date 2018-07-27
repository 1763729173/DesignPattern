using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditorTest
{

    /// <summary>
    /// 房屋中介
    /// </summary>
    public class HouseMediator : Mediator
    {
        private List<Person> lordList = new List<Person>();
        private List<Person> renderList = new List<Person>();
        public void AddLord(Person person)
        {
            lordList.Add(person);
        }
        public void RemoveLord(Person person)
        {
            lordList.Remove(person);
        }
        public void AddRender(Person person)
        {
            renderList.Add(person);
        }
        public void RemoveRender(Person person)
        {
            renderList.Remove(person);
        }
        public override void Opreator(Person person, string message)
        {
            if(person is LandLord)
            {        
                foreach (var item in renderList)
                {
                    item.GetMessage(person.GetName()+":"+message);
                }
            }
            else if(person is Render)
            {
                foreach (var item in lordList)
                {
                    item.GetMessage(person.GetName() + ":" + message);
                }
            }
        }
    }
}
