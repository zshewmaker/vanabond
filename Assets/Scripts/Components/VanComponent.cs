using System;
using System.Linq;
using UnityEngine;

public class VanComponent : MonoBehaviour
{
	public VanContext Context;
	public Resource[] Resources;

	public delegate void ResourceChangeAction(Resource resource, VanContext context);
	public static event ResourceChangeAction OnResourceChange;

	public Resource GetResource(string key)
	{
		return Resources.FirstOrDefault(x => x.Key == key);
	}

	public void ResetResourcesToDefault()
    {
        foreach (var resource in Resources)
        {
			resource.Value = resource.DefaultValue;
			BroadcastResourceChange(resource);
		}
    }

	public void IncreaseResource(string key, float amount)
	{
		AdjustResource(key, resource => Math.Min(resource.MaxValue, resource.Value + amount));
	}

	public void DecreaseResource(string key, float amount)
	{
		AdjustResource(key, resource => Math.Max(0, resource.Value - amount));
	}

	private void AdjustResource(string key, Func<Resource, float> fn)
	{
		var resource = Resources.FirstOrDefault(x => x.Key == key);
		if (resource == null)
		{
			return;
		}

		resource.Value = fn(resource);
		BroadcastResourceChange(resource);
	}

	private void BroadcastResourceChange(Resource resource)
	{
		if (OnResourceChange == null)
		{
			return;
		}

		OnResourceChange(resource, Context);
	}
}