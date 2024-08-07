using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject opsipanel;
    public GameObject settingpanel;
    public GameObject infopanel;
    public GameObject tentangpanel;
    public GameObject lantai1panel;
    public GameObject lantai2panel;
    public GameObject lantai3panel;
    // Start is called before the first frame update
    void Start()
    {
      menupanel.SetActive(true);
      opsipanel.SetActive(false);
      infopanel.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
        menupanel.SetActive(false);
        opsipanel.SetActive(true);
        infopanel.SetActive(false);
        settingpanel.SetActive(false);
        tentangpanel.SetActive(false);
        lantai1panel.SetActive(false);
        lantai2panel.SetActive(false);
        lantai3panel.SetActive(false);
    }
    public void InfoButton()
    {
       menupanel.SetActive(false);
       opsipanel.SetActive(false);
       infopanel.SetActive(true);
       settingpanel.SetActive(false);
       tentangpanel.SetActive(false);
       lantai1panel.SetActive(false);
       lantai2panel.SetActive(false);
       lantai3panel.SetActive(false);  
      
    }
    public void SettingButton()
    {
       menupanel.SetActive(false);
       opsipanel.SetActive(false);
       infopanel.SetActive(false);
       settingpanel.SetActive(true);
       tentangpanel.SetActive(false);
       lantai1panel.SetActive(false);
       lantai2panel.SetActive(false);
       lantai3panel.SetActive(false);  
      
    }
    public void BackButton()
    {
        menupanel.SetActive(true);
        opsipanel.SetActive(false);
        infopanel.SetActive(false);
        settingpanel.SetActive(false);
        tentangpanel.SetActive(false);
        lantai1panel.SetActive(false);
        lantai2panel.SetActive(false);
        lantai3panel.SetActive(false); 
    }
    public void  TentangButton()
    {
       menupanel.SetActive(false);
       opsipanel.SetActive(false);
       infopanel.SetActive(false);
       settingpanel.SetActive(false);
       tentangpanel.SetActive(true);
       lantai1panel.SetActive(false);
       lantai2panel.SetActive(false);
       lantai3panel.SetActive(false); 
    }
    public void  lantai1Button()
    {
       menupanel.SetActive(false);
       opsipanel.SetActive(false);
       infopanel.SetActive(false);
       settingpanel.SetActive(false);
       tentangpanel.SetActive(false);
       lantai1panel.SetActive(true);
       lantai2panel.SetActive(false);
       lantai3panel.SetActive(false);  
    }
    public void  lantai2Button()
    {
       menupanel.SetActive(false);
       opsipanel.SetActive(false);
       infopanel.SetActive(false);
       settingpanel.SetActive(false);
       tentangpanel.SetActive(false);
       lantai1panel.SetActive(false);
       lantai2panel.SetActive(true);
       lantai3panel.SetActive(false);  
    }
    public void  lantai3Button()
    {
       menupanel.SetActive(false);
       opsipanel.SetActive(false);
       infopanel.SetActive(false);
       settingpanel.SetActive(false);
       tentangpanel.SetActive(false);
       lantai1panel.SetActive(false);
       lantai2panel.SetActive(false);
       lantai3panel.SetActive(true);  
    }
}