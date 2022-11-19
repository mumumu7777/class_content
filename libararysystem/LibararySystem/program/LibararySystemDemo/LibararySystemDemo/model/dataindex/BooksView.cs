using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystemDemo.model.dataindex
{
	public class BooksIndexView
	{
        //public int BookID { get; set; }

        public string BookName { get; set; }

        public string CategoryName { get; set; }

        //public int CategoryID { get; set; }

        public string Author { get; set; }

		public string ISBN { get; set; }

		public int PublishYear { get; set; }

	}

	public class BooksView
    {
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string CategoryName { get; set; }

        public int CategoryID { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public int PublishYear { get; set; }

    }

}
