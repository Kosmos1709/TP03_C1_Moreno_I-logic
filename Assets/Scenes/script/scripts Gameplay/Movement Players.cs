using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class MovimentPlayers : MonoBehaviour
{
    public float timeScale;
    [SerializeField] private GameObject PauseMenu;
    public float speed= 10f;
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode DownKey;



    void Start()
    {
        
    }

    void Update()
    {
        //
        Time.timeScale = timeScale;

        if (PauseMenu.activeSelf)
        {
            timeScale = 0f;
        }
        else
        {
            timeScale = 1f;
        }

        if (Input.GetKey(UpKey))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(DownKey))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
