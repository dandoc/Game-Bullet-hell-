using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidedmissile : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject Player;
    private float d;
    private float vx = 0, vy = 0;
    public float speed = 5;

    private Vector3 aaa;

    void Start()
    {
        aaa = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        aaa = this.transform.position;
        //Debug.Log(Player.transform.position);
        //Vector2 a = new Vector2(this.transform.position.x - Player.transform.position.x, this.transform.position.y - Player.transform.position.y);
        //this.transform.Translate(-a * Time.deltaTime * 10);
        // 시발 이거 아님

        //this.transform.rotation = Quaternion.Euler(new Vector3(0,0, GetAngle(this.transform.position, Player.transform.position)-90));
        //this.transform.Translate(Vector2.up * Time.deltaTime);
        // 이거도 아님

        d = Mathf.Sqrt(Mathf.Pow(Player.transform.position.x - this.transform.position.x, 2) + Mathf.Pow(Player.transform.position.y - this.transform.position.y, 2));

        if (d != 0)
        {
            vx = (Player.transform.position.x - this.transform.position.x)/d*speed;
            vy = (Player.transform.position.y - this.transform.position.y)/d*speed;
        }
        else
        {
            vx = 0;
            vy = speed;
        }

        this.transform.position += new Vector3(vx*Time.deltaTime,0,0);
        this.transform.position += new Vector3(0, vy*Time.deltaTime, 0);

    }








    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
    }
}
