using UnityEngine;
using System.Collections;


public class myRotate2 : MonoBehaviour
{
    float rotSpeed = 8;

    private void Update()
    {
        if(Input.touchCount == 3){
            OnMouseDragX();
            OnMouseDragY();
        }

    }

    void OnMouseDrag()
    {
        if (Input.touchCount == 2)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed /2* Mathf.Deg2Rad;
            transform.RotateAround(Vector3.up, -rotX);
        }

    }
    void OnMouseDragX()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed / 2 * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.up, -rotX);

    }

    void OnMouseDragY()
    {

        float rotY = Input.GetAxis("Mouse Y") * rotSpeed / 2 * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.right, -rotY);
    }


}