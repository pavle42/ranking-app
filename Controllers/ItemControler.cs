using Microsoft.AspNetCore.Mvc;
using RankingApp.Models;

namespace RankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id =1, Title = "Real Madrid", ImageId=1, Ranking=0,ItemType=1 },
            new ItemModel{Id =2, Title = "Bayern", ImageId=2, Ranking=0,ItemType=1 },
            new ItemModel{Id =3, Title = "Barcelona", ImageId=3, Ranking=0,ItemType=1 },
            new ItemModel{Id =4, Title = "Inter", ImageId=4, Ranking=0,ItemType=1 },
            new ItemModel{Id =5, Title = "Man City", ImageId=5, Ranking=0,ItemType=1 },
            new ItemModel{Id =6, Title = "Dortmund", ImageId=6, Ranking=0,ItemType=1 },
            new ItemModel{Id =7, Title = "PSG", ImageId=7, Ranking=0,ItemType=1 },
            new ItemModel{Id =8, Title = "Arsenal", ImageId=8, Ranking=0,ItemType=1 },
            new ItemModel{Id =9, Title = "Napoli", ImageId=9, Ranking=0,ItemType=1 },
            new ItemModel{Id =10, Title = "Porto", ImageId=10, Ranking=0,ItemType=1 },
            /*new ItemModel{Id = 11, Title = "LA Lakers", ImageId=11, Ranking=0,ItemType=2 },
            new ItemModel{Id = 12, Title = "Golden State Warriors", ImageId=12, Ranking=0,ItemType=2 },
            new ItemModel{Id = 13, Title = "Brooklyn Nets", ImageId=13, Ranking=0,ItemType=2 },
            new ItemModel{Id = 14, Title = "Chicago Bulls", ImageId=14, Ranking=0,ItemType=2 },
            new ItemModel{Id = 15, Title = "Boston Celtics", ImageId=15, Ranking=0,ItemType=2 },
            new ItemModel{Id = 16, Title = "Miami Heat", ImageId=16, Ranking=0,ItemType=2 },
            new ItemModel{Id = 17, Title = "Dallas Mavericks", ImageId=17, Ranking=0,ItemType=2 },
            new ItemModel{Id = 18, Title = "Toronto Raptors", ImageId=18, Ranking=0,ItemType=2 },
            new ItemModel{Id = 19, Title = "Philadelphia 76ers", ImageId=19, Ranking=0,ItemType=2 },
            new ItemModel{Id = 20, Title = "Denver Nuggets", ImageId=20, Ranking=0,ItemType=2 }*/

        };

        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            System.Threading.Thread.Sleep(2000);
            return items;
        }
    }
}
