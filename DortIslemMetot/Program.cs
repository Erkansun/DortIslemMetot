using System.Transactions;

namespace DortIslemMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin");
            Console.Write("1-Toplama | 2-Çıkarma | 3-Çarpma | 4-Bölme: ");
            int islemTipi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("1. sayıyı girin: ");
            double sayi1=Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı girin: ");
            double sayi2=Convert.ToDouble(Console.ReadLine());


            double DortIslem(int islem, double sayi1, double sayi2)
            {
                if (islem == 1)
                    return sayi1 + sayi2;
                else if (islem == 2)
                    return sayi1 - sayi2;
                else if (islem == 3)
                    return sayi1 * sayi2;
                else if ((islem == 4))
                    return sayi1 / sayi2;
                else
                    return 0;
            }

            switch (islemTipi)
            {
                case 1:
                    double sonucToplama = DortIslem(islem: 1, sayi1: sayi1, sayi2: sayi2);
                    Console.WriteLine($"Toplama işleminizin sonucu: {sonucToplama}");
                    break;
                case 2:
                    double sonucCikartma = DortIslem(islem: 2, sayi1: sayi1, sayi2: sayi2);
                    Console.WriteLine($"Çıkartma işleminizin sonucu: {sonucCikartma}");
                    break;
                case 3:
                    double sonucCarpma = DortIslem(islem: 3, sayi1: sayi1, sayi2: sayi2);
                    Console.WriteLine($"Çarpma işleminizin sonucu: {sonucCarpma}");
                    break;
                case 4:
                    double sonucBolme = DortIslem(islem: 4, sayi1: sayi1, sayi2: sayi2);
                    Console.WriteLine($"Bölme işleminizin sonucu: {sonucBolme}");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
