using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CourseWork1._0
{
	public class Dao
	{
		Art arts;
		const string pathFile = "arts.bin";

		public Dao(Art arts)
		{
			this.arts = arts;
		}

		// метод збереження даних то файлу
		public void SaveData()
		{
			using (Stream stream = File.Create(pathFile))
			{
				var serializer = new BinaryFormatter();
				serializer.Serialize(stream, arts);
			}
		}

		// метод завантаження даних з файлу
		public void LoadData()
		{
			using (Stream stream = File.OpenRead(pathFile))
			{
				var serializer = new BinaryFormatter();
				Art art = (Art)serializer.Deserialize(stream);

				Copy(art.artists, arts.artists);
				Copy(art.pictures, arts.pictures);
				Copy(art.museums, arts.museums);
				Copy(art.auctions, arts.auctions);
				Copy(art.collectioners, arts.collectioners);
				Copy(art.comShops, arts.comShops);
				Copy(art.ownCollections, arts.ownCollections);
			}

			// метод копіювання Generic Lists
			void Copy<T>(List<T> from, List<T> to)
			{
				to.Clear();
				to.AddRange(from);
			}
		}
	}
}
