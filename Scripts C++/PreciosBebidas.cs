using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PreciosBebidas : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public float num1 = 0f;
    public float num2 = 0f;
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


    public void Agua()
    {
        p = 1 * x;
        resultText.text = p.ToString();
    }

    public void Cafe()
    {
        p = 1f * x;
        resultText.text = p.ToString();
    }

    public void Refresco()
    {
        p = 1.2f * x;
        resultText.text = p.ToString();
    }

    public void Cervezas()
    {
        p = 1.7f * x;
        resultText.text = p.ToString();
    }

    public void Sidra()
    {
        p = 3f * x;
        resultText.text = p.ToString();
    }

    public void VinoVaso()
    {
        p = 1.7f * x;
        resultText.text = p.ToString();
    }

    public void VinoBotella()
    {
        p = 5.2f * x;
        resultText.text = p.ToString();
    }

    public void Infusion()
    {
        p = 1f * x;
        resultText.text = p.ToString();
    }

    public void Kalimotxo()
    {
        p = 2.2f * x;
        resultText.text = p.ToString();
    }

    public void Combinado()
    {
        p = 4.7f * x;
        resultText.text = p.ToString();
    }

    public void PatxaranVaso()
    {
        p = 3.2f * x;
        resultText.text = p.ToString();
    }

    public void Vermouth()
    {
        p = 2.7f * x;
        resultText.text = p.ToString();
    }

    public void BitterKas()
    {
        p = 2.2f * x;
        resultText.text = p.ToString();
    }

    public void Mosto()
    {
        p = 1.2f * x;
        resultText.text = p.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
