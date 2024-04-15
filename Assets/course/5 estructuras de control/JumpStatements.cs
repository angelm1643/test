using System.Collections;
using UnityEngine;

namespace course
{
    public struct PlayerData
    {
        public int score;
        public bool isAlive;
    }

    public class JumpStatements : MonoBehaviour
    {
        public PlayerData[] PlayerData;

        private void CheackMaxScore()
        {
            for (int i = 0; i < PlayerData.Length; i++)
            {
                // if score >= 10, win
                if (PlayerData[i].score >= 10)
                {
                    // winner
                    break;  // ya tenemos ganador asique cortamos la funcion con un break, el codigo deja de buscar un ganador y pasa a la siguiente funcion
                }
            }
        }
        private void CheckPlayerScore()
        {
            for (int i = 0; i <PlayerData.Length; i++)
            {
                // if isen't alive, skip
                if (PlayerData[i].isAlive)
                {
                    continue;  // el continue saltea la funcion
                }

                // other logic
            }
        }
        private void checkplayerscore(int index)
        {
            if (PlayerData[index].isAlive)
            {
                return; // early exit
            }
            // if isn't alive, dont execute
            // other logic
        }

    }
}
