using System;
using Xamarin.Forms;

namespace ShareSample
{
	public interface IShare
	{
		void Share(string subject, string message, string image);
	}
}
