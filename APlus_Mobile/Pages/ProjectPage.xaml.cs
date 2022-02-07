using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlus_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : TabbedPage
    {
        public ProjectPage()
        {
            InitializeComponent();
            //proj_title.Text;
        }

        //private async void Edit_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync();
        //}
    }
}