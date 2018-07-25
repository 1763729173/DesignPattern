using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorateTest
{
    public class CarTrim
    {
        private IDecorate _mycar;
        public CarTrim(IDecorate mycar)
        {
            this._mycar = mycar;
        }
        public virtual void Show()
        {
            if (_mycar != null)
            {
                _mycar.Show();
            }
        }
    }
}
