using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationTest
{
    /// <summary>
    /// 文件节点
    /// </summary>
    public class FileNode : Node
    {
        public string name { get; set; }
        public void display()
        {
            Console.WriteLine("文件：" + name);
        }
    }
}
