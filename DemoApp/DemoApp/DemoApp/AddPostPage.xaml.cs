using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace DemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPostPage : ContentPage
    {
        public AddPostPage()
        {
            InitializeComponent();
        }
        private void savePostButton_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Title = postTitle.Text,
                Date = DateTime.Now
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Post>();
                conn.Insert(post);
            }


            Navigation.PushAsync(new MainPage());
        }
    }
}