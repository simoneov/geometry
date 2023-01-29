using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle
    {
        private float _base = 0;
        private float _height = 0;
        public float Base
        {
            get { return _base; }
            set
            {
                _base = value;
                calcArea();
            }
        }


        public float Height
        {
            get { return _height; }
            set
            {
                _height = value;
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

        public Triangle()
        {

        }

        public Triangle(float _base, float _height )
        {
            this._base=_base;
            this._height = _height;
            calcArea();
        }

        private void calcArea()
        {
            _area =(_base * _height)/2;
        }


    }
}
