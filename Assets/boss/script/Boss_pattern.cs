using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_pattern : MonoBehaviour
{
    public int oneShoting;
    public int twoShoting;
    public GameObject bullet;
    public GameObject bullet1;
    public GameObject boss;

    public float speed;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        twoShoting = 2 * oneShoting;
    }

    // Update is called once per frame
    void Update()
    {
        at_1();
    }

    void at_1()
    {

        while (count <= 0)
        {
            for (int i = 0; i < oneShoting; i++)
            {
                Debug.Log(i);
                GameObject obj;
                obj = (GameObject)Instantiate(bullet, boss.transform.position, Quaternion.identity);

                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * -Mathf.Cos(Mathf.PI * i/ 2 / oneShoting), speed * -Mathf.Sin(Mathf.PI * i / oneShoting)));
            }
            count ++;
        }
    }
}
