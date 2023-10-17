using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.interfaces
{
    public class ImplementationClass : ISampleInterface
    {

        public ImplementationClass(string name)
        {
            Name = name;
        }
        public string Name
        {
            get; 
            set ; 
        }

        public void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
