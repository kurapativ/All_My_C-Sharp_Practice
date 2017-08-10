using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    class Rectangle
    {

        CustomException cExp;
        private double area;
        private double perimeter;
        private double width =1;
        private double length=1;
        private string color ="WHITE"; 
        

        public Rectangle(double Width, double Length, string Color)
        {
            if (Width <= 0)
            {
                throw new CustomException("Width less than or equal to zero");
            }else
            {
                width = Width;
            }

            if(Length <= 0)
            {
                throw new CustomException("Length less than or equal to zero");
            }
            else
            {
                length = Length;
            }
            
            
            color = Color;
        }

        public Rectangle(double Width, double Length)
        {
            if (Width <= 0)
            {
                throw new CustomException("Width less than or equal to zero");
            }
            else
            {
                width = Width;
            }

            if (Length <= 0)
            {
                throw new CustomException("Length less than or equal to zero");
            }
            else
            {
                length = Length;
            }
        }

        public Rectangle()
        {

        }


        public double _Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new CustomException("Width less than or equal to zero");
                }
                else
                {
                    width = value;
                }                  
                
            }
        }
               
        public double _Length {
            get
            {
                return length;
            }
            set
            {
                //try
                //{
                    if (value <= 0)
                    {
                        throw new CustomException("Length less than or equal to zero");
                    }
                    else
                    {
                        length = value;
                    }
                //}catch(CustomException e)
                //{
                //    Console.WriteLine(e.message);
                //}
                
                
            }
        }

        private string _Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        } 

        public string GetRectangle()
        {
           
            return "width, length and color  of rectangle are " + width+" "+"W,"+" " +length+"L,"+" "+color;  
        }

        public string Area()
        {
            //if (length <= 0 || width <= 0)
            //{
            //    throw new Exception("Height or width cant be less than or equal to zero");
            //}
            //else
            //{
                area = width * length;
                return "Area of the Rectangle is :" + area + " SqUnits";
        //}

    }
        public string Perimeter()
        {
            //if (length <= 0 || width <= 0)
            //{
            //    throw new Exception("Height or width cant be less than or equal to zero");
            //}
            //else
            //{

                perimeter = 2 * (length + width);
                return "Perimenter of the Rectangle is :" + perimeter + " Units";


            //}

        }
        

    }
   

}

