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

    [SerializeField] private Button startgameB;
    [SerializeField] private Button continuegameB;
    [SerializeField] private Button retrygameB;
    [SerializeField] private Button settingsB;
    [SerializeField] private Button backBinSettings;
    [SerializeField] private Button backBinWinPanel;
    

    [SerializeField] private TextMeshProUGUI textCoinCount;
    
    
    private void Start()
    {
        Time.timeScale = 0;
        mainMenu.SetActive(true);
        conditionsMenu.SetActive(false);

        settingsMenu.SetActive(false);
        winMenu.SetActive(false);
        loseMenu.SetActive(false);
        
        startgameB.onClick.AddListener(CloseMainMenu);
        continuegameB.onClick.AddListener(ConditionsMenu);
        settingsB.onClick.AddListener(SettingsMenu);
        backBinSettings.onClick.AddListener(CloseSettingsMenu);
        backBinWinPanel.onClick.AddListener(BacktoMM);
        retrygameB.onClick.AddListener(RetryGame);
        backBinWinPanel.onClick.AddListener(BacktoMM);

    }

    #region Panels

    void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CloseMainMenu()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1;
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

    void winningMenu()
    {
        
    }
    public void UpdateTextCoinCount(int newCount)
    {
        textCoinCount.text = newCount.ToString();
    
    }

    public void Showlose()
    {
        loseMenu.SetActive(true);
        var canMove = false;

    }

    #endregion
    
    
    
    
    
    
    
}
