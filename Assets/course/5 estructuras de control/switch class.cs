using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace course // curso sobre la variante switch
{
    public enum Eplatform
    {
        none,
        pc,
        xbox,
        playstation,
        swtich
    }

    public class switchclass : MonoBehaviour
    {
        public int WeaponType;
        public string EnemyClass;
        public Eplatform CurrentPlatform;

        private void Start()
        {
            switch (WeaponType)    // ordena muchos casos distintos mas ordenado en lugar de poner muchos if y else
            {
                case 0:
                     // do something
                     break;

                case 1:
                     // do something
                     break;

                case 2:
                case 3:                                  // se pueden encadenar asi para un mismo resultado
                //case "archer":   // esto es para strings
                     // do something
                     break;
                     
                default:
                    // in case nothing archived do something else
                    break;
            }

            switch (CurrentPlatform)  // pones el enum y presionas doble enter y sale automatico
            {
                case Eplatform.none:
                    break;
                case Eplatform.pc:
                    break;
                case Eplatform.xbox:
                    break;
                case Eplatform.playstation:
                    break;
                case Eplatform.swtich:
                    break;
                default:
                    break;
            }
        }
    }
}