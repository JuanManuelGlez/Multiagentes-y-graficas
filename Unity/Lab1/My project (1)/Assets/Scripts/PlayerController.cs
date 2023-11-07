using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Velocidad del vehiculo
    public float speed = 5.0f;
    //Variable para controlar el movimiento del vehiculo
    public float turnSpeed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mover vehiculo para adelante
        //transform.Translate(0,0,1)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Modificar el giro
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed); 
    }
}