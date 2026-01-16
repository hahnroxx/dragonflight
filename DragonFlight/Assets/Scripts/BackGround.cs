using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private Material myMaterial;
    void Start()
    {
        //머티리얼 가져오기
        myMaterial = GetComponent<Renderer>().material; 
        //인스펙터에 mesh Renderer의 부분을 가져오려고 하는 것.

    }

    void Update()
    {
        //오프셋을 머티리얼에서 가져오기
        Vector2 newOffset = myMaterial.mainTextureOffset;
        //새롭게 offset 바꿔주기
        //y부분 값을 속도에 프레임 보정해서 더해주기
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        //머티리얼에 오프셋 값을 넣어준다.
        myMaterial.mainTextureOffset = newOffset;
    }
}
