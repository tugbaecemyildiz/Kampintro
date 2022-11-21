namespace Donguler
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme","Programlamaya Başlangıç","Java" , "Python", "C#"};
            
            for (int i = 0; i <kurslar.Length ;  i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}