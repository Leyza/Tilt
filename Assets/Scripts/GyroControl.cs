using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private Vector3 initialAngles;
    private float previousAngleX;
    private float previousAngleZ;
    private float angleX;
    private float angleZ;

    private void Start()
    {
        gyroEnabled = EnabledGyro();

        if (gyroEnabled)
        {
            initialAngles = gyro.attitude.eulerAngles;
            previousAngleX = initialAngles.x;
            previousAngleZ = initialAngles.y;
        }
    }

    private bool EnabledGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }

        return false;
    }

    private void Update()
    {
        if (gyroEnabled)
        {
            angleX = gyro.attitude.eulerAngles.x - initialAngles.x;
            angleZ = gyro.attitude.eulerAngles.y - initialAngles.y;
            if (angleX > 20 && angleX < 340)
            {
                angleX = previousAngleX;
            }
            else
            {
                previousAngleX = angleX;
            }
            if (angleZ > 20 && angleZ < 340)
            {
                angleZ = previousAngleZ;
            }
            else
            {
                previousAngleZ = angleZ;
            }

            transform.eulerAngles = new Vector3(-angleX, 0f, -angleZ);
        }
    }
}
