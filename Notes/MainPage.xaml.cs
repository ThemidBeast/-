using Notes.Models;
using System.Windows.Input;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        public List<Team> Teams { get; set; } = StaticTeams.Teams;
        public Command<Team> SelectCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();
            SelectCommand = new(TapGestureRecognizer_Tapped);
            BindingContext = this;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AboutPage));
        }

        private async void TapGestureRecognizer_Tapped(Team team)
        {
            await Shell.Current.GoToAsync(nameof(AboutPage));
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AboutPage));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            var commandName = ((((sender as Frame)!.Parent as Grid)!.Children[1] as Frame)!.Content as Label)!.Text;
            AboutPage.CommandName = commandName;
            await Shell.Current.GoToAsync(nameof(AboutPage));
        }
    }

}
