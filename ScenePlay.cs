using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenePlay : MonoBehaviour
{
    public GameObject gameoverpanel;
    
    public GameObject missionSelect;
    public Text mission1;
    public Text mission2;
    public Text mission3;
    int mission_num = 0;

    void Start()
    {
       // gameoverpanel.SetActive(true);

        //missionSelect.SetActive(true);
        //mission1.text = "1";
        //mission2.text = "2";
        //mission3.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        if(mission_num == 1)
        {

        }
    }

    public void OnClick_mission1()
    {
        

        //mission_num = missionSelect.GetComponent<Mission>().MissionNum;
        missionSelect.SetActive(false);
    }
    public void OnClick_mission2()
    {
        mission_num = 2;
        missionSelect.SetActive(false);
    }
    public void OnClick_mission3()
    {
        mission_num = 3;
        missionSelect.SetActive(false);
    }



}
