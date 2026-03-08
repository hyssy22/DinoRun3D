using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; //따라갈 오브젝트(공룡)
    public Vector3 offset; //카메라의 고정된 위치(현재 세팅된 쿼터뷰 카메라 위치)
	void Start()
    {
       offset = target.position - transform.position; //타켓과 카메라 사이의 거리
	}
    void Update()
    {
        if (target != null)
        {
            //카메라의 새로운 위치 계산(공룡이 좌우로 움직여도 z축만 따라감)
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, target.position.z-offset.z);

            //카메라 위치를 업데이트
            transform.position = newPosition;
		}
	}
}
