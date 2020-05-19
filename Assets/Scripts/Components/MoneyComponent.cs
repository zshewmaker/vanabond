using Assets.Scripts.Interfaces;
using UnityEngine;

public class MoneyComponent : MonoBehaviour, IResettable
{
	public int DefaultAmount = 100;
	public int Amount = 100;
	public int MaxAmount = 100;

	public void Reset()
	{
		Amount = DefaultAmount;
	}
}
