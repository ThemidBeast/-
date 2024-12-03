using Notes.Models;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        public List<Team> Teams { get; set; } = new List<Team> ()
        {
            new() { Name = "Кливленд Кавальерс", Games = 21, Image = "cleavlend.png" } ,
            new() { Name = "Кливленд Кавальерс", Games = 21 }
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            
            await Shell.Current.GoToAsync(nameof(AboutPage));
           


        }
    }

}
