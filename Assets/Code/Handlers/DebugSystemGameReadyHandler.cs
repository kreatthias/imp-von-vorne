// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Matze {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class DebugSystemGameReadyHandler {
        
        private uFrame.Kernel.GameReadyEvent _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private object ActionNode1_message = default( System.Object );
        
        private string StringNode2 = "gameready\n";
        
        public uFrame.Kernel.GameReadyEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode1_message = StringNode2;
            // ActionNode
            while (this.DebugInfo("2765c9ed-2821-4b2a-ac06-83f6ece5e855","2765c9ed-2821-4b2a-ac06-83f6ece5e855", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.DebugLibrary.LogMessage
            uFrame.ECS.Actions.DebugLibrary.LogMessage(ActionNode1_message);
            yield break;
        }
    }
}
