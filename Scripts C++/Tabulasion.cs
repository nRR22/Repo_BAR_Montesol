using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tabulasion : MonoBehaviour
{
    public GameObject Esc_Bebidas;
    public GameObject Esc_Pintxos;
    public GameObject Esc_Postres;
    public GameObject Esc_Calculadora;
    public GameObject Esc_Quick;

    public void Boton_Bebidas()
    {
        Esc_Bebidas.SetActive(true);
        Esc_Pintxos.SetActive(false);
        Esc_Postres.SetActive(false);
    }

    public void Boton_Pintxos()
    {
        Esc_Bebidas.SetActive(false);
        Esc_Pintxos.SetActive(true);
        Esc_Postres.SetActive(false);
    }

    public void Boton_Postres()
    {
        Esc_Bebidas.SetActive(false);
        Esc_Pintxos.SetActive(false);
        Esc_Postres.SetActive(true);
    }

    public void TAB_Cacluladora()
    {
        Esc_Calculadora.SetActive(true);
        Esc_Quick.SetActive(false);;
    }

    public void TAB_Quick()
    {
        Esc_Calculadora.SetActive(false);
        Esc_Quick.SetActive(true); ;
    }


    public void MoverCalculadora()
    {
        SceneManager.LoadScene("Calculadora");
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
