using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Transform.Rotate example
//
// This script creates two different cubes: one red which is rotated using Space.Self; one green which is rotated using Space.World.
// Add it onto any GameObject in a scene and hit play to see it run. The rotation is controlled using xAngle, yAngle and zAngle, modifiable on the inspector.

public class SphereRotation : MonoBehaviour
{
    int _rotationSpeed = 15;

    void Update () {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
}