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
      DisplayMoney();
      UpdateSkillImage();
    }

    private void DisplayMoney(){
      currencyText.text = remainingCurrency + "";
    }

    private void UpdateSkillImage(){
      for (int i = 0; i<skills.Length;i++) {
        if (skills[i].isBuyable==true) {
          skills[i].GetComponent<Image>().color = new Vector4(1,1,1,1);
          skills[i].transform.GetChild(0).GetComponent<Image>().sprite = activeFrame;
        }
        else {
          skills[i].GetComponent<Image>().color = new Vector4(0.39f, 0.39f, 0.39f, 1);
          skills[i].transform.GetChild(0).GetComponent<Image>().sprite = defaultFrame;
        }
      }
    }

    public void UpgradeButton(){
      if (activateSkill.isBuyable==true&&remainingCurrency >= activateSkill.skillCost) {
        activateSkill.isBuyable=false;
        remainingCurrency-=activateSkill.skillCost;
      } else{
        Debug.Log("Not enough coins!!! OR "+activateSkill+" is bought already");
      }
      UpdateSkillImage();
      DisplayMoney();
    }
}
