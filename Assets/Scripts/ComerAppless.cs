using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComerAppless : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txtVida;

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject objVida = GameObject.Find("txt_Vida");

        txtVida = objVida.GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Nombre: " + name + " Tag: " + tag);

        if (tag.Equals("manzana"))
        {
            GameObject obj = GameObject.Find(name);
            Destroy(obj);

            Contador.contador.vida += Contador.contador.comer;

            if (Contador.contador.vida > 100)
            {
                Contador.contador.vida = 100;
            }

            txtVida.text = Contador.contador.vida.ToString();
        }


    }
}
