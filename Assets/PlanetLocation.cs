using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLocation : MonoBehaviour {

    // Use this for initialization
    void Start () {
        int mercury = 0;
        int venus = 1;
        int mars = 2;
        int jupiter = 3;
        int saturn = 4;
        int uranus = 5;
        int neptune = 6;
        int sun = 7;
        int moon = 8;

        int d = 5;

        double[] elements = {48.3313 + 3.24587E-5 * d, 7.0047 + 5.00E-8 * d, 29.1241 + 1.01444E-5 * d, 0.387098, 0.205635 + 5.59E-10 * d, 168.6562 + 4.0923344368 * d,
                76.6799 + 2.46590E-5 * d, 3.3946 + 2.75E-8 * d, 54.8910 + 1.38374E-5 * d, 0.723330, 0.006773 - 1.302E-9 * d, 48.0052 + 1.6021302244 * d,
                49.5574 + 2.11081E-5 * d, 1.8497 - 1.78E-8 * d, 286.5016 + 2.92961E-5 * d, 1.523688, 0.093405 + 2.516E-9 * d, 18.6021 + 0.5240207766 * d,
                100.4542 + 2.76854E-5 * d, 1.3030 - 1.557E-7 * d, 273.8777 + 1.64505E-5 * d };

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
