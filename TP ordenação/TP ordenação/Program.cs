using System;
using System.Diagnostics;

class TPordenação
{
    static void Preencher(int[] vetor1,int[]vetor2, int[]vetor3)
    {
        for (int i = 0; i <= vetor1.Length - 1; i++)//este for ira preencher o vetor de forma crescente
        {
            vetor1[i] = i;

        }
        for (int i = vetor2.Length - 1; i >= 1; i--)//este for ira preencher o vetor de forma decrescente
        {
            vetor2[i] = i;

        }
        for (int i = 0; i <= vetor3.Length - 1; i++)//este for ira preencher o vetor com numeros randomicos
        {
            vetor3[i] = RandomNumber(0, 10000);

        }
    }

       
    public static void Main()
    {


        int[] vetor1 = new int[10000];
        int[] vetor2 = new int[10000];
        int[] vetor3 = new int[10000];



        Preencher(vetor1, vetor2, vetor3);

               
        



        
        
        Stopwatch timer = new Stopwatch();// O comando Stopwatch conta o tempo que o programa levou para ler um metodo

        timer.Start();//o comando Start começa a ler o tempo do comando
        bubbleSort(vetor1);
        bubbleSort(vetor2);
        bubbleSort(vetor3);
      
        timer.Stop();//O comando Stop indica onde para de ler o tempo 


        TimeSpan tempoBubble = timer.Elapsed;//declara o tempo que levou para decorrer o bubblesort


        timer.Reset();//reseta o contador

        
        timer.Start();
        InsertionSort(vetor1);
        InsertionSort(vetor2);
        InsertionSort(vetor3);
        timer.Stop();
        TimeSpan tempoInsertion = timer.Elapsed;

        timer.Reset();

        timer.Start();
        SelectionSort(vetor1);
        SelectionSort(vetor2);
        SelectionSort(vetor3);
        timer.Stop();
        TimeSpan tempoSelection = timer.Elapsed;

        timer.Reset();//reseta o contador
        timer.Start();
        MergeSort(vetor1, vetor1[0], vetor1[9999]);
        MergeSort(vetor2, vetor2[9999], vetor2[0]);
        MergeSort(vetor3, vetor1[0], vetor1[9999]);
        timer.Stop();
        TimeSpan tempoMerge = timer.Elapsed;


        Console.WriteLine("\nO tempo do Bubble Sort foi: " + tempoBubble);
        Console.WriteLine("O tempo do Insertion Sort foi: " + tempoInsertion);
        Console.WriteLine("O tempo do Selection Sort foi: " + tempoSelection);
        Console.WriteLine("O tempo do Merge Sort foi: " + tempoMerge);


        Console.ReadKey();
    }//fim do main


    static int RandomNumber(int min, int max)//metodo que ira gerar os numeros randomicos
    {
        Random random = new Random();//chamada do metodo
        return random.Next(min, max);//retona numeros randomicos entre o minimo e o maximo
    }//fim do random

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
            }
            vetor[j + 1] = aux;
        }
    }
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
    public static void MergeSort(int[] input, int PrimeiroV, int ultimoV)
    {
        if (PrimeiroV < ultimoV)
        {
            int Meio = (PrimeiroV + ultimoV) / 2;

            MergeSort(input, PrimeiroV, Meio);
            MergeSort(input, Meio + 1, ultimoV);

            //Merge
            int[] leftArray = new int[Meio - PrimeiroV + 1];
            int[] rightArray = new int[ultimoV - Meio];

            Array.Copy(input, PrimeiroV, leftArray, 0, Meio - PrimeiroV + 1);
            Array.Copy(input, Meio + 1, rightArray, 0, ultimoV - Meio);

            int i = 0;
            int j = 0;
            for (int k = PrimeiroV; k < ultimoV + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }

}
