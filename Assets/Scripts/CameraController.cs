using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform target;
	private Vector3 newPosition;

	void FixedUpdate()
	{
		newPosition = target.position;
		newPosition.z = -10;
		transform.position = newPosition;
	}
}
