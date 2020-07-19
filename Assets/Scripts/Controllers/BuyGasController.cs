using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
	public class BuyGasController : MonoBehaviour
	{
		public Button BuyGasButton;
		public VanComponent Van;

		void Start()
		{
			BuyGasButton.onClick.AddListener(() =>
			{
				Van.DecreaseResource("money", 1);
				Van.IncreaseResource("gas", 1);
			});
		}
	}
}
