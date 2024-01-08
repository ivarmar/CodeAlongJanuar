namespace CodeAlongJanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HusBase House = new HusBase();

            while (true)
            {
                Console.WriteLine("1. Show House");
                Console.WriteLine("2. Add Floor");
                Console.WriteLine("3. Add Room");
                var inputs = Console.ReadLine();
                switch (inputs)
                {
                    case "1":
                        House.ShowRooms();
                        break;
                    case "2":
                        House.AddFloor();
                        break;
                    case "3":
                        House.AddRoom();
                        break;
                    default: return;
                }
                
            }
        }
    }
    /*
     * Lag en app som kan bygge et hus. Et hus kan bestå av etasjer og rom.
     * Brukeren skal kunne velge hva slags type rom den vil legge til om det er bad, kjøkken, soverom eller stue.
     * Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom, og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje.
     * Når huset er ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.
        */
}