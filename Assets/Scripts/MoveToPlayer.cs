using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.gameManager.player;
    }

    // Update is called once per frame
    void Update()
    {
        moveToPlayer();
    }

    void moveToPlayer()
    {
        Vector3 dirToPlayer = player.transform.position - this.transform.position;
        this.transform.position += dirToPlayer.normalized * 3f * Time.deltaTime;
    }
}
