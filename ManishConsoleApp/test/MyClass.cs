using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.test
{
    public class MyClass
    {
        private readonly ICustomData _customData;//iconfig

        public MyClass(ICustomData customData)
        {
            _customData = customData;
        }

        public int DoSomething() //get string
        {
            int value = _customData.GetValue();
            return value * 2;
        }
    }
}
