using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public float rotateSpeed = 10f;

    public float speadY = 1f;
    public float speadZ = 1f;
    public float timer = 1f;

    public bool isCapture = false;

    public float minimum = 1f;
    public float maximum = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed/10, 0);

        if (!isCapture)
        {
            if (timer <= 0)
            {
                speadY = Random.Range(-10, 10) / 10f;
                speadZ = Random.Range(-10, 10) / 10f;
                timer = 1f;
            }
            timer -= Time.deltaTime;

            transform.position += new Vector3(0, speadY, speadZ);
        }
        else
        {
            Ñapture();
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void Ñapture()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, GameObject.FindGameObjectWithTag("Bag").transform.position, 1f);
        transform.localScale = new Vector3(A(), A(), A());

    }

    private void OnBecameInvisible()
    {
        Destroy();
    }  

    float A()
    {
        return Mathf.PingPong(Time.time, maximum - minimum) + minimum;
    }
}
