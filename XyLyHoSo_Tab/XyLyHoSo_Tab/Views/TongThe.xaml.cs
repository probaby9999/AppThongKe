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
	public partial class TongThe : ContentPage
	{
		public TongThe ()
		{
			InitializeComponent ();
            Init();

        }
        public void Init()
        {
            this.Title = "TỔNG HỢP";
        }
    }
}