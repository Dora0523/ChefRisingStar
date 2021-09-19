using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Text;
using Newtonsoft.Json;

namespace ChefRisingStar.Models
{
    class LeaderboardModel
    {
        public string Name { get; set; }
		public Color Color { get; set; }
		public List<Rank> RankList { get; set; }

		public static IList<LeaderboardModel> All { get; set; }

		static LeaderboardModel ()
		{
			All = new ObservableCollection<LeaderboardModel> {
				new LeaderboardModel {
					Name = "Class Leaderboard",
					Color = Color.Red,
                    RankList = JsonConvert.DeserializeObject<List<Rank>>(@"[
                  {
                    ""Ranking"": ""1"",
                    ""Recipe"": ""Plantain Pizza"",
                    ""Rating"": ""99.9"",
                    ""Link"": ""https://physicalkitchness.com/paleo-plantain-pizza-crust/""
                  },
                  {
                    ""Ranking"": ""2"",
                    ""Recipe"": ""Corned Beef"",
                    ""Rating"": ""98"",
                    ""Link"": ""https://www.foodnetwork.com/recipes/alton-brown/corned-beef-recipe-1947363""
                  }
                    ,
                  {
                    ""Ranking"": ""3"",
                    ""Recipe"": ""Cornbread"",
                    ""Rating"": ""92"",
                    ""Link"": ""https://www.blessthismessplease.com/the-best-cornbread-recipe/""
                    },
                   {
                    ""Ranking"": ""4"",
                    ""Recipe"": ""Carrot Cake"",
                    ""Rating"": ""91"",
                    ""Link"": ""https://www.inspiredtaste.net/25753/carrot-cake-recipe/""
                    },
                   {
                    ""Ranking"": ""5"",
                    ""Recipe"": ""Taco"",
                    ""Rating"": ""84.5"",
                    ""Link"": ""https://www.thewholesomedish.com/the-best-homemade-tacos/""
                    },

                    {
                    ""Ranking"": ""6"",
                    ""Recipe"": ""Chili Soup"",
                    ""Rating"": ""82"",
                    ""Link"": ""https://www.thewholesomedish.com/the-best-classic-chili/""
                    },

                    {
                    ""Ranking"": ""7"",
                    ""Recipe"": ""Tomato Soup"",
                    ""Rating"": ""80"",
                    ""Link"": ""https://www.inspiredtaste.net/27956/easy-tomato-soup-recipe/""
                    },
                    {
                    ""Ranking"": ""8"",
                    ""Recipe"": ""Fried Rice"",
                    ""Rating"": ""79"",
                    ""Link"": ""https://www.gimmesomeoven.com/fried-rice-recipe/""
                    },
                    {
                    ""Ranking"": ""9"",
                    ""Recipe"": ""Greek Salad"",
                    ""Rating"": ""78"",
                    ""Link"": ""https://www.loveandlemons.com/greek-salad/""
                    },
                    {
                    ""Ranking"": ""10"",
                    ""Recipe"": ""Greek Moussaka"",
                    ""Rating"": ""78"",
                    ""Link"": ""https://www.mygreekdish.com/recipe/mousakas/""
                    }]")
                }
                ,
                new LeaderboardModel {
                    Name = "School Leaderboard",
                    Color = Color.Green,
                    RankList = JsonConvert.DeserializeObject<List<Rank>>(@"[
                  {
                    ""Ranking"": ""1"",
                    ""Recipe"": ""Plantain Pizza"",
                    ""Rating"": ""99.9"",
                    ""Link"": ""https://physicalkitchness.com/paleo-plantain-pizza-crust/""
                  },
                  {
                    ""Ranking"": ""2"",
                    ""Recipe"": ""Corned Beef"",
                    ""Rating"": ""98"",
                    ""Link"": ""https://www.foodnetwork.com/recipes/alton-brown/corned-beef-recipe-1947363""
                  }
                    ,
                  {
                    ""Ranking"": ""3"",
                    ""Recipe"": ""Cornbread"",
                    ""Rating"": ""92"",
                    ""Link"": ""https://www.blessthismessplease.com/the-best-cornbread-recipe/""
                    },
                   {
                    ""Ranking"": ""4"",
                    ""Recipe"": ""Carrot Cake"",
                    ""Rating"": ""91"",
                    ""Link"": ""https://www.inspiredtaste.net/25753/carrot-cake-recipe/""
                    },
                   {
                    ""Ranking"": ""5"",
                    ""Recipe"": ""Taco"",
                    ""Rating"": ""84.5"",
                    ""Link"": ""https://www.thewholesomedish.com/the-best-homemade-tacos/""
                    },

                    {
                    ""Ranking"": ""6"",
                    ""Recipe"": ""Chili Soup"",
                    ""Rating"": ""82"",
                    ""Link"": ""https://www.thewholesomedish.com/the-best-classic-chili/""
                    },

                    {
                    ""Ranking"": ""7"",
                    ""Recipe"": ""Tomato Soup"",
                    ""Rating"": ""80"",
                    ""Link"": ""https://www.inspiredtaste.net/27956/easy-tomato-soup-recipe/""
                    },
                    {
                    ""Ranking"": ""8"",
                    ""Recipe"": ""Fried Rice"",
                    ""Rating"": ""79"",
                    ""Link"": ""https://www.gimmesomeoven.com/fried-rice-recipe/""
                    },
                    {
                    ""Ranking"": ""9"",
                    ""Recipe"": ""Greek Salad"",
                    ""Rating"": ""78"",
                    ""Link"": ""https://www.loveandlemons.com/greek-salad/""
                    },
                    {
                    ""Ranking"": ""10"",
                    ""Recipe"": ""Greek Moussaka"",
                    ""Rating"": ""78"",
                    ""Link"": ""https://www.mygreekdish.com/recipe/mousakas/""
                    }]")
                }
            };
		}
	}
}
