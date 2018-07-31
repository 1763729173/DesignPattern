using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 原型模式
/// </summary>
namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address() { Name = "杭州" };
            Person person = new Person() { Name = "小明", Address = address };

            #region 浅拷贝
            Person clonePerson = person.Clone() as Person;
            Console.WriteLine(clonePerson.Address == person.Address);
            #endregion

            #region 深拷贝
            Person deepClonePerson = SerializeHelper.Deserialize<Person>(SerializeHelper.Serialize(person));
            Console.WriteLine(deepClonePerson.Address == person.Address);
            #endregion
            Console.ReadLine();
        }
    }
}
