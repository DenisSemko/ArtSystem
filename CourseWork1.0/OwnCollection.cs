using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class OwnCollection
	{
		public string myCollectionName { get; set; }
		public string pictureName { get; set; }
		public int pictureYear { get; set; }
		public string pictureType { get; set; }
		public string placeBuy { get; set; }

		public OwnCollection(string myCollectionName, string pictureName, int pictureYear, string pictureType,
			string placeBuy)
		{
			this.myCollectionName = myCollectionName;
			this.pictureName = pictureName;
			this.pictureYear = pictureYear;
			this.pictureType = pictureType;
			this.placeBuy = placeBuy;
		}
		public OwnCollection() : this("empty", "empty", 0, "empty", "empty") { }
	}
}
