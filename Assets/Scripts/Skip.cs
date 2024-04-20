using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class Skip : MonoBehaviour
{
    public Flowchart flowChart;
    public void onClickSkip()
    {
        
        List<Block> ExecutingBlocks = flowChart.GetExecutingBlocks();
        Block ExecutingBlock = ExecutingBlocks[0];
        
        if(ExecutingBlock.BlockName=="Intro")
        {
            flowChart.StopAllBlocks();
            flowChart.ExecuteBlock("Hide All");
            flowChart.ExecuteBlock("Main");
        }

        else if (ExecutingBlock.BlockName == "Event_Sick_Intro")
        {
            flowChart.StopAllBlocks();
            flowChart.ExecuteBlock("Hide All");
            flowChart.ExecuteBlock("Event_Sick_Next");
        }

        else if (ExecutingBlock.BlockName == "Event_Gym")
        {
            flowChart.StopAllBlocks();
            flowChart.ExecuteBlock("Hide All");
            flowChart.ExecuteBlock("Main");
        }

        else if (ExecutingBlock.BlockName == "Event_HangOut")
        {
            flowChart.StopAllBlocks();
            flowChart.ExecuteBlock("Hide All");
            flowChart.ExecuteBlock("Main");
        }

        else if (ExecutingBlock.BlockName == "Event_Home")
        {
            flowChart.StopAllBlocks();
            flowChart.ExecuteBlock("Hide All");
            flowChart.ExecuteBlock("Main");
        }

        else if (ExecutingBlock.BlockName == "EndingText")
        {
            flowChart.StopAllBlocks();
            flowChart.ExecuteBlock("Hide All");
            flowChart.ExecuteBlock("EndingCheck");
        }

        else if (ExecutingBlock.BlockName == "Ending0")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 0, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }


        else if (ExecutingBlock.BlockName == "Ending1")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 1, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }

        else if (ExecutingBlock.BlockName == "Ending2")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 2, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }

        else if (ExecutingBlock.BlockName == "Ending3")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 3, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }

        else if (ExecutingBlock.BlockName == "Ending4")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 4, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }

        else if (ExecutingBlock.BlockName == "Ending5")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 5, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }

        else if (ExecutingBlock.BlockName == "Ending6")
        {
            flowChart.StopAllBlocks();
            PlayerPrefs.SetInt("unlockEnding" + 6, 1);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
        }


    }
}
