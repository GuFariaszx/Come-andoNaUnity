using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercício07 : MonoBehaviour
{
    //7. (Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.

    int[] num = { 4, 56, 7, 90, 123, 43, 79, 38, -125, 67, 78 , -23, -35};
    int maior;
    void Start()
    {

        maior = num[0];
        foreach (var item  in num)
        {
            if (item > maior)
            {
                maior = item;
            }
        }
        print("O maior número dessa lista é o: " +  maior);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
