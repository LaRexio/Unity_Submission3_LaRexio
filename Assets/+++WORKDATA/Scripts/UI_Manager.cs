using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject conditionsMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject winMenu;
    [SerializeField] private GameObject loseMenu;

    [SerializeField] private Button StartgameB;
    [SerializeField] private Button ContinuegameB;
    [SerializeField] private Button RetrygameB;
    [SerializeField] private Button SettingsB;
    [SerializeField] private Button BackBinSettings;
    [SerializeField] private Button BackBinWinPanel;

    [SerializeField] private TextMeshProUGUI textCoinCount;
    
    
    private void Start() 
    {
        mainMenu.SetActive(true);
        conditionsMenu.SetActive(false);
        settingsMenu.SetActive(false);
        winMenu.SetActive(false);
        loseMenu.SetActive(false);
        
        StartgameB.onClick.AddListener(CloseMainMenu);
        ContinuegameB.onClick.AddListener(ConditionsMenu);
        SettingsB.onClick.AddListener(SettingsMenu);
        BackBinSettings.onClick.AddListener(CloseSettingsMenu);
        BackBinWinPanel.onClick.AddListener(BacktoMM);

    }

    #region Panels

    public void CloseMainMenu()
    {
        mainMenu.SetActive(false);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void SettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    void ConditionsMenu()
    {
        conditionsMenu.SetActive(false);
    }

    void CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    void BacktoMM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void UpdateTextCoinCount(int newCount)
    {
        textCoinCount.text = newCount.ToString();
    
    }

    public void Showlose()
    {
        loseMenu.SetActive(true);
       
    }

    #endregion
    
    
    
    
    
    
    
}
