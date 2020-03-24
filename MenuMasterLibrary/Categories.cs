using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Categories
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }

        public Categories()
        {

        }

        public Categories(int categoryid, string categoryname)
        {
            this.categoryid = categoryid;
            this.categoryname = categoryname;
        }
    }



}
