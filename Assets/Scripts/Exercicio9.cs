using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    // (Placar final) Crie um script que l� o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos tr�s
    //resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
    //ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi �um empate emocionante�.

    int resultadoValorMax = 5;
    int resultadoValorMin = 0;
    int resultadoA;
    int resultadoB;
    
    void Start()
    {
        resultadoA = UnityEngine.Random.Range(resultadoValorMax, resultadoValorMin);
        resultadoB = UnityEngine.Random.Range(resultadoValorMax, resultadoValorMin);
        print("Palmeiras "+resultadoA+ " - " + resultadoB + " Barcelona");
        if (resultadoA == resultadoB && resultadoA >= 3 && resultadoB >=3)
        {
            print("Um empate emocionante entre Palmeiras e Barcelona!!!");
        } 
        else if (resultadoA > resultadoB)
        {
            print("Vit�ria do Palmeiras");
        }
        else if(resultadoA < resultadoB) 
        {
            print("Vit�ria do Barcelona");
        }

    }

    void Update()
    {
        
    }
}
