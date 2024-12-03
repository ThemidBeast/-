using Notes.Models;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Notes;

[QueryProperty(nameof(CommandName), nameof(CommandName))]
public partial class AboutPage : ContentPage
{
    private static string commandName = string.Empty;
    public static string CommandName { get => commandName; set => SetProperty(value); }

    public static ObservableCollection<CommandMatch> Matches { get; set; } = [];
    public AboutPage()
    {
        BindingContext = this;
        InitializeComponent();
        command.Text = CommandName;
        MatchesView.ItemsSource = Matches;
    }

    protected static void SetProperty(string value)
    {
        commandName = value;
        Matches.Clear();
        for (int i = 0; i < 5; i++)
        {
            Matches.Add(GetCommandMatch(value));
        }
    }

    private static CommandMatch GetCommandMatch(string value) => new()
    {
        LeftName = value,
        RightName = StaticTeams.Teams.Where(team => team.Name != value).ToArray()[new Random().Next(StaticTeams.Teams.Count - 1)].Name,
    };
}
