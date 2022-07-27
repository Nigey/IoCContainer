using UnityEngine;

namespace ExampleUsage
{
    public class Rotator : MonoBehaviour, IRotator
    {
        public void Rotate()
        {
            transform.Rotate(Vector3.left * 100, Space.World);
        }
    }
}
