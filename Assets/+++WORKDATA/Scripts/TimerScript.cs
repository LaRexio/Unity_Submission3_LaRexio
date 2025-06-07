using System;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem.iOS;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
   float elapsedTime;

   public int countdownTime;
   public TextMeshProUGUI countdownText;

   private void Start()
   {
       StartCoroutine(CountdowntoStart());
   }
   IEnumerator CountdowntoStart()
   {
       
       while (countdownTime > 0)
       {
           countdownText.text = countdownTime.ToString();
           
           yield return new WaitForSeconds(1f);
           countdownTime--;
       }
       countdownText.text = "GO!";
       
       yield return new WaitForSeconds(1f);
       countdownText.gameObject.SetActive(false);
   }

   void Update()
   {
       elapsedTime += Time.deltaTime;
       int minutes = Mathf.FloorToInt(elapsedTime / 60);
       int seconds = Mathf.FloorToInt(elapsedTime % 60);
       timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
   }

    


}
