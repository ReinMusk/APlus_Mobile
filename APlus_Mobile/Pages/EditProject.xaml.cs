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
    public partial class EditProject : ContentPage
    {
        Project project;
        public EditProject(Project newProj)
        {
            InitializeComponent();
            project = newProj;

            txt_AddName.Text = project.Name;
            txt_AddDescription.Text = project.Description;
            txt_AddTel.Text = project.Number;
            txt_AddEmail.Text = project.Email;
            txt_AddAdress.Text = project.Address;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            var proj = (Project)BindingContext;
            if (!String.IsNullOrEmpty(proj.Name))
            {
                App.Database.SaveItem(proj);
            }
            this.Navigation.PopAsync();
        }
    }
}