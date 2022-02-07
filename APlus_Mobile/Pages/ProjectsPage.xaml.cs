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
    public partial class ProjectsPage : ContentPage
    {
        public ProjectsPage()
        {
            this.BindingContext = this;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            projectList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            ProjectPage projectPage = new ProjectPage();
            projectPage.BindingContext = selectedProject;
            await Navigation.PushAsync(projectPage);
        }

        private async void CreateProject(object sender, EventArgs e)
        {
            Project friend = new Project();
            AddProject friendPage = new AddProject();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }

        private async void CreateProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProject());
        }
    }
}