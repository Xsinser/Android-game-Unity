using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Unity;
using System.IO;
using System.Text;
using System;
using UnityEngine.UI;
public class ClickScript : MonoBehaviour, IPointerClickHandler {    
    private int i = 0;
    public Material[] mater;
    public Text txt;
    public void OnPointerClick(PointerEventData eventData)
    {
        i++;
     
        using (StreamWriter sw = new StreamWriter(Application.persistentDataPath+"/sv.txt", false, System.Text.Encoding.Default))
        {
            sw.WriteLine(i);
        }
        Debug.Log(i);
        TestScr a = new TestScr();
        a.Change(i, mater, txt);

        // TestScr a = new TestScr();
        //    a.Change(i); 
        //   this.renderer.material;
        //  GameObject.renderer.material = GameObject.GetComponent<Script>().newMaterial;

    }
    public void Click()
    {
        Debug.Log("Clik");
    }
    // Use this for initialization
    void Start () {
        if (File.Exists(Application.persistentDataPath + "/sv.txt"))
        {
            using (StreamReader sw = new StreamReader(Application.persistentDataPath + "/sv.txt", System.Text.Encoding.Default))
            {
                i = Convert.ToInt16(sw.ReadLine());
                TestScr a = new TestScr();
                a.Change(i, mater,txt);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
