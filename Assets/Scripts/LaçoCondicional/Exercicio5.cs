using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio5 : MonoBehaviour
{
    //Exercicio 05
    //5. (Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int Pontuação = 50;
    [SerializeField] string Completar;
    void Start()
    {
        Completar = Pontuação >= 50 ? "Missão bem-sucedida" : "Missão incompleta";
        print(Completar);

    }

    void Update()
    {
        
    }
}
