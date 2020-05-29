using System;

using Xamarin.Forms;

namespace ShareSample
{
	public class SharePage : ContentPage
	{
		public SharePage()
		{
			Button sharebutton = new Button()
			{
				Text = "Share",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.White,
				BackgroundColor = Color.Blue

			};

			Image img = new Image()
			{
                //Source = "campaign.jpg",
               Source = "https://www.w3schools.com/images/picture.jpg",
				Aspect = Aspect.AspectFit
			};

			sharebutton.Clicked += (sender, e) =>
			{
				DependencyService.Get<IShare>().Share("udhaya", "Hi udhay. How are you?", img.Source);
			};

			StackLayout stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Aqua,
				Children = { sharebutton,img }
			};

			Content = stack;
			Padding = new Thickness(0, 20, 0, 0);
		}
	}
}

