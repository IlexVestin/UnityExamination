using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{

    public TMP_Text TMtext;
    public int coinCounter = 7;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCounter = 7;
        TMtext = GetComponent<TMP_Text>();
        TMtext.text = "Coins Left:" + coinCounter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickupCoin()
    {
        coinCounter--;
        TMtext.text = "Coins Left:" + coinCounter;
    }
}
