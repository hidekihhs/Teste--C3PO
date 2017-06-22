using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person  // calsse para pessoa
    {
        // campos
        private string name;
        private DateTime thisDate1; 

        // Construtor sem argumentos.
        public Person()
        {
            name = "unknown";
            thisDate1 = new DateTime();
        }

        // Construtor com argumentos.
        public Person(string nm,int ano, int mes, int dia)
        {
            name = nm;
            thisDate1 = new DateTime(ano, mes, dia);
        }

        // Metodos
        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetData_nasc(int ano, int mes, int dia)
        {
             thisDate1 = new DateTime(ano, mes, dia);

        }  

        public DateTime GetData_nasc()
        {
            return thisDate1;
        }

        public string GetName()
        {
            return name;
        }

        //Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");
    }


    class Program
    {
        

        public static void questao1()
        {
            int soma5 = 0, soma3 = 0, soma = 0;

            for (int i = 5; i <= 1000; i += 5)
            {
                soma5 = soma5 + i;
            }
            for (int j = 3; j <= 1000; j += 3)
            {
                if (j % 5 != 0)
                    soma3 = soma3 + j;
            }
            soma = soma3 + soma5;
            Console.WriteLine(soma);

        }


        public static void questao2(int qtd)
        {
            int max = 1000, aux = 0;
            Dictionary<int, List<int>> dicionario = new Dictionary<int, List<int>>();
            for (int i = 0; i <= max; i++)
            {
                List<int> lista = new List<int>();
                lista.Add(aux);
                lista.Add(aux + 1);
                lista.Add(aux + 2);
                aux += 4;
                dicionario.Add(i, lista);
            }

            Imprimir_lista(qtd, dicionario);

        }


        public static void Imprimir_lista(int x, Dictionary<int, List<int>> dicionario)
        {
            for (int j = 0; j <= 4; j++)
                Console.Write("[" + j + "]:" + "[" + dicionario[j][0] + "," + dicionario[j][1] + "," + dicionario[j][2] + "]" + "\n");
        }


        public static bool VerificarMaioridade(Person pessoa)
        {
            DateTime hoje = DateTime.Now;
            if (((hoje.Subtract(pessoa.GetData_nasc()).TotalDays) / 365) >= 18)
                return true;
            else
                return false;
        }


        public static void Imprimir_MaiorIdade(bool var)
        {
            if (var == true)
                Console.WriteLine("É maior de idade");
            else
                Console.WriteLine("Não É maior de idade");
        }


        static void Main(string[] args)
        {
            int max;

            Console.WriteLine("\nQuestão 01 \nResultado : ");
            questao1();
            Console.WriteLine("\n");

            Console.WriteLine("\nQuestão 02 \nDigite um valor maximo menor que 1000 para ver do dicionario : ");
            max = Console.Read();
            questao2(max);
            Console.WriteLine("\n");


            Console.WriteLine("\nQuestão 03 \nTendo como base dois objetos Persons já criados : \n");
            // chamando contrutor sem parametro.
            Person person1 = new Person();
            //Console.WriteLine(person1.GetName());
            
            person1.SetName("Han Solo");
            person1.SetData_nasc( 1995, 02, 17);
            Console.WriteLine(person1.GetName());
            Console.WriteLine(person1.GetData_nasc().ToString("MMMM dd, yyyy"));
            Imprimir_MaiorIdade(VerificarMaioridade(person1)); // verificando maior idade
            Console.WriteLine("\n");

            // chamando construtor com parametro.
            Person person2 = new Person("Luke Skywalker",2000,03,11);
            Console.WriteLine(person2.GetName());
            Console.WriteLine(person2.GetData_nasc().ToString("MMMM dd, yyyy"));
            Imprimir_MaiorIdade(VerificarMaioridade(person2)); // verificando maior idade
            Console.WriteLine("\n");

            //DateTime hoje = DateTime.Now;
            //Console.WriteLine(hoje);
            //Console.WriteLine((hoje.Subtract(person2.GetData_nasc()).TotalDays)/365);
            //Console.WriteLine(VerificarMaioridade(person1));
            //Console.WriteLine(VerificarMaioridade(person2));  


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
       
    }

}

