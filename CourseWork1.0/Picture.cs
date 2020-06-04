using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class Picture
	{
		public string authorName { get; set; }
		public string pictureName { get; set; }
		public string pictureGenre { get; set; }
		public int pictureYear { get; set; }
		public string drawingMaterial { get; set; }
		public string pictureSize { get; set; }
		public string displayMethod { get; set; }

		public Picture(string authorName, string pictureName, string pictureGenre, int pictureYear, string drawingMaterial, string pictureSize, string displayMethod)
		{
			this.authorName = authorName;
			this.pictureName = pictureName;
			this.pictureGenre = pictureGenre;
			this.pictureYear = pictureYear;
			this.drawingMaterial = drawingMaterial;
			this.pictureSize = pictureSize;
			this.displayMethod = displayMethod;
		}
		public Picture() : this(authorName: "empty", pictureName: "empty", pictureGenre: "empty", pictureYear: 0, drawingMaterial: "empty", pictureSize: "empty", displayMethod: "empty") { }

	}
}
