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
        int index = Random.Range(0, ObjectPrefab.Length);
        GameObject copy = Instantiate(ObjectPrefab[index], transform);
        float angle = (Random.Range(0f, 1f)) * Mathf.PI * 2f;
        
        copy.transform.position = new Vector3(Mathf.Sin(angle)* Radius, Mathf.Cos(angle)* Radius + (Radius), 0);
    }
}
