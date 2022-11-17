using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Estore.Models.ViewModels
{
/// <summary>
/// For ProductForm
/// </summary>
	public class ProductIndexView
	{
		public int id { get; set; }
		public string CategoryName { get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }
	}
	/// <summary>
	/// For EditProductform,CreateProducctForm
	/// </summary>
	public class ProductVM
	{
		public int Id { get; set; }
		public int CategoryID{ get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }


	}
}
