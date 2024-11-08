using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio7 : MonoBehaviour
{
    // Exercicio 07
    //7. (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    //calcular probabilidades e simular a rolagem de dados.Crie um
    //script em que o usu�rio defina o n�mero de faces de um dado
    //(int) e calcule a rolagem de um dado com esse n�mero de faces.
    //Use a fun��o abaixo para o c�lculo: Random.Range (valor_min,
    //valor_max); (Coloque o c�digo dentro da fun��o-evento Start).

    [SerializeField] int valor_min = 1;
    [SerializeField] int valor_max = 20;
    int resultado;

    void Start()
    {
        resultado =Random.Range(valor_min, valor_max);
        print(resultado);
        
    }

    void Update()
    {
        
    }
}
