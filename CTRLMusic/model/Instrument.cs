
public class Instrument : Product
{
    public string Type { get; set; }
    public Measures Measures { get; set; }

    public Instrument() { }
    public Instrument(string type, Measures measures) 
    {
        Type = type;
        Measures = measures;
    }
}
