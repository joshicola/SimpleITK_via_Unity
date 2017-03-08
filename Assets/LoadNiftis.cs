using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using itk.simple;

public class LoadNiftis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Image input = SimpleITK.ReadImage ("/home/josher/UnityProjects/Read_Niftis/Assets/Ax_SWI.nii.gz");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
