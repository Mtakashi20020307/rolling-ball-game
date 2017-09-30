using System.Collections;
using UnityEngine;

public class GoalController : MonoBehaviour 
{

	public UIController UIController;
	public UIControllervol3 UIControllervol3;

	private void OnTriggerEnter (Collider hit)
	{
		
		if (hit.CompareTag ("Player")) 
		{
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			UIController.ShowGameClearLabel();

			UIControllervol3.ShowRetry ();
		}
	}
}
