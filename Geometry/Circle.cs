using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle
    {
            private float _raggio = 0;
            public float Raggio
            {
                get { return _raggio; }
                set
                {
                    _raggio = value;
                    calcArea();
                }
            }

            

            private float _area = 0;
            public float Area
            {
                get
                {
                    return _area;
                }
            }

            public Circle()
            {

            }

            public Circle(float raggio)
            {
                _raggio = raggio;
                calcArea();
            }

            private void calcArea()
            {
                _area = (float)(_raggio * _raggio * Math.PI); 
            }
    }
}
