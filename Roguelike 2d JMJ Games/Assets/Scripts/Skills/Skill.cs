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
    public int timesBuyable;
    public int counter;

    void Start(){
      switch (this.tag) {
        case "Skill01":
          counter = GlobalControl.Instance.counterList[0];
          UpdatePrice(0);
          break;
        case "Skill02":
          counter = GlobalControl.Instance.counterList[1];
          UpdatePrice(1);
          break;
        case "Skill03":
          counter = GlobalControl.Instance.counterList[2];
          UpdatePrice(2);
          break;
        case "Skill04":
          counter = GlobalControl.Instance.counterList[3];
          UpdatePrice(3);
          break;
      }
    }

    void UpdatePrice(int numSkill){
      if (counter!=timesBuyable) {
        skillCost = GlobalControl.Instance.priceList[numSkill];
      }
    }

    public void SaveData(){
      switch (this.tag) {
        case "Skill01":
          GlobalControl.Instance.counterList[0] = counter;
          GlobalControl.Instance.priceList[0] = skillCost;
          break;
        case "Skill02":
          GlobalControl.Instance.counterList[1] = counter;
          GlobalControl.Instance.priceList[1] = skillCost;
          break;
        case "Skill03":
          GlobalControl.Instance.counterList[2] = counter;
          GlobalControl.Instance.priceList[2] = skillCost;
          break;
        case "Skill04":
          GlobalControl.Instance.counterList[3] = counter;
          GlobalControl.Instance.priceList[3] = skillCost;
          break;
    }
  }
}
