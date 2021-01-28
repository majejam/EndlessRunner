using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 Direction;
    public float Speed;
    

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
        Vector3 pos = transform.position + (Direction * Speed * Time.deltaTime * horAxis);
        rb.MovePosition(pos);
        
    }
}
