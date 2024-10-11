using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterController : MonoBehaviour
{
    public Rigibody PlayerRigibody; // 이동에 사용할 리디즈바디 컴포넌트
    public float speed = 8f; // 이동 속력

    // bool Input.GetKey(KeyCode key);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            // 위쪽 방향키 입력이 감지된 경우 z 방향 힘 주기
            playerRigibody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘 주기
            playerRigibody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘 주기
            playerRigibody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // 왼쪽 방향키 입력이 감지된 경우 -x 방향 힘 주기
            playerRigibody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
