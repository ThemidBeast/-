namespace Notes.Models;

public class CommandMatch
{
    public string LeftName { get; set; } = "";
    public string RightName { get; set; } = "";
    public int LeftPoints { get; set; } = new Random().Next(80, 120);
    public int RightPoints { get; set; } = new Random().Next(80, 120);
}
