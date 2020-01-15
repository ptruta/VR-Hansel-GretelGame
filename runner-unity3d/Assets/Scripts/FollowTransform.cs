using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform[] transformObject = new Transform[2];
	public int axis;

	private void Update()
	{
		Vector3 newPosition;
		
		if (GameManager.difficulty == 1){
			newPosition = transform.position;
			newPosition[axis] = transformObject[1].position[axis];
			transform.position = newPosition;
		}

		if (GameManager.difficulty == 2){
			newPosition = transform.position;
			newPosition[axis] = transformObject[0].position[axis];
			transform.position = newPosition;
		}

		if (GameManager.difficulty == 3){
			newPosition = transform.position;
			newPosition[axis] = transformObject[1].position[axis];
			transform.position = newPosition;
		}
	}
}
