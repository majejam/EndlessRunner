using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Vector3 Direction;
    public float Speed = 50;

    public Vector3 Axe = new Vector3(0, 0, 1);
    

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horAxis = Input.GetAxis("Horizontal");
        //transform.Translate(Direction * Speed * Time.deltaTime * horAxis);
        //position d'arrivée = Pos actuelle + deplacement 
        transform.Rotate(Axe, Time.deltaTime * horAxis * Speed);
        
        
    }
}
