using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio5 : MonoBehaviour
{
    //Exercicio 05
    //5. (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //incompleta".

    [SerializeField] int Pontua��o = 50;
    [SerializeField] string Completar;
    void Start()
    {
        Completar = Pontua��o >= 50 ? "Miss�o bem-sucedida" : "Miss�o incompleta";
        print(Completar);

    }

    void Update()
    {
        
    }
}
