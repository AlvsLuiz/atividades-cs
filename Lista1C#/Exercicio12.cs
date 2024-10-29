using System;
using System.Runtime.Serialization;
public class Exercicio12
{
    /*12. Carnaval
O Carnaval é um feriado celebrado normalmente em fevereiro;
em muitas cidades brasileiras, a principal atração são
os desfiles de escolas de samba. As várias agremiações
desfilam ao som de seus sambas-enredos e são julgadas
pela liga das escolas de samba para determinar a campeã do Carnaval.
Cada agremiação é avaliada em vários quesitos; em cada
quesito, cada escola recebe cinco notas que variam de 5,0
a 10,0. A nota final da escola em um dado quesito é a soma
das três notas centrais recebidas pela escola, excluindo a
maior e a menor das cinco notas.
Como existem muitas escolas de samba e muitos quesitos, o 
presidente da liga pediu que você escrevesse um
programa que, dadas as notas da agremiação, calcula a sua nota final num dado quesito.*/
    static void Main()
    {
        double[] nota = new double[5];
        double notm=0, notn=999, som=0;
        Console.WriteLine("quais as notas da escola atual? entre 5.0 e 10.0");
        for (int i = 0; i < nota.Length; i++)
        {
            a:
            nota[i] = double.Parse(Console.ReadLine());
            if (nota[i]<5.0 || nota[i] > 10.0)
            {
                Console.WriteLine("valor invalido");
                goto a;
            }
        }
        for (int i = 0;i < nota.Length; i++)
        {
            if (nota[i] > notm)
            {
                notm = nota[i];
            }
            if (nota[i] < notn)
            {
                notn = nota[i];
            }
            som += nota[i];
        }
        Console.WriteLine($"a nota final desta escola de samba é {som - notn - notm}");
        

    }
}
