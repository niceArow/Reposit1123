using System.Security.Cryptography;
class Program
{
    public static byte rdmeth()
    {
        RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        byte[] rndnum = new byte[1];
        Rand.GetBytes(rndnum);
        return (rndnum[0]);
    }

    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            double val = rdmeth();
            Console.Write(val);
            Console.Write(" ");
        }
        Console.ReadLine();
    }
}