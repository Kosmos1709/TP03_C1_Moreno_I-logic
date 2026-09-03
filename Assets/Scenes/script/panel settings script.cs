using UnityEngine;
using UnityEngine.UI;

public class panelsettingsscript : MonoBehaviour
{
        [SerializeField] private GameObject SettingsMenu;
        [SerializeField] private Button BackBtn;
        [SerializeField] private Button ForwardBtn;
        [SerializeField] private Button btnplay;


    private void Awake()
    {
        BackBtn.onClick.AddListener(FunctionBack);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnDestroy()
    {
        BackBtn.onClick.RemoveAllListeners();
    }
    // Update is called once per frame

    private void FunctionBack()
    {
        
       
    }

    void Update()
    {
        if (SettingsMenu.activeSelf) {
            ForwardBtn.interactable = true;
            btnplay.interactable = false;
             }
        if (!SettingsMenu.activeSelf) {
            ForwardBtn.interactable = false;
            btnplay.interactable = true;
        }
    }
}
