using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWatergun : MonoBehaviour
{
    private CircleCollider2D waterGunCollider;
    public GameObject waterGun;
    private Vector3 worldMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        waterGunCollider = GetComponent<CircleCollider2D>();
        waterGun.transform.position = new Vector3(0f, 0f, -1f);
    }

    // Update is called once per frame
    void Update()
    {
        worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            waterGun.transform.position = new Vector3(worldMousePosition.x, worldMousePosition.y, 1f);
            if(waterGun.transform.localScale.x < .5 && waterGun.transform.localScale.y < .5)
            {
                waterGun.transform.localScale += new Vector3(.001f, .001f, 0);
            }
        }
        else
        {
            waterGun.transform.position = new Vector3(0f, 0f, -1f);
            waterGun.transform.localScale = new Vector3(.1f, .1f, 0);
            
        }
    }
}
