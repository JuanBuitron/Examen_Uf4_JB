using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int Coins = 0;
    public TextMeshProUGUI CoinsText;
    public Image[] Items;
    // Start is called before the first frame update
    private void Awake() 
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this )
        Destroy(gameObject);
        else 
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);

        CoinsText.text="Coins:"+Coins;
        }



        
    }
    

    // Update is called once per frame
    public void CoinCollected()
    {
        Coins++;
    }
    public void ItemCollected(Sprite sprite, int id)
    {
        Items[id].sprite = sprite;
    }
    public void GetItem(Sprite sprite, int id)
    {
        Items[id].sprite = sprite;
    }
}
