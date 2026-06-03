using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    int CoinsCount = 0;
    public TMP_Text CoinsCText;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Coin")
        {
            CoinsCount += 1;
            Destroy(col.gameObject);
            CoinsCText.text = "Coins count: " + CoinsCount.ToString(); 
        }
    }

}
