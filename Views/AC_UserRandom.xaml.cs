using Newtonsoft.Json;
using static CherrezProgreso3.Model.AC_UserRandom;

namespace CherrezProgreso3.Views;

public partial class AC_UserRandom : ContentPage
{
	public AC_UserRandom()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            using (var client = new HttpClient())
            {
                string url = "https://randomapi.com/api/t9m03ui5?key=5312-NOXP-Q5OF-6ZRB";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var root = JsonConvert.DeserializeObject<Root>(json);

                    if (root.results != null && root.results.Count > 0)
                    {
                        var randomUser = root.results[0];

                        namelabel.Text = randomUser.name;
                        phonelabel.Text = randomUser.phone;
                    }
                    else
                    {
                        namelabel.Text = "No data available";
                        phonelabel.Text = "";
                    }
                }
            }
        }
    }

}