using UnityEngine;

namespace course
{
    public abstract class ClassEnemy : MonoBehaviour  // creamos la clase padre con valores que heredaran la clase hijo para reutilizar codigo y no estar creando 100 scrpts diferentes cada vez o si queremos agregar algun cambio general,
                                                      // abstract sirve para que no se pueda utilizar ya que es una clase padre de referencia
    {
        [Header("enemy")]
        [SerializeField]protected string _Title;  // nota: en variables privadas se suelen usar guion bajo primero, solo algo de educacion como programador
        // encapsulamiento: al marcar la variable (titulo) selecionamos el foco y selecionamos encapsulamiento el de abajo para que salga en una instancia como vemos mas abajo
        [SerializeField]protected int damage; // protected permite que a pesar del serialized field si pueda ser usado por clases hijo
        [SerializeField]protected float health;

        //encapsulamiento de lo de arriba:
        public string Title // nota: presionando control y 2 veces R puedes cambiar el nombre de una variable y topdas sus instancias a la vez
                            // nota de la nota: otra persepsion universal es que si algo tiene mayuscula normalmente es una variable
        {
            get // get significa conseguir una variable x de alguna otra parte, hacer que pueda leerse
            {
                Debug.Log("el pepe get");  // tambien se pueden setear como si fueran una funcion
                return _Title;  
            }
            //set // set significa darle un valor a esa varaible, hacer que pueda setearse
            
               // Debug.Log("el pepe get");  // tambien se pueden setear como si fueran una funcion
                //_Title = value;
            
        }

        // puede usar [SerializedField] para que otras clases hijo no puedan modificar un valor
        private void Start()
        {
            //attack();
        }
        // polimorfismo:: decir que una clase puede ser sobreescrita en un script hijo para cambiar sus funciones
        public virtual void attack()  // el virtual sirve para poder reescribir una funcion en una clase hijo, crear una variante de ella
        {
            Debug.Log($"enemy '{_Title}' attack. damage: '{damage}'");
        }        
        public abstract void defense();
    }
}
