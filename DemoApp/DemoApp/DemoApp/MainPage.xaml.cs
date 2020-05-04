using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;



namespace DemoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Posts_ListView.ItemsSource = App.Posts;

            //Posts_ListView.ItemsSource = Posts;
        }
        protected override void OnAppearing()
        {

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Post>();
                var posts = conn.Table<Post>().ToList();
                Posts_ListView.ItemsSource = posts;
            }


        }


        private void addPostToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPostPage());
        }

    }
}
