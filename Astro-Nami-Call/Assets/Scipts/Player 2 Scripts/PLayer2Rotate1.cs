using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer2Rotate : MonoBehaviour
{
    [SerializeField]
    private int RotationSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float RotationX = 0;
        float RotationY = 0;
        float RotationZ = 0;


        if (Input.GetButton("R2"))
        {
            RotationZ = -RotationSpeed * Time.deltaTime;
        }
        if (Input.GetButton("L2"))
        {
            RotationZ = RotationSpeed * Time.deltaTime;
        }

        transform.Rotate(RotationX, RotationY, RotationZ);

    }
}
