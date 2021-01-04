using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//MARKER Skill Detail information
public class Skill : MonoBehaviour
{
    public string skillName;
    public Sprite skillSprite;

    [TextArea(1, 3)]
    public string skillDes;
    public bool isBuyable;
    public int skillCost;
    public bool isUpgradable;
    public int timesBuyable;
    public int counter;

    void Start(){
      switch (this.tag) {
        case "Skill01":
          counter = GlobalControl.Instance.counterList[0];
          break;
        case "Skill02":
          counter = GlobalControl.Instance.counterList[1];
          break;
        case "Skill03":
          counter = GlobalControl.Instance.counterList[2];
          break;
        case "Skill04":
          counter = GlobalControl.Instance.counterList[3];
          break;
      }
    }

    public void SaveData(){
      GlobalControl.Instance.counterList[0] = counter;
    }
}
