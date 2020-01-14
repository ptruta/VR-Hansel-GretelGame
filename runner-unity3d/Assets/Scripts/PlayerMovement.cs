using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float force = 200f;

	private void FixedUpdate()
	{
		Rigidbody player;
		Rigidbody player1;

		player = GetComponent<Rigidbody>();
		player1 = GetComponent<Rigidbody>();

		// Move player on the Z axis (sideways)
		if (player)
		{
			if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			{
				player.AddForce(force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
			}
		
			if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
			{
				player.AddForce(-force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
			}
		}else {
			if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			{
				player1.AddForce(force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
			}
		
			if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
			{
				player1.AddForce(-force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
			}
		}
	}
}
