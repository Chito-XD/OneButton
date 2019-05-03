using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private bool direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction)
        {
            gameObject.transform.Translate(new Vector3(speed, 0, 0));
        }   
        else
        {
            gameObject.transform.Translate(new Vector3(-speed, 0, 0));
        }

        if (Input.GetButtonDown("Jump"))
        {
            direction = !direction;
        }
    }
}
