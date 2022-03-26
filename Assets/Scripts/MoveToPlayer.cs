using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public Rigidbody2D rBody;
    public float speed;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.gameManager.player;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector2.Distance(player.transform.position, this.rBody.position) <= 12f)
        {
            moveToPlayer();
        }
    }

    void moveToPlayer()
    {
        Vector2 dirToPlayer = player.transform.position - this.transform.position;
        //this.transform.position += dirToPlayer.normalized * 3f * Time.deltaTime;
        rBody.MovePosition(rBody.position + dirToPlayer * speed * Time.fixedDeltaTime);
    }
}
