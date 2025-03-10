using Unity.VisualScripting;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
            thingToFollow.transform.position.x,
            thingToFollow.transform.position.y,
            thingToFollow.transform.position.z - 10
        );
    }
}
