using UnityEngine;

public class CreditsRoll : MonoBehaviour
{
    public float scrollSpeed = 20f;  // Velocidade de rolagem do texto

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // Mover o texto para cima
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);
    }
}

