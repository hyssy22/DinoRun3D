using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour

{
	public DinoPositionController dinoPositionController; //DinoPositionController 스크립트를 관리할 변수
	public float zMoveSpeed = 0.1f;
    public float xMoveSpeed = 0.1f;

    //구체의 중심이 될 위치
    public Vector3 sphereCenter;
    // 구체의 반지름
    public float sphereRadius = 0.5f;
	void Start()
    {
        
    }

    void Update()
	{
		DinoMove();
		DoorCheck();
	}

	private void DinoMove()
	{
		transform.Translate(0, 0, zMoveSpeed);

		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-xMoveSpeed*Time.deltaTime, 0, 0);
		}

		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(xMoveSpeed*Time.deltaTime, 0, 0);
		}
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3.8f, 3.8f), transform.position.y, transform.position.z);
	}

	void DoorCheck()
	{
		//구체 영역 내의 Collider들을 감지
		Collider[]hitColliders = Physics.OverlapSphere(transform.position + sphereCenter , sphereRadius);

		//감지된 Collider들을 처리
		foreach (Collider doors in hitColliders)
		{
				int doorNumber = doors.gameObject.GetComponent<SelectDoors>().GetDoorNumber(transform.position.x); //문짝의 숫자
			DoorType doorType = doors.gameObject.GetComponent<SelectDoors>().GetDoorType(transform.position.x); //문짝의 상태

			dinoPositionController.SetDoorCalc(doorType, doorNumber); //DinoPositionController의 DinoDoorCheck 함수에 문짝의 숫자와 상태를 전달
		}
	}
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position + sphereCenter, sphereRadius);
	}
}


