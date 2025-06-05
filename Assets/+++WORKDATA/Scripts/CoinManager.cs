using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int coinCounter = 0;
    [SerializeField] private UI_Manager ManagerUI;

    public void AddCoin()
    {
        coinCounter++;
        ManagerUI.UpdateTextCoinCount(coinCounter);
    }
}
