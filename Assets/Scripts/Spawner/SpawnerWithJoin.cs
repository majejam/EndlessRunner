using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerWithJoin : MonoBehaviour
{
    public GameObject[] ObjectPrefab;
    public GameObject LastObject;

    public void Spawn()
    {
        int index = Random.Range(0, ObjectPrefab.Length);
        GameObject copy = Instantiate(ObjectPrefab[index], transform);

        Vector3 pos = LastObject.transform.position;

        

        pos.z = pos.z - copy.GetComponent<BoxCollider>().bounds.size.z;

        copy.transform.position = pos;

        LastObject = copy;
    }
}
