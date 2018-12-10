using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualScr : MonoBehaviour {

    public Transform playerPos;
    private Collider2D col;
    public float YoffsetTop, YoffsetBot;
    void Start () {
        col = GetComponent<Collider2D>();
	}
	
	
	void Update () {
        if (transform.position.y>playerPos.position.y)
        {
            if (transform.position.z <2)
            {
                transform.position += new Vector3(0, 0, 2);
                col.offset = new Vector2(col.offset.x, YoffsetTop);
            }
        }
        else
        {
            if (transform.position.z<=2 && transform.position.z>=0)
            {
                transform.position -= new Vector3(0, 0, 2);
                col.offset = new Vector2(col.offset.x, YoffsetBot);
            }
        }
        

    }
}
