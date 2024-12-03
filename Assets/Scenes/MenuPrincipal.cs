using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Método para iniciar o jogo
    public void PlayGame()
    {
        // Substitua "GameScene" pelo nome da cena do seu jogo
        SceneManager.LoadScene("SampleScene");
    }

    // Método para sair do jogo
    public void QuitGame()
    {
        Debug.Log("Jogo Fechado!"); // Apenas para confirmar que o método funciona no editor
        Application.Quit();
    }
}
