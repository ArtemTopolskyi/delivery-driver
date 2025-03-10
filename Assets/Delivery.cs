using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float delayBeforeHidingPickedPackage = 0.5f;
    bool hasPickedPackage = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Package") && !hasPickedPackage) {
            Debug.Log("Picked up the package");

            hasPickedPackage = true;

            Debug.Log($"Destroying {collider.gameObject.name} after {delayBeforeHidingPickedPackage} seconds.");

            Destroy(collider.gameObject, delayBeforeHidingPickedPackage);
        }

        if (collider.CompareTag("Customer") && hasPickedPackage) {
            Debug.Log("Delivered to customer");

            hasPickedPackage = false;
        }
    }
}
