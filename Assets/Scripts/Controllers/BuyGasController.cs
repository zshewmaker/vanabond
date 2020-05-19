using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
	public class BuyGasController : MonoBehaviour
	{
		public Button BuyGasButton;
		public Text MoneyText;
		public MoneyComponent MoneyComponent;
		public Text GasText;
		public GasComponent GasComponent;

		void Start()
		{
			BuyGasButton.onClick.AddListener(OnBuyGas);
		}

		void OnBuyGas()
		{
			if (MoneyComponent.Amount <= 0)
			{
				return;
			}

			var money = --MoneyComponent.Amount;
			MoneyText.text = money.ToString();
			var gas = ++GasComponent.Amount;
			GasText.text = gas.ToString();
		}
	}
}
