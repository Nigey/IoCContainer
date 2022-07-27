using IoCFramework.Interfaces;
using UnityEngine;

namespace ExampleUsage
{
    public class Bootstrapper : AbstractBootstrapper
    {
        [SerializeField] private Rotator rotator;
        
        protected override void Configure(IIoCContainer container)
        {
            container.RegisterSingleton<IRotator>(rotator);
        }
    }
}