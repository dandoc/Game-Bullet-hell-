using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject explosionPrefab;

    public Transform bullets;

    public float time;

    public int damage;

    public float speed;

    public float DestroyTime;


    void Start()
    {

    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        time += Time.deltaTime;

        //if (time >= 0.8f)
        //{
        //    Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
        //}
        //Destroy(this.gameObject, DestroyTime);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //void OnTriggerEnter2D(Collider2D other)

    //{
    //    if (other.gameObject.tag.Equals("Ground") || other.gameObject.tag.Equals("Enemy"))
    //    //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
    //    {
    //        Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
    //        Destroy(this.gameObject);
    //        //자신을 파괴합니다.
    //    }
    //}




}
