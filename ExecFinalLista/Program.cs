using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecFinalLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void exec01() 
            {

                List<string[]> respostas = new List<string[]>();
                List<int> notas = new List<int>();
                string[] gabarito = { "A", "B", "C", "D", "E", "E", "D", "C", "B", "A" };
                int respVerif = 0;
                
                do 
                { 
                
                    Console.WriteLine("Digite as respostas que você colocou na prova: ");
                    for (int i = 0; i < 10; i++) { }
                    string r1 = Console.ReadLine().ToUpper();
                    string r2 = Console.ReadLine().ToUpper();
                    string r3 = Console.ReadLine().ToUpper();
                    string r4 = Console.ReadLine().ToUpper();
                    string r5 = Console.ReadLine().ToUpper();
                    string r6 = Console.ReadLine().ToUpper();
                    string r7 = Console.ReadLine().ToUpper();
                    string r8 = Console.ReadLine().ToUpper();
                    string r9 = Console.ReadLine().ToUpper();
                    string r10 = Console.ReadLine().ToUpper();

                    respostas.Add(new string[] { r1,r2,r3, r4, r5, r6, r7, r8, r9, r10 });
                                
                    Console.WriteLine("Deseja cadastrar as respostas de outra pessoa? 1 - Sim; 0 - Não;");
                    respVerif = int.Parse(Console.ReadLine());

                }

                while (respVerif != 0);

                foreach (string[] resposta in respostas)
                {
                    int acertos = 0;

                    for (int i = 0; i < 10; i++)
                    {

                        if (resposta[i] == gabarito[i])
                        {
                            acertos++;
                        }

                    }

                    notas.Add(acertos);

                }
                                             
                Console.WriteLine("Maior acerto: "+ notas.Max() + " e Menor Acerto: "+notas.Min());
                Console.WriteLine("Total de Alunos que utilizaram o sistema: " + notas.Count);
                Console.WriteLine("Média das Notas da Turma: " + notas.Average());
                Console.WriteLine("Gabarito: "+string.Join(", ", gabarito));

                Console.ReadKey();
            }

            void exec02()
            {
                /*PARTE ADICIONAL:
                 - Após concluir isto você poderia incrementar o programa permitindo que o professor digite o gabarito da prova antes dos alunos usarem o programa.*/

                Console.WriteLine("Digite as respostas do gabarito: ");
                string rGabarito1 = Console.ReadLine().ToUpper();
                string rGabarito2 = Console.ReadLine().ToUpper();
                string rGabarito3 = Console.ReadLine().ToUpper();
                string rGabarito4 = Console.ReadLine().ToUpper();
                string rGabarito5 = Console.ReadLine().ToUpper();
                string rGabarito6 = Console.ReadLine().ToUpper();
                string rGabarito7 = Console.ReadLine().ToUpper();
                string rGabarito8 = Console.ReadLine().ToUpper();
                string rGabarito9 = Console.ReadLine().ToUpper();
                string rGabarito10 = Console.ReadLine().ToUpper();
                Console.WriteLine("\nAs respostas do gabarito foram gravadas!");
                Console.ReadKey();
                Console.Clear();

                List<string[]> respostas = new List<string[]>();
                List<int> notas = new List<int>();

                string[] gabarito = { rGabarito1, rGabarito2, rGabarito3, rGabarito4, rGabarito5, 
                    rGabarito6, rGabarito7, rGabarito8, rGabarito9, rGabarito10};
                
                int respVerif = 0;

                do
                {

                    Console.WriteLine("Digite as respostas que você colocou na prova: ");
                    string r1 = Console.ReadLine().ToUpper();
                    string r2 = Console.ReadLine().ToUpper();
                    string r3 = Console.ReadLine().ToUpper();
                    string r4 = Console.ReadLine().ToUpper();
                    string r5 = Console.ReadLine().ToUpper();
                    string r6 = Console.ReadLine().ToUpper();
                    string r7 = Console.ReadLine().ToUpper();
                    string r8 = Console.ReadLine().ToUpper();
                    string r9 = Console.ReadLine().ToUpper();
                    string r10 = Console.ReadLine().ToUpper();

                    respostas.Add(new string[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 });

                    Console.WriteLine("Deseja cadastrar as respostas de outra pessoa? 1 - Sim; 0 - Não;");
                    respVerif = int.Parse(Console.ReadLine());

                }

                while (respVerif != 0);

                foreach (string[] resposta in respostas)
                {
                    int acertos = 0;

                    for (int i = 0; i < 10; i++)
                    {

                        if (resposta[i] == gabarito[i])
                        {
                            acertos++;
                        }

                    }

                    notas.Add(acertos);

                }
                               
                Console.WriteLine("Maior acerto: " + notas.Max() + " e Menor Acerto: " + notas.Min());
                Console.WriteLine("Total de Alunos que utilizaram o sistema: " + notas.Count);
                Console.WriteLine("Média das Notas da Turma: " + notas.Average());
                Console.WriteLine("Gabarito: " + string.Join(", ", gabarito));

                Console.ReadKey();
            }
            exec02();
        }
    }
}
