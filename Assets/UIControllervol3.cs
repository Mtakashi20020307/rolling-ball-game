using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControllervol3 : MonoBehaviour 
{
	public Button Retry;

	private void Start () 
	{
		
		Retry.gameObject.SetActive (false);

		Retry.onClick.AddListener (Restart);
	}

	void Restart ()
	{
		SceneManager.LoadScene (0);
	}
	public void ShowRetry () 
	{
		
		Retry.gameObject.SetActive (true);
	}
}
