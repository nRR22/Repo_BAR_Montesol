using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PreciosPintxos : MonoBehaviour
{

    public TextMeshProUGUI resultText;
    public float num1 = 0f;
    public float num2 = 0f;
    public string operation;
    public int x = 1;
    public float p;

    public void Aclaracion()
    {
        if (resultText.text == "")
        {

        }
        else
        {
            Calculadora.Igual();
        }
    }

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

    public void PintxoCasa()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }

    public void Brocheta()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }

    public void Txistorra()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }

    public void Salchichas()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }

    public void Hamburguesas()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }

    public void Tosta()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }

    public void Bocatas()
    {
        p = 2.8f * x;
        resultText.text = p.ToString();
    }
}