using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCambio : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CursorCambio.Cursores estadoCursor;
    private void OnMouseEnter(){
        CursorCambio.instance.CambiarCursor(estadoCursor);
    }

    private void OnMouseExit() {
        CursorCambio.instance.CambiarCursor(CursorCambio.Cursores.basico);
    }
}
