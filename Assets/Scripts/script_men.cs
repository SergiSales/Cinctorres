using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prueba : MonoBehaviour
{
    public GameObject menu;
    public GameObject opciones;
    private bool activo = true;    // Start is called before the first frame update
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void btnPressed(GameObject x)
    {
        //Instantiate(square);
        activo= !activo;
        x.SetActive(activo);



    }
}
