using UnityEngine;

public class MovingSphere : MonoBehaviour {
    [SerializeField, Range(0f, 100f)]
	 float maxSpeed = 10f;
	void Update () {
        
		Vector2 playerInput;
        /*
        Get Input axis for movement
        */
		playerInput.x = Input.GetAxis("Horizontal");
		playerInput.y = Input.GetAxis("Vertical");
       // playerInput.Normalize();
        playerInput= Vector2.ClampMagnitude(playerInput, 1f);

        //BASIC FORMULA Vitesse = Distance * Temps
				Vector3 velocity =
			new Vector3(playerInput.x, 0f, playerInput.y) * maxSpeed;
		Vector3 displacement = velocity * Time.deltaTime;
		transform.localPosition += displacement;
	}
}