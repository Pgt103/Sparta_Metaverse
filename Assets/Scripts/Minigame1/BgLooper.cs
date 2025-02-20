using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int numBgCount = 5;
    
    public int obstacleCount = 0;

    public Vector3 obstacleLastPosition = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>(); // Obstacle이 달려있는 오브젝트를 전부 찾아온다
        obstacleLastPosition = obstacles[0].transform.position;
        obstacleCount = obstacles.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPosition = obstacles[i].SetRandomPlace(obstacleLastPosition, obstacleCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered: " + collision.name);

        // 배경과 충돌 시 배경을 앞쪽으로 재배치 한다
        if (collision.CompareTag("Background"))
        {
            // 사이즈를 가져오기 위해 단순한 콜리전이 아닌 박스콜라이더 취급을 해야한다.
            float widthOfBgObject = ((BoxCollider2D)collision).size.x; 
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * numBgCount;
            collision.transform.position = pos;
            return;
        }

        // 옵스타클들을 랜덤한 위치에 재배치
        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            obstacleLastPosition = obstacle.SetRandomPlace(obstacleLastPosition, obstacleCount);
        }
    }
}
