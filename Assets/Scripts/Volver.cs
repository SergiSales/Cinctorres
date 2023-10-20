using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Volver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;

    public void Flecha(){
        menu.SetActive(true);
    }

    public void Plaza(){
        SceneManager.LoadScene("Plaza");
    }

    public void Return(){
        menu.SetActive(false);
    }
}
