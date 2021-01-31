using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Dinheiro;

    private void Update()
    {
        Dinheiro.text = $"{Game.DinheiroDoJogador}";
    }
}
