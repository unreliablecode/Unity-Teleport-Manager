using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    [Header("GameObject Settings")]
    public GameObject targetObject;

    [Header("Position")]
    public Vector3 newPosition = Vector3.zero;

    [Header("Rotation (Euler Angles)")]
    public Vector3 newRotationEuler = Vector3.zero;

    [Header("Rotation (Quaternion)")]
    public Quaternion newRotationQuaternion = Quaternion.identity;

    [Header("Scale")]
    public Vector3 newScale = Vector3.one;

    [Header("Gravity")]
    public float newGravityScale = -9.81f;

    [Header("Time Scale")]
    public float newTimeScale = 1.0f;

    [Header("Rigidbody")]
    public bool addRigidbody = false;

    private void OnGUI()
    {
        GUILayout.Label("Teleport Manager Controls");

        // Check if the target object is assigned
        if (targetObject == null)
        {
            GUILayout.Label("Please assign a target GameObject.");
            return;
        }

        // Teleport Position
        GUILayout.Label("Teleport Position:");
        newPosition.x = float.Parse(GUILayout.TextField(newPosition.x.ToString()));
        newPosition.y = float.Parse(GUILayout.TextField(newPosition.y.ToString()));
        newPosition.z = float.Parse(GUILayout.TextField(newPosition.z.ToString()));
        if (GUILayout.Button("Teleport Position"))
        {
            TeleportPosition(targetObject, newPosition);
        }

        // Teleport Rotation (Euler Angles)
        GUILayout.Label("Teleport Rotation (Euler):");
        newRotationEuler.x = float.Parse(GUILayout.TextField(newRotationEuler.x.ToString()));
        newRotationEuler.y = float.Parse(GUILayout.TextField(newRotationEuler.y.ToString()));
        newRotationEuler.z = float.Parse(GUILayout.TextField(newRotationEuler.z.ToString()));
        if (GUILayout.Button("Teleport Rotation"))
        {
            TeleportRotation(targetObject, newRotationEuler);
        }

        // Teleport Quaternion Rotation
        GUILayout.Label("Teleport Rotation (Quaternion):");
        newRotationQuaternion.x = float.Parse(GUILayout.TextField(newRotationQuaternion.x.ToString()));
        newRotationQuaternion.y = float.Parse(GUILayout.TextField(newRotationQuaternion.y.ToString()));
        newRotationQuaternion.z = float.Parse(GUILayout.TextField(newRotationQuaternion.z.ToString()));
        newRotationQuaternion.w = float.Parse(GUILayout.TextField(newRotationQuaternion.w.ToString()));
        if (GUILayout.Button("Teleport Quaternion"))
        {
            TeleportQuaternion(targetObject, newRotationQuaternion);
        }

        // Change Scale
        GUILayout.Label("Change Scale:");
        newScale.x = float.Parse(GUILayout.TextField(newScale.x.ToString()));
        newScale.y = float.Parse(GUILayout.TextField(newScale.y.ToString()));
        newScale.z = float.Parse(GUILayout.TextField(newScale.z.ToString()));
        if (GUILayout.Button("Change Scale"))
        {
            ChangeScale(targetObject, newScale);
        }

        // Change Gravity
        GUILayout.Label("Change Gravity:");
        newGravityScale = float.Parse(GUILayout.TextField(newGravityScale.ToString()));
        if (GUILayout.Button("Change Gravity"))
        {
            ChangeGravity(targetObject, newGravityScale);
        }

        // Change Time Scale
        GUILayout.Label("Change Time Scale:");
        newTimeScale = float.Parse(GUILayout.TextField(newTimeScale.ToString()));
        if (GUILayout.Button("Change Time Scale"))
        {
            ChangeTimeScale(newTimeScale);
        }

        // Add/Remove Rigidbody
        GUILayout.Label("Toggle Rigidbody:");
        addRigidbody = GUILayout.Toggle(addRigidbody, "Add Rigidbody");
        if (GUILayout.Button(addRigidbody ? "Add Rigidbody" : "Remove Rigidbody"))
        {
            ToggleRigidbody(targetObject, addRigidbody);
        }
    }

    // Teleport methods
    private void TeleportPosition(GameObject obj, Vector3 position)
    {
        obj.transform.position = position;
    }

    private void TeleportRotation(GameObject obj, Vector3 eulerAngles)
    {
        obj.transform.rotation = Quaternion.Euler(eulerAngles);
    }

    private void TeleportQuaternion(GameObject obj, Quaternion rotation)
    {
        obj.transform.rotation = rotation;
    }

    private void ChangeScale(GameObject obj, Vector3 scale)
    {
        obj.transform.localScale = scale;
    }

    private void ChangeGravity(GameObject obj, float gravityScale)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = true;
            Physics.gravity = new Vector3(0, gravityScale, 0);
        }
    }

    private void ChangeTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    private void ToggleRigidbody(GameObject obj, bool addRigidbody)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();

        if (addRigidbody && rb == null)
        {
            rb = obj.AddComponent<Rigidbody>();
        }
        else if (!addRigidbody && rb != null)
        {
            Destroy(rb);
        }
    }
}
