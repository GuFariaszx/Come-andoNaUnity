using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    // Exercicio 3
    // O jogo possui um power-up : revive; Caso ele pegue, revive com 50% da vida; caso n�o Game over;

    /*
     Operadores L�gicos
     
     && (e/ and)
     !! (ou/ or)
     ! (n�o/ not)
     */

    [SerializeField] bool vivoPlayer; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    void Start()
    {
        if(vivoPlayer == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda n�o, vida atual " + vidaPlayer);
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
