using UnityEngine;
using UnityEngine.UI;

public class CharackterStats : MonoBehaviour
{
    //UI
   public Image[] hearts;


    //STATS

    public int helath = 5;
    int maxHealth = 5;

    public void Damage(int amount)
    {
        hearts[helath - 1].enabled = false;
        helath -= amount;
    }

    public void Regen(int amount)
    {
        helath += amount;

        for (int i = 0; i < helath; i++)
        {
            hearts[i].enabled = true;
        }
    }

    private void Update()
    {
        if (helath>maxHealth)
        {
            helath = maxHealth;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (helath>0)
            {
                Damage(1);
            }
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            if (helath < maxHealth)
            {
                Regen(1);
            }
        }
    }
}
