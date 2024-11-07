using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    // Exercício 06
    //6. (Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    [SerializeField] bool Guerreiro;
    [SerializeField] bool Mago;
    void Start()
    {
        if (Guerreiro == true)
        {
            print("Guerreiro Escolhido");
        }
        else if (Mago == true) 
        {
            print("Mago escolhido");
        }
        else
        {
            print("Erro! Por Favor escolha somente 1 personagem");
        }

    }

    void Update()
    {
        
    }
}
