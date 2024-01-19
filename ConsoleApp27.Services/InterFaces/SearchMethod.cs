using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Services.InterFaces
{
    public interface SearchMethod
    {
        void Search(string name, string surName);
        int GettingTheSameNames(string name);
        
    }
}
