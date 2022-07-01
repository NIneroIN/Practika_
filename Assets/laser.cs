using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    private Camera camera;
    public float Rotate;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastHit))
        {
            Debug.Log("Запуск лазера" + raycastHit.collider);
        }
    }
}
