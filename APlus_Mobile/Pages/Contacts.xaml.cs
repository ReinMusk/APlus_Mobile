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
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();

            txt_ContAdress.Text = Project.globProj.Address;
            txt_ContEmail.Text = Project.globProj.Email;
            txt_contc_tel.Text = Project.globProj.Number;
        }
    }
}