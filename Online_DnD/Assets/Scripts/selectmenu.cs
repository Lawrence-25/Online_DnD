using UnityEngine;
using UnityEngine.SceneManagement;

public class selectmenu : MonoBehaviour
{
    public void news () {
        SceneManager.LoadScene(0);
    }
    public void characters () {
        SceneManager.LoadScene(1);
    }
    public void play () {
        SceneManager.LoadScene(2);
    }
    public void community () {
        SceneManager.LoadScene(3);
    }
}
