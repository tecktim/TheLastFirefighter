using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rBody;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        movePlayer();
    }


    void movePlayer(){
        rBody.MovePosition(rBody.position + new Vector2(horizontalInput, verticalInput) * speed * Time.fixedDeltaTime);

        
    }

}
