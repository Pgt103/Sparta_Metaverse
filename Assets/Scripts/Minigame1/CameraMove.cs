using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float cameraMoveSpeed = 3f;
    public float speedPlus = 1f;

    void Update()
    {
        float currentSpeed = cameraMoveSpeed + (speedPlus * Time.time);
        transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
    }
}
