using Notes.Models;

namespace Notes;

public class StaticTeams
{
    public static List<Team> Teams { get; set; } = new List<Team>()
    {
        new() { Name = "Кливленд Кавальерс", Games = 21, Image = "cleavlend.png" } ,
        new() { Name = "Бостон Селтикс", Games = 21 },
        new() { Name = "Оклахома-Сити Тандер", Games = 21 },
    };
}
