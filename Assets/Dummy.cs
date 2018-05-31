using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{

    public static string dummyName = "Earth";
    public float speed = 10f;
    private float baseAngle = 0.0f;

    // Use this for initialization
    void Start()
    {
        Material();
        gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    void Material()
    {
        Renderer rend = this.GetComponent<Renderer>();
        rend.material = new Material(Resources.Load("Mesh" + dummyName + "Material", typeof(Material)) as Material);
        if (dummyName != "Saturn")
        {
            gameObject.transform.Find("Circle").gameObject.SetActive(false);
        }
        else
        {
            gameObject.transform.Find("Circle").gameObject.SetActive(true);
        }
    }

    public static void change(string v)
    {
        dummyName = v;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up, speed * Time.deltaTime);
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
        transform.rotation = Quaternion.AngleAxis(ang, Vector3.down);
        Material();
    }


}
