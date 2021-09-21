using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car_Model 
    {
        public string title { get; private set; }
        public void SetTitle( string _title)
        {
            title = _title;
        }
    }
}
