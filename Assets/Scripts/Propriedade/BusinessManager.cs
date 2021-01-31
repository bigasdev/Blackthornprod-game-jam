using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessManager : MonoBehaviour
{
    [SerializeField] private GameObject Fazenda, Apartamento, Restaurante;
    [SerializeField] private GameObject[] FazendaObjetos, ApartamentoObjetos, RestauranteObjetos;
    [SerializeField] private Transform Spawn_Point;

    public void SpawnBusiness(string Business)
    {
        Instantiate(Resources.Load(Business), Spawn_Point.position, Quaternion.identity);
        if (Business == "Apartamento") Game.JogoApartamento = true;
        else if (Business == "Fazenda") Game.JogoFazenda = true;
        else if (Business == "Restaurante") Game.JogoRestaurante = true;
    }
}
