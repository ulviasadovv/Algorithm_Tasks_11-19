namespace Algorithm_Tasks_11_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 -- Daxil edilen ededin tersi ile eyni olub olmadigini yoxlayin
            //Console.Write("Bir eded daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int numForUse = num;
            //int reversedNum = 0;

            //while (numForUse > 0)
            //{
            //    reversedNum = reversedNum * 10 + numForUse % 10;
            //    numForUse /= 10;
            //}

            //if (reversedNum == num)
            //{
            //    Console.WriteLine("Eded tersi ile eynidir");
            //}
            //else
            //{
            //    Console.WriteLine("Eded tersi ile eyni deyil");
            //}



            // Task 3 -- Saniye cinsinden daxil edilmis zamanin hesablanmasi
            //Console.Write("Saniyeni daxil edin: ");
            //int second = Convert.ToInt32(Console.ReadLine());
            //int day = second / 60 / 60 / 24;
            //second = second - day * 24 * 60 * 60;
            //int hour = second / 60 / 60;
            //second = second - hour * 60 * 60;
            //int minute = second / 60;
            //second = second - minute * 60;

            //Console.WriteLine($"{day} gun {hour} saat {minute} deqiqe {second} saniye");



            // Task 4 -- Verilmis iki koordinat arasindaki mesafeni hesablayin
            //Console.WriteLine("Koordinalari daxil edin: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x > y)
            //{
            //    Console.WriteLine($"Bu koordinatlar arasindaki mesafe: {x - y}");
            //}
            //else if (y > x)
            //{
            //    Console.WriteLine($"Bu koordinatlar arasindaki mesafe: {y - x}");
            //}
            //else
            //{
            //    Console.WriteLine("Koordinatlar eynidir");
            //}



            // Task 5 -- Daxil edilen ededi 2-lik qruplara ayirin
            //Console.Write("Bir eded daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = num;
            //int divider = 1;

            //while (temp > 0)
            //{
            //    temp /= 10;
            //    divider *= 10;
            //}

            //while (divider > 1)
            //{
            //    divider /= 100;
            //    Console.Write(num / divider);
            //    Console.Write(" ");
            //    num %= divider;
            //}



            // Task 6 -- Insanin yaşını hesablayin
            //Console.Write("Dogum ilini daxil edin: ");
            //int birthYear = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Dogum ayini daxil edin: ");
            //int birthMonth = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Dogum gununu daxil edin: ");
            //int birthDay = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Hazirki ili daxil edin: ");
            //int thisYear = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hazirki ayi daxil edin: ");
            //int thisMonth = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hazirki gunu daxil edin: ");
            //int thisDay = Convert.ToInt32(Console.ReadLine());

            //int age = thisYear - birthYear;

            //if (thisYear > birthYear)
            //{
            //    if (thisMonth < birthMonth || thisMonth == birthMonth && thisDay < birthDay)
            //    {
            //        age--;
            //    };

            //    Console.WriteLine($"{age} yas");
            //}
            //else 
            //    Console.WriteLine("Yanlis daxiletme!");

            // Task 7 -- Daxil edilen ededi teleb olunan vahide cevir
            //Console.Write("Ededi daxil edin: ");
            //double num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Vahidi daxil edin: ");
            //char unit = Convert.ToChar(Console.ReadLine());
            //Console.Write("Cevirilecek vahidi daxil edin: ");
            //char unit2 = Convert.ToChar(Console.ReadLine());

            //if (unit == 'm')
            //{
            //    switch (unit2)
            //    {
            //        case 'm':
            //            Console.WriteLine(num);
            //            break;
            //        case 's':
            //            Console.WriteLine(num / 10);
            //            break;
            //        case 'd':
            //            Console.WriteLine(num / 100);
            //            break;
            //        case 'M':
            //            Console.WriteLine(num / 1000);
            //            break;
            //        case 'K':
            //            Console.WriteLine(num / 1000000);
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis daxiletme!");
            //            break;
            //    }
            //}
            //else if (unit == 's')
            //{
            //    switch (unit2)
            //    {
            //        case 'm':
            //            Console.WriteLine(num * 10);
            //            break;
            //        case 's':
            //            Console.WriteLine(num);
            //            break;
            //        case 'd':
            //            Console.WriteLine(num / 10);
            //            break;
            //        case 'M':
            //            Console.WriteLine(num / 100);
            //            break;
            //        case 'K':
            //            Console.WriteLine(num / 100000);
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis daxiletme!");
            //            break;
            //    }
            //}
            //else if (unit == 'd')
            //{
            //    switch (unit2)
            //    {
            //        case 'm':
            //            Console.WriteLine(num * 100);
            //            break;
            //        case 's':
            //            Console.WriteLine(num * 10);
            //            break;
            //        case 'd':
            //            Console.WriteLine(num);
            //            break;
            //        case 'M':
            //            Console.WriteLine(num / 10);
            //            break;
            //        case 'K':
            //            Console.WriteLine(num / 10000);
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis daxiletme!");
            //            break;
            //    }
            //}
            //else if (unit == 'M')
            //{
            //    switch (unit2)
            //    {
            //        case 'm':
            //            Console.WriteLine(num * 1000);
            //            break;
            //        case 's':
            //            Console.WriteLine(num * 100);
            //            break;
            //        case 'd':
            //            Console.WriteLine(num * 10);
            //            break;
            //        case 'M':
            //            Console.WriteLine(num);
            //            break;
            //        case 'K':
            //            Console.WriteLine(num / 1000);
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis daxiletme!");
            //            break;
            //    }
            //}
            //else if (unit == 'K')
            //{
            //    switch (unit2)
            //    {
            //        case 'm':
            //            Console.WriteLine(num * 1000000);
            //            break;
            //        case 's':
            //            Console.WriteLine(num * 100000);
            //            break;
            //        case 'd':
            //            Console.WriteLine(num * 10000);
            //            break;
            //        case 'M':
            //            Console.WriteLine(num * 1000);
            //            break;
            //        case 'K':
            //            Console.WriteLine(num);
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis daxiletme!");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Yanlis daxiletme!");
            //}



            // Task 8 -- Verilmis natural edede gore onun bolenleri sayini tapin
            //Console.WriteLine("Eded daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    int quot = num / i;
            //    int rem = num % i;

            //    if (quot == rem)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"{num} ededinin beraber bolenleri sayi: {count}");



            // Task 9 -- Qazlar ve dovsanlar
            //int together = 64;
            //int rabLegs = 4;
            //int gooseLegs = 2;

            //for (int i = 0; i <= together / 2; i++)
            //{
            //    if ((together - i * rabLegs) % gooseLegs == 0 && (together - i * rabLegs) % gooseLegs >= 0)
            //    {
            //        Console.WriteLine($"Dovsanlarin sayi: {i}");
            //        Console.WriteLine($"Qazlarin sayi: {(together - i * rabLegs) / gooseLegs}");
            //        Console.WriteLine();
            //    }
            //}

        }
    }
}
