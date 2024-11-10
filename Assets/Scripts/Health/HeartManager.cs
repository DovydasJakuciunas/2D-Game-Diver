using System.Collections.Generic;
using UnityEngine;

public class HeartManger : MonoBehaviour
{
    public GameObject heartPreFab;
    public HealthSystem playerHeart;

    List<HealthHeart> hearts = new List<HealthHeart>();

    private void OnEnable()
    {
        HealthSystem.OnPlayerDamaged += DrawHearts;
        HealthSystem.OnPlayerHeal += DrawHearts;
    }

    private void OnDisable()
    {
        HealthSystem.OnPlayerDamaged -= DrawHearts;
        HealthSystem.OnPlayerHeal -= DrawHearts;
    }

    private void Start()
    {
        DrawHearts();
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPreFab); //Instatiating Prefab
        newHeart.transform.SetParent(transform);        //Setting Parent

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();      
        heartComponent.SetHeartImage(HeartStatus.Empty);    //  To be empty every time
        hearts.Add(heartComponent); //To add into list
    }
   
    public void DrawHearts()
    {
        ClearHearts();

        float maxHealthRemainder = playerHeart.getMaxHealth() % 2; //Ccking if max health is odd or even
        int heartsToMake = (int)((playerHeart.getMaxHealth() / 2) + maxHealthRemainder);
        for (int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        for(int i = 0; i< hearts.Count; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(playerHeart.getHealth() - (i * 2), 0, 2); //What is the heart satatus
            hearts[i].SetHeartImage((HeartStatus)heartStatusRemainder);
        }
    }

    public void ClearHearts()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HealthHeart>();
    }

    
}
