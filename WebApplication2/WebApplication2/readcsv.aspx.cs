using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class readcsv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Success");

            //StreamReader sr = new StreamReader("C:/Users/Tatha/documents/visual studio 2015/Projects/WebApplication2/WebApplication2/Test.csv");

            //string line;

            //while ((line = sr.ReadLine()) != null)
            //{
            //    //  Console.WriteLine(line);
            //    string[] columns = line.Split(',');
            //    Console.WriteLine(columns[0] + " " + columns[1] + " " + columns[2] + " " + columns[3]);
            //}

            //sr.Close();
            //Console.WriteLine("Success");

        }
    }
}