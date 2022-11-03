using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject shellPrefab;
    public GameObject shellSpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Fire()
    {
        GameObject shell = Instantiate(shellPrefab, shellSpawnPos.transform.position, shellSpawnPos.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Fire();
    }
}
