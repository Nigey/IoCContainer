using System;
using ExampleUsage;
using IoCFramework.Attributes;
using IoCFramework.Extensions;
using UnityEngine;

public class RotateableObject : MonoBehaviour
{
    [Dependency] public IRotator Rotator { get; set; }

    private void Awake()
    {
        this.Inject();
    }

    private void Update()
    {
        Rotator.Rotate();
    }
}
