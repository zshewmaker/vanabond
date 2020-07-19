using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
	public class MakeMoneyController : MonoBehaviour
	{
		public Button MakeMoneyButton;
		public VanComponent Van;

		void Start()
		{
			MakeMoneyButton.onClick.AddListener(() => Van.IncreaseResource("money", 1));
		}
	}
}
