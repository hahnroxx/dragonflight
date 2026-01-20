using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1;
    public GameObject effect;

    void Start()
    {
        
    }

    void Update()
    {
        //y축 이동
        transform.Translate(0,moveSpeed * Time.deltaTime,0);
    }


    //화면 밖으로 나가면 안 보이게 해주는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //trigger 충돌일경우 한번 실행

        if (collision.gameObject.CompareTag("Enemy"))
        {
            //이펙트 생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1); //1초 있다가 없애기
            
            //미사일 충돌시
            Destroy(collision.gameObject);  //적 삭제
            SoundManager.instance.SoundDie();

            Destroy(gameObject);    //미사일도 삭제
        }

    }

    //ctrl + shift + m 누르면 미리 정해져있는 함수 있다.
}
