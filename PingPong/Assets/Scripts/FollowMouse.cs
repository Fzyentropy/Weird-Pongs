using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // private bool isHolding = false;
    private Vector3 lastMousePosition;
    public float sensitivity = 0.1f; // 调整这个值可以改变物体跟随鼠标的灵敏度

    // public float boundaryX = 7.3f;
    // public float boundaryY = 5f;

    private void Start()
    {
        // lastMousePosition = Input.mousePosition;
    }

    private void Update()
    {
        
        // 最初的实现方法
        // Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
        // Vector3 moveDirection = new Vector3(mouseDelta.x, mouseDelta.y, 0).normalized;
        // transform.position += moveDirection * sensitivity;
        // lastMousePosition = Input.mousePosition;

        
        // 使用 GetAxis

        transform.position = new Vector3(
            transform.position.x + Input.GetAxis("Mouse X") * sensitivity,
            transform.position.y + Input.GetAxis("Mouse Y") * sensitivity);


        // 尝试解决鼠标触碰屏幕边缘的问题，失败
        // transform.position.x + moveDirection.x * sensitivity
        // transform.position.y + moveDirection.y * sensitivity
        // if 
        // (((transform.position.x + moveDirection.x * sensitivity) >= boundaryX) 
        //  || 
        //  ((transform.position.x + moveDirection.x * sensitivity) <= -boundaryX) )
        // {
        //     transform.position = new Vector3(transform.position.x, moveDirection.y * sensitivity);
        // }
        // if 
        // (((transform.position.x + moveDirection.x * sensitivity) < boundaryX) 
        //  && 
        //  ((transform.position.x + moveDirection.x * sensitivity) > -boundaryX) )
        // {
        //     transform.position += moveDirection * sensitivity;
        // }
        //
        //
        // if 
        //     (((transform.position.y + moveDirection.y * sensitivity) >= boundaryY) 
        //      || 
        //      ((transform.position.y + moveDirection.y * sensitivity) <= -boundaryY) )
        // {
        //     transform.position = new Vector3(moveDirection.x * sensitivity,transform.position.y);
        // }
        // if 
        //     (((transform.position.y + moveDirection.y * sensitivity) < boundaryY) 
        //      && 
        //      ((transform.position.y + moveDirection.y * sensitivity) > -boundaryY) )
        // {
        //     transform.position += moveDirection * sensitivity;
        // }



    }
}
