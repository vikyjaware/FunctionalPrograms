// See https://aka.ms/new-console-template for more information
using FunctionalPrograms;
Console.WriteLine("Welcome to functional problem statement!");

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter\n0 for Exit\n" + "1 for flip Coin \n");
    Console.WriteLine("Enter your option: ");
    int option = Convert.ToInt32(Console.ReadLine() + "\n");


    switch (option)
    {
        case 0:
            flag = false;
            break;

        case 1:
            flag = true;
            CoinToss coin = new CoinToss();
            coin.toss();
            break;

    }
}