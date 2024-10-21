using UnityEngine;

public class PlatformDetector : MonoBehaviour
{
    public GameObject MoveJoystick; // atribua o objeto que voc� deseja desativar
    public GameObject InnerJoy;
    public GameObject InteractionBut;

    void Start()
    {
        // Verifica se o jogo est� sendo executado no PC
       if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            // Desativa o objeto
            MoveJoystick.SetActive(false);
            InnerJoy.SetActive(false);
            InteractionBut.SetActive(false);
        }
    }
}
