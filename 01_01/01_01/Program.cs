namespace _01_01
{
    internal class Program
    {
        static int GGTeiler(int z1, int z2)
        {
            int kleinstezahl = Math.Min(z1,z2);
            if (kleinstezahl<=0){
                return -1;
            }
            int teiler = -1;
            for (int i=1;kleinstezahl>=i;i++){
                if (z1%i==0&&z2%i==0){
                    teiler=i;
                }
            }
            return teiler;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte schreiben Sie die erste Zahl:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte schreiben Sie die zweite Zahl:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            int GGT = GGTeiler(zahl1,zahl2);
            if (GGT!=-1){
            Console.WriteLine("Der grösster gemeinsamer Teiler ist "+Convert.ToString(GGT)+".");
            }
            else{
                Console.WriteLine("Bitte nur positive Zahlen!");
            }
        }
    }
}