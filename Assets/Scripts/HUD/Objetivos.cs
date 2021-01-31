using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objetivos : MonoBehaviour
{
    [SerializeField] private string[] PrimeiroObjetivo, SegundoObjetivo, TerceiroObjetivo, QuartoObjetivo;
    [SerializeField] private TextMeshProUGUI FirstTask, SecondTask, ThirdTask, ForthTask;
    [SerializeField] private TextMeshProUGUI FirstTaskNumbers, SecondTaskNumbers, ThirdTaskNumbers, ForthTaskNumbers;

    private void Update()
    {
        if (Game.CidadeERural) ObjetivosCasoRural();
        else ObjetivosCasoUrbano();
    }

    void ObjetivosCasoRural()
    {
        if(Game.JogoApartamento)
        {
            FirstTask.text = PrimeiroObjetivo[0];
            SecondTask.text = SegundoObjetivo[0];
            ThirdTask.text = TerceiroObjetivo[0];
            ForthTask.text = QuartoObjetivo[0];

            FirstTaskNumbers.text = $"{Game.PrimeiroObjetivoPlayer}" + "/" + $"{5}";
            SecondTaskNumbers.text = $"{Game.SegundoObjetivoPlayer}" + "/" + $"{2}";
            ThirdTaskNumbers.text = $"{Game.TerceiroObjetivoPlayer}" + "/" + $"{3}";
            ForthTaskNumbers.text = $"{Game.QuartoObjetivoPlayer}" + "/" + $"{5}";
        }
        if (Game.JogoFazenda)
        {
            FirstTask.text = PrimeiroObjetivo[1];
            SecondTask.text = SegundoObjetivo[1];
            ThirdTask.text = TerceiroObjetivo[1];
            ForthTask.text = QuartoObjetivo[1];

            FirstTaskNumbers.text = $"{Game.PrimeiroObjetivoPlayer}" + "/" + $"{4}";
            SecondTaskNumbers.text = $"{Game.SegundoObjetivoPlayer}" + "/" + $"{2}";
            ThirdTaskNumbers.text = $"{Game.TerceiroObjetivoPlayer}" + "/" + $"{2}";
            ForthTaskNumbers.text = $"{Game.QuartoObjetivoPlayer}" + "/" + $"{1}";
        }
        if (Game.JogoRestaurante)
        {
            FirstTask.text = PrimeiroObjetivo[2];
            SecondTask.text = SegundoObjetivo[2];
            ThirdTask.text = TerceiroObjetivo[2];
            ForthTask.text = QuartoObjetivo[2];

            FirstTaskNumbers.text = $"{Game.PrimeiroObjetivoPlayer}" + "/" + $"{5}";
            SecondTaskNumbers.text = $"{Game.SegundoObjetivoPlayer}" + "/" + $"{2}";
            ThirdTaskNumbers.text = $"{Game.TerceiroObjetivoPlayer}" + "/" + $"{3}";
            ForthTaskNumbers.text = $"{Game.QuartoObjetivoPlayer}" + "/" + $"{3}";
        }
    }

    void ObjetivosCasoUrbano()
    {
        if (Game.JogoApartamento)
        {
            FirstTask.text = PrimeiroObjetivo[0];
            SecondTask.text = SegundoObjetivo[0];
            ThirdTask.text = TerceiroObjetivo[0];
            ForthTask.text = QuartoObjetivo[0];

            FirstTaskNumbers.text = $"{Game.PrimeiroObjetivoPlayer}" + "/" + $"{4}";
            SecondTaskNumbers.text = $"{Game.SegundoObjetivoPlayer}" + "/" + $"{2}";
            ThirdTaskNumbers.text = $"{Game.TerceiroObjetivoPlayer}" + "/" + $"{2}";
            ForthTaskNumbers.text = $"{Game.QuartoObjetivoPlayer}" + "/" + $"{1}";
        }
        if (Game.JogoFazenda)
        {
            FirstTask.text = PrimeiroObjetivo[1];
            SecondTask.text = SegundoObjetivo[1];
            ThirdTask.text = TerceiroObjetivo[1];
            ForthTask.text = QuartoObjetivo[1];

            FirstTaskNumbers.text = $"{Game.PrimeiroObjetivoPlayer}" + "/" + $"{5}";
            SecondTaskNumbers.text = $"{Game.SegundoObjetivoPlayer}" + "/" + $"{2}";
            ThirdTaskNumbers.text = $"{Game.TerceiroObjetivoPlayer}" + "/" + $"{3}";
            ForthTaskNumbers.text = $"{Game.QuartoObjetivoPlayer}" + "/" + $"{5}";
        }
        if (Game.JogoRestaurante)
        {
            FirstTask.text = PrimeiroObjetivo[2];
            SecondTask.text = SegundoObjetivo[2];
            ThirdTask.text = TerceiroObjetivo[2];
            ForthTask.text = QuartoObjetivo[2];

            FirstTaskNumbers.text = $"{Game.PrimeiroObjetivoPlayer}" + "/" + $"{3}";
            SecondTaskNumbers.text = $"{Game.SegundoObjetivoPlayer}" + "/" + $"{2}";
            ThirdTaskNumbers.text = $"{Game.TerceiroObjetivoPlayer}" + "/" + $"{2}";
            ForthTaskNumbers.text = $"{Game.QuartoObjetivoPlayer}" + "/" + $"{1}";
        }
    }
}
