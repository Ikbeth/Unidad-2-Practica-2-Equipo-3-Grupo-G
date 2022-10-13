using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Contador : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI txtTiempo;
    [SerializeField]
    TextMeshProUGUI txtVida;

    public static Contador contador;
    public int tiempo = 0;
    public int vida = 100;
    public int comer = 5;

    private void Awake()
    {
        if (contador == null)
        {
            contador = this;
        }
        else
        {
            Destroy(this);
        }

        GameObject objTiempo = GameObject.Find("txt_Tiempo");
        GameObject objVida = GameObject.Find("txt_Vida");

        txtTiempo = objTiempo.GetComponent<TextMeshProUGUI>();
        txtVida = objVida.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StopAllCoroutines();
        StartCoroutine("Reloj");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Reloj()
    {
        while (contador.tiempo >= 0)
        {
            txtTiempo.text = contador.tiempo.ToString();
            txtVida.text = contador.vida.ToString();

            contador.tiempo++;
            contador.vida--;

            yield return new WaitForSeconds(1f);
        }
    }
}
