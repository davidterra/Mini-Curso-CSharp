using System.Linq;

namespace Exemplo1
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    };

    class Distributor
    {
        public int ID { get; set; }
        public string City { get;  set; }
        public string Name { get; set; }
    }

    static class ExampleClass
    {
        private static int _xpto;
        public static int ResultSoFar()
        {
            return 0;
        }
    }

    class ExampleClass2
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Location { get; set; }
        public float Age { get; set; }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.Collections.Generic.IList<float> Scores { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {
            // *Convenções de nomenclatura
            var currentPerformanceCounterCategory = new System.Diagnostics.
            PerformanceCounterCategory();

            // *Convenções de Layout
            // Use as configurações padrão do Editor de códigos(recuo inteligente, recuos de quatro caracteres, guias salvas como espaços).
            // Gravar apenas uma instrução por linha.
            // Gravar apenas uma declaração por linha.
            // Se as linhas de continuação não devem recuar automaticamente, recue-as uma tabulação(quatro espaços).
            // Adicione pelo menos uma linha em branco entre as definições de método e de propriedade.
            // Use parênteses para criar cláusulas em uma expressão aparente, conforme mostrado no código a seguir.

            double val1 = 0;
            double val2 = 0;
            double val3 = 0;

            if ((val1 > val2) && (val1 > val3))
            {
                //Bloco de código.
            };

            // *Comentando Convenções
            // Coloque o comentário em uma linha separada, não no final de uma linha de código.
            // Comece o texto do comentário com uma letra maiúscula.
            // Termine o texto do comentário com um ponto final.
            // Insira um espaço entre o delimitador de comentário (//) e o texto do comentário, conforme mostrado no exemplo a seguir.

            // *Diretrizes de Linguagem

            var nameList = new Customer[] { new Customer { FirstName = "Xpto", LastName = "Bar" } };

            // Use o operador + para concatenar cadeias de caracteres curtas, conforme mostrado no código a seguir.

            string displayName = nameList[0].LastName + ", " + nameList[0].FirstName;

            // Para acrescentar cadeias de caracteres em loops, especialmente quando você estiver trabalhando com grandes quantidades de texto, 
            // use um objeto System.Text.StringBuilder.

            var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
            var manyPhrases = new System.Text.StringBuilder();
            for (var i = 0; i < 10000; i++)
            {
                manyPhrases.AppendFormat("{0} {1} {0}", phrase, "acme");

            }
            
            

            System.Console.WriteLine("tra" + manyPhrases);

            // *Variáveis Locais Tipadas Implicitamente

            // Use a digitação implícita para variáveis locais quando o tipo da variável for óbvio do lado direito da atribuição 
            // ou quando o tipo exato não for importante.

            var var1 = "This is clearly a string.";
            var var2 = 27;
            var var3 = System.Convert.ToInt32(System.Console.ReadLine());

            // Não use var quando o tipo não estiver aparente no lado direito da atribuição.

            int var4 = ExampleClass.ResultSoFar();

            // Não se baseie no nome da variável para especificar o tipo dela. Ele pode não estar correto.

            var inputInt = System.Console.ReadLine();
            System.Console.WriteLine(inputInt);

            // Evite o uso de var em vez de dynamic.
            // Use a digitação implícita para determinar o tipo da variável de loop nos loops for e foreach.
            // O exemplo a seguir usa digitação implícita em uma instrução for.

            var syllable = "ha";
            var laugh = "";
            for (var i = 0; i < 10; i++)
            {
                laugh += syllable;
                System.Console.WriteLine(laugh);
            }

            // O exemplo a seguir usa digitação implícita em uma instrução foreach.

            foreach (var ch in laugh)
            {
                if (ch == 'h')
                    System.Console.Write("H");
                else
                    System.Console.Write(ch);
            }

            System.Console.WriteLine();

            // *Matrizes
            // Use a sintaxe concisa ao inicializar matrizes na linha da declaração.

            // Preferred syntax. Note that you cannot use var here instead of string[].
            string[] vowels1 = { "a", "e", "i", "o", "u" };

            // If you use explicit instantiation, you can use var.
            var vowels2 = new string[] { "a", "e", "i", "o", "u" };

            // If you specify an array size, you must initialize the elements one at a time.
            var vowels3 = new string[5];
            vowels3[0] = "a";
            vowels3[1] = "e";

            // try-catch e instruções de uso no tratamento de exceção

            // Simplifique o código usando a instrução using do #C. Se você tiver uma instrução try-finally na qual o único 
            // código do bloco finally é uma chamada para o método System.IDisposable.Dispose, use, em vez disso, uma instrução using.

            // This try-finally statement only calls Dispose in the finally block.

           

            System.Drawing.Font font1 = new System.Drawing.Font("Arial", 10.0f);
            try
            {
                byte charset = font1.GdiCharSet;
            }
            finally
            {
                if (font1 != null)
                {
                    ((System.IDisposable)font1).Dispose();
                }
            }

            // You can do the same thing with a using statement.
            using (var font2 = new System.Drawing.Font("Arial", 10.0f))
            {
                byte charset = font2.GdiCharSet;
            }

            // *Operadores && e ||

            System.Console.Write("Enter a dividend: ");
            var dividend = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Enter a divisor: ");
            var divisor = System.Convert.ToInt32(System.Console.ReadLine());

            // If the divisor is 0, the second clause in the following condition
            // causes a run-time error. The && operator short circuits when the
            // first expression is false. That is, it does not evaluate the
            // second expression. The & operator evaluates both, and causes 
            // a run-time error when divisor is 0.
            if ((divisor != 0) && (dividend / divisor > 0))
            {
                System.Console.WriteLine("Quotient: {0}", dividend / divisor);
            }
            else
            {
                System.Console.WriteLine("Attempted division by 0 ends up here.");
            }

            // *Operador New

            var instance1 = new ExampleClass2();

            // A linha anterior é equivalente à declaração a seguir.

            ExampleClass2 instance2 = new ExampleClass2();

            // Object initializer.

            var instance3 = new ExampleClass2
            {
                Name = "Desktop",
                ID = 37414,
                Location = "Redmond",
                Age = (float)2.3
            };

            // *Membros Estáticos
            // Chame membros estáticos usando o nome de classe: ClassName.StaticMember.Essa prática torna o código mais legível, tornando o acesso

            // *Consultas LINQ
            // Use nomes significativos para variáveis de consulta.O exemplo a seguir usa seattleCustomers para os clientes que estão localizados em Seattle.

            var customers = new System.Collections.Generic.List<Customer>();
            {
                new Customer { FirstName = "Xpto", LastName = "Bar", City = "Seattle" };
                new Customer { FirstName = "Acme", LastName = "Bar", City = "Pelotas" };
            }

            //Alinhe cláusulas de consulta na cláusula from, conforme mostrado nos exemplos anteriores.

            var seattleCustomers = from cust in customers
                                   where cust.City == "Seattle"
                                   select cust.FirstName;

            // Use aliases para se certificar de que os nomes de propriedades de tipos anônimos sejam colocados corretamente em maiúsculas, 
            // usando o padrão Pascal-Case.

            var distributors = new System.Collections.Generic.List<Distributor>()
            {
                new Distributor { Name ="Acme", City = "Seattle" },
            };

            var localDistributors =
                from customer in customers
                join distributor in distributors on customer.City equals distributor.City
                select new { Customer = customer, Distributor = distributor };

            // Renomeie propriedades quando os nomes de propriedades no resultado forem ambíguos.
            // Por exemplo, se a sua consulta retornar um nome de cliente e uma ID de distribuidor, em vez de deixá-los como Name e ID no resultado, 
            // renomeie -os para esclarecer que Name é o nome de um cliente, e ID é a identificação de um distribuidor.

            var localDistributors2 =
                from cust in customers
                join dist in distributors on cust.City equals dist.City
                select new { CustomerName = cust.FirstName, DistributorID = dist.ID };

            // Use cláusulas where antes de outras cláusulas de consulta para garantir que cláusulas de consulta 
            // posteriores operem no conjunto de dados filtrado e reduzido.

            var seattleCustomers2 = from cust in customers
                                    where cust.City == "Seattle"
                                    orderby cust.FirstName
                                    select cust;

            // Use várias cláusulas from em vez de uma cláusula join para acessar coleções internas. 
            // Por exemplo, cada coleção de objetos Student pode conter um conjunto de pontuações no teste. 
            // Quando a próxima consulta for executada, ela retorna cada pontuação que seja acima de 90, 
            // juntamente com o sobrenome do estudante que recebeu a pontuação.

            var students = new System.Collections.Generic.List<Student>();

            var scoreQuery = from student in students
                             from score in student.Scores
                             where score > 90
                             select new { Last = student.LastName, score };

        }

        // try-catch e instruções de uso no tratamento de exceção

        static string GetValueFromArray(string[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException ex)
            {
                System.Console.WriteLine("Index is out of range: {0}", index);
                throw;
            }
        }


    }
}
