using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _criteriaCount;
    [SerializeField] private TextMeshProUGUI _dropReason;

    [SerializeField] private CriterionElement _criteriaPrefab;

    [SerializeField] private Transform _criteriaList;

    private void OnEnable()
    {
        if (!WeldProcess.Instance.GetCriterion(CriterionName.TableIsClear).Complete)
        {
            WeldProcess.Instance.DropResults();
            _dropReason.text = "�� ��������� �������� ������������!";
        }

        foreach (var criterion in WeldProcess.Instance.Criteria)
        {
            var c = Instantiate(_criteriaPrefab, _criteriaList);
            c.Text.text = criterion.Description;
            c.Toggle.isOn = criterion.Complete;
        }

        _criteriaCount.text = $"������� ������: {WeldProcess.Instance.GetCompletedCriteriaCount()}";
    }

    public void Exit()
    {
        Application.Quit();
    }
}
