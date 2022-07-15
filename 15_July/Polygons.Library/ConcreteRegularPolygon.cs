using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public  class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }



        public int SideLength;
        //public int Sidelength
        //{
        //    get {  return SideLength; }
        //    set { SideLength = value; }
        //}


        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;

        }
        public double GetPerimeter()
        {
            return NumberOfSides* SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

    }
}
