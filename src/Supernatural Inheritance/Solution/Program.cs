namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Pupil p = new Pupil("Mezil-kree", "Icecrown");
        Mage m = new Mage("Gul'dan", "Draenor");
        Archmage a = new Archmage("Nielas Aran", "Stormwind");

        Storm[] storms = new Storm[5];
        storms[0] = p.CastWindStorm();
        storms[1] = m.CastWindStorm();
        storms[2] = m.CastRainStorm();
        storms[3] = a.CastRainStorm();
        storms[4] = a.CastLightningStorm();

        foreach (Storm storm in storms)
        {
            Console.WriteLine(storm.Announce());
        }
    }
}