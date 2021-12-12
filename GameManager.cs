using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Image portraitImg;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;
    public GameObject menuSet;
    public GameObject player;

    void Start()
    {
        GameLoad();
    }
    void Update()
    {
        //서브메뉴
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
                menuSet.SetActive(false);
            else
                menuSet.SetActive(true);
        }
            
    }
    public void Action(GameObject scanObj)
    { 
        if (isAction)
        { //Exit Action
            isAction = false;
        }
        else
        {  //Enter Action
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNpc);
        }
        talkPanel.SetActive(isAction);
    }
    void Talk(int id, bool isNpc)
    {
        //Set Talk Data

        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        //Continue Talk
        if (isNpc)
        {
            talkText.text = talkData;

      
        }
        else 
        {
            talkText.text = talkData;

      
        }
        isAction = true;
        talkIndex++;
    }
    public void GameSave()
    {
        PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.transform.position.x);
        PlayerPrefs.Save();

        menuSet.SetActive(true);
    }
    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("PlayerX"))
            return;
        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");

        player.transform.position = new Vector3(x, y, 0);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}