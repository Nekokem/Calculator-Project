using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnPointerClickInput : MonoBehaviour {

	public InputField display;
	public InputField startdisplay;


	public static List <InputField> Inputs = new List<InputField>();

	void Start () 
	{
	
		if (Inputs.Count == 0) 
		{
			Inputs.Add (startdisplay);

		}

	}

	public void OnPointerClick() 
	{
		
		
		if (Inputs.Count > 0) 
		{
			Inputs.Remove (Inputs [0]);
			Inputs.Add (display);
		} 
		else 
		{
			Inputs.Add (display);
		}
	}
}


