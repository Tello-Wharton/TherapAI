function Start()
{
}
 
function Update ()
{
	// When end key is pressed get the TestVoice 
    if (Input.GetKey(KeyCode.End))
    {
        var cs = GameObject.Find("TextVoice");
        var script = cs.GetComponent("TestVoice");
        // Script object is the TestVoice script, and can then be used to call functions
        script.saySpeech("Hello world! How are you doing today?");
    }
    
}
 
function printTestJS()
{
    Debug.Log("Inside JS");
}