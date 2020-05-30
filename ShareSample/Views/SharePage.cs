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
            string imagebase64 = "data:image/jpeg;base64,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";
            imagebase64 = imagebase64.Substring(imagebase64.LastIndexOf(",") + 1);
            sharebutton.Clicked += (sender, e) =>
			{
				DependencyService.Get<IShare>().Share("udhaya", "Hi udhay. How are you?", imagebase64);
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

