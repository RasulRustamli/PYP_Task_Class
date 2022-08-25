using PYP_Task_Class.Abstract;
using PYP_Task_Class.Model;
using System.Reflection;

#region Object instance

Guitar guitar = new Guitar
{
    Model = "VC204",
    Brand = "Valencia",
    Price = 14.4,
    HeadStock = 3
};
Marimba marimba = new Marimba
{
    Model ="3100",
    Brand ="Wave",
    Price =145.5,
    Legs =4,
    TonePlates =5,

};

Piano piano = new Piano
{
    Model = "Y345",
    Brand="Fazioli",
    Price =600,
    KeyBoard =23
};
Timpani timpani = new Timpani
{
    Model = "FG512",
    Brand = "Benchstone",
    Price = 600,
    Caster =3,
    SusPansionRing =4,
};
#endregion


Instrument[] instrument = { timpani, piano, marimba, guitar };

PrintAllInstruments(instrument);



#region Print All Instruments Method

static void PrintAllInstruments(Instrument[] instrument)
{
    List<PropertyInfo> properties;

    foreach (var item in instrument)
    {

        properties = item.GetType().GetProperties().ToList();
        Console.WriteLine($"Enstruman : {item.GetType().Name}");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Ozellikler : ");

        Console.WriteLine($"          Sesi:{item.Sound()}");
        foreach (var property in properties)
        {
            
           Console.WriteLine($"          {property.Name} : {property.GetValue(item)}");
        }
        Console.WriteLine("----------------------------------");

    }
}
#endregion

