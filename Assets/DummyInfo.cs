using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DummyInfo : MonoBehaviour {
    string paths = "Assets/Resources/Info/" + Dummy.dummyName + ".txt";

    // Use this for initialization
    void Start () {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        ReadString();
    }

    void ReadString()
    {
        gameObject.GetComponentInChildren<Text>().text = Read(Dummy.dummyName);
    }

    public static string Read(string filename)
    {
        //Load the text file using Reources.Load
        TextAsset theTextFile = Resources.Load<TextAsset>(filename);

        //There's a text file named filename, lets get it's contents and return it
        if (theTextFile != null)
            return theTextFile.text;

        //There's no file, return an empty string.
        return string.Empty;
    }

    // Update is called once per frame
    void Update () {
        ReadString();


    }


}
