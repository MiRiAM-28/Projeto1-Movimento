using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{

    void Update()
    {
        this.transform.Translate(0, 0, 0.01f);
    }
}
