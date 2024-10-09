using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
 
        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;

        transform.Translate(move);

        float rotationY = Input.GetAxis("Mouse X");

        Vector3 rotation =  new Vector3(0, rotationY * Time.deltaTime * rotationSpeed, 0 );

        transform.Rotate(rotation);
    }
}
