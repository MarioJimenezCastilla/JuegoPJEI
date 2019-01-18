using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    public int speed = 10;
    public Vector3 posicionObjetivo;

    private bool movimientoDerecha = true;
    private bool bajando = false;
    private bool movimientoIzquierda = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != posicionObjetivo){
            transform.position = Vector2.MoveTowards(transform.position, posicionObjetivo, speed * Time.deltaTime);
        } else {
            
            if (movimientoDerecha){
                posicionObjetivo.y -= 2; 
                bajando = true;
            }


        }
        
    }
}
