using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{

	public Text GameClearLabel;

	// Use this for initialization
	private void Start () 
	{

		GameClearLabel.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	public void ShowGameClearLabel () 
	{

		GameClearLabel.gameObject.SetActive (true);

	}
}
