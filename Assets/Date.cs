using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Date : MonoBehaviour {
    private DateTime now = DateTime.Now;
    public PlanetLocation p;
    public GameObject pl;
    private Boolean timelapse = false;
    // Use this for initialization
    void Start () {
        p = pl.GetComponent<PlanetLocation>();
        GetComponent<UnityEngine.UI.Text>().text = now.ToString();
        InvokeRepeating("TimeLapse", 0f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
        if (timelapse == false)
        {
            GetComponent<UnityEngine.UI.Text>().text = DateTime.Now.ToString();
        }
    }
    void TimeLapse()
    {
        if (timelapse == true)
        {
            print("running");
            now = now.AddDays(2);
            GetComponent<UnityEngine.UI.Text>().text = now.ToString();
            double time = now.Subtract(new DateTime(2000, 1, 1, 12, 0, 0)).TotalSeconds / (60 * 60 * 24 * 365.25 * 100);

            for (int i = 0; i < 9; i++)
            {
                Vector3 earth = p.GetPlanetLocation(2, time);
                Vector3 pos = p.GetPlanetLocation(i, time) - earth;
                p.planets[i].transform.position = pos.normalized * 6;
                print(p.planets[i].transform.position);
            }
        }
        else
        {
            TimeLapseStop();
        }
    }

    void TimeLapseStop()
    {
        now = DateTime.Now;
        double time = now.Subtract(new DateTime(2000, 1, 1, 12, 0, 0)).TotalSeconds / (60 * 60 * 24 * 365.25 * 100);
        for (int i = 0; i < 9; i++)
        {
            Vector3 earth = p.GetPlanetLocation(2, time);
            Vector3 pos = p.GetPlanetLocation(i, time) - earth;
            p.planets[i].transform.position = pos.normalized * 6;
            print(p.planets[i].transform.position);
        }
        timelapse = false;
    }

    public void TimeLapseStart()
    {
        if (timelapse)
        {
            timelapse = false;
        }
        else
        {
            timelapse = true;
        }
    }
}
