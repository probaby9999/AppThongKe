using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XyLyHoSo_Tab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomNayPage : ContentPage
	{
		public HomNayPage ()
		{
			InitializeComponent ();
            Init();
		}
        public void Init()
        {
            this.Title = "HÔM NAY";
        }

    }
}