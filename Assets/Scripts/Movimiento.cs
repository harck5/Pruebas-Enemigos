using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform puntoA;//empty
    public Transform puntoB;
    public float velocidad = 5f;

    private bool yendoHaciaB = true;

    void Update()
    {
        if (yendoHaciaB)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoB.position, velocidad * Time.deltaTime);

            if (transform.position == puntoB.position)//Vector3.MoveTowards Moves a point current in a straight line towards a target point.
            {
                yendoHaciaB = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoA.position, velocidad * Time.deltaTime);

            if (transform.position == puntoA.position)
            {
                yendoHaciaB = true;
            }
        }
    }
}
