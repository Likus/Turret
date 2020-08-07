using UnityEngine;

public class ShootInput : MonoBehaviour
{
    public SImplePhysicShooter[] guns;

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            foreach(var gun in guns)
            {
                gun.Shoot();
            }
        }
    }
}
