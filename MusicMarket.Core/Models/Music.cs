namespace MusicMarket.Core.Models;

public class Musics
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
}