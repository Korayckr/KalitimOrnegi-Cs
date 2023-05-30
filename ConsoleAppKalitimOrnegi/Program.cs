using System;



namespace ConsoleAppKalitimOrnegi
{
    class program{

        static void Main(string[] args)
        {

            // Kalıtılan sınıf üzerinden işlemler gerçeklerştirildi.
            Kedi kedi = new Kedi();

            kedi.hayvanName = "Mia \n";
            kedi.hayvanGender = "Dişi \n";


            kedi.hayvanInfo();

            Console.ReadKey();







        }



    }


}