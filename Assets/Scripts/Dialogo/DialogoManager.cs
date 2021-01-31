using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoManager : MonoBehaviour
{
    [SerializeField] private AudioSource Digitando, CliqueEmBotao;
    [SerializeField] private TMP_InputField DisplayInputField;
    [SerializeField] private TextMeshProUGUI TextDisplay;
    [SerializeField] private string[] Dialogos;
    [SerializeField] private float VelocidadeDoDialogo;
    private int Index;

    [SerializeField] private Animator NPC;
    [SerializeField] private GameObject[] YesNoButton;
    [SerializeField] private GameObject[] BusinnesButtons;
    [SerializeField] private GameObject HUD_Nome;

    [SerializeField] private GameObject Objetivos;
    [SerializeField] private BusinessManager BM;
    public void HabilitarDialogo()
    {
        if(Index == 0) StartCoroutine(Digitar());
    }

    private void Update()
    {
        AcrescentarTipoDeCidade();
        HabilitarButoes();
    }
    IEnumerator Digitar()
    {
        foreach(char Letra in Dialogos[Index].ToCharArray())
        {
            TextDisplay.text += Letra;
            Digitando.Play();
            yield return new WaitForSeconds(VelocidadeDoDialogo);
        }
    }

    void AcrescentarTipoDeCidade()
    {
        if (Game.CidadeERural) Dialogos[1] = "Our land is RURAL and we need to grow in some way, which business would you like to run? (There is a 100 coins fee for opening)";
        else Dialogos[1] = "Our land is URBAN and we need to feed a lot of people, which business would you like to run? (There is a 100 coins fee for opening)";
    }

    void HabilitarButoes()
    {
        if(TextDisplay.text == Dialogos[0]) foreach (GameObject Button in YesNoButton) Button.SetActive(true);
        if (TextDisplay.text == Dialogos[1]) foreach (GameObject Button in BusinnesButtons) Button.SetActive(true);
    }

    public void BotaoNo()
    {
        CliqueEmBotao.Play();
        foreach (GameObject Button in YesNoButton) Button.SetActive(false);
        Index = 1;
        TextDisplay.text = "";
        StartCoroutine(Digitar());
    }

    public void BotaoSim()
    {
        CliqueEmBotao.Play();
        foreach (GameObject Button in YesNoButton) Button.SetActive(false);
        NPC.SetTrigger("Sair");
        HUD_Nome.SetActive(true);
        Index = 1;
        TextDisplay.text = "";
    }

    public void TerminouDeDarNome()
    {
        if(DisplayInputField.text != null) Game.NomeDaCidade = DisplayInputField.text;
        CliqueEmBotao.Play();
        NPC.SetTrigger("Entrar");
        HUD_Nome.SetActive(false);
        StartCoroutine(Digitar());
        Debug.Log(Game.NomeDaCidade);
    }

    public void EscolhaDeNegocios(string Negocio)
    {
        NPC.SetTrigger("Sair");
        CliqueEmBotao.Play();
        foreach (GameObject Button in BusinnesButtons) Button.SetActive(false);
        BM.SpawnBusiness(Negocio);
        Game.GameIsPaused = false;
        Objetivos.SetActive(true);
        Game.DinheiroDoJogador -= 100;
    }
}
