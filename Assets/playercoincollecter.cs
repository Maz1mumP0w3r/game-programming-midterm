using UnityEngine;

public class playercoincollecter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int coinsToWin = 3; 
    private int coinsCollected = 0;
    
   
    public GameObject winScreen; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
    
        {

              coinsCollected++;
              Destroy(other.gameObject);
              CheckWinCondition();
              

        }
    }

    // Update is called once per frame
    void CheckWinCondition()
    {
         if (coinsCollected >= coinsToWin)
    
       {
             Debug.Log("You Win!");
             if (winScreen != null)
             

                winScreen.SetActive(true);
             }
       }
    }

