﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public static SkillManager instance;
    public Skill[] skills;
    public SkillButton[] skillButtons;
    [SerializeField] private Skill activateSkill;

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
}