using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Bullet : MonoBehaviour
{
    public float speed = 10;
    public float speed1;
    public float speed2;
    public float time = 0.3f;
    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed1 = speed / 2;
        speed2 = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= time)
        {
            count += Time.deltaTime;
            speed = speed1;
        }
        else speed = speed2 ;
        this.transform.Translate(new Vector2(0, 2) * speed * Time.deltaTime);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
