using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject b;
    private GameObject player;
    private float rotation;
    private float fire_rotation;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            rotation = 60;
            for (int n = 0; n < 5; n++)
            {
                for (int i = -2; i < 3; i++)
                {
                    fire_rotation = rotation;
                    fire_rotation = fire_rotation + 10 * i;
                    Instantiate(b, this.transform.position, Quaternion.Euler(0, 0, fire_rotation));
                }
            }
        }
    }

    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
    }
}
