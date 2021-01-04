using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public static SkillManager instance;
    public Skill[] skills;
    public SkillButton[] skillButtons;
    [SerializeField] public Skill activateSkill;

    [Header("STAGE 02")]
    public GameObject player;
    public Sprite defaultFrame;
    public Sprite activeFrame;

    public int actualCurrency;
    public int remainingCurrency;
    public Text currencyText;

    private void Awake(){
      if (instance==null) {
        instance=this;
      }
      else{
        if (instance!=this) {
          Destroy(gameObject);
        }
      }
      DontDestroyOnLoad(gameObject);
    }

    void Start(){
      actualCurrency = GlobalControl.Instance.currentCurrency;
      remainingCurrency = actualCurrency;
      UpdateCounter();
      DisplayMoney();
      UpdateSkillImage();
    }

    private void UpdateCounter(){
      for (int i = 0; i<skills.Length;i++){
        skills[i].transform.GetChild(1).GetComponent<Text>().text = skills[i].counter.ToString() + "/" + skills[i].timesBuyable.ToString();
      }
    }

    private void DisplayMoney(){
      currencyText.text = remainingCurrency + "";
    }

    private void UpdateSkillImage(){
      for (int i = 0; i<skills.Length;i++) {
        if (skills[i].isBuyable==false) {
          skills[i].GetComponent<Image>().color = new Vector4(1,1,1,1);
          skills[i].transform.GetChild(0).GetComponent<Image>().sprite = activeFrame;
        }
        else {
          skills[i].GetComponent<Image>().color = new Vector4(0.39f, 0.39f, 0.39f, 1);
          skills[i].transform.GetChild(0).GetComponent<Image>().sprite = defaultFrame;
        }
      }
    }

    public void UpgradeButtons(){
      if (activateSkill.isBuyable==true&&remainingCurrency >= activateSkill.skillCost) {
        activateSkill.counter++;
        remainingCurrency-=activateSkill.skillCost;
        if (activateSkill.counter==activateSkill.timesBuyable) {
          activateSkill.isBuyable=false;
          activateSkill.GetComponent<SkillButton>().skillCostText.text = "Max";
        }
        UpgradePlayer();
      } else{
        Debug.Log("Not enough coins!!! OR "+activateSkill+" is bought already");
      }
      UpdateSkillImage();
      DisplayMoney();
      UpdateCounter();
    }

    public void UpgradePlayer(){
      switch (activateSkill.skillName) {
        case "AttackUp":
          GlobalControl.Instance.damage+=1;
          activateSkill.skillCost+=100;
          activateSkill.GetComponent<SkillButton>().UpdateSkill();
          break;
        case "SpeedUp":
          player.GetComponent<PlayerMovement>().moveSpeed+=(player.GetComponent<PlayerMovement>().moveSpeed*50)/100;
          break;
        case "CadenceUp":
          player.GetComponent<PlayerMovement>().BulletSpeed+=1;
          player.GetComponent<PlayerMovement>().fireDelay-=(player.GetComponent<PlayerMovement>().fireDelay*25)/100;
          break;

      }
    }
}
