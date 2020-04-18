using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBoard : MonoBehaviour {
	RefrigtzChessPortable.RefrigtzChessPortableForm t=null;
	// Use this for initialization
	void Start () {
		t = new RefrigtzChessPortable.RefrigtzChessPortableForm ();
		t.Form1_Load ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
