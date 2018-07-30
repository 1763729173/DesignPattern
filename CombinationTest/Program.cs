using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 组合模式
/// </summary>
namespace CombinationTest
{
    class Program
    {

        /// <summary>
        /// 生成节点树
        /// </summary>
        /// <param name="node"></param>
        public static void createTree(DirectoryNode node)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(node.name);
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (var file in fileInfo)
            {
                FileNode fileNode = new FileNode() { name = file.FullName };
                node.addFileNode(fileNode);
            }
            DirectoryInfo[] subInfo = directoryInfo.GetDirectories();
            foreach (var directory in subInfo)
            {
                DirectoryNode directoryNode = new DirectoryNode() { name = directory.FullName };
                node.addDirectoryNode(directoryNode);
                createTree(directoryNode);
            }

        }
        static void Main(string[] args)
        {
            DirectoryNode directoryNode = new DirectoryNode() { name = @"E:\BaiduNetdiskDownload" };
            createTree(directoryNode);
            directoryNode.display();

            Console.ReadLine();
        }
    }
}
