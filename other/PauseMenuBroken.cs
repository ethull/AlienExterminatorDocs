using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject inventoryMenuUI;
    [SerializeField]
    private Text[] gunTexts;

    private CurrentSceneManager currentSceneManager;
    private WeaponSwitcher weaponSwitcher;
    
    void Start(){
        currentSceneManager = GameObject.FindGameObjectWithTag("MainManager").GetComponent<CurrentSceneManager>();
        weaponSwitcher = GameObject.FindGameObjectWithTag("WeaponHolder").GetComponent<WeaponSwitcher>();
        // TODO swap to find in children
        Debug.Log(GameObject.Find("TextCurrentGun"));
        int i = 0;
        foreach (Transform weapon in inventoryMenuUI.transform)
        {
            Debug.Log(weapon.gameObject.c);
            gunTexts[i] = weapon.gameObject.GetComponent<Text>();
            Debug.Log(gunTexts[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        inventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void Inventory(){
        SetGunText();
        pauseMenuUI.SetActive(false);
        inventoryMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        currentSceneManager.QuitFromPauseMenu();
    }

    public void SetGunText()
    {
        Gun currentGun = weaponSwitcher.selectedWeaponRef;
        gunTexts[0].text = currentGun.name;
        gunTexts[1].text = Convert.ToString(currentGun.damage);
        gunTexts[2].text = Convert.ToString(currentGun.fireRate);
        //currentGunText = string.Format("{0}: damage {1}, fire rate {2}", currentGun.name, currentGun.damage, currentGun.fireRate);
    }
}