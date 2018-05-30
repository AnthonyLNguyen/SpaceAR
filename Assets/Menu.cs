using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    // Use this for initialization
    void Start() {
        gameObject.SetActive(false);
    }

    public void toggle(){
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
