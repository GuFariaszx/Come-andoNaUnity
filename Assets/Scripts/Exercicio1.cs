using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    //Exercício 01 
    //(Verificação de pontos de vida) Um personagem perde pontos
    //de vida após uma batalha.Verifique se ele ainda está vivo.Caso
    //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    //contrário, "Game Over".

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
