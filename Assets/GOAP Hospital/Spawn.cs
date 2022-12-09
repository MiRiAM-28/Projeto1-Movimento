using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject Patient;
    public int numPatients;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numPatients; i++)
        {
            Instantiate(Patient, this.transform.position, Quaternion.identity);
        }

        Invoke("SpawnPatient", 5);
    }

    void SpawnPatient()
    {
        Instantiate(Patient, this.transform.position, Quaternion.identity);
        Invoke("SpawnPatient", Random.Range(2, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
