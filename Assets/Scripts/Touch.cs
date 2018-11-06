using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

   public float speed = 60;

    private void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotx);
        transform.Rotate(Vector3.right, roty);
    }


}
