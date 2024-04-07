using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{

    public TextMeshProUGUI resultText;
    public TextMeshProUGUI ExtraText;
    public int j = 0;
    public float[] Operaciones = new float[100];
    public float[] Numeros = new float[100];
    float result = 0f;

    public void Negativizar()
    {
        resultText.text = (-float.Parse(resultText.text)).ToString();
    }

    public void Suma()
    {
        Numeros[j] = float.Parse(resultText.text);
        Operaciones[j] = 1;
        resultText.text = "";
        j = j + 1;
    }

    public void Resta()
    {
        Numeros[j] = float.Parse(resultText.text);
        Operaciones[j] = 2;
        resultText.text = "";
        j = j + 1;
    }

    public void Multiplicacion()
    {
        Numeros[j] = float.Parse(resultText.text);
        Operaciones[j] = 3;
        resultText.text = "";
        j = j + 1;
    }

    public void Division()
    {
        Numeros[j] = float.Parse(resultText.text);
        Operaciones[j] = 4;
        resultText.text = "";
        j = j + 1;
    }

    public void Button_1()
    {
        if (resultText.text == "0".ToString())   
        {
            resultText.text="1".ToString();
        }
        else
        {
            resultText.text = resultText.text + "1";
        }
    }

    public void Button_2()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "2".ToString();
        }
        else
        {
            resultText.text = resultText.text + "2";
        }
    }

    public void Button_3()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "3".ToString();
        }
        else
        {
            resultText.text = resultText.text + "3";
        }
    }

    public void Button_4()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "4".ToString();
        }
        else
        {
            resultText.text = resultText.text + "4";
        }
    }

    public void Button_5()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "5".ToString();
        }
        else
        {
            resultText.text = resultText.text + "5";
        }
    }

    public void Button_6()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "6".ToString();
        }
        else
        {
            resultText.text = resultText.text + "6";
        }
    }

    public void Button_7()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "7".ToString();
        }
        else
        {
            resultText.text = resultText.text + "7";
        }
    }

    public void Button_8()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "8".ToString();
        }
        else
        {
            resultText.text = resultText.text + "8";
        }
    }

    public void Button_9()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "9".ToString();
        }
        else
        {
            resultText.text = resultText.text + "9";
        }
    }

    public void Button_0()
    {
        if (resultText.text == "0".ToString())
        {
            resultText.text = "0".ToString();
        }
        else
        {
            resultText.text = resultText.text + "0";
        }
    }

    public void Igual()
    {
        if (j > 0)
        {
            Numeros[j] = float.Parse(resultText.text);
            result = Numeros[0];
            for (int i = 1; i < j + 1; i++)
            {
                if (Operaciones[i - 1] == 1)
                {
                    result = result + Numeros[i];
                }
                if (Operaciones[i - 1] == 2)
                {
                    result = result - Numeros[i];
                }
                if (Operaciones[i - 1] == 3)
                {
                    result = result * Numeros[i];
                }
                if (Operaciones[i - 1] == 4)
                {
                    if (Numeros[i] == 0)
                    {
                    }
                    else
                    {
                        result = result / Numeros[i];
                    }
                }
                Operaciones[i - 1] = 0;
                Numeros[i] = 0;
            }
            Numeros[0] = result;
            resultText.text = result.ToString();
            ExtraText.text = result.ToString();
            j = 0;
        }
    }

public void  CE()
    {
        resultText.text = "0";
    }
public void BS()
{
    j = 0;
    resultText.text = "0";
    ExtraText.text = "0";
        for (int i = 0; i < Numeros.Length; i++)
        {
            Numeros[i] = 0;
        }

        for (int i = 0; i < Operaciones.Length; i++)
        {
            Operaciones[i] = 0;
        }
    }

    public void BotonC()
    {
        if (resultText.text.Length > 0)
        {
            resultText.text = resultText.text.Remove(resultText.text.Length - 1, 1);
        }
        if (resultText.text == "")
        {
            resultText.text = "0";
        }
    }

     public void Coma()
    {
        if (!resultText.text.Contains(","))
        {
            resultText.text = resultText.text + ",";
        }
    }

    public void OK()
    {

    }

    public void PINTXOS()
    {
    resultText.text = "1.2".ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
