using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1._0
{
	[Serializable] // для зчитування та запису у .bin
	public class Artist
	{
		public string artistName { get; set; }
		public string Country { get; set; }
		public string styleOfDrawing { get; set; }
		public DateTime dateOfBirth { get; set; }

		public Artist() : this(artistName: "empty", Country: "empty", styleOfDrawing: "empty", DateTime.MinValue) { }

		public Artist(string artistName, string Country, string styleOfDrawing, DateTime dateOfBirth)
		{
			this.artistName = artistName;
			this.Country = Country;
			this.styleOfDrawing = styleOfDrawing;
			this.dateOfBirth = dateOfBirth;
		}
	}
}
