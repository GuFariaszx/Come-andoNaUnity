using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    //Exerc�cio 01 
    // Caso A vida do her�i for maior que o dano recebido = Vivo; Caso seja menor que o dano recebido = Game over;
    [SerializeField] int vidaHeroi = 10;
    [SerializeField] int danoOponente = 5;
    string resultado;
    
    
    void Start()
    {
        resultado = vidaHeroi > danoOponente ? "Personagem vivo" : "Game over";
        print(resultado);
    }

    void Update()
    {
        
    }
}
