using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    GameObject objBlock = null;
    GameObject objBlack = null;
    System.Random ro = new System.Random();
    // Use this for initialization

    List<Color> lColor = new List<Color>();
    void Start()
    {
        lColor.Add(Color.red);
        lColor.Add(Color.green);
        lColor.Add(Color.blue);
        lColor.Add(Color.cyan);
        lColor.Add(Color.magenta);

        objBlock = GameObject.Find("Block");
        objBlock.transform.localScale = new Vector3(0.92f, 0.92f, 0.92f);
        objBlock.SetActive(false);

        objBlack = GameObject.Find("Black");
        objBlack.SetActive(false);
		

        //for (int i=0; i<10; i++)
        //{
        //    for (int j = 0; j < 15; j++)
        //    {
        //        GameObject obj = GameObject.Instantiate(objBlack, objBlack.transform.parent);

        //        obj.GetComponent<RectTransform>().position = new Vector3((i*100)+40, (j*100+40), 0f);
        //        obj.SetActive(true);
        //    }
        //}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
