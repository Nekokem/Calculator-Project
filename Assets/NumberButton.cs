using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NumberButton : MonoBehaviour {

	public InputField display;
	public InputField display2;

	public void AddNumberToDisplay (float number) 
	{

		if (display == OnPointerClickInput.Inputs [0]) {
			display.text += number.ToString ();

		} 

		else if (display2 == OnPointerClickInput.Inputs [0])
		{
			display2.text += number.ToString ();

		}
	}

}
