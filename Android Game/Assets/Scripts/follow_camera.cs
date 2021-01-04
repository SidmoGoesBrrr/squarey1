using UnityEngine;

public class follow_camera : MonoBehaviour{
	public Transform playerboii;
	public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
       transform.position=playerboii.position + offset;

    }
    
}
 