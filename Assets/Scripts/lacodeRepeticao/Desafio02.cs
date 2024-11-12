using System;
using Unity.VisualScripting;
using UnityEngine;

public class Desafio02 : MonoBehaviour
{
    //Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu, imprima na tela quantos anos,
    //meses e dias essa pessoa já viveu.Leve em consideração o ano com 365 dias e o mês com 30 dias.

    [SerializeField] int dia;
    [SerializeField] int mes;
    [SerializeField] int ano;

    void Start()
    {
        DateTime dataAtual = DateTime.Now;
        int diaAtual = dataAtual.Day;
        int mesAtual = dataAtual.Month;
        int anoAtual = dataAtual.Year;

        int anosVividos = (anoAtual - ano);
        int mesesVividos = (mesAtual - mes);
        int diasVividos = (dia - diaAtual);


        print("Você viveu um total de : " + anosVividos+  " Anos" + "\n: " + mesesVividos +" meses" +"\n: " + diasVividos + " dias");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
