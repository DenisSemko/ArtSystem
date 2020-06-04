using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class Auction
	{
		public string auctionName { get; set; }
		public DateTime dateHoldingEvent { get; set; }
		public string pictureName { get; set; }
		public int pictureYear { get; set; }
		public int pictureFirstPrice { get; set; }

		public Auction(string auctionName, DateTime dateHoldingEvent, string pictureName, int pictureYear, int pictureFirstPrice)
		{
			this.auctionName = auctionName;
			this.dateHoldingEvent = dateHoldingEvent;
			this.pictureName = pictureName;
			this.pictureYear = pictureYear;
			this.pictureFirstPrice = pictureFirstPrice;
		}
		public Auction() : this("empty", DateTime.MinValue, "empty", 0, 0) { }
	}
}
