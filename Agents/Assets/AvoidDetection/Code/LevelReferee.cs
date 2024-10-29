using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SotomaYorch.FiniteStateMachine;
using SotomaYorch.FiniteStateMachine.Agents;
using TMPro;

namespace SotomaYorch.AvoidDetection
{
    #region Enums

    public enum GameStates
    {
        START,
        GAME,
        PAUSE,
        VICTORY,
        DRAW,
        GAME_OVER
    }

    #endregion

    public class LevelReferee : MonoBehaviour
    {
        #region RuntimeVariables

        [SerializeField] protected GameStates _gameState;

        #endregion


        #region UnityMethods

        void Start()
        {
            //if (LevelReferee.instance != this)
            //{
            //    GameObject.DestroyImmediate(this.gameObject);
            //}
        }

        void Update()
        {

        }

        #endregion
    }

}
