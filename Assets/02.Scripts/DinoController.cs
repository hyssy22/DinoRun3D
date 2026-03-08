using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour

{
    public float zMoveSpeed = 0.1f;
    public float xMoveSpeed = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0 , zMoveSpeed);

		if (Input.GetKey(KeyCode.LeftArrow))
        {
			transform.Translate(-xMoveSpeed, 0, 0);
		}
		
		if (Input.GetKey(KeyCode.RightArrow))
    {
			transform.Translate(xMoveSpeed, 0, 0);
    }
}
}
