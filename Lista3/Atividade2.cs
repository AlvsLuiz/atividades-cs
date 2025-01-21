using System;

class Livros
{
    public string titulo;
    public string autor;
    public int prateleira;
    public int data;
    
}

class Atividade2
{
    static void addLivro(List <Livros> livro)
    {
        Console.WriteLine("--- Adicionando Livro ---");
        Console.WriteLine("Qual o titulo do livro?");
        Livros book = new Livros();
        string ti;
        do
        {
            ti = Console.ReadLine();
            ti.ToArray();
            if (ti.Length > 30)
            {
                Console.WriteLine("o titulo desejado é mair do que o suportado" +
                    "\ninsira um titulo com no maximo 30 caracteres");
            }
            else
            {
                book.titulo = ti;
            }
        } while (ti.Length > 30);
        Console.WriteLine("qual o nome do autor deste livro?");
        book.autor = Console.ReadLine();

        Console.WriteLine("Qual o ano do livro?");
        int ano;
        bool lda;
        do
        {
            ano = int.Parse(Console.ReadLine());
            lda = true;
            if (ano < 0 || ano > 2025)
            {
                Console.WriteLine("o ano de publicacao deste livro esta invalido");
                Console.WriteLine("por favor reveja o ano de publicacao");
                lda = false;
            }
            else
            {
                book.data = ano;
            }

        } while (lda = false);
        Console.WriteLine("qual a prateleira em que o livro esta?");
        book.prateleira = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------");
        livro.Add(book);
        Console.WriteLine("Livro adicionado com sucesso");
    }//addlivro
    static void buscalivro(List <Livros> livros, string titulo)
    {
        Console.WriteLine("--- Buscando Livro ---");
        for (int i = 0; i < livros.Count; i++)
        {
            string titulobusca = livros[i].titulo.ToUpper();
            if (titulobusca.Contains(titulo.ToUpper()))
            {
                Console.WriteLine($" Livro {i + 1} ");
                Console.WriteLine($"Titulo: {livros[i].titulo}");
                Console.WriteLine($"Autor: {livros[i].autor}");
                Console.WriteLine($"Data Publicacao: {livros[i].data}");
                Console.WriteLine($"Prateleira: {livros[i].prateleira}");
            }
        }
    }//buscalivro
    static void mostralivro(List<Livros> livros)
    {
        for (int i = 0; i < livros.Count; i++)
        { 
            Console.WriteLine($" Livro {i + 1} ");
            Console.WriteLine($"Titulo: {livros[i].titulo}");
            Console.WriteLine($"Autor: {livros[i].autor}");
            Console.WriteLine($"Data Publicacao: {livros[i].data}");
            Console.WriteLine($"Prateleira: {livros[i].prateleira}");
        }
    }//mostralivro
    static void buscaAno(List<Livros> livro, int ano)
    {
        Console.WriteLine("--- Buscando Ano ---");
        for (int i = 0;i < livro.Count; i++)
        {
            if (livro[i].data > ano)
            {
                Console.WriteLine($"--- Livros mais recentes que o ano {ano} ---");
                Console.WriteLine($"Titulo: {livro[i].titulo}");
                Console.WriteLine($"Autor: {livro[i].autor}");
                Console.WriteLine($"Data Publicacao: {livro[i].data}");
                Console.WriteLine($"Prateleira: {livro[i].prateleira}");
                Console.WriteLine("-------------------------------------------------");
            }
        }

    }//buscaano
    static int menu()
    {
        Console.WriteLine("Qual seria a operação desejada?");
        Console.WriteLine("1 - adicionar livro");
        Console.WriteLine("2 - buscar livro");
        Console.WriteLine("3 - buscar data");
        Console.WriteLine("4 - mostrar livros cadastrados");
        Console.WriteLine("0 - sair");
        int ret = int.Parse(Console.ReadLine());
        return ret;
    }
    static void Main()
    {
        List<Livros> livros = new List<Livros>();
        Console.WriteLine("exercicio 2");
        int op;
        string buscatitulo;
        int buscaano;
        do
        {
            op = menu();
            if (op == 0)
            {
                Console.WriteLine("Saindo");
            }
            else if(op == 1)
            {
                Console.WriteLine("adicionando livro!");
                addLivro(livros);
            }
            else if(op == 2)
            {
                Console.WriteLine("buscando livro!");
                buscatitulo = Console.ReadLine();
                buscalivro(livros, buscatitulo);
            }
            else if(op == 3)
            {
                Console.WriteLine("buscando data!");
                buscaano = int.Parse(Console.ReadLine());
                buscaAno(livros, buscaano);
            }else if(op == 4)
            {
                Console.WriteLine("mostrando livros!");
                mostralivro(livros);
            }
            Console.ReadKey();
            Console.Clear();
        } while(op != 0);
        
    }   
}
