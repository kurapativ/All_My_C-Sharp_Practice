using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susheel_HW03
{
    class Rectangle
    {
        private double _area;
        private double _perimeter;
        private double _width = 1;
        private double _height = 1;
        private string _color = "WHITE";

        public Rectangle(double Width, double Height, string Color)
        {
            _width = Width;
            _height = Height;
            _color = Color;
        }

       
        public Rectangle()
        {

        }

        private double _Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        private double _Height
        {
            get
            {
                return _height;
            }
            set
            {

                _height = value;
            }
        }

        private string _Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public string GetRectangle()
        {

            return "Width:" + " "+_width + " " + "Height:" + " " + _height + " "+"Color:" + " " + _color;
        }

        public string Area()
        {
             _area = _width * _height;
                return "Area = " + _area ;
            

        }
        public string Perimeter()
        {
         
                _perimeter = 2 * (_height + _width);
                return "Perimenter = " + _perimeter;


            }

        }
    }

