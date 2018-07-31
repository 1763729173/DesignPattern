using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTest
{

    /// <summary>
    /// 具体的构造类
    /// </summary>
    public class ConcreteBuilder : IBuilder
    {
        private Product Product;
        public ConcreteBuilder()
        {
            Product = new Product(); 
        }
        public void buildBasic()
        {
            Product.basic = "设置地基";
        }

        public void buildRoofed()
        {
            Product.roofed = "设置墙顶";
        }

        public void buildWall()
        {
            Product.wall = "设置墙";
        }

        public Product GetProduct()
        {
            return Product;
        }
    }
}
