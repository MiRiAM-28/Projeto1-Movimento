using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellmove : MonoBehaviour
{
    float speed = 2;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, (speed * Time.deltaTime)/2.0f, speed * Time.deltaTime);
    }
}
