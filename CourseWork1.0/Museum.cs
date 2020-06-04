using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class Museum
	{
		public string museumName { get; set; }
		public string countryLocation { get; set; }
		public string museumAddress { get; set; }
		public string pictureName { get; set; }
		public int pictureYear { get; set; }
		public string pictureType { get; set; }

		public Museum(string museumName, string countryLocation, string museumAddress, string pictureName, int pictureYear,
			string pictureType)
		{
			this.museumName = museumName;
			this.countryLocation = countryLocation;
			this.museumAddress = museumAddress;
			this.pictureName = pictureName;
			this.pictureYear = pictureYear;
			this.pictureType = pictureType;
		}

		public Museum() : this("empty", "empty", "empty", "empty", 0, "empty") { }
	}
}
