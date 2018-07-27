using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeditorTest
{
    public abstract class Person
    {
        protected Mediator mediator;
        private string Name;
        public Person(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void SendMessage(string message);
        public abstract void GetMessage(string message);
    }
}
