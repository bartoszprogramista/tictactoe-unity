using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update

    public string tura;
    public string[] plansza = new string[9] {"", "", "", "", "", "", "", "", ""};
    public bool wygrana;

    public void Start()
    {
        tura = "x";
        wygrana = false;
        GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Tura: x";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pisz(string text)
    {
        Debug.Log(text);
    }

    public void Zmien(Text text)
    {
        text.text = "Nowy";
    }

    public void Czysc()
    {
        foreach(Text tmp in GetComponentsInChildren<Text>())
        {
            tmp.text = "";
        }
    }



    public void sprawdzPlansze()
    {
        if (plansza[0]==plansza[1] && plansza[1] == plansza[2] && plansza[2]!="")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if(plansza[3] == plansza[4] && plansza[4] == plansza[5] && plansza[5] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if (plansza[6] == plansza[7] && plansza[7] == plansza[8] && plansza[8] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if (plansza[0] == plansza[3] && plansza[3] == plansza[6] && plansza[6] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if (plansza[1] == plansza[4] && plansza[4] == plansza[7] && plansza[7] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if (plansza[2] == plansza[5] && plansza[5] == plansza[8] && plansza[8] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if (plansza[0] == plansza[4] && plansza[4] == plansza[8] && plansza[8] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if (plansza[2] == plansza[4] && plansza[4] == plansza[6] && plansza[6] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Wygrał " + tura;
            wygrana = true;
        }
        else if(plansza[0]!="" && plansza[1]!="" && plansza[2] != "" && plansza[3] != "" && plansza[4] != "" && plansza[5] != "" && plansza[6] != "" && plansza[7] != "" && plansza[8] != "")
        {
            GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Remis";
            wygrana = true;
        }

        
    }

    public void botEnable(Button button)
    {
        button.GetComponentInChildren<Text>().text = "Graj 1vs1";
    }

    public void changeButton(Button button)
    {

        string nrprzycisku = button.name;
        int intNrPrzycisku = Int32.Parse(nrprzycisku);
        Debug.Log(button.name);
        Debug.Log(plansza[intNrPrzycisku]);
        if (wygrana)
        {
            Czysc();
            for (int i = 0; i < 9; i++)
            {
                plansza[i] = "";
               
            }
            wygrana = false;
            GameObject.Find("Text").GetComponentInChildren<Text>().text = "KÓŁKO I KRZYŻYK";
            if(tura == "x")
            {
                tura = "o";
                GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Tura: o";

            }
            else if(tura == "o")
            {
                tura = "x";
                GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Tura: x";
            }
        }
        else if (tura == "o" && plansza[intNrPrzycisku]=="" && wygrana ==false)
        {
            plansza[intNrPrzycisku] = "o";
            button.GetComponentInChildren<Text>().text = "o";
            sprawdzPlansze();
            if(wygrana == false)
            {
                GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Tura: x";
                tura = "x";
            }
       
        }
        else if(tura == "x" && plansza[intNrPrzycisku]=="" && wygrana ==false)
        {
            plansza[intNrPrzycisku] = "x";
            button.GetComponentInChildren<Text>().text = "x";
            sprawdzPlansze();
            if (wygrana == false)
            {
                GameObject.Find("TuraText").GetComponentInChildren<Text>().text = "Tura: o";
                tura = "o";
            }
        }


    }
}
