using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 150;
    [SerializeField] float moveSpeed = 10;

   void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        int steerMultiplier = moveAmount < 0
            ? 1
            : -1;

        transform.Rotate(0, 0, steerMultiplier * steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
