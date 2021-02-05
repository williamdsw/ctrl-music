
public class Accessory : Product
{
    public string InstrumentType { get; set; }
    public Measures Measures { get; set; }

    public Accessory() { }
    public Accessory(string instrumentType, Measures measures)
    {
        InstrumentType = instrumentType;
        Measures = measures;
    }
}
