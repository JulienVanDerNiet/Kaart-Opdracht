using ExtensionMethods;

namespace Kaart{
    public class Starter{
        public static void Main(string[] args){
            Console.WriteLine("Test!");
            
            Tekener CT = new ConsoleTekener();
            Kaart kaart = new Kaart(10,10);
            
        }
    }
}