using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // exercicio 02
    //(Detecção de power-up) Ao coletar um power-up, o
    //personagem aumenta sua velocidade.Se o jogador encontrar um
    //power-up, exiba "Power-up Coletado". Caso contrário, exiba
    //"Nenhum power-up encontrado".
    [SerializeField] bool PowerUp;
    void Start()
    {
        if(PowerUp == true)
        {
            print("Power-Up Coletado!");
        }
        else
        {
            print("Nenhum Power-up Coletado!");
        }
    }

    void Update()
    {
        
    }
}
