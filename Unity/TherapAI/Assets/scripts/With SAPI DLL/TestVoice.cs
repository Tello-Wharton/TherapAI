﻿// **************************************************************************
// Unity Text To Speech V2 ZJP. Test Voice
// **************************************************************************
using UnityEngine;

public class TestVoice : MonoBehaviour
{
	public int voiceOk;
	public int numVoice;
	public string voiceName;
	public VoiceManager vm;
	
	public string textesay;
	
	void Start ()
	{
		vm = GameObject.Find("VoiceManager").GetComponent<VoiceManager>();
		numVoice  = vm.VoiceNumber;
		voiceName = vm.VoiceNames[0];
		Debug.Log("Voice number " + vm.VoiceNumber);
		textesay = "<voice required='Name=Microsoft Helena Desktop'> Hola Luis";
		vm.Say (textesay);
		// textesay = "<voice required='" + voiceName + "'>" + sayThisText;
		// textesay = "<voice required='" + vm.VoiceNames[i] + "'>" + sayThisText;
        //textesay = "<voice required='Name=Microsoft Helena Desktop'> Hola Luis";
		//vm.Say(textesay); // start a speech
		//vm.SayEX("c:/text.txt",12);
		//vm.SayEX("Ella. But is that your real name?", 1+8);
		//vm.SayEX("<voice required='Name=" + voiceName + "'>" + "Hello, this is the voice 2", 1+8+32);
		//vm.SayEX("Funny, it's the voice 2 again", 1+8);
	}
	// Update is called once per frame
	void Update ()
	{
		if (vm.Status(0) == 2 ) // a speech is running
		{
			Debug.Log(" Total Stream  > " + vm.Status(2));
			Debug.Log(" Actual stream <<<<<<<<<<<<<<<<<<<<<<<<<<<<<> " + vm.Status(3));
			Debug.Log(" Position of the actual spoken word in the actual stream > " + vm.Status(1));
		}
	}

	// Test function to check that speech works
	void speechTest () {
		vm.SayEX("Hello, I have now become a human being", 1+8);
	}

	// Input string for conversion to text to speech - Callable from JavaS script
	void saySpeech(string textToSay) {
		vm.SayEX(textToSay, 1+8+32);
	}
	
}
