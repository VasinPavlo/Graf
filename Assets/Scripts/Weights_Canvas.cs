﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Weights_Canvas : MonoBehaviour {
	public Transform LeftConer;
	public Transform RightConer;
	public GameObject inputField;
	public Vector3 ownPos;
	public int weight;

	private Text text;
	void Awake()
	{
		text = GetComponentInChildren<Text> ();
		setEdit(true);
	}
	void LateUpdate () 
	{
		if(LeftConer!=null&&RightConer!=null)
		{
			transform.position = ownPos + LeftConer.position + (RightConer.position - LeftConer.position) / 2;
		}
		if (text.text != "")
			weight = Convert.ToInt32 (text.text);
		else 
			weight = 0;
	}
	public void setEdit(bool b)
	{
		//print ("setEdit:" + b);
		if (inputField != null)
			inputField.SetActive (b);
	}
}