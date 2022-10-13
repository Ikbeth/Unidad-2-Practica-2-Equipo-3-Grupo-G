using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Spawners : MonoBehaviour
{
    [SerializeField]
    int rnd_ubi_manzana;
    [SerializeField]
    Transform[] spawners;
    int tot_spawners = 4;
    [SerializeField]
    GameObject obj_Manzana;
    // Start is called before the first frame update
    private void Awake()
    {
        
        spawners=new Transform[tot_spawners];
        GameObject objTemp; 
        for (int i = 0; i < tot_spawners; i++)
        {
            
            objTemp = GameObject.Find("Spawner (" + (i + 1).ToString() + ")");
            spawners[i] = objTemp.transform;   
        }
    }

    void createManzana()
    {
         rnd_ubi_manzana = Random.Range(0, tot_spawners);
                Transform aux = spawners[rnd_ubi_manzana];
                GameObject objTemp=Instantiate(obj_Manzana,
                    aux.position, aux.rotation);
                objTemp .name = "manzana";
    }
    void Start()
    {
        createManzana();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("manzana") == null)
        {
            createManzana();
        }
    }
}
