using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio10 : MonoBehaviour
{
    //10. (Itens do invent�rio) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, po��es, ou power-ups)
    //que t�m efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.

    [SerializeField] int itens = 1 ;
   
    void Start()
    {
        switch(itens)
        {
            case 0:
                print("Super-Pulo : player poder� pular duas vezes sua altura!");
                break;
            case 1:
                print("Moeda de Prata : O player poder� usar essas moedas para comprar perk!");
                break;
            case 3:
                print("Moeda de Ouro : O player poder� trocar essas moedas para aprimorar suas habilidades;");
                break;
            case 4:
                print("Po��o de Cura : O player poder� regenerar sua vida em 20%!");
                break;
            case 5:
                print("Escudo : O player ter� um acr�scimo de 100hp fora sua Life!");
                break;
        }

    }

    void Update()
    {
        
    }
}
