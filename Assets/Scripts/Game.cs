using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static bool CidadeERural;
    public static bool GameIsPaused;

    public static string NomeDaCidade = "Land";
    public static bool JogoApartamento, JogoFazenda, JogoRestaurante;

    public static int DinheiroDoJogador = 100;

    public static float PrimeiroObjetivo, SegundoObjetivo, TerceiroObjetivo, QuartoObjetivo;
    public static float PrimeiroObjetivoPlayer, SegundoObjetivoPlayer, TerceiroObjetivoPlayer, QuartoObjetivoPlayer;

    public static bool ArrastandoObjeto;
    private void Awake()
    {
        AplicarDados();
        var Chance = Random.Range(0, 2);
        if (Chance == 0) CidadeERural = false;
        else CidadeERural = true;
        Debug.Log("Esse jogo a cidade vai ser rural:" + CidadeERural);
        GameIsPaused = true;
    }

    void AplicarDados()
    {
        NomeDaCidade = "Land";
        DinheiroDoJogador = 100;
    }
}
