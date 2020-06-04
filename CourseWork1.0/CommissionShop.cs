using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class CommissionShop
	{
		public string shopName { get; set; }
		public string shopAddress { get; set; }
		public string pictureName { get; set; }
		public int pictureYear { get; set; }
		public int picturePrice { get; set; }

		public CommissionShop(string shopName, string shopAddress, string pictureName, int pictureYear,
			int picturePrice)
		{
			this.shopName = shopName;
			this.shopAddress = shopAddress;
			this.pictureName = pictureName;
			this.pictureYear = pictureYear;
			this.picturePrice = picturePrice;
		}

		public CommissionShop() : this("empty", "empty", "empty", 0, 0) { }
	}
}
