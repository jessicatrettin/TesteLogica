namespace TesteLogica
{
    public class Network
    {
        public int NumberOfElements { get; set; }

        public Network()
        {

        }

        public Array Set(int numberOfElements)
        {
            if (numberOfElements <= 0)
            {
                throw new Exception("Número inválido! É necessário inserir um número inteiro positivo.");
            }

            int[] setElements = new int[numberOfElements];
            for (int i = 1; i <= numberOfElements; i++)
            {
                setElements[i] = i;
            }
            return setElements;
        }


        public void NumbersExistInSet(Array set, int num)
        {
            var verification = true;

            if (verification)
            {
                foreach (int element in set)
                {
                    while (num != element)
                    {
                        verification = true;
                    }
                }
            }
            else
            {
                throw new Exception("Número não existe na sequência");
            }
        }

        public Array Connect(Array set, int n1, int n2)
        {
            NumbersExistInSet(set, n1);
            NumbersExistInSet(set, n2);

            int[,] connection = new int[n1, n2];
            return connection;
        }

        public List<Array> Connections(Array connection)
        {
            List<Array> connections = new List<Array>();
            connections.Add(connection);
            return connections;
        }

        public bool Query(List<Array> connections, int n1, int n2)
        {
            int[,] connectionVerify = new int[n1, n2];
            var verification = 0;

            foreach (var connection in connections)
            {
                if (connection == connectionVerify)
                {
                    verification += 1;
                }
            }

            if (verification != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
