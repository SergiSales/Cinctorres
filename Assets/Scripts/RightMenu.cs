using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public void Flecha(){
        menu.SetActive(true);
    }

    public void Ermita(){
        SceneManager.LoadScene("Ermita");
    }
    public void Torreta(){
        SceneManager.LoadScene("Torreta");
    }

    public void Volver(){
        menu.SetActive(false);
    }
}
