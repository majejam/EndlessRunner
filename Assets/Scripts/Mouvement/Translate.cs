using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float TranslateSpeed = 1;

    GlobalSpeed Global;

    public Vector3 Direction = new Vector3(0, 1, 0);
    
    // Start is called before the first frame update

    void Start()
    {
        Global = GameObject.FindObjectOfType<GlobalSpeed>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Global.Speed * Time.deltaTime);
    }
}
