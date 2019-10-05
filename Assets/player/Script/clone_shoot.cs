using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone_shoot : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        check_Time();
       
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
        if (flag == false)
        {
            count_time += Time.deltaTime;

            if (count_time >= Del_time) flag = true;
        }
    }
}
