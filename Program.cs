namespace ams_heranca_treeclass{
class program{
        public static void Main(string[] args)
        {
            Fly aguia = new Fly("224312", "Águia");
            Walks pinguim = new Walks("224313", "Pinguim");

            aguia.Voar();
            System.Console.WriteLine($"----------------------------------");
            pinguim.Voar();
        }
    }
}