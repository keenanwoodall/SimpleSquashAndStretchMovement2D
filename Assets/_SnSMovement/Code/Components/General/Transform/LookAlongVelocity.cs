using UnityEngine;

public class LookAlongVelocity : MonoBehaviour
{
	public float minVelocity = 0.01f;
	public new Rigidbody2D rigidbody;

	private void Update ()
	{
		if (rigidbody == null)
			return;

		if (rigidbody.velocity.magnitude < minVelocity)
			return;

		var rotation = transform.eulerAngles;

		var angle = Vector2.SignedAngle (Vector2.up, rigidbody.velocity);
		rotation.z = angle;

		transform.eulerAngles = rotation;
	}
}