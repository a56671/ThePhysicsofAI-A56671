using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    public float speed = 0.5;
    void LateUpdate()
    {
        this.transform.Translate(0f,0f,Time.deltaTime * speed);
    }
}
