using UnityEngine;

public class ForceRotationIdentity : MonoBehaviour
{
	private void Update ()
	{
		transform.rotation = Quaternion.identity;
	}
}