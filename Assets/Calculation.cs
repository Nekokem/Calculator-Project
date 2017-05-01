using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculation : MonoBehaviour {

	public InputField numInput1;
	public InputField numInput2;
	public InputField output;
	public Text ranNum;
	public Text winText;
	int number;
	private static int count = 4;

	public void CalcProduct () 
	{
		float CalculationTotal;

		CalculationTotal = float.Parse (numInput1.text) + float.Parse (numInput2.text);

		output.text = CalculationTotal.ToString ();

	}

	public void CalcSubtract () 
	{
		float CalculationTotal;

		CalculationTotal = float.Parse (numInput1.text) - float.Parse (numInput2.text);

		output.text = CalculationTotal.ToString ();

	}

	public void CalcMulti () 
	{
		float CalculationTotal;

		CalculationTotal = float.Parse (numInput1.text) * float.Parse (numInput2.text);

		output.text = CalculationTotal.ToString ();

	}

	public void CalcDivide () 
	{
		float CalculationTotal;

		CalculationTotal = float.Parse (numInput1.text) / float.Parse (numInput2.text);

		output.text = CalculationTotal.ToString ();

	}
		
	void Start () 
	{
		number = Random.Range (1, 9);

		ranNum.text += number.ToString ();
		
		winText.text = "";
	}

	void Update()
	{
		if (output.text == ranNum.text && !ranNum.IsDestroyed())
   	 	{
			Destroy(ranNum);
			count = count - 1;
    	}

		if (count == 0)
		{
			winText.text = "You Win!";
		}
	}


}