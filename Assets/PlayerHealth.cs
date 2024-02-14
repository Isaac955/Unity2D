using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Vie maximale du joueur
    private int currentHealth; // Vie actuelle du joueur
    public Text healthText; // Référence au texte d'affichage de la vie du joueur

    void Start()
    {
        currentHealth = maxHealth; // Définir la santé actuelle sur la santé maximale au début
        UpdateHealthUI(); // Mettre à jour l'interface utilisateur de la santé
    }

    // Fonction pour infliger des dégâts au joueur
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Réduire la santé actuelle du joueur
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Assurer que la santé actuelle reste entre 0 et maxHealth
        UpdateHealthUI(); // Mettre à jour l'interface utilisateur de la santé

        if (currentHealth <= 0)
        {
            Die(); // Appeler la fonction de mort si la santé du joueur atteint zéro ou moins
        }
    }

    // Fonction pour guérir le joueur
    public void Heal(int healAmount)
    {
        currentHealth += healAmount; // Augmenter la santé actuelle du joueur
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Assurer que la santé actuelle reste entre 0 et maxHealth
        UpdateHealthUI(); // Mettre à jour l'interface utilisateur de la santé
    }

    // Fonction pour mettre à jour l'interface utilisateur de la santé
    void UpdateHealthUI()
    {
        healthText.text = "Health: " + currentHealth.ToString(); // Mettre à jour le texte d'affichage de la santé avec la valeur actuelle de la santé
    }

    // Fonction pour gérer la mort du joueur
    void Die()
    {
        Debug.Log("Player is dead!"); // Afficher un message de débogage pour indiquer que le joueur est mort
        // Vous pouvez ajouter ici le code pour gérer la mort du joueur, comme le redémarrage du niveau ou l'affichage d'un écran de fin de jeu
    }
}
