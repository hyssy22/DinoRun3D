using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

   public enum DoorType
    {
       Plus,
       Minus,
       Times,
       Division
	}
public class SelectDoors : MonoBehaviour
{
    public SpriteRenderer rightDoorSpriteRD; //오른쪽 문의 색을 관리할 변수
    public SpriteRenderer leftDoorSpriteRD; //왼쪽 문의 색을 관리할 변수
    public TextMeshPro rightDoorText; //오른쪽 문의 텍스트를 관리할 변수
    public TextMeshPro leftDoorText; //왼쪽 문의 텍스트를 관리할 변수

    [SerializeField]
    private DoorType rightDoorType; //오른쪽 문의 상태를 관리할 변수
    public int rightDoorNum; //오른쪽 문의 숫자를 관리할 변수
    [SerializeField]
    private DoorType leftDoorType; //왼쪽 문의 상태를 관리할 변수
    public int leftDoorNum; //왼쪽 문의 숫자를 관리할 변수

    public Color goodColor; //좋은 문의 색을 관리할 변수
    public Color badColor; //나쁜 문의 색을 관리할 변수0
    
	void Start()
    {
        SettingDoors();
    }

    public void SettingDoors()
    {
        //오른쪽 문짝
        if(rightDoorType.Equals(DoorType.Plus)) 
            {
            rightDoorSpriteRD.color = goodColor;
            rightDoorText.text = "+" + rightDoorNum;
        }
            else if(rightDoorType.Equals(DoorType.Minus)) 
            {
                rightDoorSpriteRD.color = badColor;
                rightDoorText.text = "-" + rightDoorNum;
            }
            else if(rightDoorType.Equals(DoorType.Times)) 
            {
                rightDoorSpriteRD.color = goodColor;
                rightDoorText.text = "x" + rightDoorNum;
            }
            else if(rightDoorType.Equals(DoorType.Division)) 
            {
                rightDoorSpriteRD.color = badColor;
                rightDoorText.text = "/" + rightDoorNum;
			}
        //왼쪽 문짝
        if(leftDoorType.Equals(DoorType.Plus)) 
            {
            leftDoorSpriteRD.color = goodColor;
            leftDoorText.text = "+" + leftDoorNum;
        }
            else if(leftDoorType.Equals(DoorType.Minus)) 
            {
                leftDoorSpriteRD.color = badColor;
                leftDoorText.text = "-" + leftDoorNum;
            }
            else if(leftDoorType.Equals(DoorType.Times)) 
            {
                leftDoorSpriteRD.color = goodColor;
                leftDoorText.text = "x" + leftDoorNum;
            }
            else if(leftDoorType.Equals(DoorType.Division)) 
            {
                leftDoorSpriteRD.color = badColor;
                leftDoorText.text = "/" + leftDoorNum;
		}
    }

        public DoorType GetDoorType(float xPos)
        {
            if(xPos > 0) //Dino의 위치값이 0보다 크면
            {
                return rightDoorType; //오른쪽 문의 타입 반환
		    }
            else
            {
                return leftDoorType; //왼쪽 문타입 반환
            }
	}
    public int GetDoorNumber
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        (float xPos)
    {
        if(xPos > 0) //Dino의 위치값이 0보다 크면
        {
                return rightDoorNum; //오른쪽 문의 숫자 반환
		}
        else
        {
                return leftDoorNum; //왼쪽 문의 숫자 반환
		}
    }
}


