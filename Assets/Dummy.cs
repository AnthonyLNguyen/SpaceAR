using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{

    public static string dummyName = "Earth";
    public float speed = 10f;

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
    }

    public static void change(string v)
    {
        dummyName = v;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        Material();
    }
    void OnMouseDown()
    {
        GameObject[] infos = GameObject.FindGameObjectsWithTag("Info Text");
        foreach (GameObject a in infos)
        {
            a.transform.localScale = new Vector3(0, 0, 0);
        }
        infos = GameObject.FindGameObjectsWithTag("Info Model");
        foreach (GameObject a in infos)
        {
            a.transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
