using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class MovimentPlayers : MonoBehaviour
{
    
    public float timeScale;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private Rigidbody2D RigiPlayer;
    public float speed= 10f;
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode DownKey;


    void Awake()
    {
        RigiPlayer = GetComponent<Rigidbody2D>();
    }

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
        else if(!PauseMenu.activeSelf) 
            timeScale = 1f;
        


    }

    private void FixedUpdate()
    {
        if (Input.GetKey(UpKey))
        {
            RigiPlayer.MovePosition(RigiPlayer.position + Vector2.up * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(DownKey))
        {
            RigiPlayer.MovePosition(RigiPlayer.position + Vector2.down * speed * Time.fixedDeltaTime);
        }
    }
}
