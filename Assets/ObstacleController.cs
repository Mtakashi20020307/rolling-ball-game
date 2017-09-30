using System.Collections;
using UnityEngine;

public class ObstacleController : MonoBehaviour 
{
	public UIControllervol2 UIControllervol2;

	private void OnTriggerEnter (Collider hit)
	{

		if (hit.CompareTag ("Player")) 
		{

			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;

			UIControllervol2.ShowGameOverLabel ();
		}
	}
}
