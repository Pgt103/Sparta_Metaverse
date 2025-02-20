using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float cameraMoveSpeed = 3f; // 카메라 속도
    public float speedPlus = 0.03f; // 시간에 따른 추가 속도

    void Update() // 카메라 이동
    {
        float currentSpeed = cameraMoveSpeed + (speedPlus * Time.timeSinceLevelLoad);
        transform.Translate(Vector3.right * currentSpeed * Time.deltaTime);
    }
}
