using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWork1._0
{
	[Serializable]
	public class Art
	{
		// Списки класів
		public List<Artist> artists { get; set; }
		public List<Picture> pictures { get; set; }
		public List<Museum> museums { get; set; }
		public List<Collectioner> collectioners { get; set; }
		public List<Auction> auctions { get; set; }
		public List<CommissionShop> comShops { get; set; }
		public List<OwnCollection> ownCollections { get; set; }
		public bool isChangeData;

		public Art()
		{
			artists = new List<Artist>();
			pictures = new List<Picture>();
			museums = new List<Museum>();
			collectioners = new List<Collectioner>();
			auctions = new List<Auction>();
			comShops = new List<CommissionShop>();
			ownCollections = new List<OwnCollection>();
		}
		// загальний метод збереження даних
		public void Save()
		{
			new Dao(this).SaveData();
		}

		// загальний метод завантаження даних
		public void Load()
		{
			new Dao(this).LoadData();
			isChangeData = false;
		}

		// методи додавання нових елементів
		#region AddMethods
		public void AddArtist(Artist art)
		{
			artists.Add(art);
			isChangeData = false;
		}

		public void AddPicture(Picture pct)
		{
			pictures.Add(pct);
			isChangeData = false;
		}

		public void AddMuseum(Museum msm)
		{
			museums.Add(msm);
			isChangeData = false;
		}

		public void AddCollectioner(Collectioner clr)
		{
			collectioners.Add(clr);
			isChangeData = false;
		}

		public void AddAuction(Auction au)
		{
			auctions.Add(au);
			isChangeData = false;
		}

		public void AddOwnCollection(OwnCollection oc)
		{
			ownCollections.Add(oc);
			isChangeData = false;
		}
		public void AddComShop(CommissionShop cs)
		{
			comShops.Add(cs);
			isChangeData = false;
		}
		#endregion
	}
}
