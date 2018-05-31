using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInfo : MonoBehaviour {

    public int planetNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        string name = PlanetLocation.bodyNames[planetNumber];
        Debug.unityLogger.Log(name);
        Dummy.change(name);
        GameObject[] infos = GameObject.FindGameObjectsWithTag("Info Model");
        foreach (GameObject a in infos)
        {
            a.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        infos = GameObject.FindGameObjectsWithTag("Info Text");
        foreach (GameObject a in infos)
        {
            a.transform.localScale = new Vector3(1, 1, 1);
        }

    }
}
