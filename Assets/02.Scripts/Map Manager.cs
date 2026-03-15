using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject[] mapPrefabs;
	void Start()
	{
        Vector3 mapPosition = Vector3.zero; // 초기생성 위치는 원점으로 한다.

        for(int i=0; i<5; i++) //일단 테스트로 5개만 만들어본다
        {
            GameObject selectedMap = mapPrefabs[Random.Range(0,mapPrefabs.Length)]; //만들 map을 랜덤으로 선택
            if(i>0) 
            {
                //2번째 map에서부터 이전 map의 크기의 반을 더해준다
             mapPosition.z += selectedMap.GetComponent<Map>().GetMapSize()/2;
			}
            GameObject nowMap = Instantiate(selectedMap, mapPosition, Quaternion.identity); //현재 만들 맵을 생성한다.
            mapPosition.z +=nowMap.GetComponent<Map>().GetMapSize()/2; //현재 map의 크기의 반을 더해준다.
		}
    }
}
