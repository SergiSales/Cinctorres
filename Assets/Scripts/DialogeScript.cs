using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeScript : MonoBehaviour
{

    //Privados

    private int num; //Obtienes aleatoriamente el sonido

    private int index;

    private bool silence = false; //Determina si hay sonido o no

    //Publicos. Se puede acceder desde unity

    public TextMeshProUGUI dialogueText; //Texto de unity

    public string[] lines;// Bloques de dialogos

    public float textSPD = 0.1f;

    public AudioSource sound1, sound2; // Variable de audio
    

    //Llamada automatica de inicio
    void Start()
    {
        dialogueText.text = string.Empty;
        startDialoge();
    }

    //Llamada iterativa cada ciclo del programa 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Click derecho
        {
            if (dialogueText.text == lines[index]) //Si se ha escrito todo siguiente linea
            {
                NextLine();
            }
            else //Si falta algo por escribir del bloque de texto termina de ponerlo todo
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
    }

    public void startDialoge()
    {
        index = 0;

        //Inicio de la corutina de los dialogos
        StartCoroutine(WriteLine());
    }

    //Corrutina

    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray()) //Recorre todos los bloques de dialogos letra a letra
        {
            dialogueText.text += letter;//Escribe letras una a una 

            //Si no esta en silencio se mete en los condicionales
            if (!silence)
            {
                //Numero aleatorio del 0 - 1
                num = Random.Range(0, 2);
               
                if (num == 0) sound1.Play();

                else sound2.Play();
            }
            //Cambia al valor booleano inverso
            silence = !silence;
            

            yield return new WaitForSeconds(textSPD); // velocidad con la que aparece el texto
        }
    }

    public void NextLine()
    {
        if (index < lines.Length - 1) //Si no es la ultima linea
        {
            dialogueText.text =string.Empty;
            index++;
            StartCoroutine(WriteLine());

        }
        else// Si es la ultima destruye la ventana de dialogos
        {
            gameObject.SetActive(false);
        }
    }

}
