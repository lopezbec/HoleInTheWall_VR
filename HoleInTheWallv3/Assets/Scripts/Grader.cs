using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Grader : MonoBehaviour
{

    private bool pass = true;
    public static int score;
    public static int failed;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -4f)
        {
            if (pass)
            {
                if (GameController.gameModeGetter() == 0)
                {
                    GameController.NotifyPassed();
                }
                score++;
                pass = false;
                Invoke("DisableMarks", 1f);
            }
            else
            {
                //If not pass, fail streak continues
                GameController.minusStreak();
            }

            //Check after wall has passed if achivement has been completed
            //if (GameController.gc.checkAchievement())
            // {
            //    GameController.gc.showAchievement();
            //}
            //Resets the collision counter for every obstacle
            GameController.resetCollisions();

        }
    }

    void DisableMarks()
    {
        GameController.ClearNotify();
    }


    public void Fail()
    {
        pass = false;
        if (GameController.gameModeGetter() == 0)
        {
            GameController.NotifyFailed();
        }
        Invoke("DisableMarks", 1f);
    }
}
