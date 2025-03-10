using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 driverWithPackageColor = new Color32(255, 0, 0, 255);
    [SerializeField] Color32 driverWithoutPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] float delayBeforeHidingPickedPackage = 0.5f;
    bool hasPickedPackage = false;

    SpriteRenderer driverSpriteRenderer;

    void Start()
    {
        driverSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Package") && !hasPickedPackage) {
            Debug.Log("Picked up the package");

            hasPickedPackage = true;

            driverSpriteRenderer.color = driverWithPackageColor;

            Debug.Log($"Destroying {collider.gameObject.name} after {delayBeforeHidingPickedPackage} seconds.");

            Destroy(collider.gameObject, delayBeforeHidingPickedPackage);
        }

        if (collider.CompareTag("Customer") && hasPickedPackage) {
            Debug.Log("Delivered to customer");

            hasPickedPackage = false;

            driverSpriteRenderer.color = driverWithoutPackageColor;
        }
    }
}
