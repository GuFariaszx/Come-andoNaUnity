using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    //Escreva um programa que conta o número de consoantes em uma string.

    [SerializeField] string nome = "";
    [SerializeField] int contadorCon;


    char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
    void Start()
    {
        for (int i = nome.Length -1; i >= 0; i--)
        {
            char c = nome[i];
            vogais.Contains(c);
            if (!vogais.Contains(c))
            {
                contadorCon++;
            }
        }
        print(contadorCon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
