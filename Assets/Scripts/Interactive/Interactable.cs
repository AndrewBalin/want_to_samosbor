using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;

namespace Interactive
{
    [RequireComponent(typeof(Collider))]
    public class Interactable : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<CustomPassVolume>().customPasses[0].enabled = false;
        }
        
        public void OnHover()
        {
            this.GetComponent<CustomPassVolume>().customPasses[0].enabled = true;
        }
        
        public void OnUnhover()
        {
            this.GetComponent<CustomPassVolume>().customPasses[0].enabled = false;
        }
        
        public void PerformAction(string action)
        {
            Debug.Log($"Action {action} performed on {gameObject.name}");
            
            // Логика взаимодействия
        }
    }
}