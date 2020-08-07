using UnityEngine;

public class VerticalRotateInput : MonoBehaviour
{
    public Transform[] rotatedObjects;

    public float rotateSpeed;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            foreach (var rotated in rotatedObjects)
            {
                rotated.Rotate(Vector3.left * rotateSpeed * Time.fixedDeltaTime);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            foreach (var rotated in rotatedObjects)
            {
                rotated.Rotate(Vector3.right * rotateSpeed * Time.fixedDeltaTime);
            }
        }
    }
}
