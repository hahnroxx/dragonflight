using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    //싱글톤은 자주 쓰이는 디자인 패턴 중 하나임.

    public static SingletonTest instance;   //자기 자신을 변수로 만들고
    //어디서든 쓸 수 있게 해서 편하게 씀

    private void Awake()
    {
        //start 보다 더 빠르게 설정
        if (instance == null)
        {
            instance = this;    //자기참조객체
        }
    }

    
    public void PlayerSound()
    {
        Debug.Log("플레이어 사운드야");
    }

    public void EnemySound()
    {
        Debug.Log("플레이어 사운드야");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
