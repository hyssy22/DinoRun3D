using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class DinoPositionController : MonoBehaviour
{
    public float dinoGapX; // 공룡 사이의 간격을 조절하는 변수 (인스펙터에서 조절 가능)
	void Start()
    {
        
    }

    void Update()
    {
        float startPosX = (transform.childCount*-(dinoGapX/2))+(dinoGapX/2); 
        // 자식 오브젝트의 개수에 따라 시작 위치를 계산 (오른쪽으로 배치하기 위해 gapX/2만큼 더해줌)
																		   
		for (int i = 0; i < transform.childCount; i++)
        {
		transform.GetChild(i).localPosition = new Vector3(startPosX + i * dinoGapX, 0, 0);
            // 각 자식 오브젝트의 위치를 gapX 간격으로 배치
		}
	}
}