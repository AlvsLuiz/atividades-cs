using System;
/* Desenvolver um sistema para catalogo e controle de coleções de jogos. 
Crie e leia um vetor com dados de n jogos: título (30 letras),
console  (15  letras) ano, ranking e empréstimo. 
O campo empréstimo é uma classe data que por sua vez, possui os campos:  o data 
o nomePessoa o emprestado (S/N)

a. Permita procurar o jogo por título, ou listar todos os jogos de um  console.  

b. Permita realizar o empréstimo de um jogo, anotando a data atual, o  nome da 
pessoa que pegou o jogo e alterando o campo emprestado  para ‘S’. 

c. Permita devolver o jogo definindo o campo emprestado para ‘N’. d. Mostre todos
os jogos que estão emprestados e para quem.*/

class Emprestimo
{
    public string nomePessoa;
    public DateTime data;
    public char emprestado;
}

class Games
{
    public string name;
    public string console;
    public int ano;
    public int ranking;
    public char emprestimo;

}

class Atividade4
{
    static void addGame(List<Games> jogo)
    {
        Games novoJogo = new Games();

        Console.WriteLine("--- Adicionando Jogo ---");
        Console.WriteLine("Qual o nome do jogo a ser adicionado?");
        novoJogo.name = Console.ReadLine();
        Console.WriteLine("De qual console é esse jogo?");
        novoJogo.console = Console.ReadLine();
        Console.WriteLine("de que ano é o jogo?");
        novoJogo.ano = int.Parse(Console.ReadLine());
        Console.WriteLine("qual o ranking deste jogo?");
        novoJogo.ranking = int.Parse(Console.ReadLine());
        Console.WriteLine("o jogo esta entrando agora?");
        novoJogo.emprestimo = char.Parse(Console.ReadLine());

        jogo.Add(novoJogo);

    }

    static void jogos(List<Games> jogo)
    {
        Console.WriteLine("--- Lista de Jogos ---");
        for (int i = 0; i < jogo.Count; i++)
        {
            Console.WriteLine($"Nome: {jogo[i].name}");
            Console.WriteLine($"Console: {jogo[i].console}");
            Console.WriteLine($"Ano: {jogo[i].ano}");
            Console.WriteLine($"Ranking: {jogo[i].ranking}");
            Console.WriteLine($"Emprestado: {jogo[i].emprestimo}");
        }
    }

    static void console(List<Games> jogo, string game)
    {
        Console.WriteLine("--- Lista de Jogos ---");
        for (int i = 0; i < jogo.Count; i++)
        {
            string console = jogo[i].console.ToUpper();
            if (console.Equals(game.ToUpper()))
            {
                Console.WriteLine($"Nome: {jogo[i].name}");
                Console.WriteLine($"Console: {jogo[i].console}");
                Console.WriteLine($"Ano: {jogo[i].ano}");
                Console.WriteLine($"Ranking: {jogo[i].ranking}");
                Console.WriteLine($"Emprestado: {jogo[i].emprestimo}");
            }
        }
    }

    static void search(List<Games> jogo, string titulo)
    {
        Console.WriteLine("--- Buscando Jogo ---");
        for(int i = 0; i < jogo.Count;i++)
        {
            string nome = jogo[i].name.ToUpper();
            if (nome.Equals(titulo.ToUpper()))
            {
                Console.WriteLine($"Nome: {jogo[i].name}");
                Console.WriteLine($"Console: {jogo[i].console}");
                Console.WriteLine($"Ano: {jogo[i].ano}");
                Console.WriteLine($"Ranking: {jogo[i].ranking}");
                Console.WriteLine($"Emprestado: {jogo[i].emprestimo}");
            }
        }
    }

    static void emprestar(List<Games> jogo, List<Emprestimo> listadeEmprestimos, string nomeJogo)
    {
        Emprestimo emprestado = new Emprestimo();
        for (int i = 0; i < jogo.Count; i++)
        {
            if (jogo[i].name.Equals(nomeJogo) && jogo[i].emprestimo == 'N')
            {
                Console.Write("Qual o nome da Pessoa? ");
                emprestado.nomePessoa = Console.ReadLine();
                Console.Write("Data (dia/mês/ano): ");
                emprestado.data = DateTime.Parse(Console.ReadLine());

                jogo[i].emprestimo = 'S';
                listadeEmprestimos.Add(emprestado);
                Console.WriteLine("Empréstimo realizado com sucesso!");
                return;
            }
        }
        Console.WriteLine("O jogo não existe ou já está emprestado.");
    }
    static void devolver(List<Games> jogo, string nome)
    {
        for (int i = 0; i < jogo.Count; i++)
        {
            if (jogo[i].name.ToUpper().Equals(nome.ToUpper()) && jogo[i].emprestimo == 'S')
            {
                jogo[i].emprestimo = 'N';
                Console.WriteLine($"Jogo '{nome}' devolvido com sucesso!");
                return;
            }
        }
        Console.WriteLine("O jogo não existe ou não está emprestado.");
    }

    static void emprestados(List<Games> jogo, List<Emprestimo> emprestimo)
    {
        Console.WriteLine("* Jogos Emprestados *");
        for (int i = 0; i < jogo.Count; i++)
        {
            if (jogo[i].emprestimo == 'S')
            {
                var emprestimoJogo = emprestimo.FirstOrDefault(e => e.nomePessoa.Equals(jogo[i].name));
                if (emprestimoJogo != null)
                {
                    Console.WriteLine($"Nome do jogo: {jogo[i].name}");
                    Console.WriteLine($"Emprestado para: {emprestimoJogo.nomePessoa}");
                    Console.WriteLine($"Data do empréstimo: {emprestimoJogo.data.ToString("dd/MM/yyyy")}");
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
        }
    }

    static int Menu()
    {
        Console.WriteLine("--- Lista de Interação ---");
        Console.WriteLine("1 - Adicionar Jogo");
        Console.WriteLine("2 - Listar Jogos");
        Console.WriteLine("3 - Buscar Jogo");
        Console.WriteLine("4 - Buscar por Console");
        Console.WriteLine("5 - Emprestar Jogo");
        Console.WriteLine("6 - Devolver Jogo");
        Console.WriteLine("7 - emprestados");
        Console.WriteLine("0 - Sair");
        int op = int.Parse(Console.ReadLine());
        return op;

    }

    
    static void Main()
    {
        Console.WriteLine("Atividade 4");
        List<Games> jogo = new List<Games>();
        List<Emprestimo> emprestado = new List<Emprestimo>();

        int opcao;
        do
        {
            opcao = Menu();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Fim do programa ;)");
                    break;

                case 1:
                    addGame(jogo);
                    break;

                case 2:
                    jogos(jogo);
                    break;
                    

                case 3:
                    Console.Write("Digite o nome do jogo: ");
                    string nomeBusca = Console.ReadLine();
                    search(jogo, nomeBusca);
                    break;
                    

                case 4:
                    Console.Write("Digite o nome do console para buscar os jogos relacionados a ele: ");
                    string consoleBusca = Console.ReadLine();
                    console(jogo, consoleBusca);
                    break;
                    

                case 5:
                    Console.Write("Digite o nome do jogo que será emprestado: ");
                    string nomeEmprestimo = Console.ReadLine();
                    emprestar(jogo, emprestado, nomeEmprestimo);
                    break;
                   

                case 6:
                    Console.Write("Digite o nome do jogo para devolução: ");
                    string nomeDevolucao = Console.ReadLine();
                    devolver(jogo, nomeDevolucao);
                    break;
                case 7:
                    emprestados(jogo, emprestado);
                    break;


                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();  // Pausa
            Console.Clear();  // Limpa a tela
        } while (opcao != 0);

    }
}
