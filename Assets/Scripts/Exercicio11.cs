using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC(personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    string PlayerSay = "Player : Olá, Prazer em conhecer!";
    string PlayerSay2 = "Player : Mas, eai como vai a vida?";
    string PlayerSay3 = "Player : Comigo tudo bem!!";
    [SerializeField] int Npc =0;
    [SerializeField] int Npc2 =0;
    
    void Start()
    {
        print(PlayerSay);
        switch (Npc)
        {
            case 0:
                print("Npc : Oiii, Prazer em conhecer você também!");
                break;
            case 1:
                print("Npc : Eae , o prazer é todo meu!");
                break;
        }
        print(PlayerSay2);
        switch (Npc2)
        {
            case 0:
                print("Npc : Vai bem, Graças a Deus!");
                break;
            case 1:
                print("Npc : Vai indo e você?");
                break;
        }
        if (Npc2 == 1)
        {
            print(PlayerSay3);
        }
    }

    void Update()
    {
        
    }
}
