using System;
using System.Linq;
using UnityEngine;

public class VanComponent : MonoBehaviour
{
    public VanContext Context;
    public Resource[] Resources;

    public delegate void ResourceChangeAction(Resource resource, VanContext context);
    public static event ResourceChangeAction OnResourceChange;

    void Start()
    {
    }

    void Update()
    {
    }

    public Resource GetResource(string key)
    {
        return Resources.FirstOrDefault(x => x.Key == key);
    }

    public void IncreaseResource(string key, float amount)
    {
        AdjustResource(key, resource => Math.Min(resource.MaxValue, resource.Value + amount));
    }

    public void DecreaseResource(string key, float amount)
    {
        AdjustResource(key, resource => Math.Max(0, resource.Value - amount));
    }

    public void AdjustResource(string key, Func<Resource, float> fn)
    {
        var resource = Resources.FirstOrDefault(x => x.Key == key);
        if (resource == null) return;

        resource.Value =fn(resource);
        if (OnResourceChange == null) return;

        OnResourceChange(resource, Context);
    }
}