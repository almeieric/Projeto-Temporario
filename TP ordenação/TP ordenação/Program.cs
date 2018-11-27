using System;
using System.Diagnostics;

class TPordenação
{
    /// <summary>
    /// Cria um metodo para Preencher o Vetores 
    /// </summary>
    ///<param name="vetor1">recebe o valor de vetor 1</param>
    ///<param name="vetor2">recebe o valor de vetor 2</param>
    ///<param name="vetor3">recebe o valor de vetor 3</param>

    static void Preencher(int[] vetor1,int[]vetor2, int[]vetor3)
    {
        
        for (int i = 0; i <= vetor1.Length - 1; i++)//este for ira preencher o vetor de forma crescente
        {
           
            vetor1[i] = i+ 1 ;

        }
        for (int i = vetor2.Length-1; i >= 0; i--)//este for ira preencher o vetor de forma decrescente
        {
            vetor2[i] = i + 1;

        }
        
        for (int i = 0; i <= vetor3.Length - 1; i++)//este for ira preencher o vetor com numeros randomicos
        {
            vetor3[i] = RandomNumber(0, 100000);

        }
    }
    /// <summary>
    /// Imprime os vetores na ordem que foram preenchidos ou ordenados dependendo de onde o codigo for chamado
    /// </summary>
    /// <param name="vetor1">recebe vetor 1</param>
    /// <param name="vetor2">recebe vetor 2</param>
    /// <param name="vetor3">recebe vetor 3</param>
    static void Imprime(int[] vetor1, int[] vetor2, int[] vetor3)
    {

        for (int i = 0; i <= vetor1.Length - 1; i++)//este for ira preencher o vetor de forma crescente
        {

            Console.WriteLine(vetor1[i]);

        }
        for (int i = 0; i <= vetor2.Length - 1; i++)//este for ira preencher o vetor de forma decrescente
        {
            Console.WriteLine(vetor2[i]);

        }

        for (int i = 0; i <= vetor3.Length - 1; i++)//este for ira preencher o vetor com numeros randomicos
        {
            Console.WriteLine(vetor3[i]);

        }
    }

    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        int[] vetor1;
        int[] vetor2;
        int[] vetor3;
        
        bool sair = false;
        do
        {
            Console.Write("Contagem de tempo de ordenação\n" +
            "Menu [1] = BubbleSort\n" +
            "Menu [2] = InsertionSort\n" +
            "Menu [3] = SelectionSort\n" +
            "Menu [4] = MergeSort\n" +
            "Menu [5] = QuickSort\n" +
            "Insira apenas numero no menu:\n");
            Stopwatch timer = new Stopwatch();// O comando Stopwatch conta o tempo que o programa levou para ler um metodo

            bool bubble = false;
            bool insertion = false;
            bool selection = false;
            bool merge = false;
            bool quick = false;

            var menu = Console.ReadKey();
            Console.WriteLine("\n");
            
            if (bubble = menu.KeyChar == '1')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);
                                                                                    
                timer.Start();
                bubbleSort(vetor1);
                timer.Stop();
                TimeSpan tempoBubble1 = timer.Elapsed;//declara o tempo que levou para decorrer o bubblesort
                timer.Reset();

                timer.Start();
                bubbleSort(vetor2);
                timer.Stop();
                TimeSpan tempoBubble2 = timer.Elapsed;//declara o tempo que levou para decorrer o bubblesort
                timer.Reset();

                timer.Start();
                bubbleSort(vetor3);
                timer.Stop();
                TimeSpan tempoBubble3 = timer.Elapsed;//declara o tempo que levou para decorrer o bubblesort
                timer.Reset();





               //Imprime(vetor1, vetor2, vetor3);//escreve o vetor ordenado


                Console.WriteLine("\nO tempo do Bubble Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble1.Minutes, tempoBubble1.Seconds, tempoBubble1.Milliseconds);
                Console.WriteLine("\nO tempo do Bubble Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble2.Minutes, tempoBubble2.Seconds, tempoBubble2.Milliseconds);
                Console.WriteLine("\nO tempo do Bubble Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble3.Minutes, tempoBubble3.Seconds, tempoBubble3.Milliseconds);
                timer.Reset();//reseta o contador
            }
            else if (insertion = menu.KeyChar == '2')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                InsertionSort(vetor1);
                timer.Stop();
                TimeSpan tempoInsertion1 = timer.Elapsed;
                timer.Reset();


                timer.Start();
                InsertionSort(vetor2);
                timer.Stop();
                TimeSpan tempoInsertion2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                InsertionSort(vetor3);
                timer.Stop();

                TimeSpan tempoInsertion3 = timer.Elapsed;

                timer.Reset();

                //Imprime(vetor1, vetor2, vetor3);//escreve o vetor ordenado
                

                Console.WriteLine("O tempo do Insertion Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion1.Minutes, tempoInsertion1.Seconds, tempoInsertion1.Milliseconds);
                Console.WriteLine("O tempo do Insertion Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion2.Minutes, tempoInsertion2.Seconds, tempoInsertion2.Milliseconds);
                Console.WriteLine("O tempo do Insertion Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion3.Minutes, tempoInsertion3.Seconds, tempoInsertion3.Milliseconds);

                timer.Reset();
            }
            else if (selection = menu.KeyChar == '3')
            {

                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                SelectionSort(vetor1);
                timer.Stop();
                TimeSpan tempoSelection1 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                SelectionSort(vetor2);
                timer.Stop();
                TimeSpan tempoSelection2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                SelectionSort(vetor3);
                timer.Stop();
                TimeSpan tempoSelection3 = timer.Elapsed;
                timer.Reset();


                //Imprime(vetor1, vetor2, vetor3);//escreve o vetor ordenado



                Console.WriteLine("O tempo do Selection Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection1.Minutes , tempoSelection1.Seconds, tempoSelection1.Milliseconds);
                Console.WriteLine("O tempo do Selection Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection2.Minutes, tempoSelection2.Seconds, tempoSelection2.Milliseconds);
                Console.WriteLine("O tempo do Selection Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection3.Minutes, tempoSelection3.Seconds, tempoSelection3.Milliseconds);

                timer.Reset();//reseta o contador
            }
            else if (merge = menu.KeyChar == '4')
            {
                /*
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                MergeSort(vetor1,vetor1[0],vetor1.Length-1);
                timer.Stop();
                TimeSpan tempoMerge1 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                MergeSort(vetor2, vetor2[0], vetor2.Length-1);
                timer.Stop();
                TimeSpan tempoMerge2 = timer.Elapsed;
                timer.Reset();

                timer.Start();
                MergeSort(vetor3, vetor3[0], vetor3.Length-1);
                timer.Stop();
                TimeSpan tempoMerge3 = timer.Elapsed;
                timer.Reset();

                Imprime(vetor1, vetor2, vetor3);//confere se o vetor esta ordenado

               

                Console.WriteLine("O tempo do Merge Sort no vetor 1 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge1.Minutes, tempoMerge1.Seconds, tempoMerge1.Milliseconds);
                Console.WriteLine("O tempo do Merge Sort no vetor 2 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge2.Minutes, tempoMerge2.Seconds, tempoMerge2.Milliseconds);
                Console.WriteLine("O tempo do Merge Sort no vetor 3 foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge3.Minutes, tempoMerge3.Seconds, tempoMerge3.Milliseconds);
                timer.Reset();//reseta o contador*/
            }
            else if (quick = menu.KeyChar == '5')
            {

                vetor1 = new int[10000];
                vetor2 = new int[10000];
                vetor3 = new int[10000];
                Preencher(vetor1, vetor2, vetor3);
                
                timer.Start();
                QuickSort(vetor1);
                timer.Stop();
                TimeSpan tempoQuick1 = timer.Elapsed;
                timer.Reset();//reseta o contador

                timer.Start();
                QuickSort(vetor2);
                timer.Stop();
                TimeSpan tempoQuick2 = timer.Elapsed;
                timer.Reset();//reseta o contador

                timer.Start();
                QuickSort(vetor3);
                timer.Stop();
                TimeSpan tempoQuick3 = timer.Elapsed;


                //Imprime(vetor1, vetor2, vetor3);//confere se o vetor esta ordenado

                //Console.WriteLine(tempoQuick.TotalMinutes);

                Console.WriteLine("O tempo do Quick Sort no vetor 1 foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick1.Minutes, tempoQuick1.Seconds, tempoQuick1.Milliseconds);
                Console.WriteLine("O tempo do Quick Sort no vetor 2 foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick2.Minutes, tempoQuick2.Seconds, tempoQuick2.Milliseconds);
                Console.WriteLine("O tempo do Quick Sort no vetor 3 foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick3.Minutes, tempoQuick3.Seconds, tempoQuick3.Milliseconds);
                timer.Reset();//reseta o contador
            }
            else if (menu.KeyChar > 5)
                Console.WriteLine("Insira um numero do menu por favor;");

            Console.WriteLine("\n");
            Console.Write("Deseja Sair?: (se Sim digite S)");
            var finalizar = Console.ReadKey();
            sair = finalizar.KeyChar == 'S' || finalizar.KeyChar == 's';
            Console.WriteLine("\n");
        } while(!sair);

        Console.ReadKey();
    }//fim do main

    /// <summary>
    /// Cria um metodo para randominar os numeros nos Vetores 
    /// </summary>
    ///<param name="min">recebe o valor minimo que pode aparecer</param>
    ///<param name="max">recebe o valor vaximo que pode aparecer</param>
   
    static int RandomNumber(int min, int max)//metodo que ira gerar os numeros randomicos
    {
        Random random = new Random();//chamada do metodo
        return random.Next(min, max);//retona numeros randomicos entre o minimo e o maximo
    }//fim do random

    /// <summary>
    /// Organiza cada vetor no metodo bubble sort
    /// </summary>
    ///<param name="vetor">recebe o vetor que sera organizado</param>
    
    static int[] bubbleSort(int[] vetor)
    {
        int aux = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            for (int j = 0; j < vetor.Length - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])//ira verificar o menor numero
                {
                    aux = vetor[j + 1];//ira jogar o numero no auxiliar
                    vetor[j + 1] = vetor[j];//ira colocar o numero no vetor
                    vetor[j] = aux;// colocara novo numero no auxiliar
                }//fim do if
            }//fim do 2ºfor
        }//fim do 1ºfor
        return vetor;
    }//fim do bubblesort

    /// <summary>
    /// Organiza cada vetor no metodo Insertion sort
    /// </summary>
    /// <param name="vetor">recebe o vetor que sera organizado</param>
    static int[] InsertionSort(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            int j = i + 1;

            while (j > 0)
            {
                if (vetor[j - 1] > vetor[j])
                {
                    int aux = vetor[j - 1];
                    vetor[j - 1] = vetor[j];
                    vetor[j] = aux;

                }
                j--;
            }
        }
        return vetor;
    }
    /// <summary>
    /// Organiza cada vetor no metodo Selection sort
    /// </summary>
    /// <param name="vetor">recebe o vetor que sera organizado</param>
    static int[] SelectionSort(int[] vetor)
    {
        int menor, i, j, aux;
        for (i = 0; i < vetor.Length - 1; i++)
        {
            menor = i;
            for (j = i; j < vetor.Length; j++)
            {
                if (vetor[j] < vetor[menor])
                    menor = j;
                aux = vetor[menor];
                vetor[menor] = vetor[i];
                vetor[i] = aux;
            }
        }
        return vetor;
    }
    
    /// <summary>
    /// Chama o metodo e separa o inicio e o fim do vetor
    /// </summary>
    /// <param name="vetor">recebe vetor</param>
    /// <returns></returns>
    public static int[] QuickSort(int[] vetor)
    {
        int inicio = 0;
        int fim = vetor.Length - 1;

        QuickSort(vetor, inicio, fim);

        return vetor;
    }
    /// <summary>
    /// recebe o vetor com o inicio e o fim ja estabelecidos
    /// </summary>
    /// <param name="vetor">recebe vetor</param>
    /// <param name="inicio">estabelece o inicio do vetor</param>
    /// <param name="fim">estabelece o fim do vetor</param>
    private static void QuickSort(int[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor[i] <= p)
                {
                    i++;
                }
                else if (p < vetor[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor[inicio] = vetor[f];
            vetor[f] = p;

            QuickSort(vetor, inicio, f - 1);
            QuickSort(vetor, f + 1, fim);
        }
    }



}



