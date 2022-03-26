using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOtherGameObjectOnCollision : MonoBehaviour
{
    public GameObject other;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Gehts?");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Neien");
            other.SetActive(false);
        }
    }
}
