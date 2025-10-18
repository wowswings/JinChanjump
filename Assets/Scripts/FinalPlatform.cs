using UnityEngine;

public class FinalPlatform : MonoBehaviour
{
    private bool triggered = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!triggered && collision.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("🏁 Победа! Переход к следующей сцене!");
        }
    }
}
