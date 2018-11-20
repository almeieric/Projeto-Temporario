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
           
            vetor1[i] = i+1;

        }
        for (int i = vetor2.Length - 1; i >= 1; i--)//este for ira preencher o vetor de forma decrescente
        {
            vetor2[i] = i + 1;

        }
        
        for (int i = 0; i <= vetor3.Length - 1; i++)//este for ira preencher o vetor com numeros randomicos
        {
            vetor3[i] = RandomNumber(0, 100000);

        }
    }

       
    public static void Main()
    {
        
        int[] vetor1 = new int[100000];
        int[] vetor2 = new int[100000];
        int[] vetor3 = new int[100000];


        
        Preencher(vetor1, vetor2, vetor3);
                

        

        Stopwatch timer = new Stopwatch();// O comando Stopwatch conta o tempo que o programa levou para ler um metodo

        timer.Start();//o comando Start começa a ler o tempo do comando
        bubbleSort(vetor1);
        bubbleSort(vetor2);
        bubbleSort(vetor3);
      
        timer.Stop();//O comando Stop indica onde para de ler o tempo 


        TimeSpan tempoBubble = timer.Elapsed;//declara o tempo que levou para decorrer o bubblesort


        timer.Reset();//reseta o contador

        Preencher(vetor1, vetor2, vetor3);

        timer.Start();
        InsertionSort(vetor1);
        InsertionSort(vetor2);
        InsertionSort(vetor3);
        timer.Stop();
        TimeSpan tempoInsertion = timer.Elapsed;

        timer.Reset();

        Preencher(vetor1, vetor2, vetor3);

        timer.Start();
        SelectionSort(vetor1);
        SelectionSort(vetor2);
        SelectionSort(vetor3);
        timer.Stop();
        TimeSpan tempoSelection = timer.Elapsed;

        timer.Reset();//reseta o contador

        Preencher(vetor1, vetor2, vetor3);

        timer.Start();
        MergeSort(vetor1, vetor1[0], vetor1[99999]);
        MergeSort(vetor2, vetor2[99999], vetor2[0]);
        MergeSort(vetor3, vetor1[0], vetor1[99999]);
        timer.Stop();

        TimeSpan tempoMerge = timer.Elapsed;
        timer.Reset();//reseta o contador


        Preencher(vetor1, vetor2, vetor3);

        timer.Start();
        QuickSort(vetor1, vetor1[0], vetor1[99999]);
        QuickSort(vetor2, vetor2[99999], vetor2[0]);
        QuickSort(vetor3, vetor1[0], vetor1[99999]);
        timer.Stop();

        TimeSpan tempoQuick = timer.Elapsed;

        Console.WriteLine("\nO tempo do Bubble Sort foi:    " + tempoBubble);
        Console.WriteLine("O tempo do Insertion Sort foi: " + tempoInsertion);
        Console.WriteLine("O tempo do Selection Sort foi: " + tempoSelection);
        Console.WriteLine("O tempo do Merge Sort foi:     " + tempoMerge);
        Console.WriteLine("O tempo do Quick Sort foi:     " + tempoQuick);


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
    
    static void bubbleSort(int[] Vetor)
    {
        int aux = 0;

        for (int i = 0; i < Vetor.Length; i++)
        {
            for (int j = 0; j < Vetor.Length - 1; j++)
            {
                if (Vetor[j] > Vetor[j + 1])//ira verificar o menor numero
                {
                    aux = Vetor[j + 1];//ira jogar o numero no auxiliar
                    Vetor[j + 1] = Vetor[j];//ira colocar o numero no vetor
                    Vetor[j] = aux;// colocara novo numero no auxiliar
                }//fim do if
            }//fim do 2ºfor
        }//fim do 1ºfor
    }//fim do bubblesort

    /// <summary>
    /// Organiza cada vetor no metodo Insertion sort
    /// </summary>
    /// <param name="vetor">recebe o vetor que sera organizado</param>
    static void InsertionSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 1; i < n; ++i)
        {
            int aux = vetor[i];
            int j = i - 1;


            while (j >= 0 && vetor[j] > aux)
            {
                vetor[j + 1] = vetor[j];
                j = j - 1;
            }//fim do while
            vetor[j + 1] = aux;
        }// fim do for
    }//fim do insetion sort

    /// <summary>
    /// Organiza cada vetor no metodo Selection sort
    /// </summary>
    /// <param name="vetor">recebe o vetor que sera organizado</param>
    static void SelectionSort(int[] Vetor)
    {
        int menor, i, j, aux;
        for (i = 0; i < Vetor.Length - 1; i++)
        {
            menor = i;
            for (j = i; j < Vetor.Length; j++)
            {
                if (Vetor[j] < Vetor[menor])
                    menor = j;
                aux = Vetor[menor];
                Vetor[menor] = Vetor[i];
                Vetor[i] = aux;
            }
        }
    }
    /// <summary>
    /// Organiza cada vetor no metodo Merge sort
    /// </summary>
    /// <param name="vetor">recebe o vetor que sera organizado</param>
    /// <param name="primeiroV">recebe a primeira posição do vetor</param>
    /// <param name="ultimoV">recebe a ultima posição do vetor</param>
    public static void MergeSort(int[] vetor, int primeiroV, int ultimoV)
    {
        if (primeiroV < ultimoV)
        {
            int meio = (primeiroV + ultimoV) / 2;

            MergeSort(vetor, primeiroV, meio);
            MergeSort(vetor, meio + 1, ultimoV);

            //Merge
            int[] leftArray = new int[meio - primeiroV + 1];
            int[] rightArray = new int[ultimoV - meio];

            Array.Copy(vetor, primeiroV, leftArray, 0, meio - primeiroV + 1);
            Array.Copy(vetor, meio + 1, rightArray, 0, ultimoV - meio);

            int i = 0;
            int j = 0;
            for (int k = primeiroV; k < ultimoV + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    vetor[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    vetor[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    vetor[k] = leftArray[i];
                    i++;
                }
                else
                {
                    vetor[k] = rightArray[j];
                    j++;
                }//fim do 2º if 
            }//fim do for
        }//fim do 1º if
    }// fim do merge sort

    /// <summary>
    /// Organiza cada vetor no metodo Quick sort
    /// </summary>
    /// <param name="vetor">recebe o vetor que sera organizado</param>
    /// <param name="primeiroV">recebe a primeira posição do vetor</param>
    /// <param name="ultimoV">recebe a ultima posição do vetor</param>
    static public void QuickSort(int[] vetor, int primeiroV, int ultimoV)
    {
        /*pivo vai definir o meio da pesquisa para organisação para que o metodo busque o numero e o reorganize
         * por exmplo como temos 10 mil posições com numeros sequenciais o pivo vai ser 5mil
         *enquanto o atributo meio vai pegar a posição 5mil mesmo que o valor dela não seja 5mil
         */
        int menor, maior, meio, pivo, aux;
        menor = primeiroV;
        maior = ultimoV;
        meio = (int)((menor + maior) / 2);

        pivo = vetor[meio];

        while (menor <= maior)
        {
            while (vetor[menor] < pivo)
                menor++;
            while (vetor[maior] > pivo)
                maior--;
            if (menor < maior)
            {
                aux = vetor[menor];
                vetor[menor++] = vetor[maior];
                vetor[maior--] = aux;
            }
            else
            {
                if (menor == maior)
                {
                    menor++;
                    maior--;
                }
            }
        }

        if (maior > primeiroV)
            QuickSort(vetor, primeiroV, maior);
        if (menor < ultimoV)
            QuickSort(vetor, menor, ultimoV);
    }
}



