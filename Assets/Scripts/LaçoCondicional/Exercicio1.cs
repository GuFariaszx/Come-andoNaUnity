using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    //Exerc�cio 01 
    //(Verifica��o de pontos de vida) Um personagem perde pontos
    //de vida ap�s uma batalha.Verifique se ele ainda est� vivo.Caso
    //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    //contr�rio, "Game Over".

        [SerializeField] int vidaHeroi = 10;
    [SerializeField] int hitRecebido = 5;
    string resultado;
    
    
    void Start()
    {
        resultado = vidaHeroi > hitRecebido ? "Personagem vivo" : "Game over";
        print(resultado);
    }

    void Update()
    {
        
    }
}
