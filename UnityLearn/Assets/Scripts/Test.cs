using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;
// dll 가져온다.


public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // json 파일 가져오기.
        // resource - 에셋s [사운드, 텍스처, 모델링, 번역파일, JSON, 동영상 ] 
        // 텍스트
        // Text(UI) vs TextAsset
        // 상대 경로 : 시작 위치를 알아야 한다. Assets. "Resources" 
        TextAsset CharacterJson = Resources.Load<TextAsset>("Data/Character/CharacterData");
        Debug.Log(CharacterJson);

        List<Character> CharacterDB = JsonConvert.DeserializeObject<List<Character>>(CharacterJson.ToString());

        Debug.Log(CharacterDB[0].Job);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
