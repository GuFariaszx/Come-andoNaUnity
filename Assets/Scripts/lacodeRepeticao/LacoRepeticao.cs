using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //for -> É utilizado quando se sabe a quantidade de repetiçoes.

    //while ou doWhile -> É utilizado quando não se sabe a quantidade de repetições.

    //foreach -> usado em listas ou arrays, para executar uma operação para cada item da lista ou array.

    //array -> uma lista

    //int x = 0;
    //int y = 10;

    // Criando uma lista de números inteiros
    List<int> n = new List<int>();

    void Start()
    {
        // for(inicializador; condição; incremento/decremento)
        //for (int i = 0; i <= 10; i++)
        //{
        //    //if (i == 5)
        //    //{
        //    //    break;
        //    //}

        //    if (i == 6)
        //    {
        //        continue;
        //    }
        //    print(i);
        //}

        //while
        //while (x <= 10)
        //    {
        //        print(x);
        //        x++;
        //    }

        ////DO While
        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        //print(num[3]);

        //num[0]++;

        //print(num[0]);

        //string[] nome;

        //nome = new string[1];
        //nome[0] = "ElMacho";

        //print(nome[0]);

        //for (int i = 1; i <= 8; i+=2)
        //{
        //    print(num[i]);
        //}

        //foreach (int i in num )
        //{
        //    print( i );
        //}

        //----------------------------------------------

        // Adiciona elementos  à lista de números inteiros
        n.Add(1); // indice 0
        n.Add(2); // indice 1 
        n.Add(3); // indice 2
        n.Add(4); // indice 3
        n.Add(5); // indice 4
        n.Add(6); // indice 5
        n.Add(7); // indice 6
        n.Add(8); // indice 7
        
        // Remove o primeiro valor '4' encontrado na lista (indice 3)
        n.Remove(4);

        // Ordena os elementos da lista em ordem crescente
        n.Sort();

        // Ordena os elementos da lista em ordem decrescente
        n.Reverse();

        // Pega o elemento 
        n.IndexOf(1);
    }


    void Update()
    {

    }
}

