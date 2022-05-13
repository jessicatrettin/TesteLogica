using System.Text;
using TesteLogica;

public class Program : Network
{
    private readonly Network _network;

    public Program(Network network)
    {
        _network = network;
    }

    static void Main()
    {
        Console.Write("");
    }
    public void Run()
    {
        Console.Write("Digite o número de elementos da série: ");
        int numberOfElements = Convert.ToInt32(Console.ReadLine());

        var set = _network.Set(numberOfElements);

        Console.WriteLine("");
        Console.WriteLine("Agora vamos conectar os números");

        var connectionList = new List<Array> ();
        string resp = "S";
        while (resp == "S")
        {
            Console.Write("Número 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var conection = _network.Connect(set, num1, num2);
            connectionList = _network.Connections(conection);

            Console.Write("Deseja conectar mais 2 números? (S/N): ");
            resp = Console.ReadLine().ToUpper();

        }
        Console.WriteLine("As conexões são:");
        for (int i = 0; i < connectionList.Count; i++)
        {
            Console.WriteLine(connectionList[i]);
        }

        Console.WriteLine("Agora você pode verificar se 2 números estão conectados:");
        string resp2 = "S";
        while (resp2 == "S")
        {
            Console.Write("Número 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var conectionIsTrue = _network.Query(connectionList, num1, num2);

            if (conectionIsTrue == true)
            {
                Console.WriteLine("Os números estão conectados");
            }
            else
            {
                Console.WriteLine("Os números não estão conectados");
            }
            Console.WriteLine("");

            Console.Write("Deseja verificar mais 2 números? (S/N): ");
            resp2 = Console.ReadLine().ToUpper();
        }
        Console.WriteLine("FIM");
    }
}
