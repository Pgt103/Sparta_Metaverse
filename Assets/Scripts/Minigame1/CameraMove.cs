using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float cameraMoveSpeed = 3f;
    public float speedPlus = 1f;

    void Update() // 카메라 이동
    {
        float currentSpeed = cameraMoveSpeed + (speedPlus * Time.deltaTime);
        transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
    }
}
