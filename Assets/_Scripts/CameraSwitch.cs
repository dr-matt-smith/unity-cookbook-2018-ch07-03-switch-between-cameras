using UnityEngine;
/* ----------------------------------------
 * class to demonstrate how to switch cameras
 * based on keyboard input
 */ 

public class CameraSwitch : MonoBehaviour 
{
	// A list of cameras from the scene
	public Camera[] cameras = new Camera[3];

	// A boolean variable for whether the audiolistener of the selected camera should be enabled or not
	public bool changeAudioListener = true;

	/* ----------------------------------------
	 * At Update, whenever the user presses a key from the 'shorcuts' list,
	 * the SwitchCamera function should be called, and the shortcut, passed.
	 */
	void  Update ()
	{	
		if (Input.GetKeyDown("0"))
		{
			EnableCamera(cameras[0], true);
			EnableCamera(cameras[1], false);
			EnableCamera(cameras[2], false);
		}
		
		if (Input.GetKeyDown("1"))
		{
			EnableCamera(cameras[0], false);
			EnableCamera(cameras[1], true);
			EnableCamera(cameras[2], false);
		}
		
		if (Input.GetKeyDown("2"))
		{
			EnableCamera(cameras[0], false);
			EnableCamera(cameras[1], false);
			EnableCamera(cameras[2], true);
		}
		
	}
	
	private void EnableCamera(Camera cam, bool enabledStatus)
	{
		cam.enabled = enabledStatus;
		
		if(changeAudioListener)			
			cam.GetComponent<AudioListener>().enabled = enabledStatus;
	}
	
}

