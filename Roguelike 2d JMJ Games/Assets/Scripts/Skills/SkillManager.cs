using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public static SkillManager instance;
    public Skill[] skills;
    public List<Skill> skillList;
    public SkillButton[] skillButtons;
    public List<SkillButton> skillButtonList;
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
      // DontDestroyOnLoad(gameObject);
    }

    void Start(){
      actualCurrency = GlobalControl.Instance.currentCurrency;
      remainingCurrency = actualCurrency;
      skillList.Add(GameObject.FindGameObjectWithTag("Skill01").GetComponent<Skill>());
      skillList.Add(GameObject.FindGameObjectWithTag("Skill02").GetComponent<Skill>());
      skillList.Add(GameObject.FindGameObjectWithTag("Skill03").GetComponent<Skill>());
      skillList.Add(GameObject.FindGameObjectWithTag("Skill04").GetComponent<Skill>());
      skillButtonList.Add(GameObject.FindGameObjectWithTag("Skill01").GetComponent<SkillButton>());
      skillButtonList.Add(GameObject.FindGameObjectWithTag("Skill02").GetComponent<SkillButton>());
      skillButtonList.Add(GameObject.FindGameObjectWithTag("Skill03").GetComponent<SkillButton>());
      skillButtonList.Add(GameObject.FindGameObjectWithTag("Skill04").GetComponent<SkillButton>());
      UpdateCounter();
      DisplayMoney();
      UpdateSkillImage();
    }

    private void UpdateCounter(){
      foreach (Skill x in skillList){
        x.transform.GetChild(1).GetComponent<Text>().text = x.counter.ToString() + "/" + x.timesBuyable.ToString();
      }
    }

    private void DisplayMoney(){
      currencyText.text = remainingCurrency + "";
    }

    private void UpdateSkillImage(){

      foreach (Skill x in skillList){
        if (x.isBuyable==false) {
          x.GetComponent<Image>().color = new Vector4(1,1,1,1);
          x.transform.GetChild(0).GetComponent<Image>().sprite = activeFrame;
        }
        else {
          x.GetComponent<Image>().color = new Vector4(0.39f, 0.39f, 0.39f, 1);
          x.transform.GetChild(0).GetComponent<Image>().sprite = defaultFrame;
        }
      }
    }

    public void UpgradeButtons(){
      if (activateSkill.isBuyable==true&&remainingCurrency >= activateSkill.skillCost) {
        activateSkill.counter++;
        remainingCurrency-=activateSkill.skillCost;
        if (activateSkill.counter==activateSkill.timesBuyable) {
          activateSkill.isBuyable=false;
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
