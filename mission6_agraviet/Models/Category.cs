using System;
using System.ComponentModel.DataAnnotations;

namespace mission6_agraviet.Models
{
	public class Category
	{
		[Key]
		[Required]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
	}
}

