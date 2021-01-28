using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObjectPrefab;
    public float SpawnInterval = 1;


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
        GameObject copy = Instantiate(ObjectPrefab[index]);
        Vector3 position = transform.position;
        position.x = position.x + Random.Range(-1, 2);
        copy.transform.position = position; //new Vector3(Random.Range(-5, 5), 1, 0);
    }
}
