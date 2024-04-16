using UnityEngine;

namespace course.PatronesDiseno.Facade
{
    public class BattleFacade : MonoBehaviour
    {
        public BattleUi battleUI;
        public CharacterSpawner CharacterSpawner;
        public CharacterUi characterUI;

        public void BattleStart()
        {
            battleUI.Show();

            CharacterSpawner.SpawnPlayers();
            CharacterSpawner.SpawnEnemies();

            characterUI.ShowPlayerUI();
            characterUI.ShowEnemiesUI();

            battleUI.Hide();
        }
        public void BattleEnd()
        {
            battleUI.Show();

            CharacterSpawner.DestroyPlayers();
            CharacterSpawner.DestroyEnemies();

            characterUI.HidePlayerUI();
            characterUI.HideEnemiesUI();

            battleUI.Hide();
        }
    }
}
