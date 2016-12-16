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
    using Matze;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class DebugSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private IEcsComponentManagerOf<Orc> _OrcManager;
        
        private IEcsComponentManagerOf<Sword> _SwordManager;
        
        private IEcsComponentManagerOf<Shield> _ShieldManager;
        
        private DebugSystemGameReadyHandler DebugSystemGameReadyHandlerInstance = new DebugSystemGameReadyHandler();
        
        public IEcsComponentManagerOf<Health> HealthManager {
            get {
                return _HealthManager;
            }
            set {
                _HealthManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Orc> OrcManager {
            get {
                return _OrcManager;
            }
            set {
                _OrcManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Sword> SwordManager {
            get {
                return _SwordManager;
            }
            set {
                _SwordManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Shield> ShieldManager {
            get {
                return _ShieldManager;
            }
            set {
                _ShieldManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            HealthManager = ComponentSystem.RegisterComponent<Health>(3);
            OrcManager = ComponentSystem.RegisterGroup<OrcGroup,Orc>();
            SwordManager = ComponentSystem.RegisterComponent<Sword>(1);
            ShieldManager = ComponentSystem.RegisterComponent<Shield>(2);
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ DebugSystemGameReadyFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void DebugSystemGameReadyHandler(uFrame.Kernel.GameReadyEvent data) {
            var handler = DebugSystemGameReadyHandlerInstance;
            handler.System = this;
            handler.Event = data;
            StartCoroutine(handler.Execute());
        }
        
        protected void DebugSystemGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            this.DebugSystemGameReadyHandler(data);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("691822a2-1ca9-4476-aa76-d716ed84d042")]
    public partial class DebugSystem : DebugSystemBase {
        
        private static DebugSystem _Instance;
        
        public DebugSystem() {
            Instance = this;
        }
        
        public static DebugSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
