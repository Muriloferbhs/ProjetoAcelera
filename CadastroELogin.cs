

string opcaoEscolhida = "421421";
Dictionary<string, string> cadastros = new Dictionary<string, string>()
{
    {
        "Murilo" , "sccp"
    }
};

string nome;
string senha;
void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("   ==========");
    Console.WriteLine("   Study Flow");
    Console.WriteLine("   ==========\n");

    Console.WriteLine("Menu\n");
}

while (opcaoEscolhida != "1" && opcaoEscolhida != "2")
{
    Console.Clear();
    Console.WriteLine("   ==========");
    Console.WriteLine("   Study Flow");
    Console.WriteLine("   ==========\n");

    Console.WriteLine("1- Fazer cadastro");
    Console.WriteLine("2- Fazer login");
    Console.WriteLine("0- Sair da aplicacao\n");

    Console.Write("\nEscolha uma opcao valida: ");
    opcaoEscolhida = Console.ReadLine()!;
    switch (opcaoEscolhida)
    {
        case "1":
            Console.Clear();
            Console.Write("Cadastro\n\n");
            Console.Write("Digite seu nome: ");

            nome = Console.ReadLine();

            if (cadastros.ContainsKey(nome))
            {
                Console.WriteLine("Esse nome ja foi registrado anteriormente!");
                opcaoEscolhida = "421421";
                Thread.Sleep(1500);
                Console.Clear();
                break;
            }

            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();
            cadastros[nome] = senha;
            opcaoEscolhida = "421421";
            Console.WriteLine("\nCadastro concluído!");
            Thread.Sleep(2000);
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            Console.Write("Login\n\n");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nDigite sua senha: ");
            senha = Console.ReadLine();

            if (!cadastros.ContainsKey(nome) || cadastros[nome] != senha)
            {
                Console.WriteLine("Nome ou senha invalido!");
                opcaoEscolhida = "421421";
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }

            Console.Write("\nLogin realizado com sucesso!");
            break;
        case "0":
            Console.WriteLine("\nVoce escolheu sair da aplicacao!");
            Thread.Sleep(2000);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("\nOpcao invalida!");
            Thread.Sleep(1500);
            Console.Clear();
            break;
    }
}
