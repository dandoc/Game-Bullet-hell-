using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_1 : MonoBehaviour
{
    public GameObject b;
    private GameObject player;
    private float rotation;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = GetAngle(this.transform.position, player.transform.position)+90;
        if (Input.GetKeyDown(KeyCode.I)) Instantiate(b, this.transform.position, Quaternion.Euler(0,0, rotation));
    }

    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
    }
}
