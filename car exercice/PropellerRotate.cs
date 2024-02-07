using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 

    public float rotationSpeed = 100f; // Vitesse de rotation de l'hélice

    void Update()
    {
        // Faire tourner l'hélice autour de son axe Y
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

}
