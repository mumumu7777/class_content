using ISpan.Utility;
using LibararySystemDemo.model.dataindex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibararySystemDemo
{
    public partial class Books : Form
    {
        private BooksIndexView[] bookCategories = null;

        public Books()
        {

            InitializeComponent();
            InitForm();
            DisplayBookCategory();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            DisplayBookCategory();

        }

        private void DisplayBookCategory()
        {
            //string sql = @"SELECT * FROM Books join BookCategory on Books.CategoryID = BookCategory.CategoryID";
            string sql = @"SELECT c.* FROM
                                (SELECT 
                                    b.BookID,
                                    b.BookName, 
                                    b.Author, 
                                    b.ISBN, 
                                    b.PublishYear,
                                    bc.CategoryName,
                                    bc.CategoryID
                                FROM Books b , BookCategory bc
                                WHERE b.categoryid= bc.categoryid) c
                          ";

            //取得篩選值
            //SqlParameter[] parameters = new SqlParameter[] { };
            var parameters = new List<SqlParameter>();
            //表單選的直
            int categoryId = ((BookCategoryIndexView)bookclasscombobox.SelectedItem).CategoryID;
            string bookName = BooknameText.Text;
            string author = authortext.Text;
            string isbn = isbntexbox.Text;
            string pYear = publishyeartextbox.Text;

            sql += " WHERE 1 = 1 ";


            if (categoryId > 0)
            {
                sql += " AND categoryid= @categoryid";

                var par = new SqlParameter("categoryid", SqlDbType.Int);
                par.Value = categoryId;
                parameters.Add(par);

            }

            if (!string.IsNullOrWhiteSpace(bookName))
            {
                sql += " AND BookName like @bookName";

                var par = new SqlParameter("bookName", SqlDbType.NVarChar, bookName.Length + 2);
                par.Value = $"%{bookName}%";
                parameters.Add(par);
            }

            if (!string.IsNullOrWhiteSpace(author))
            {
                sql += " AND Author like @author";

                var par = new SqlParameter("author", SqlDbType.NVarChar, author.Length + 2);
                par.Value = $"%{author}%";
                parameters.Add(par);

            }

            if (!string.IsNullOrWhiteSpace(isbn))
            {
                sql += " AND ISBN = @isbn";

                var par = new SqlParameter("isbn", SqlDbType.NVarChar, isbn.Length);
                par.Value = isbn;
                parameters.Add(par);
            }


            if (!string.IsNullOrWhiteSpace(pYear))
            {
                int intYear = -1;
                int.TryParse(pYear, out intYear);

                if(intYear != -1)
                {
                    sql += " AND PublishYear= @intYear";

                    var par = new SqlParameter("intYear", SqlDbType.Int);
                    par.Value = intYear;
                    parameters.Add(par);

                }
            }


            //sql += " ORDER BY BookID ";
            var dbHelper = new SqlDBhelper("default");

            bookCategories = dbHelper.Select(sql, parameters.ToArray())
                .AsEnumerable()
                .Select(row => ParseTobookcategoryIndexVM(row))
                .ToArray();
           
            BindData(bookCategories);
        }

        private void BindData(BooksIndexView[] data)
        {
            dataGridView1.DataSource = data;
        }

        private BookCategoryIndexView TOBookClassIndex(DataRow row)
        {
            return new BookCategoryIndexView
            {
                CategoryID = row.Field<int>("CategoryID"),
                CategoryName = row.Field<string>("CategoryName"),
            };
        }

        private void InitForm()
        {

            bookclasscombobox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM BookCategory order by CategoryName";
            var dbHelper = new SqlDBhelper("default");

            List<BookCategoryIndexView> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => TOBookClassIndex(row))
                .Prepend(new BookCategoryIndexView { CategoryID = 0, CategoryName = String.Empty })
                .ToList();

            this.bookclasscombobox.DataSource = categories;

        }

        private BooksIndexView ParseTobookcategoryIndexVM(DataRow row)
        {
            return new BooksIndexView
            {

                Author = row.Field<string>("Author"),
                //CategoryID = row.Field<int>("CategoryID"),
                CategoryName = row.Field<string>("CategoryName"),
                BookName = row.Field<string>("BookName"),
                ISBN = row.Field<string>("ISBN"),
                PublishYear = row.Field<int>("PublishYear"),
                //BookID = row.Field<int>("BookID")
            };
        }

        private void BookCategory_Load(object sender, EventArgs e)
        {

        }





        //private void textget
    }
}
