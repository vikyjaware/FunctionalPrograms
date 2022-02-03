// See https://aka.ms/new-console-template for more information
using FunctionalPrograms;

Console.WriteLine("Welcome to functional problem statement!");


{
    Console.WriteLine("Enter\n0 for Exit\n" + "1 for flip Coin \n");
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

    }
}