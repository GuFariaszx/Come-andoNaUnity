using UnityEngine;

public class Geral : MonoBehaviour
{
    /*
       Operadores Falacionais
       == (igual);
       != (diferente);
       > (maior que);
       < (menor que);
       >= (Maior ou igual que);
       <= (menor ou igual que);

    */

    /*
        Operadores L�gicos
        
    */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    //[SerializeField]private int vidaJogador = 10;

    //public int vidaPlayer;

    //float velocidadeCarro = 125.5f;

    //double velocidade = 120.2;

    //string nomePlayer = "ElMacho";

    //char apelido = 'E';

    //bool vivo = true;

    string resultado;


    void Start()
    {
        //int variavelLocal = 10;
        //print(variavelLocal);
        //print(variavelGlobal);
        //print(vidaPlayer);
        //string tutorial = "ElMacho";
        //print(tutorial);   
        //print(vidaHeroi == vidaVilao);//false

        //Operador tern�rio
        //condi��o ? valor a ser atribuido caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVilao ? "vidaHeroi Menor" : "VidaHeroi Maior" ;
        //print(resultado);

        // Estrutura condicional
        if (vidaHeroi < vidaVilao)
        {
            resultado = "Vida Heroi Menor";
            print(resultado);
        }
        else if (vidaHeroi == vidaVilao)
        {
            resultado = "Vida Heroi igual a vida Vilao";
            print(resultado);
        }
        else
        {
            resultado = "Vida Heroi Maior";
            print(resultado);
        }
    }

   
    void Update()
    {
        //print(variavelGlobal);
    }
}
