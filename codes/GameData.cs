using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public int play_count;
    public int Area_score;
    public int Enemy_score;
    public int bonus_score;
    public int Time_score;
    public int high_score;
    public int Enemy_num;
    public int Session_num;
    public int play_score;
}
