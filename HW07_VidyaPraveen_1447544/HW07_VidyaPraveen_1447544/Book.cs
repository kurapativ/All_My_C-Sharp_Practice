using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_VidyaPraveen_1447544
{
    class Book 
    {

        int bId;
        string bAuthor;
        string bTitle;

        public Book(int bid, string bauthor, string btitle)
        {
            bId = bid;
            bAuthor = bauthor;
            bTitle = btitle;

        }
        public int BId
        {
            get{

                return BId;
            }
            set{                               
                bId = value;
            }

        }

        public string BTitle
        {
            get
            {

                return BTitle;
            }
            set
            {
                bTitle = value;
            }

        }

        public string BAuthor
        {
            get
            {

                return BAuthor;
            }
            set
            {
                bAuthor = value;
            }

        }
    }
}
