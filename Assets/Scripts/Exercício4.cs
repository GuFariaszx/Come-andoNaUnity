using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercício4 : MonoBehaviour
{
    //Exercicio 4
    //(Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    [SerializeField] string itens;
    [SerializeField] bool poção;

    void Start()
    {
        itens = poção ? "Usando Poção de Vida" : "Poção Indisponível";
        print(itens);
    }

    void Update()
    {
        
    }
}
