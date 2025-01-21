using System;

class Eletrodomesticos
{
    public string nome;
    public double potencia;
    public double ativo;
}

class Atividade3
{
    static void addmovel(List<Eletrodomesticos> movel)
    {
        Eletrodomesticos novoeletro = new Eletrodomesticos();

        //Crie uma estrutura para armazenar os dados de cada eletrodoméstico:
        //nome,  potencia (real, em kW) e tempo médio ativo por dia (real, em horas)

        Console.WriteLine("--- Adicionando Eletrodomestico ---");
        Console.WriteLine("qual o nome do eletrodomestico?");
        novoeletro.nome = Console.ReadLine();
        Console.WriteLine("qual a potencia do eletrodomestico?");
        novoeletro.potencia = double.Parse(Console.ReadLine());
        Console.WriteLine("qual o tempo medio que ele fica ativo?");
        novoeletro.ativo = double.Parse(Console.ReadLine());
    }// add de eletro

    static void buscaeletro(List<Eletrodomesticos> movel, string nome)
    {

        //Permita buscar pelo seu nome.

        for (int i = 0; i < movel.Count; i++)
        {
            string eletro = movel[i].nome.ToUpper();

            if (eletro.Contains(nome.ToUpper()))
            {
                Console.WriteLine($"--- Buscando Eletrodomesticos ---");
                Console.WriteLine($"Nome: {movel[i].nome}");
                Console.WriteLine($"Potencia: {movel[i].potencia}");
                Console.WriteLine($"Media de tempo ativo: {movel[i].ativo}");
                Console.WriteLine($"---------------------------------");

            }
        }
    }//Busca de eletro

    static void buscagasto(List<Eletrodomesticos> movel, double gasto, double tarifa)
    {

        //Permita buscar pelos eletrodomésticos que gastam mais que um valor X.
        //e. Calcule e mostre o consumo diário e mensal da casa em kW e R$.
        //Para mostrar  em R$ receba o valor do kW/h. 


        for (int i = 0; i < movel.Count; i++)
        {
            double kwh = movel[i].potencia;

            if (kwh > gasto)
            {
                Console.WriteLine("--- Eletrodomesticos que gastam mais ---");
                Console.WriteLine($"Nome: {movel[i].nome}");
                Console.WriteLine($"Potencia: {movel[i].potencia}");
                Console.WriteLine($"Tempo Ativo: {movel[i].ativo}");
                kwh = movel[i].potencia * movel[i].ativo;
                Console.WriteLine($"Consumo diario em KW: {kwh}, em R$: {kwh * tarifa} ");
                Console.WriteLine($"Consumo medio mensal em KW: {kwh * 30}, em R$: {(kwh * 30) * tarifa}");
                Console.WriteLine("----------------------------------------");

            }
        }
    }//fim gasto

    static void gastocasa(List<Eletrodomesticos> moveis, double gasto, double tarifa)
    {
        double dia, mes;
        dia = gasto * tarifa;
        mes = dia * 30;
        Console.WriteLine($"A media gasta por dia em R$ é de {dia} e a media gasta por mes é de {mes}");
    }//fim gasto casa

    static void guardar(List<Eletrodomesticos> movel, string arquivo)
    {

        //Permite listar em tela e salvar em um arquivo. 


        StreamWriter writer = new StreamWriter(arquivo);

        foreach (Eletrodomesticos tipo in movel)
        {
            writer.WriteLine($"{tipo.nome},{tipo.potencia},{tipo.ativo}");
        }
        Console.WriteLine("Dados salvos!");
        writer.Dispose();

    }// fim salvar

    static void expor(List<Eletrodomesticos> listamovel, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                Eletrodomesticos moveis = new Eletrodomesticos();
                moveis.nome = campos[0];
                moveis.potencia = int.Parse(campos[1]);
                moveis.ativo = int.Parse(campos[2]);
                listamovel.Add(moveis);

            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado");
        }
    }//fim carregar

    static int menu()
    {
        Console.WriteLine("--- Menu de Interacao ---");
        Console.WriteLine("1 - adicionar eletrodomestico");
        Console.WriteLine("2 - buscar eletrodomestico");
        Console.WriteLine("3 - buscar eletrodomestico por gasto");
        Console.WriteLine("4 - calcular em R$, por gasto");
        Console.WriteLine("0 - sair e salvar dados");
        int op = int.Parse(Console.ReadLine());
        return op;
    }
    static void Main()
    {
        List<Eletrodomesticos> movel = new List<Eletrodomesticos>();
        //Crie uma estrutura para armazenar os dados de cada eletrodoméstico:
        //nome,  potencia (real, em kW) e tempo médio ativo por dia (real, em horas) 
        expor(movel, "dadosmoveis.txt");
        Console.WriteLine("Qual sera a acao desejada?!");
        int op;
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    addmovel(movel);
                    break;
                case 2:
                    Console.WriteLine("qual o nome do eletrodomestico desejado?");
                    string furnam = Console.ReadLine();
                    buscaeletro(movel, furnam);
                    break;
                case 3:
                    Console.WriteLine("qual o gasto em Kw desejado");
                    double kw = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a tarifa de energia?");
                    double tarifa = double.Parse(Console.ReadLine());
                    buscagasto(movel, kw, tarifa);
                    break;
                case 4:
                    Console.WriteLine("qual a quantidade de KW/h esta sendo usada?");
                    kw = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a tarifa de energia?");
                    tarifa = double.Parse(Console.ReadLine());
                    gastocasa(movel, kw, tarifa);
                    break;
                case 0:
                    Console.WriteLine("saindo . . .");
                    guardar(movel, "dadosmoveis.txt");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        } while (op != 0);
    }

}
