using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Grader : MonoBehaviour
{

    private bool pass = true;
    private GameController gc;
    public static int score;
    public static int failed;

    // Update is called once per frame
    void Update()
    {
        gc = GameController.instanceGetter();
        if (transform.position.z < -4f)
        {
            if (pass)
            {
                if (gc.gameModeGetter() == 0)
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
                gc.minusStreak();
            }

            //Check after wall has passed if achivement has been completed
            //if (GameController.gc.checkAchievement())
            // {
            //    GameController.gc.showAchievement();
            //}
            //Resets the collision counter for every obstacle
            gc.resetCollisions();

        }
    }

    void DisableMarks()
    {
        GameController.ClearNotify();
    }


    public void Fail()
    {
        pass = false;
        if (gc.gameModeGetter() == 0)
        {
            GameController.NotifyFailed();
        }
        Invoke("DisableMarks", 1f);
    }
}
