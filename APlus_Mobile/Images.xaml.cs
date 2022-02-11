using System;
using System.Diagnostics;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using APlus_Mobile;

namespace MobileDbPic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Images : ContentPage
    {
        public string pathName;
        public Images()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            imgList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private void UpdateList()
        {
            imgList.ItemsSource = App.Database.GetItems();
        }

        private async void GetPhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                pathName = photo.FullPath;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private async void TakePhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                {
                    Title = $"xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                });

                var newFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), photo.FileName);
                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);

                Debug.WriteLine($"Путь фото {photo.FullPath}");

                pathName = photo.FullPath;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private void AddImage(object sender, EventArgs e)
        {
            Photo img = new Photo();
            img.Name = nameImg.Text;
            img.PathImage = pathName;

            App.Database.SaveItem(img);
            UpdateList();
        }

        private async void imgList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Photo selectedImage = (Photo)e.SelectedItem;
            SelectedImg imagePage = new SelectedImg();
            imagePage.BindingContext = selectedImage;
            await Navigation.PushAsync(imagePage);
        }
    }
}