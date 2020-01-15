using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform transformObject;
	public Transform transformObject1;
	public int axis;

	private void Update()
	{
		Vector3 newPosition;
		
		newPosition = transform.position;
		newPosition[axis] = transformObject.position[axis];
		newPosition[axis] = transformObject1.position[axis];

		transform.position = newPosition;
	}
}
