using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    // Exercicio 3
    //(Desafio) Considere que o jogo tem um power-up que revive o
    //personagem caso ele morra.Caso o jogador morra e tiver
    //coletado o power-up ele volta a vida com 50% de sua vida total e
    //deve ser exibido a mensagem "Ainda não, vida atual XX". Caso ele
    //não tenha coletado o power-up exiba "Game Over".

    /*
     Operadores Lógicos
     
     && (e/ and)
     !! (ou/ or)
     ! (não/ not)
     */

    [SerializeField] bool vivoPlayer; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    void Start()
    {
        if(vivoPlayer == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual " + vidaPlayer);
        }
        else
        {
            print("Game Over! ):");
        }
    }


    void Update()
    {
        
    }
}
