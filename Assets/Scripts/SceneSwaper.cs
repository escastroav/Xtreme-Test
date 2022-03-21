using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneSwaper : MonoBehaviour
{
    private void Start() {
        Button gameButton = GameObject.Find("PlayButton").GetComponent<Button>();        
        gameButton.onClick.AddListener(LoadGameScenes);           
    }
    public void LoadGameScenes()
    {
        SceneManager.LoadScene(1);
    }
}
