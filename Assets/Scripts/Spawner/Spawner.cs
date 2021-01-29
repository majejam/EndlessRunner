using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObjectPrefab;
    public float SpawnInterval = 1;
    public float Radius = 25;
    public float Cos = 1;
    public float Sin = 1;


    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= SpawnInterval)
        {
            Spawn();
            Timer = 0;
        }
    }
    
    public void Spawn()
    {
        int randomNb = Random.Range(0, 10);

        GameObject copy;

        if (randomNb > 8)
        {
            copy = Instantiate(ObjectPrefab[0], transform);
        }
        else 
        {
            copy = Instantiate(ObjectPrefab[1], transform);
        }
        
        float angle = (Random.Range(0f, 1f)) * Mathf.PI * 2f;

        copy.transform.Rotate(new Vector3(0,0,(-((angle) * 180/  Mathf.PI) -180)), Space.World);
        
        
        copy.transform.position = new Vector3(Mathf.Sin(angle)* Radius, Mathf.Cos(angle)* Radius + (Radius), 0);
    }
}
