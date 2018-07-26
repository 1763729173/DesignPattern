using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stateTest
{
    public interface IState
    {

        /// <summary>
        /// 启动方法
        /// </summary>
        void Start();

        /// <summary>
        /// 停止方法
        /// </summary>
        void Stop();

        void PrintState();
    }
}
