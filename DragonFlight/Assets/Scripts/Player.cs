using UnityEngine;

public class Player : MonoBehaviour
{
    //스피드
    public float moveSpeed = 3;

    void Start()
    {
            
    }

    void Update()
    {
        //x쪽값 설정만 한다. 드래곤 플라이트는 좌우로만 움직이기 때문.
        //vector 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed;

        //위에서 만든 벡터 값을 트랜스폼에 넣어서 이동 설정함
        transform.Translate(distanceX, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);  //적 삭제

            Destroy(gameObject);            //플레이어 삭제
        }
    }

    
}
