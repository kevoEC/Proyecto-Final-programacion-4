using ProyectoFinalProgramacion4.Models;

namespace ProyectoFinalProgramacion4.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}


    private async void llamarAPI(object sender, EventArgs e)
    {
        ReturnContent returnContent;
        var client = new HttpClient();
        returnContent = await App.API.GetFoto();
        if (returnContent.status == "success")
        {
            await Shell.Current.DisplayAlert("Downloading", $"API CONSUMIDA: {returnContent.download_url}...", "OK");
            var download_response = await client.GetAsync(returnContent.download_url);
            using (var stream = await download_response.Content.ReadAsStreamAsync())
            {
                var fileInfo = new FileInfo("image.jpeg");
                using (var fileStream = fileInfo.OpenWrite())
                {
                    await stream.CopyToAsync(fileStream);
                }
            }
        }
    }
    //private async void llamarAPI(object sender, EventArgs e)
    //{
    //    ReturnContent resp;
    //    resp = await App.API.GetFoto();
    //    try
    //    {
    //        Uri imageurl = new Uri(resp.message);
    //        imgperro.Source = ImageSource.FromUri(imageurl);
    //    }
    //    catch (Exception)
    //    {
    //        await Application.Current.MainPage.DisplayAlert("Alerta", "No se logró contactar a la API", "OK");
    //    }
    //}

}