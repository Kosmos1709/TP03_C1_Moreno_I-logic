using UnityEngine;
using UnityEngine.UI;

public class MovimentPlayers : MonoBehaviour
{
    
    [SerializeField] private KeyCode UpKey;
    [SerializeField] private KeyCode DownKey;
    public float speed= 5f;



    void Start()
    {
        
    }

    void Update()
    {
        //
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
