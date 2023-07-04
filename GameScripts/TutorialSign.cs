using UnityEngine;

public class TutorialSign : MonoBehaviour
{
    public GameObject tutorialText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        tutorialText.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        tutorialText.SetActive(false);
    }
}
