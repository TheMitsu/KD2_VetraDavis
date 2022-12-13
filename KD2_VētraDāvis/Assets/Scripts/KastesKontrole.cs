using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float rotationAmount = rotationSpeed * Time.deltaTime;

        if (horizontalInput < 0)
        {
            transform.Rotate(Vector3.back, rotationAmount);
        }
        else if (horizontalInput > 0)
        {
            transform.Rotate(Vector3.forward, rotationAmount);
        }

        if (verticalInput < 0)
        {
            transform.Rotate(Vector3.left, rotationAmount);
        }
        else if (verticalInput > 0)
        {
            transform.Rotate(Vector3.right, rotationAmount);
        }   
    }
}
