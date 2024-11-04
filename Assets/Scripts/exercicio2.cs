using UnityEngine;

// exercicio 02

public class Exercicio2 : MonoBehaviour
{
    // Ao coletar power-up : Power-Up Coletado!; CAso não seja: Nenhum Power-up Coletado!
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
