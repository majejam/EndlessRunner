using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ObjectPrefab;
        public void Spawn()
    {
        int index = Random.Range(0, ObjectPrefab.Length);
        GameObject copy = Instantiate(ObjectPrefab[index]);
        Vector3 position = transform.position;
        //position.x = position.x + Random.Range(-1, 2);
        copy.transform.position = position; //new Vector3(Random.Range(-5, 5), 1, 0);
    }
}
