using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy;   //미사일 프리펩 가져올 함수

    public float MoveSpeed = 1;
    
    void Start()
    {
        //Invoke, InvokeRepeating("함수이름", 초기지연시간, 지연할 시간);
        InvokeRepeating("EnemyBorn", 1f, 1f);
    }

    void EnemyBorn()        //적 생성 함수
    {


        float randomX = Random.Range(-3f, 3f);  //x 좌표 랜덤으로 생성
        //적 프리펩
        if (enableSpawn)
        {
            Instantiate(Enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
    }


    void Update()
    {
        
        
        

    }

    
}
