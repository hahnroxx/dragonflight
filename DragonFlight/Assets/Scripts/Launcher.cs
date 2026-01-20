using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   //미사일 프리펩 가져올 함수
    void Start()
    {
        //Invoke, InvokeRepeating("함수이름", 초기지연시간, 지연할 시간);
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()        //쏘는 함수. 정말 많이 쓴다. 외워라~
    {
        //미사일 프리펩, 런처포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);

        SoundManager.instance.SoundBullet();

    }

    void Update()
    {
        
    }
}
