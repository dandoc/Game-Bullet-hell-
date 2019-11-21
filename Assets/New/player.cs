using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float r_speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) r_speed = r_speed / 2;
        else if (Input.GetKeyUp(KeyCode.LeftShift)) r_speed = r_speed * 2;
        if (Input.GetAxisRaw("Horizontal") > 0) transform.Translate(Vector2.right * r_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Horizontal") < 0) transform.Translate(Vector2.left * r_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") < 0) transform.Translate(Vector2.down * r_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") > 0) transform.Translate(Vector2.up * r_speed * Time.deltaTime);
    }
}