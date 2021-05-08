using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//Script pour les boutons dans L'UI
public class ScriptBouton : MonoBehaviour
{
    public bool clicked = false;
    //Fonction du bonton jouer
    public void Jouer(string sceneJeu)
    {
        SceneManager.LoadScene(sceneJeu);
    }

 
}
