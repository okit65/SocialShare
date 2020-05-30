using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using ShareSample.Droid;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using asd = Android.App;
[assembly: Dependency(typeof(IShareService))]
namespace ShareSample.Droid
{
	public class IShareService : Activity, IShare
	{
        private readonly Context _context = asd.Application.Context;
        public async void Share(string subject, string message, string imagebase64)
        {
            try
            {
                
			var intent = new Intent(Intent.ActionSend);
			//intent.PutExtra(Intent.ExtraSubject, subject);
			intent.PutExtra(Intent.ExtraText, message);
			intent.SetType("image/jpg");

			var handler = new ImageLoaderSourceHandler();

                var bitmap = await handler.LoadImageAsync(image, this);

                Bitmap bmpReturn = null;
                byte[] byteBuffer = Convert.FromBase64String(imagebase64);

                //bmpReturn = (Bitmap)Bitmap.FromArray(byteBuffer);
                Bitmap bitmapq = BitmapFactory.DecodeByteArray(byteBuffer, 0, byteBuffer.Length);


                byteBuffer = null;


                var bitmap = bitmapq;
                var path = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads
				+ Java.IO.File.Separator + "logo.jpg");

			using (var os = new System.IO.FileStream(path.AbsolutePath, System.IO.FileMode.Create))
			{
				bitmap.Compress(Bitmap.CompressFormat.Png, 100, os);
			}

			intent.PutExtra(Intent.ExtraStream, Android.Net.Uri.FromFile(path));
			//Forms.Context.StartActivity(Intent.CreateChooser(intent, "Share Image"));


                var chooserIntent = Intent.CreateChooser(intent, "Share Image");
                chooserIntent.SetFlags(ActivityFlags.ClearTop);
                chooserIntent.SetFlags(ActivityFlags.NewTask);
                _context.StartActivity(chooserIntent);

                //return Task.FromResult(true);
            }
            catch (System.Exception ex)
            {

              //  throw;
            }
        }
	}
}
