using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    void FixedUpdate()
    {
        this.transform.Translate(0, 0, 0.01f);
    }
}
