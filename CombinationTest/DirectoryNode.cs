using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationTest
{

    /// <summary>
    /// 目录节点
    /// </summary>
    public class DirectoryNode : Node
    {
        private List<FileNode> fileNodes = new List<FileNode>();
        private List<DirectoryNode> directoryNodes = new List<DirectoryNode>();
        public string name { get; set; }
        public void addFileNode(FileNode node)
        {
            fileNodes.Add(node);
        }

        public void addDirectoryNode(DirectoryNode node)
        {
            directoryNodes.Add(node);
        }

        public void display()
        {
            foreach(var file in fileNodes)
            {
                file.display();
            }
            Console.Write("目录：" + name);
            foreach (var directory in directoryNodes)
            {
                directory.display();
            }
        }
    }
}
