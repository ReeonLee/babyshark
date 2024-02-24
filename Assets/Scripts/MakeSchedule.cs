using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class MakeSchedule : MonoBehaviour
{
    public ScheduleButton[] schedulebuttons;
    public RectTransform[] selectedslots;
    public UnityEngine.UI.Button startButton;
    public Flowchart flowChart;


    public UnityEngine.UI.Text BasketValue;
    public UnityEngine.UI.Text StudyValue;
    public UnityEngine.UI.Text CharmValue;
    public UnityEngine.UI.Text StressValue;
    public UnityEngine.UI.Text Date;


    private ScheduleButton[] schedulebuttons_selected;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < schedulebuttons.Length; i++)
        {
            schedulebuttons[i].onclickcallback = onclickschedulebutton;
            schedulebuttons[i].deleteToggle.SetActive(false);
        }

        schedulebuttons_selected = new ScheduleButton[selectedslots.Length];

        startButton.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        BasketValue.text = "농구력 : " + flowChart.GetVariable("농구력").GetValue();
        StudyValue.text = "지력 : " + flowChart.GetVariable("지력").GetValue();
        CharmValue.text = "매력 : " + flowChart.GetVariable("매력").GetValue();
        StressValue.text = "스트레스 : " + flowChart.GetVariable("스트레스").GetValue();
        Date.text = flowChart.GetVariable("날짜").GetValue() + "월";
    }

    public void Close()
    {
        gameObject.SetActive(false);
        onclickReset();
    }

    public void onclickschedulebutton(int index)
    {
        Debug.Log("onclickschedulebutton" + index);

        if (index == 3 || index == 4 || index == 5)
        {
            if (schedulebuttons_selected[3] != null)
            {
                return;
            }
            ScheduleButton newButton = Instantiate(schedulebuttons[index], selectedslots[3]);
            RectTransform newButtonReckTransform = newButton.GetComponent<RectTransform>();
            newButtonReckTransform.anchoredPosition = new Vector2(0, 0);
            newButtonReckTransform.anchorMax = new Vector2(0.5f, 0.5f);
            newButtonReckTransform.anchorMin = new Vector2(0.5f, 0.5f);
            newButton.deleteToggle.SetActive(false);
            schedulebuttons_selected[3] = newButton;

        }

        else
        {
            int slotindex = -1;

            for (int i = 0; i < 3; i++)
            {
                if (schedulebuttons_selected[i] == null)
                {
                    slotindex = i;
                    break;
                }
            }

            if (slotindex < 0)
            {
                return;
            }

            ScheduleButton newButton = Instantiate(schedulebuttons[index], selectedslots[slotindex]);
            RectTransform newButtonReckTransform = newButton.GetComponent<RectTransform>();
            newButtonReckTransform.anchoredPosition = new Vector2(0, 0);
            newButtonReckTransform.anchorMax = new Vector2(0.5f, 0.5f);
            newButtonReckTransform.anchorMin = new Vector2(0.5f, 0.5f);
            newButton.deleteToggle.SetActive(false);
            schedulebuttons_selected[slotindex] = newButton;
        }

        startButton.interactable = true;
        for (int i = 0; i < schedulebuttons_selected.Length; i++)
        {
            if (schedulebuttons_selected[i] == null)
            {
                startButton.interactable = false;
                break;

            }
        }

    }

    public void onclickReset()
    {
        for (int i = 0;i < schedulebuttons_selected.Length;i++) 
        {
            if (schedulebuttons_selected[i] != null)
            {
                Destroy(schedulebuttons_selected[i].gameObject);
                schedulebuttons_selected[i] = null;

            }
        }
        startButton.interactable = false;
    }

    public void onclickStart()
    {
        for (int i = 0; i < schedulebuttons_selected.Length; i++)
        {
            var scheduleVar = flowChart.GetVariable<IntegerVariable>("schedule" + i);
            scheduleVar.Value = schedulebuttons_selected[i].index;
        }

        flowChart.ExecuteBlock("Schedule0");
    }
}
