using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "(또 다른 도깨비다..도깨비들은 다 키가 크구나)","안녕하세요 나그네님","어서오시오 낭자를 기다렸소.","저를 기다렸다고요?","시간이 없소 어서 나를 따라오시오","(나를 기다렸다고? 뭔가....)","나그네를 따라가자" });
        talkData.Add(2000, new string[] { "(도깨비...?)", "흑흑....", "도깨비 왕은 어디가고 여기서 울고있는거야?","내가 아끼는 술병을 잃어버렸어!!","울지말고 내 얘기를 들어줘 나는 이 곳 사람이 아니야","나는 원래 살던 곳으로 가고싶어","그러니까 이 곳의 왕과 얘기를 하고싶어","흑흑...그 분은 지금 여기 없으셔","흑흑....명절이라서 외출하셨거든","흑흑...그래서 다들 위층으로 놀러온거야","그러면 나는 어떻게 해?","내 술병을 찾아. 신비한 힘으로 탑을 오르게 해줄거야","알겠어 마지막으로 기억나는 곳을 알려줘","왕좌 보고 신이 나서 놀다 잃어버렸는데...","여기 근처에 있을거야","(근처를 찾아보자)","대화가 끝난 뒤에 스페이스 바를 한 번 더 눌러주세요"});
        talkData.Add(100, new string[] { "엄청 큰 방석이다." });
        talkData.Add(200, new string[] { "갑자기 축축한 느낌이 든다." });
        talkData.Add(300, new string[] { "너가 장산범이야?" });
        talkData.Add(500, new string[] { "도깨비가 말한 술병의 예시입니다" });

        //Quest Talk
        talkData.Add(1000 + 10 , new string[] { "인간", "내가 아끼는 술병을 잃어버렸어","내 술병을 찾아주면 널 도와줄게" });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
