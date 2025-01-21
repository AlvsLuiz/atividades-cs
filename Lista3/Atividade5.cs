using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DataNascimento
{
    public int mes;
    public int ano;

    public DataNascimento(int mes, int ano)
    {
        this.mes = mes;
        this.ano = ano;
    }
}

class Animal
{
    public int id;
    public float leitePorSemana;
    public float alimentoPorSemana;
    public char vaiParaAbate;
    public DataNascimento nascimento;

    public Animal(int id, float leitePorSemana, float alimentoPorSemana, char vaiParaAbate, DataNascimento nascimento)
    {
        this.id = id;
        this.leitePorSemana = leitePorSemana;
        this.alimentoPorSemana = alimentoPorSemana;
        this.vaiParaAbate = vaiParaAbate;
        this.nascimento = nascimento;
    }
}

class Atividade5
{
    static int exibirMenu()
    {
        Console.WriteLine("--- Lista de Interações ---");
        Console.WriteLine("1 - Registrar Animais");
        Console.WriteLine("2 - Listar os animais para abate");
        Console.WriteLine("3 - Calcular o total de leite produzido na semana");
        Console.WriteLine("4 - Calcular o total de alimento consumido por semana");
        Console.WriteLine("0- Sair");
        int opcao = int.Parse(Console.ReadLine());

        return opcao;
    }

    static void registrarAnimal(List<Animal> listaAnimais, List<DataNascimento> listaNascimentos)
    {
        Console.WriteLine("--- Registrar Animal ---");

        Console.Write("Código do animal: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de leite produzida por semana (em litros): ");
        float leitePorSemana = float.Parse(Console.ReadLine());

        Console.Write("Quantidade de alimento consumido por semana (em kg): ");
        float alimentoPorSemana = float.Parse(Console.ReadLine());

        Console.Write("Mês de nascimento do animal: ");
        int mesNascimento = int.Parse(Console.ReadLine());

        Console.WriteLine("Ano de nascimento do animal: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        Console.Write("Este animal será destinado ao abate? (S/N): ");
        char vaiParaAbate = char.Parse(Console.ReadLine().ToUpper());

        DataNascimento novoNascimento = new DataNascimento(mesNascimento, anoNascimento);
        Animal novoAnimal = new Animal(id, leitePorSemana, alimentoPorSemana, vaiParaAbate, novoNascimento);

        listaAnimais.Add(novoAnimal);
        Console.WriteLine("Dados do animal registrados com sucesso");
    }

    static void atualizarAbate(List<Animal> listaAnimais)
    {
        int anoAtual = DateTime.Now.Year;

        foreach (var animal in listaAnimais)
        {
            if (anoAtual - animal.nascimento.ano > 5 || animal.leitePorSemana < 40)
            {
                animal.vaiParaAbate = 'S';
            }
            else
            {
                animal.vaiParaAbate = 'N';
            }
        }
    }

    static void calcularTotalLeite(List<Animal> listaAnimais)
    {
        float totalLeite = 0;

        foreach (var animal in listaAnimais)
        {
            totalLeite += animal.leitePorSemana;
        }
        Console.WriteLine($"O total de leite produzido semanalmente é {totalLeite} litros.");
    }

    static void calcularTotalAlimento(List<Animal> listaAnimais)
    {
        float totalAlimento = 0;

        foreach (var animal in listaAnimais)
        {
            totalAlimento += animal.alimentoPorSemana;
        }
        Console.WriteLine($"O total de alimento consumido semanalmente é {totalAlimento}kg.");
    }

    static void listarAnimaisAbate(List<Animal> listaAnimais)
    {
        Console.WriteLine("* Animais para Abate *");

        foreach (var animal in listaAnimais)
        {
            if (animal.vaiParaAbate == 'S')
            {
                Console.WriteLine($"Código do animal: {animal.id}");
                Console.WriteLine($"Leite produzido por semana: {animal.leitePorSemana} litros");
                Console.WriteLine($"Alimento consumido por semana: {animal.alimentoPorSemana} kg");
                Console.WriteLine($"Mês de nascimento: {animal.nascimento.mes}");
                Console.WriteLine($"Ano de nascimento: {animal.nascimento.ano}");
                Console.WriteLine("---------------------------------------------------");
            }
        }
    }

    static void salvarDados(List<Animal> listaAnimais, string caminhoArquivo)
    {
        using (StreamWriter sw = new StreamWriter(caminhoArquivo))
        {
            foreach (var animal in listaAnimais)
            {
                sw.WriteLine($"{animal.id} | {animal.leitePorSemana} | {animal.alimentoPorSemana} | {animal.vaiParaAbate} | {animal.nascimento.mes} | {animal.nascimento.ano}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }

    static void carregarDados(List<Animal> listaAnimais, string caminhoArquivo)
    {
        if (File.Exists(caminhoArquivo))
        {
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split('|');

                    int id = int.Parse(dados[0]);
                    float leitePorSemana = float.Parse(dados[1]);
                    float alimentoPorSemana = float.Parse(dados[2]);
                    char vaiParaAbate = char.Parse(dados[3]);
                    int mes = int.Parse(dados[4]);
                    int ano = int.Parse(dados[5]);

                    DataNascimento nascimento = new DataNascimento(mes, ano);
                    Animal animalCarregado = new Animal(id, leitePorSemana, alimentoPorSemana, vaiParaAbate, nascimento);

                    listaAnimais.Add(animalCarregado);
                }
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
    }

    static void Main()
    {
        List<Animal> listaAnimais = new List<Animal>();
        List<DataNascimento> nascimento = new List<DataNascimento>();
        string caminhoArquivo = "animais.txt";

        bool continuar = true;
        carregarDados(listaAnimais, caminhoArquivo);
        while (continuar)
        {
            int opcao = exibirMenu();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Fim do programa");
                    salvarDados(listaAnimais, caminhoArquivo);
                    continuar = false;
                    break;
                case 1:
                    registrarAnimal(listaAnimais, nascimento);
                    break;
                    
                case 2:
                    listarAnimaisAbate(listaAnimais);
                    break;
                case 3:
                    calcularTotalLeite(listaAnimais);
                    break;
                case 4:
                    calcularTotalAlimento(listaAnimais);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
