using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{

    public TMP_Text TMtext;
    public int healthCounter = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthCounter = 5;
        TMtext = GetComponent<TMP_Text>();
        TMtext.text = "5" + healthCounter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        healthCounter--;
        TMtext.text = "Health:" + healthCounter;
    }
}
