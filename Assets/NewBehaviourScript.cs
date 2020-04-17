using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	RefrigtzChessPortable.RefrigtzChessPortableForm t=null;
	int Order=1;
	// Use this for initialization
	void Start () {
		t = new RefrigtzChessPortable.RefrigtzChessPortableForm ();
		t.Form1_Load();
	}
	
	// Update is called once per frame
	void Update () {
		if (Order == 1) {
			Order = -1;
		} else 
			if(Order==-1)
		{
			t.Play (-1, -1);
			Order = 1;
		}
	}
}
