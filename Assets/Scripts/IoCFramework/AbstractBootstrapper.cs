using IoCFramework;
using IoCFramework.Extensions;
using IoCFramework.Interfaces;
using UnityEngine;

public abstract class AbstractBootstrapper : MonoBehaviour
{
    private void Awake()
    {
        var container = new Unity3dIoCContainer();

        container.SetSingletonGameObject(this.gameObject.name);
        MonobehaviourExtensions.SetDependencyInjector(container);
        this.Configure(container);
    }

    protected abstract void Configure(IIoCContainer container);
}
