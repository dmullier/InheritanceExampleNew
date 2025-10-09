using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal interface IShape
    {
        void draw(Graphics g);
        float calcArea();
    }
}
