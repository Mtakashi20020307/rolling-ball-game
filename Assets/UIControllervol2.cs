using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIControllervol2 : MonoBehaviour 
{
	public Text GameOverLabel;

	// Use this for initialization
	private void Start () 
	{
		
		GameOverLabel.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	public void ShowGameOverLabel() 
	{
		
		GameOverLabel.gameObject.SetActive (true);


	}
}
