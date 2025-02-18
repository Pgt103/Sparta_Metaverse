using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothTime = 0.2f;

    [SerializeField] private Vector2 minBoundary;
    [SerializeField] private Vector2 maxBoundary;
    
    private void FixedUpdate()
    {   // 카메라 좌표 지정. z축 위치가 계속해서 변형하는 문제 때문에 기본값인 -10 지정
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, -10f);
        
        targetPosition.x = Mathf.Clamp(player.position.x, minBoundary.x, maxBoundary.x);
        targetPosition.y = Mathf.Clamp(player.position.y, minBoundary.y, maxBoundary.y);
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothTime);
    }
    
    
}
