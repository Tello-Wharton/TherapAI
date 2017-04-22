using UnityEngine;
using System.Collections;
 
public class CSharp : MonoBehaviour
{  

	public GameObject jj;

    void Start ()
    {
    }
   
    void Update ()
    {
        if (Input.GetKey(KeyCode.Home))
        {
           
            if (jj == null)
            {
                Debug.Log("Error, null JavaScript Component");
            }
            else
	        {
	           //(jj.GetComponent(typeof(JavaS)) as JavaS).printTestJS();
	        }
            
        }
    }
   
    public void printTestCS()
    {
       
        Debug.Log("Inside C#");
    }


}