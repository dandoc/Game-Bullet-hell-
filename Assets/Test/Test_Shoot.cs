using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Shoot : MonoBehaviour
{
    public GameObject Bullet_1;
    public GameObject Bullet_2;
    public GameObject gm;
    public Transform Firepos;

    public GameObject player;

    public int What_Pattern;


    public float angle = 0;
    public float angle_1 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Check_Pattern();
        Operating();

        Debug.Log(Vector2.Angle(Firepos.transform.position, player.transform.position));

        if (Input.GetKeyDown(KeyCode.I)) Instantiate(gm);
        
    }


    void Check_Pattern()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) What_Pattern = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) What_Pattern = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha3)) What_Pattern = 3;
        else if (Input.GetKeyDown(KeyCode.Alpha4)) What_Pattern = 4;
    }

    void Operating()
    {
        if (What_Pattern == 1) Pattern_1();
        else if (What_Pattern == 2) Pattern_2();
        else if (What_Pattern == 3) Pattern_3();
        else if (What_Pattern == 4) Pattern_4();
    }


    void Pattern_1() // 원으로 따당
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            angle = 0;
            for (int i = 0; i < 360; i += 4)
            {
                Instantiate(Bullet_1, Firepos.transform.position, Quaternion.Euler(0, 0, angle));
                angle += 4;
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            angle = 2;
            for (int i = 0; i < 360; i += 4)
            {
                Instantiate(Bullet_1, Firepos.transform.position, Quaternion.Euler(0, 0, angle));
                angle += 4;
            }
        }
    }

    void Pattern_2() // 세방향으로 2발씩
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(Bullet_2, Firepos.transform.position, Quaternion.Euler(0, 0, 150));
            Instantiate(Bullet_2, Firepos.transform.position, Quaternion.Euler(0, 0, 165));
            Instantiate(Bullet_2, Firepos.transform.position, Quaternion.Euler(0, 0, 180));
            Instantiate(Bullet_2, Firepos.transform.position, Quaternion.Euler(0, 0, 195));
            Instantiate(Bullet_2, Firepos.transform.position, Quaternion.Euler(0, 0, 210));
        } // 이걸 2번 쏘면 됨.
    }

    void Pattern_3()
    {
        Instantiate(Bullet_1, Firepos.transform.position, Quaternion.Euler(0, 0, angle_1));
        Instantiate(Bullet_1, Firepos.transform.position, Quaternion.Euler(0, 0, angle_1 + 120));
        Instantiate(Bullet_1, Firepos.transform.position, Quaternion.Euler(0, 0, angle_1 + 240));
        angle_1 += 5;
    }

    void Pattern_4()
    {
        Instantiate(Bullet_1, Firepos.transform.position, Quaternion.Euler(0, 0, GetAngle(Firepos.transform.position, player.transform.position)-90));
    }

    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
    }
}