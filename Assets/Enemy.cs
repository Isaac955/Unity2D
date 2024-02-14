public void Hurt(int damageAmount)
{
    currentHealth -= damageAmount;
    if (currentHealth <= 0)
    {
        Die();
    }
    else
    {
        // Autre logique de gestion des dégâts, comme la mise à jour de l'interface utilisateur de la santé, etc.
    }
}
