using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void QuitApp()
    {
        #if UNITY_EDITOR
            // Se stai eseguendo l'applicazione nell'editor, questa riga la interrompe.
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // Se è un'applicazione standalone, la chiude.
            Application.Quit();
        #endif
    }
}
