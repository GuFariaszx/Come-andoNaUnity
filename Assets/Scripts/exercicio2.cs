using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // exercicio 02
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
