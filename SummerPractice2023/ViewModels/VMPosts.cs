using SummerPractice2023.Views;
using System.ComponentModel;

namespace SummerPractice2023.ViewModels
{
    public class VMPosts : INotifyPropertyChanged
    {
        DB.Post posts;
        public string Heading { get => posts.Heading; }
        public string Author { get => posts.Author; }
        public string Imade { get => posts.Imade; }
        public string Description { get => posts.Description; }
        public string Address { get => posts.Address; }
        public string NumberOfViews { get => posts.NumberOfViews.ToString(); }

        public VMPosts(DB.Post posts)
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
