//--------------------------------------AUTO GENERATED CLASS; DON'T TOUCH-----------------------------------------------------------
#region Using Statements
using UnityEngine;
using _LogFile = UnityUtilities.LogFile;
using _GUIDPool = UnityUtilities.Networking.GUIDPool;
using _CEventSystem = UnityUtilities.CEventSystem;
#endregion

namespace UnityUtilities.AutoGen{
    public class InitializeScene : MonoBehaviour {
    
        #region Fields
        //_LogFile logFile;
        //NetBehaviourTracker netBehaviourTracker;
        //_GUIDPool gUIDPool;
        //NetBehaviourSpawner netBehaviourSpawner;
        //_CEventSystem cEventSystem;
        #endregion

        public static void Init(GameObject gameObject){
            #region Initialization
            gameObject.AddComponent<_LogFile>();
            gameObject.AddComponent<NetBehaviourTracker>();
            gameObject.AddComponent<_GUIDPool>();
            gameObject.AddComponent<NetBehaviourSpawner>();
            gameObject.AddComponent<_CEventSystem>();
            #endregion
        }
    }
}
