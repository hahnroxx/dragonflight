using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1;
    void Start()
    {

    }

    void Update()
    {
        float distanceY =  Time.deltaTime * moveSpeed;

        //위에서 만든 벡터 값을 트랜스폼에 넣어서 이동 설정함
        transform.Translate(0, -distanceY, 0);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //trigger 충돌일경우 한번 실행

    //    if (collision.gameObject.CompareTag("Bullet"))
    //    {
    //        //미사일 충돌시
    //        Destroy(collision.gameObject);  //미사일 삭제

    //        Destroy(gameObject);
    //    }
        
    //}

    ////ctrl + shift + m 누르면 미리 정해져있는 함수 있다.


}
