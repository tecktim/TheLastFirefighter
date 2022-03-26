using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWatergun : MonoBehaviour
{
    private CircleCollider2D waterGunCollider;
    public Transform waterGun;
    public GameObject waterPrefab;
    private Vector3 worldMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        waterGunCollider = GetComponent<CircleCollider2D>();
        waterGun.position = new Vector3(0f, 0f, -1f);
    }

    // Update is called once per frame
    void Update()
    {
        worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            waterGun.gameObject.SetActive(true);
            waterGun.localScale = new Vector3(.1f, .1f, 0);
        }
        else if (Input.GetMouseButton(0))
        {
            waterGun.position = new Vector3(worldMousePosition.x, worldMousePosition.y, 1f);
            if(waterGun.localScale.x < .5 && waterGun.localScale.y < .5)
            {
                waterGun.localScale += new Vector3(.1f, .1f, 0)*Time.deltaTime;
            }
        }
        else if(Input.GetMouseButtonUp(0))
        {
            GameObject waterInstance = Instantiate(waterPrefab, waterGun.position, waterGun.rotation);
            waterInstance.transform.localScale = waterGun.localScale;
            Destroy(waterInstance, 5f);
            waterGun.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
