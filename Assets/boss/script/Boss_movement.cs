using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_movement : MonoBehaviour
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
        StartCoroutine("SpellStart");
        twoShoting = 2 * oneShoting;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpellStart()
    {
        
        while(count <= 10)
        {
            for (int i = 0; i < oneShoting; i++)
            {
                Debug.Log(i);
                GameObject obj;
                obj = (GameObject)Instantiate(bullet, boss.transform.position, Quaternion.identity);

                //보스의 위치에 bullet을 생성합니다.
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / oneShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / oneShoting)));

                obj.transform.Rotate(new Vector3(0f, 0f, 360 * i / oneShoting - 90));
            }
            yield return new WaitForSeconds(1f);

            for (int i = 1; i < twoShoting; i+=2)
            {
                Debug.Log(i);
                GameObject obj;
                obj = (GameObject)Instantiate(bullet1, boss.transform.position, Quaternion.identity);

                //보스의 위치에 bullet을 생성합니다.
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * i / oneShoting), speed * Mathf.Sin(Mathf.PI * i / oneShoting)));

                obj.transform.Rotate(new Vector3(0f, 0f, 360 * i/2 / oneShoting - 90));
            }
            yield return new WaitForSeconds(1f);
            count++;
        }
        StopCoroutine("SpellStart");
    }
}
