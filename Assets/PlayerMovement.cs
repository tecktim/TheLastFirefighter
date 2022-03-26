using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        movePlayer();
    }


    void movePlayer(){


        this.transform.position += new Vector3(horizontalInput, verticalInput,0f)*5f*Time.deltaTime ;
    }

}
