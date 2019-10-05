using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_shoot : MonoBehaviour
{
    public float speed1;
    private float r_speed;
    private float speed2;
    [SerializeField]
    private GameObject Bullet;

    public GameObject pos;

    public float Del_time;
    private float count_time;
    private bool flag;
    
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        count_time = Del_time;
        speed2 = speed1 / 2;
    }

    // Update is called once per frame
    void Update()
    {
        r_speed = speed1;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            r_speed = speed2;
        }
        Move();
        Fire();
        check_Time();
        
    }

    void Move()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) transform.Translate(Vector2.right * r_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Horizontal") < 0) transform.Translate(Vector2.left * r_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") < 0) transform.Translate(Vector2.down * r_speed * Time.deltaTime);
        if (Input.GetAxisRaw("Vertical") > 0) transform.Translate(Vector2.up * r_speed * Time.deltaTime);
    }

    void Fire()
    {
        if (Input.GetKey(KeyCode.K) && flag)
        {
            Instantiate(Bullet, this.gameObject.transform.position, pos.transform.rotation);
            flag = false;
            count_time = 0;
        }
    }
    void check_Time()
    {
        if(flag == false)
        {
            count_time += Time.deltaTime;

            if(count_time >= Del_time) flag = true;
        }
    }
}
