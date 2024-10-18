using System.Collections;
using System.Collections.Generic;
using SotomaYorch.FiniteStateMachine.Agents;
using UnityEngine;

namespace SotomaYorch.FiniteStateMachine
{
    public class EnemyNPCFactory : MonoBehaviour
    {
        #region Knobs

        [SerializeField] EnemyInteractiveScript_ScriptableObject[] enemiesToProduce;

        #endregion

        #region RuntimeVariables

        [SerializeField] protected List<GameObject> _listOfTheEnemies;
        GameObject _goEnemyInstance;

        #endregion

        #region RuntimeMethods

        public void CreateEnemies()
        {
            foreach (EnemyInteractiveScript_ScriptableObject enemy in enemiesToProduce)
            {
                _goEnemyInstance = GameObject.Instantiate(enemy.prefabOfTheEnemy);
                _goEnemyInstance.transform.parent = this.transform;
                _goEnemyInstance.transform.localPosition = enemy.positionToSpawn;
                _goEnemyInstance.transform.localRotation = Quaternion.Euler(enemy.rotationToSpawn);

                _listOfTheEnemies.Add(_goEnemyInstance);
            }
        }

        public void DeleteEnemies()
        {
            if (_listOfTheEnemies.Count > 0)
            {
                for (int i = _listOfTheEnemies.Count - 1; i >= 0; i--)
                {
                    _goEnemyInstance = _listOfTheEnemies[i];
                    _listOfTheEnemies.Remove(_goEnemyInstance);
                    GameObject.DestroyImmediate(_goEnemyInstance);
                }
            }
        }

        #endregion
    }
}