using UnityEngine;

public class SoundManager : MonoBehaviour
{

    //싱글톤
    public static SoundManager instance;    //싱글톤 변수

    AudioSource myAudio;    //오디오소스 변수. 컴포넌트 변수로 담는다.

    public AudioClip soundBullet;    //재생할 소리 변수
    public AudioClip soundDie;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>();      //유니티에서 오디오소스 컴포넌트 가져오기
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);  //몬스터 죽는 소리. playoneshot은 한번 실행해준다는 기능

    }

    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}
