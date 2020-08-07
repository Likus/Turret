using UnityEngine;

public class HorizontalRotateInput : MonoBehaviour
{
    public Transform rotatedObject;

    public float rotateSpeed;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rotatedObject.Rotate(Vector3.down * rotateSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotatedObject.Rotate(Vector3.up * rotateSpeed * Time.fixedDeltaTime);
        }
    }
}
