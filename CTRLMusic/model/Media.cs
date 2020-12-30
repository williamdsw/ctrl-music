
using System.Runtime.CompilerServices;

public class Media : Product
{
    public string Genres { get; set; }
    public string Artist { get; set; }
    public string Duration { get; set; }
    public string Languages { get; set; }
    public Measures Measures { get; set; }

    public Media(){}
    public Media(string genres, string artist, string duration, string languages, Measures measures)
    {
        Genres = genres;
        Artist = artist;
        Duration = duration;
        Languages = languages;
        Measures = measures;
    }
}
