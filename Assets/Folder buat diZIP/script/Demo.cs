using UnityEngine ;

public class Demo : MonoBehaviour {

   [SerializeField] Timer timer1 ;
  

   private void Start () {
      timer1.SetDuration(6).Begin () ;

      
   }

}