using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class Collectioner
	{
		public string collectionerName { get; set; }
		public string countryBirth { get; set; }
		public string favStyleDrawing { get; set; }
		public string pictureName { get; set; }
		public int pictureYear { get; set; }
		public string pictureType { get; set; }

		public Collectioner(string collectionerName, string countryBirth, string favStyleDrawing, string pictureName, int pictureYear, string pictureType)
		{
			this.collectionerName = collectionerName;
			this.countryBirth = countryBirth;
			this.favStyleDrawing = favStyleDrawing;
			this.pictureName = pictureName;
			this.pictureYear = pictureYear;
			this.pictureType = pictureType;
		}

		public Collectioner() : this("empty", "empty", "empty", "empty", 0, "empty") { }
	}
}
