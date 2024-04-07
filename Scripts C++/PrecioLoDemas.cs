using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrecioLoDemas : MonoBehaviour
{

    public TextMeshProUGUI resultText;
    public string operation;
    public int x = 1;
    public float p;

    public void Boton_x1()
    {
        x = 1;
    }

    public void Boton_x5()
    {
        x = 5;
    }

    public void Boton_x10()
    {
        x = 10;
    }

    public void Helados()
    {
        p = 100 * x;
        resultText.text = p.ToString();
    }

    public void Batidos()
    {
        p = 1.5f * x;
        resultText.text = p.ToString();
    }

    public void Bizcocho()
    {
        p = 100 * x;
        resultText.text = p.ToString();
    }

    public void Sandwitch()
    {
        p = 1.7f * x;
        resultText.text = p.ToString();
    }

    public void Tortilla()
    {
        p = 100 * x;
        resultText.text = p.ToString();
    }

    public void FrutosSecos()
    {
        p = 1.2f * x;
        resultText.text = p.ToString();
    }

    public void AceitunasPepinillos()
    {
        p = 1.2f * x;
        resultText.text = p.ToString();
    }

    public void Fuet()
    {
        p = 1.2f * x;
        resultText.text = p.ToString();
    }

    public void Patatas()
    {
        p = 1.2f * x;
        resultText.text = p.ToString();
    }

    
}
