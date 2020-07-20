using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
	public class BuySuppliesController : MonoBehaviour
	{
		public Button BuySuppliesButton;
		public VanComponent Van;

		void Start()
		{
			BuySuppliesButton.onClick.AddListener(() =>
			{
				Van.DecreaseResource("money", 1);
				Van.IncreaseResource("supplies", 1);
			});
		}
	}
}
