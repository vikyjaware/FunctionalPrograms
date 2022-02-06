// See https://aka.ms/new-console-template for more information
using FunctionalPrograms;

Console.WriteLine("Welcome to functional problem statement!");


{
    Console.WriteLine("Enter 0 for Exit\n" 
        +"Enter 1 for flip Coin problem \n"
        +"Enter 2 for Leap year problem\n"
        +"Enter 3 for Power of 2 series");
    Console.WriteLine("Enter your option: ");
    int option = Convert.ToInt32(Console.ReadLine() + "\n");


    switch (option)
    {
        case 0:
            break;

        case 1:
            CoinToss coin = new CoinToss();
            coin.toss();
            break;
        case 2:
            LeapYear leap=new LeapYear();
            leap.year();
            break;
        case 3:
            PowerOf2 powerOf2=new PowerOf2();
            powerOf2.power();
            break;

    }
}