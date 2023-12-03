using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public GameObject insectPrefab;
    public int numInsects = 5;
    public GameObject[] allInsects;
    public float neighbourDistance = 5f;
    
    public float minSpeed = 1.0f;
    public float maxSpeed = 2.0f;
    public float rotationSpeed = 4.0f;
    public float minX = -13f;
    public float maxX = 13f;

    // Límites en los ejes Y
    public float minY = 7f;
    public float maxY = 10f;

    // Límites en los ejes Z
    public float minZ = -13f;
    public float maxZ = 13f;
    public float defaultSpeed = 5f;
    void Start() {
        
        allInsects = new GameObject[numInsects];
        for (int i = 0; i < numInsects; ++i) {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-10, 10), Random.Range(4, 7), Random.Range(-10, 10));
            Vector3 randomize = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
            allInsects[i] = (GameObject)Instantiate(insectPrefab, pos, Quaternion.LookRotation(randomize));
            allInsects[i].GetComponent<Flock>().myManager = this;
        }
    }

    void Update()
    {
        //MoveSwarm();
    }

    /*void MoveSwarm()
    {
        

        // Actualizar la posición de cada insecto basándose en el comportamiento de flocking
        foreach (GameObject insect in allInsects)
        {
            InsectManager insectBehavior = insect.GetComponent<InsectManager>();
            insectBehavior.ApplyFlockingBehavior(allInsects, swarmCenter.position);
        }
    }*/
}
