using UnityEngine;
using UnityEngine.UI;

public class ResourceDebugPanelComponent : MonoBehaviour
{
	public string ResourceKey;
	public VanComponent VanComponent;

	public Text Label;
	public Text Value;

	void Start()
	{
		if (VanComponent == null) return;

		VanComponent.OnResourceChange += HandleResourceChange;
		var resource = VanComponent.GetResource(ResourceKey);
		Label.text = resource?.DisplayText;
		Value.text = resource?.Value.ToString();
	}

	private void HandleResourceChange(Resource resource, VanContext context)
	{
		if (resource.Key != ResourceKey) return;
		
		Value.text = resource?.Value.ToString();
	}
}
