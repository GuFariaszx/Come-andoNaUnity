using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //for -> � utilizado quando se sabe a quantidade de repeti�oes.

    //while ou doWhile -> � utilizado quando n�o se sabe a quantidade de repeti��es.

    //foreach -> usado em listas ou arrays, para executar uma opera��o para cada item da lista ou array.

    //array -> uma lista

    //int x = 0;
    //int y = 10;

    void Start()
    {
        // for(inicializador; condi��o; incremento/decremento)
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

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        print(num[3]);

        num[0]++;

        print(num[0]);

        string[] nome;

        nome = new string[1];
        nome[0] = "ElMacho";

        print(nome[0]);
    }


    void Update()
    {

    }
}

