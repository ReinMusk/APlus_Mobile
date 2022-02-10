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
    public partial class Info : ContentPage
    {
        Project project;
        public Info(Project newProj)
        {
            InitializeComponent();

            project = newProj;
            projDesc.Text = project.Description;
        }

        public Info()
        {
            InitializeComponent();
        }
    }
}