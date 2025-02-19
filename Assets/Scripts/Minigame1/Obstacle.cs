using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle : MonoBehaviour
{
    //  변수들을 퍼블릭으로 선언할 경우 인스펙터, 즉 유니티 안에서 변수 수정이 가능하다
    public float highPosY = 1f;
    public float lowPosY = -1f;

    public float holeSizeMin = 1f;
    public float hoseSizeMax = 3f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 4f;


    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, hoseSizeMax);
        float halfHoleSize = holeSize / 2f;

        // 로컬 좌표는 월드가 아닌 부모 오브젝트를 0으로 기준을 잡아 그곳부터 거리를 계산한다
        topObject.localPosition = new Vector3(0, halfHoleSize); 
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);
        
        transform.position = placePosition;
        return placePosition;
    }
    
}
