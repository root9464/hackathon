using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms.Impl;

public enum CriterionName
{
    WeldDress,
    LegDress,
    Gloves,
    Mask,
    Rug,
    WireChecked,
    Grounding, 
    WireLengthSetted,
    SwitchOn,
    ElectrodeInHolder,
    SwitchOff,
    CindersRemoved,
    DetailOnTable,
    TableIsClear
}

public class WeldProcess : MonoBehaviour
{
    [SerializeField] private List<Criterion> _criteria = new List<Criterion> { 
        new Criterion(CriterionName.WeldDress, "��������� ������"),
        new Criterion(CriterionName.LegDress, "����. �����"),
        new Criterion(CriterionName.Gloves, "��������"),
        new Criterion(CriterionName.Mask, "�����"),
        new Criterion(CriterionName.Rug, "������"),
        new Criterion(CriterionName.WireChecked, "����������� �������"),
        new Criterion(CriterionName.Grounding, "����������"),
        new Criterion(CriterionName.WireLengthSetted, "����� �����"),
        new Criterion(CriterionName.SwitchOn, "��������� ���������� ��������"),
        new Criterion(CriterionName.ElectrodeInHolder, "��������� ��������� � ������"),
        new Criterion(CriterionName.SwitchOff, "���������� ���������� ��������"),
        new Criterion(CriterionName.CindersRemoved, "������ ���������"),
        new Criterion(CriterionName.DetailOnTable, "������� ������"),
        new Criterion(CriterionName.TableIsClear, "���������� �������� ������������")
    };

    public List<Criterion> Criteria => _criteria;

    public bool DetailIsComplete;

    public static WeldProcess Instance;

    private void Awake()
    {
        Instance = this;
    }

    public Criterion GetCriterion(CriterionName name)
    {
        foreach (var criterion in _criteria)
        {
            if (criterion.Name == name)
            {
                return criterion;
            }
        }

        return null;
    }

    public void SetCriterion(CriterionName criterionName, bool complete)
    {
        foreach (var criterion in _criteria)
        {
            if(criterion.Name == criterionName)
            {
                criterion.Complete = complete;
                break;
            }
        }
    }

    public int GetCompletedCriteriaCount()
    {
        int count = 0;

        foreach (var criterion in _criteria)
        {
            if (criterion.Complete)
            {
                count++;
            }
        }

        return count;
    }

    public void DropResults()
    {
        foreach (var criterion in _criteria)
        {
            criterion.Complete = false;
        }
    }
}

[Serializable]
public class Criterion
{
    public CriterionName Name;
    public string Description;
    public bool Complete;

    public Criterion(CriterionName name, string description)
    {
        Name = name;
        Complete = false;
        Description = description;
    }
}
