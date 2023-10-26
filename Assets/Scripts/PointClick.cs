using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointClick : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;

    private float posY = -4.65f;

    private float posX = 0.0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButton(0)){
            posX = mousePos.x;
           
        }
        MoverPersonaje(posX);
    }

    void MoverPersonaje(float posicionX){

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(posicionX,posY), Time.deltaTime * speed);
    }
}
