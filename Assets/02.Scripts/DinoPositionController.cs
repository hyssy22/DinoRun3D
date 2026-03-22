using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class DinoPositionController : MonoBehaviour
{
    //public float dinoGapX; // 공룡 사이의 간격을 조절하는 변수 (인스펙터에서 조절 가능)
    //void Start()
    //{

    //}

    //void Update()
    //{
    //    float startPosX = (transform.childCount * (dinoGapX / -2)) + (dinoGapX / 2); //x축의 시작 포지션

    //    //이 스크립트가 있는 오브젝트의 자식 오브젝트의 개수만큼 반복													   
    //    for (int i = 0; i < transform.childCount; i++) {
    //        //GetChild함수를 이용해 인덱스 번호(유니티에서 자식 오브젝트의 맨 위에서부터의 순서)순서대로 계산한 z값
    //        transform.GetChild(i).localPosition = new Vector3(startPosX + i * dinoGapX, 0, 0);
    //    }
    //}
    //}

    public Transform raptors; //Raptor들을 관리할 부모 오브젝트
    public GameObject raptorPrefab; //추가할 Raptor 프리팹
	public float radius = 1f; //원의 반지름
    public float ratio = 0.1f; //배치 간격 비율(작을수록 촘촘)

    void Update()
    {
        SetDinoPosition();
    }
    public void SetDoorCalc(DoorType doorType, int doorNumber)
    {
        if(doorType.Equals(DoorType.Plus)) // 더하기
        {
      PlusRaptor(doorNumber);

        }
        else if(doorType.Equals(DoorType.Minus)) // 빼기
		{

        }
             else if(doorType.Equals(DoorType.Times)) // 곱하기
		{

        }
             else if(doorType.Equals(DoorType.Division)) // 나누기
		{

        }
     
	}

    private void PlusRaptor(int number)
    {
        for(int i = 0; i<number; i++)
        {
            Instantiate(raptorPrefab, raptors); //Raptor 프리팹을 Raptor 부모 오브젝트의 자식으로 생성
        }
	}


	private void SetDinoPosition()
    {
        for(int i = 0; i<raptors.childCount; i++)
        {
           if(i>8)
            {
                raptors.GetChild(i).gameObject.SetActive(false); //9마리 이상은 비활성화
                continue;
			}
		
    
        else
            {
            if(raptors.childCount<10)
          { 
    
            //360도 각도 계산을 위한 각도 증가값
            float angleStep = 360f / (raptors.childCount * ratio);
        
            //각 오브젝트의 배치 각도 계산
            float angle = i * angleStep;
                    
            //각도를 라디안으로 변환
            float angleRad = angle*Mathf.Deg2Rad;

            //X와 Z 좌표를 원형으로 계산
            float x = Mathf.Cos(angleRad) * radius;
			float z = Mathf.Sin(angleRad) * radius;

            //새로운 위치로 자식 오브젝트를 위치시킴
            raptors.GetChild(i).localPosition = new Vector3(x, 0, z);
		}   
	}
}
}
}