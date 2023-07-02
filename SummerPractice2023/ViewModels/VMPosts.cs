using SummerPractice2023.Views;
using System.ComponentModel;

namespace SummerPractice2023.ViewModels
{
    public class VMPosts : INotifyPropertyChanged
    {
        DB.Posts posts = new DB.Posts();


        public VMPosts(DB.Posts posts)
        {
            this.posts = posts;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
