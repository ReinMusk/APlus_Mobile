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

        Project project;
        public Contacts(Project newProj)
        {
            InitializeComponent();

            project = newProj;

            txt_ContAdress.Text = project.Address;
            txt_ContEmail.Text = project.Email;
            txt_contc_tel.Text = project.Number;
        }
    }
}