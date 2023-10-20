using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCambio : MonoBehaviour
{
    // Start is called before the first frame update
    public static CursorCambio instance;
    
    public enum Cursores{
        basico,
        flecha
    }

    public Cursores  estadoCursor = Cursores.basico;
    public Texture2D[] cursores;

    void Awake()
    {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }

        Cursor.visible = true;
        Cursor.SetCursor(cursores[(int) estadoCursor], Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    public void CambiarCursor(Cursores c){
        Cursor.SetCursor(cursores[(int) c], Vector2.zero, CursorMode.Auto);
    }
}
