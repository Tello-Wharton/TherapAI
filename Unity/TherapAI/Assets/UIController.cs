using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

	public Text outtext;
	public Text intext;

	public void ReadText(){
		//intext.text;
		//use the above variable in the method that is used to get read text
	}
	public void WriteToScreen(string words){
		outtext.text = words;
	}

}
