function Start()
{
}
 
function Update ()
{
    if (Input.GetKey(KeyCode.End))
    {
        var cs = GameObject.Find("TextVoice");
        var script = cs.GetComponent("TestVoice");
        script.saySpeech("Hello world! How are you doing today?");
    }
    
}
 
function printTestJS()
{
    Debug.Log("Inside JS");
}