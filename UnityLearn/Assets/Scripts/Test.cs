using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;
// dll 가져온다.



public class Test : MonoBehaviour
{
    [SerializeField] string name = "ABC";

    [SerializeField]
    [Range(0f, 10f)] 
    int id = 10;

    Transform transform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // json 파일 가져오기.
        // resource - 에셋s [사운드, 텍스처, 모델링, 번역파일, JSON, 동영상 ] 
        // 텍스트
        // Text(UI) vs TextAsset
        // 상대 경로 : 시작 위치를 알아야 한다. Assets. "Resources" 

        transform = GetComponent<Transform>();
        transform.MovePosition(new Vector3(0, 0, 10));

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
