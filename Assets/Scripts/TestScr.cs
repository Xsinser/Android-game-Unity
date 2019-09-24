using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestScr : MonoBehaviour {

    GameObject objct = GameObject.Find("Cube");
    
    public void Change(int i, Material[] mater, Text txt)
    {
        switch (i)
        {
            case 10:
                objct.GetComponent<Renderer>().material = mater[1];
                break;
            case 35:
                objct.GetComponent<Renderer>().material = mater[2];
                break;
            case 95:
                objct.GetComponent<Renderer>().material = mater[3];
                break;
            case 153:
                objct.GetComponent<Renderer>().material = mater[4];
                break;
            case 210:
                objct.GetComponent<Renderer>().material = mater[5];
                break;
            case 290:
                objct.GetComponent<Renderer>().material = mater[6];
                break;
            case 350:
                objct.GetComponent<Renderer>().material = mater[7];
                break;
            case 480:
                objct.GetComponent<Renderer>().material = mater[8];
                break;
            case 730:
                objct.GetComponent<Renderer>().material = mater[9];
                break;
            case 901:
                objct.GetComponent<Renderer>().material = mater[10];
                break;
            case 1200:
                objct.GetComponent<Renderer>().material = mater[11];
                break;
        }
        txt.text = "Age: " + i.ToString();
        if (i>=1200)
        {
            objct.GetComponent<Renderer>().material = mater[11];
        }
        if((i<1200)&&(i>900))
        {
            objct.GetComponent<Renderer>().material = mater[10];
        }

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
