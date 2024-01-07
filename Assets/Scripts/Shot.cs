using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject proyectile;
    public Transform proyectileInstantiate;
    public float timer;
    private float timerMax = 0.5f;
    public float x = -0.48f;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            timer -= timerMax; // Se reinicia el temporizador
            Instantiate(proyectile, transform.position + new Vector3(0,x,0), Quaternion.identity);
        }
    }
}
